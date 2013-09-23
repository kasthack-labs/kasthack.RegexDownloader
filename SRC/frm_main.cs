using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using EpicMorg.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using regexdownloader.Properties;

namespace regexdownloader {
    public partial class FrmMain : Form {
        readonly Regex _rghostLink = new Regex( "http://rghost.ru/[0-9]+" );
        readonly Regex _vocarooLink = new Regex( "http://vocaroo.com/i/[a-zA-Z0-9]+" );
        readonly Regex _vocarooTarget = new Regex( "/media_command.php?media=[a-zA-Z0-9]+&command=download_mp3" );
        readonly Regex _rghostTarget = new Regex( @"http://rghost.ru/download/[0-9]+/[0-9a-z]+/[A-Za-z0-9\.%]+" );
        readonly Random _rnd = new Random();

        public FrmMain() { InitializeComponent(); }
        private void BtnGoClick( object sender, EventArgs e ) { this.BwDwn.RunWorkerAsync(); }
        private void Form1_FormClosed( object sender, FormClosedEventArgs e ) { }
        private void btn_brs_Click( object sender, EventArgs e ) {
            if ( FbdBrs.ShowDialog() == DialogResult.OK )
                this.TxtSavePath.Text = FbdBrs.SelectedPath;
        }
        private void btnRunExplorer_Click( object sender, EventArgs e ) {
            try {
                Process.Start( TxtSavePath.Text );
            }
            catch { }
        }
        private void ChkCounterEnabled_CheckedChanged( object sender, EventArgs e ) {
            GrpCounter.Enabled = ChkCounterEnabled.Checked;
        }
        private void RdDwnPagesonly_CheckedChanged( object sender, EventArgs e ) { CmbRegex.Enabled = RdDwnAslist.Checked; }

        private void bwdl_DoWork( object sender, System.ComponentModel.DoWorkEventArgs e ) {
            DownloadSettings settings = null;
            this.Invoke( (Action) ( () => {
                settings = new DownloadSettings() {
                    AutoRename = RdConflictAutorename.Checked,
                    Url = TxtDwnUrl.Text,
                    CounterEnd = Convert.ToInt32( NudCounterEnd.Value ),
                    CounterStart = Convert.ToInt32( NudCounterStart.Value ),
                    OutputDir = TxtSavePath.Text,
                    Relative = ChkRegexRelativePath.Checked,
                    RghostPatch = ChkPatchRghost.Checked,
                    SkipExisting = RdConflictSkip.Checked,
                    SleepBetween = ChkRequestSleep.Checked,
                    SleepTime = Convert.ToInt32( NudRequsetSleep.Value ),
                    UrlRegex = new Regex( CmbRegex.Text ),
                    UseCounter = ChkCounterEnabled.Checked,
                    VocarooPatch = ChkPatchVocaroo.Checked,
                    ReportProgress = ( a ) => this.Invoke( (Action) ( () => this.ReportProgress( a ) ) )
                };
                if ( RdConflictAutorename.Checked )
                    settings.ConflictAction = ConflictAction.Autorename;
                else if ( RdConflictOverwrite.Checked )
                    settings.ConflictAction = ConflictAction.Overwrite;
                else if ( RdConflictSkip.Checked )
                    settings.ConflictAction = ConflictAction.Skip;
                else settings.ConflictAction = ConflictAction.Unknown;

                if ( RdDwnAslist.Checked )
                    settings.DwnType = DownloadType.List;
                else if ( RdDwnMatches.Checked )
                    settings.DwnType = DownloadType.Mathces;
                else if ( RdDwnPagesonly.Checked )
                    settings.DwnType = DownloadType.CounterOnly;
                else if ( RDDwnAsRecList.Checked )
                    settings.DwnType = DownloadType.MatchesList;
                else settings.DwnType = DownloadType.Unknown;
            } ) );
            Download( settings );
            this.Invoke( (Action) ( () => {
                Application.DoEvents();
                PrgDwn.Value = 100;
                PrgDwn.Enabled = false;
                BtnDwnRun.Text = Resources.FrmMain_bwdl_DoWork_GO_;
                BtnDwnRun.Enabled = true;
                MessageBox.Show( Resources.FrmMain_bwdl_DoWork_Finished );
            } ) );
        }

        private void Download( DownloadSettings settings ) {
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
                Func<string, Regex, Regex, string> genPatch = (a, r1, r2) => {
                    if ( !r1.IsMatch(a) )
                        return a;
                    return r2.Match(
                        AdvancedWebClient
                            .DownloadString(a)
                    )
                    .Value;
                };
                Func<string, string> vocarooPatch = (a) => genPatch(a, this._vocarooLink, this._vocarooTarget);
                Func<string, string> rghostPatch = (a) => genPatch(a, this._rghostLink, this._rghostTarget);
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
                            .Select(vocarooPatch)
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
                                                          Path.GetFileNameWithoutExtension( output ) +
                                                          this._rnd.Next( int.MaxValue ) +
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

        private void ReportProgress( ProgressInfo progressInfo ) {
            if ( progressInfo.Total > 0 )
                this.PrgDwn.Value = ( progressInfo.Ready + progressInfo.Error ) / progressInfo.Total;
        }

    }
}
