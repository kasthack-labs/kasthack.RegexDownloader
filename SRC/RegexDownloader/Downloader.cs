using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using EpicMorg.Net;

namespace RegexDownloader {
    public static class Downloader {
        private static readonly Regex RghostLink = new Regex( "http://rghost.ru/[0-9]+" );
        private static readonly Regex VocarooLink = new Regex( "http://vocaroo.com/i/[a-zA-Z0-9]+" );
        private static readonly Regex VocarooTarget = new Regex( "/media_command.php?media=[a-zA-Z0-9]+&command=download_mp3" );
        private static readonly Regex RghostTarget = new Regex( @"http://rghost.ru/download/[0-9]+/[0-9a-z]+/[A-Za-z0-9\.%]+" );

        public static void Download( DownloadSettings settings ) {
            try {
                IEnumerable<string> pagesToParse = null;
                var targetList = new List<string>();
                if ( settings.UseCounter && settings.CounterEnd < settings.CounterStart )
                    throw new ArgumentException( @"Counter start must be <= counter end", "settings" );

                var baseuri = new Uri( settings.UseCounter ? String.Format( settings.Url, 0 ) : settings.Url );

                #region Counter

                Func<string, IEnumerable<string>> cntr = ( b ) => Enumerable
                    .Range(
                           settings.CounterStart,
                           settings.CounterEnd - settings.CounterStart + 1
                    )
                    .Select( a => String.Format( b, a ) );

                #endregion

                #region Url Matches

                Func<string, Regex, IEnumerable<string>> getMatches = ( a, b ) =>
                    b
                        .Matches( a )
                        .OfType<Match>()
                        .Select( c => c.ToString() );

                #endregion

                #region Url patches
                Func<string, Regex, Regex, string> genPatch = ( a, r1, r2 ) => {
                    if ( !r1.IsMatch( a ) )
                        return a;
                    return r2.Match(
                                    AdvancedWebClient
                                        .DownloadString( a )
                        )
                             .Value;
                };
                Func<string, string> vocarooPatch = ( a ) => genPatch( a, VocarooLink, VocarooTarget );
                Func<string, string> rghostPatch = ( a ) => genPatch( a, RghostLink, RghostTarget );
                #endregion

                switch ( settings.DwnType ) {
                    #region Matches on page

                    case DownloadType.Mathces:
                        pagesToParse = ( settings.UseCounter ? cntr( settings.Url ) : new[] { settings.Url } );
                        break;

                    #endregion

                    #region Download lists

                    case DownloadType.List:
                        targetList =
                            AdvancedWebClient
                                .DownloadString( settings.Url )
                                .Split( "\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries )
                                .SelectMany( cntr )
                                .Distinct()
                                .ToList()
                            ;
                        break;

                    #endregion

                    #region Simple counters

                    case DownloadType.CounterOnly:
                        targetList = ( settings.UseCounter ? cntr( settings.Url ) : new[] { settings.Url } )
                            .Distinct()
                            .ToList();
                        break;

                    #endregion

                    #region Matches lists

                    case DownloadType.MatchesList:
                        pagesToParse =
                            getMatches(
                                       new WebClient()
                                           .DownloadString( settings.Url ),
                                       settings.UrlRegex
                                );
                        if ( settings.UseCounter )
                            pagesToParse = pagesToParse
                                .SelectMany( cntr );
                        break;

                    #endregion

                    #region Инжалид дежице :)

                    case DownloadType.Unknown:
                        throw new ArgumentException( @"Bad download type", "settings" );
                    default:
                        throw new ArgumentOutOfRangeException();
                    #endregion
                }
                #region Get all targets

                if ( pagesToParse != null ) {
                    var toParse = pagesToParse as string[] ?? pagesToParse.ToArray();
                    var tmpq = toParse
                        .Distinct()
                        .AsParallel()
                        .Select( AdvancedWebClient.DownloadString )
                        .SelectMany( a => getMatches( a, settings.UrlRegex ) );
                    if ( settings.UseCounter )
                        tmpq = tmpq.SelectMany( cntr );
                    targetList = targetList
                        .Concat( tmpq )
                        .Distinct()
                        .ToList()
                        ;
                }

                #endregion
                #region Patches
                if ( settings.VocarooPatch )
                    targetList = targetList
                        .AsParallel()
                        .Select( vocarooPatch )
                        .Distinct()
                        .ToList();
                if ( settings.RghostPatch )
                    targetList = targetList
                        .AsParallel()
                        .Select( rghostPatch )
                        .Distinct()
                        .ToList();
                #endregion
                var reportInfo = new ProgressInfo { Ready = 0, Total = targetList.Count };

                #region Optimize target for multithread download
                var targetList2 = targetList
                    .Select( a => {
                        try {
                            return settings.Relative ? new Uri( baseuri, a ) : new Uri( a );
                        }
                        catch {
                            return null;
                        }
                    } )
                    .Where( a => !( a == null ) )
                    .GroupBy(
                             a => a.Host
                    );
                #endregion

                Parallel.ForEach( targetList2, new ParallelOptions { MaxDegreeOfParallelism = 16 }, uris => {
                    Parallel.ForEach( uris, new ParallelOptions { MaxDegreeOfParallelism = settings.SleepBetween ? 1 : 4 }, s => {
                        var output = Path.Combine( settings.OutputDir, Path.GetFileName( s.ToString() ) );
                        if ( File.Exists( output ) )
                            switch ( settings.ConflictAction ) {
                                case ConflictAction.Skip:
                                    return;
                                case ConflictAction.Autorename:
                                    output = Path.Combine(
                                                          Path.GetDirectoryName( output ),
                                                          settings.RenameOnConflictFunc(Path.GetFileNameWithoutExtension( output ))+
                                                          ////this._rnd.Next( int.MaxValue ) +
                                                          Path.GetExtension( output ) );
                                    break;
                            }
                        try {
                            AdvancedWebClient.DownloadFile( s.ToString(), output );
                            reportInfo.Ready++;
                        }
                        catch {
                            reportInfo.Error++;
                        }
                        finally {
                            settings.ReportProgress( reportInfo );
                            if ( settings.SleepBetween ) Thread.Sleep( settings.SleepTime );
                        }
                    } );
                } );
            }
            catch { }
        }
    }
}