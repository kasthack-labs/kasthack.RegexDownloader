using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using regexdownloader;
using RegexDownloader;
using RegexDownloaderGUI.Properties;

namespace RegexDownloaderGUI {
    public partial class FrmMain : Form {
        readonly Random _rnd = new Random();

        public FrmMain() { this.InitializeComponent(); }
        private void BtnGoClick( object sender, EventArgs e ) { this.BwDwn.RunWorkerAsync(); }
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
        private void RdDwnPagesonly_CheckedChanged( object sender, EventArgs e ) { this.CmbRegex.Enabled = this.RdDwnAslist.Checked; }

        private void bwdl_DoWork( object sender, System.ComponentModel.DoWorkEventArgs e ) {
            DownloadSettings settings = null;
            this.Invoke( (Action) ( () => {
                settings = new DownloadSettings() {
                    AutoRename = this.RdConflictAutorename.Checked,
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
                    ReportProgress = ( a ) => this.Invoke( (Action) ( () => this.ReportProgress( a ) ) ),

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
                Application.DoEvents();
                this.PrgDwn.Value = 100;
                this.PrgDwn.Enabled = false;
                this.BtnDwnRun.Text = @"GO";
                this.BtnDwnRun.Enabled = true;
                MessageBox.Show( @"Finished" );
            } ) );
        }

        
        private void ReportProgress( ProgressInfo progressInfo ) {
            if ( progressInfo.Total > 0 )
                this.PrgDwn.Value = ( progressInfo.Ready + progressInfo.Error ) / progressInfo.Total;
        }

    }
}
