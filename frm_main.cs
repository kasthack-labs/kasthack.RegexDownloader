using EpicMorg.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
namespace regexdownloader {
	public partial class frm_main : Form {
		Regex rghost_link = new Regex("http://rghost.ru/[0-9]+");
		Regex rghost = new Regex(@"http://rghost.ru/download/[0-9]+/[0-9a-z]+/[A-Za-z0-9\.%]+");
		public frm_main() {
			InitializeComponent();
		}
		private void button1_Click( object sender, EventArgs e ) {
			this.bwdl.RunWorkerAsync();
		}
		private void Form1_FormClosed( object sender, FormClosedEventArgs e ) {
#if !DEBUG
            try
            {
                Process.Start("http://ww.epicm.org");
            }
            catch { }
#endif
		}
		private void bwdl_DoWork( object sender, System.ComponentModel.DoWorkEventArgs e ) {
			try {
				#region Vars
				List<string> targets = new List<string>();
				string protocol = null;
				string input = null;
				Regex r = null;
				Uri tempuri = null;
				string o = null;
				bool skip_existing = true;
				bool sleep_between = false;
				int sleep_time = 0;
				bool autorename = false;
				Uri baseuri = null;
				bool relative = false;
				Random rnd = new Random();
				bool use_counter = false;
				int counter_start = 0, counter_end = 0;
				string baseuri_s = "";
				#endregion
				var Update = (Action<int>)( ( int c ) => {
					this.lbl_dl.Text = ++c + "/" + targets.Count;
					this.prg_dl.Value = Convert.ToInt32(( (double)c * 100 ) / targets.Count);
				} );
				#region GetParams
				this.Invoke((Action)( () => {
					baseuri_s = txt_url.Text;
					r = new Regex(cmb_regex.Text);
					o = txt_path.Text;
					skip_existing = rdskip.Checked;
					sleep_between = chksleep.Checked;
					sleep_time = Convert.ToInt32(nudsleep.Value);
					autorename = rdautorename.Checked;
					relative = checkBox1.Checked;
					btn_go.Text = "Loading..";
					btn_go.Enabled = false;
					this.prg_dl.Enabled = true;
					this.prg_dl.Value = 0;
					use_counter = chk_use_counter.Checked;
					counter_end = Convert.ToInt32(nud_end.Value);
					counter_start = Convert.ToInt32(nud_start.Value);
				} ));
				#endregion
				if ( use_counter && counter_end < counter_start ) {
					this.Invoke((Action)( () => {
						MessageBox.Show("Counter start must be <= counter end","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
					} ));
					return;
				}
				baseuri = new Uri(use_counter ? String.Format(baseuri_s, 0) : baseuri_s);
				protocol = baseuri.Scheme + ":";
				#region Counter
				input = use_counter ?
					String.Concat(
						Enumerable.Range(
							counter_start,
							counter_end-counter_start  + 1
						).
						Select(a =>
							AdvancedWebClient.
								DownloadString(
									String.Format(
										baseuri_s,
										a
									)
								)
						)
					)
					: new WebClient().DownloadString(baseuri);
				#endregion
				targets.AddRange(( from Match v in r.Matches(input) select v.Value ).Select(a => a.StartsWith("//") ? protocol + a : a).ToArray());
				#region RGhost
				if ( chk_rghost.Checked )
					targets = targets.Select(a => rghost_link.IsMatch(a) ? rghost.Match(AdvancedWebClient.DownloadString(a)).Value : a).Where(b => b.Length > 0).ToList();
				#endregion
				#region Download
				targets = targets.Distinct().ToList();
				this.Invoke((Action)( () => this.lbl_dl.Text = "0/" + targets.Count ));
				int cnt = 0;
				foreach ( var s in targets ) {
					string s2 = relative ? new Uri(baseuri, s).ToString() : s;
					string output = Path.Combine(o, Path.GetFileName(s));
					if ( File.Exists(output) )
						if ( skip_existing ) {
							this.Invoke((Action)( () => Update(++cnt) ));
							continue;
						}
						else
							output = autorename ?
									Path.Combine(Path.GetDirectoryName(output), Path.GetFileNameWithoutExtension(output) + rnd.Next(int.MaxValue) + Path.GetExtension(output))
									: output;
					try {
						AdvancedWebClient.DownloadFile(s2, output);
					}
					catch {
						continue;
					}
					this.Invoke((Action)( () => Update(++cnt) ));
					if ( sleep_between ) Thread.Sleep(sleep_time);
				}
			}
			catch { }
				#endregion
			this.Invoke((Action)( () => {
				Application.DoEvents();
				prg_dl.Value = 100;
				prg_dl.Enabled = false;
				btn_go.Text = "GO!";
				btn_go.Enabled = true;
				MessageBox.Show("Finished");
			} ));
		}

		private void btn_brs_Click( object sender, EventArgs e ) {
			if ( fbd1.ShowDialog() == DialogResult.OK )
				this.txt_path.Text = fbd1.SelectedPath;
		}

		private void checkBox2_CheckedChanged( object sender, EventArgs e ) {
			grp_counter.Enabled = chk_use_counter.Checked;
		}
	}
}
