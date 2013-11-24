using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RegexDownloader;

namespace RegexDownloaderGUI {
    public partial class FrmMain : Form {
        readonly Random _rnd = new Random();
        private bool _isDownloadRunning;
        public FrmMain() { this.InitializeComponent(); }

        private void BtnGoClick(object sender, EventArgs e) {
            if (!this._isDownloadRunning)
                this.BwDwn.RunWorkerAsync();
            else {
                this.BwDwn.CancelAsync();
            }
            this._isDownloadRunning ^= true;
        }
        private void Form1_FormClosed( object sender, FormClosedEventArgs e ) { }
        private void btn_brs_Click( object sender, EventArgs e ) {
            if ( this.FbdBrs.ShowDialog() == DialogResult.OK )
                this.TxtSavePath.Text = this.FbdBrs.SelectedPath;
        }
        private void btnRunExplorer_Click( object sender, EventArgs e ) {
            try {
                Process.Start( this.TxtSavePath.Text );
            }
            catch { }
        }
        private void ChkCounterEnabled_CheckedChanged( object sender, EventArgs e ) {
            this.GrpCounter.Enabled = this.ChkCounterEnabled.Checked;
        }
        private void RdDwnPagesonly_CheckedChanged( object sender, EventArgs e ) { this.CmbRegex.Enabled = !this.RdDwnPagesonly.Checked;
            ChkCounterEnabled.Checked |= this.RdDwnPagesonly.Checked;
        }

        private void bwdl_DoWork( object sender, System.ComponentModel.DoWorkEventArgs e ) {
            DownloadSettings settings = null;
            this.Invoke( (Action) ( () => {
                this._isDownloadRunning = true;
                this.GrpDownload.Enabled = true;
                this.GrpInput.Enabled = true;
                this.BtnDwnRun.Text = @"Cancel";
                Application.DoEvents();
            } ));
            this.Invoke( (Action) ( () => {
                settings = new DownloadSettings {
                    AutoRename = this.RdConflictAutorename.Checked,
                    RenameOnConflictFunc =
                        a=>
                            Path.Combine(
                                Path.GetDirectoryName(a),
                                Path.GetFileNameWithoutExtension(a)+
                                    "."+
                                    this._rnd.Next()+
                                    Path.GetExtension(a)
                            ),
                    CancelFunc=()=>e.Cancel,
                    Url = this.TxtDwnUrl.Text,
                    CounterEnd = Convert.ToInt32( this.NudCounterEnd.Value ),
                    CounterStart = Convert.ToInt32( this.NudCounterStart.Value ),
                    OutputDir = this.TxtSavePath.Text,
                    Relative = this.ChkRegexRelativePath.Checked,
                    RghostPatch = this.ChkPatchRghost.Checked,
                    SleepBetween = this.ChkRequestSleep.Checked,
                    SleepTime = Convert.ToInt32( this.NudRequsetSleep.Value ),
                    UrlRegex = new Regex( this.CmbRegex.Text ),
                    UseCounter = this.ChkCounterEnabled.Checked,
                    VocarooPatch = this.ChkPatchVocaroo.Checked,
                    ReportProgress = a => this.Invoke( (Action) ( () => this.ReportProgress( a ) ) ),
                    ThreadCount = Convert.ToInt32(this.NudParallelDownloads.Value),
                    PadLeft = this.ChkCounterPadLeft.Checked,
                    PadLength = Convert.ToInt32( this.NudCounterPadLeft.Value )
                };
                if ( this.RdConflictAutorename.Checked )
                    settings.ConflictAction = ConflictAction.Autorename;
                else if ( this.RdConflictOverwrite.Checked )
                    settings.ConflictAction = ConflictAction.Overwrite;
                else if ( this.RdConflictSkip.Checked )
                    settings.ConflictAction = ConflictAction.Skip;
                else settings.ConflictAction = ConflictAction.Unknown;

                if ( this.RdDwnAslist.Checked )
                    settings.DwnType = DownloadType.List;
                else if ( this.RdDwnMatches.Checked )
                    settings.DwnType = DownloadType.Mathces;
                else if ( this.RdDwnPagesonly.Checked )
                    settings.DwnType = DownloadType.CounterOnly;
                else if ( this.RDDwnAsRecList.Checked )
                    settings.DwnType = DownloadType.MatchesList;
                else settings.DwnType = DownloadType.Unknown;
            } ) );
            Downloader.Download( settings );
            this.Invoke( (Action) ( () => {
                this._isDownloadRunning = false;
                this.GrpDownload.Enabled = true;
                this.GrpInput.Enabled = true;
                this.PrgDwn.Value = 100;
                this.BtnDwnRun.Text = @"GO";
                MessageBox.Show( @"Finished" );
            } ) );
        }

        
        private void ReportProgress( ProgressInfo progressInfo ) {
            if ( progressInfo.Total <= 0 ) return;
            this.PrgDwn.Value = ( progressInfo.Ready + progressInfo.Error ) / progressInfo.Total;
            this.LblDwnStat.Text = string.Format(
                "{0} complete/{1} failed/{2} total",
                progressInfo.Ready,
                progressInfo.Error,
                progressInfo.Total
            );
            Application.DoEvents();
        }

        private void ChkRequestSleep_CheckedChanged( object sender, EventArgs e ) {
            this.NudRequsetSleep.Enabled = this.ChkRequestSleep.Checked;
        }

        private void ChkCounterPadLeft_CheckedChanged( object sender, EventArgs e ) {
            NudCounterPadLeft.Enabled = ChkCounterPadLeft.Checked;
        }

    }
}