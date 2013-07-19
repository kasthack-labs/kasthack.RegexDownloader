namespace regexdownloader
{
    partial class frm_main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
			this.txt_url = new System.Windows.Forms.TextBox();
			this.lbl_url = new System.Windows.Forms.Label();
			this.lbl_regex = new System.Windows.Forms.Label();
			this.lbl_path = new System.Windows.Forms.Label();
			this.txt_path = new System.Windows.Forms.TextBox();
			this.btn_go = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.chksleep = new System.Windows.Forms.CheckBox();
			this.nudsleep = new System.Windows.Forms.NumericUpDown();
			this.grp_conflicts = new System.Windows.Forms.GroupBox();
			this.rdskip = new System.Windows.Forms.RadioButton();
			this.rdautorename = new System.Windows.Forms.RadioButton();
			this.rdoverwrite = new System.Windows.Forms.RadioButton();
			this.cmb_regex = new System.Windows.Forms.ComboBox();
			this.grp_patches = new System.Windows.Forms.GroupBox();
			this.chk_rghost = new System.Windows.Forms.CheckBox();
			this.chk_vocaroo = new System.Windows.Forms.CheckBox();
			this.bwdl = new System.ComponentModel.BackgroundWorker();
			this.prg_dl = new System.Windows.Forms.ProgressBar();
			this.lbl_dl = new System.Windows.Forms.Label();
			this.btn_brs = new System.Windows.Forms.Button();
			this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
			this.grp_counter = new System.Windows.Forms.GroupBox();
			this.txt_counter_help = new System.Windows.Forms.TextBox();
			this.nud_end = new System.Windows.Forms.NumericUpDown();
			this.nud_start = new System.Windows.Forms.NumericUpDown();
			this.lbl_end = new System.Windows.Forms.Label();
			this.lbl_start = new System.Windows.Forms.Label();
			this.chk_use_counter = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.nudsleep)).BeginInit();
			this.grp_conflicts.SuspendLayout();
			this.grp_patches.SuspendLayout();
			this.grp_counter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_end)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_start)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_url
			// 
			this.txt_url.Location = new System.Drawing.Point(13, 30);
			this.txt_url.Name = "txt_url";
			this.txt_url.Size = new System.Drawing.Size(259, 20);
			this.txt_url.TabIndex = 0;
			this.txt_url.Text = "http://z.falsetrue.net/lol.php";
			// 
			// lbl_url
			// 
			this.lbl_url.AutoSize = true;
			this.lbl_url.Location = new System.Drawing.Point(13, 11);
			this.lbl_url.Name = "lbl_url";
			this.lbl_url.Size = new System.Drawing.Size(20, 13);
			this.lbl_url.TabIndex = 1;
			this.lbl_url.Text = "Url";
			// 
			// lbl_regex
			// 
			this.lbl_regex.AutoSize = true;
			this.lbl_regex.Location = new System.Drawing.Point(15, 77);
			this.lbl_regex.Name = "lbl_regex";
			this.lbl_regex.Size = new System.Drawing.Size(38, 13);
			this.lbl_regex.TabIndex = 2;
			this.lbl_regex.Text = "Regex";
			// 
			// lbl_path
			// 
			this.lbl_path.AutoSize = true;
			this.lbl_path.Location = new System.Drawing.Point(12, 137);
			this.lbl_path.Name = "lbl_path";
			this.lbl_path.Size = new System.Drawing.Size(63, 13);
			this.lbl_path.TabIndex = 4;
			this.lbl_path.Text = "Output path";
			// 
			// txt_path
			// 
			this.txt_path.Location = new System.Drawing.Point(12, 181);
			this.txt_path.Name = "txt_path";
			this.txt_path.Size = new System.Drawing.Size(223, 20);
			this.txt_path.TabIndex = 5;
			this.txt_path.Text = "B:\\z.falsetrue.net";
			// 
			// btn_go
			// 
			this.btn_go.Location = new System.Drawing.Point(16, 251);
			this.btn_go.Name = "btn_go";
			this.btn_go.Size = new System.Drawing.Size(256, 23);
			this.btn_go.TabIndex = 6;
			this.btn_go.Text = "GO";
			this.btn_go.UseVisualStyleBackColor = true;
			this.btn_go.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(16, 213);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(133, 17);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.Text = "Relative path for regex";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// chksleep
			// 
			this.chksleep.AutoSize = true;
			this.chksleep.Location = new System.Drawing.Point(300, 30);
			this.chksleep.Name = "chksleep";
			this.chksleep.Size = new System.Drawing.Size(159, 17);
			this.chksleep.TabIndex = 8;
			this.chksleep.Text = "Sleep between requests(ms)";
			this.chksleep.UseVisualStyleBackColor = true;
			// 
			// nudsleep
			// 
			this.nudsleep.Location = new System.Drawing.Point(323, 69);
			this.nudsleep.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.nudsleep.Name = "nudsleep";
			this.nudsleep.Size = new System.Drawing.Size(117, 20);
			this.nudsleep.TabIndex = 9;
			this.nudsleep.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// grp_conflicts
			// 
			this.grp_conflicts.Controls.Add(this.rdskip);
			this.grp_conflicts.Controls.Add(this.rdautorename);
			this.grp_conflicts.Controls.Add(this.rdoverwrite);
			this.grp_conflicts.Location = new System.Drawing.Point(300, 122);
			this.grp_conflicts.Name = "grp_conflicts";
			this.grp_conflicts.Size = new System.Drawing.Size(238, 152);
			this.grp_conflicts.TabIndex = 10;
			this.grp_conflicts.TabStop = false;
			this.grp_conflicts.Text = "Name confilcts solving";
			// 
			// rdskip
			// 
			this.rdskip.AutoSize = true;
			this.rdskip.Checked = true;
			this.rdskip.Location = new System.Drawing.Point(23, 116);
			this.rdskip.Name = "rdskip";
			this.rdskip.Size = new System.Drawing.Size(83, 17);
			this.rdskip.TabIndex = 2;
			this.rdskip.TabStop = true;
			this.rdskip.Text = "Skip loading";
			this.rdskip.UseVisualStyleBackColor = true;
			// 
			// rdautorename
			// 
			this.rdautorename.AutoSize = true;
			this.rdautorename.Location = new System.Drawing.Point(23, 74);
			this.rdautorename.Name = "rdautorename";
			this.rdautorename.Size = new System.Drawing.Size(82, 17);
			this.rdautorename.TabIndex = 1;
			this.rdautorename.TabStop = true;
			this.rdautorename.Text = "Autorename";
			this.rdautorename.UseVisualStyleBackColor = true;
			// 
			// rdoverwrite
			// 
			this.rdoverwrite.AutoSize = true;
			this.rdoverwrite.Location = new System.Drawing.Point(23, 29);
			this.rdoverwrite.Name = "rdoverwrite";
			this.rdoverwrite.Size = new System.Drawing.Size(70, 17);
			this.rdoverwrite.TabIndex = 0;
			this.rdoverwrite.TabStop = true;
			this.rdoverwrite.Text = "Overwrite";
			this.rdoverwrite.UseVisualStyleBackColor = true;
			// 
			// cmb_regex
			// 
			this.cmb_regex.FormattingEnabled = true;
			this.cmb_regex.Items.AddRange(new object[] {
            "//images\\.4chan\\.org\\/b\\/src\\/[0-9]+\\.(jpg|png|gif|jpeg)",
            "http://([a-zA-Z0-9\\-\\.]+\\.)?(([[a-zA-Z0-9]+)\\.([a-zA-Z]))/([a-zA-Z0-9\\/\\.\\-_%\\?]+" +
                ")?",
            "\\/[a-z]+\\/src\\/[0-9]+\\.(jpg|png|gif)",
            "\\/src\\/(jpg|png|gif|jpeg|pdf|doc|rar|7z)\\/[0-9]+\\/[0-9]+\\.(jpg|png|gif|jpeg|pdf|d" +
                "oc|rar|7z)",
            "http://rghost.ru/[0-9]+",
            "http://vocaroo.com/i/[a-zA-Z0-9]+",
            "http://anonymousdelivers.us/[0-9]+"});
			this.cmb_regex.Location = new System.Drawing.Point(13, 107);
			this.cmb_regex.Name = "cmb_regex";
			this.cmb_regex.Size = new System.Drawing.Size(259, 21);
			this.cmb_regex.TabIndex = 11;
			this.cmb_regex.Text = "\\/[a-z]+\\/src\\/[0-9]+\\.(jpg|png|gif)";
			// 
			// grp_patches
			// 
			this.grp_patches.Controls.Add(this.chk_rghost);
			this.grp_patches.Controls.Add(this.chk_vocaroo);
			this.grp_patches.Location = new System.Drawing.Point(18, 346);
			this.grp_patches.Name = "grp_patches";
			this.grp_patches.Size = new System.Drawing.Size(520, 71);
			this.grp_patches.TabIndex = 12;
			this.grp_patches.TabStop = false;
			this.grp_patches.Text = "Url Patches";
			// 
			// chk_rghost
			// 
			this.chk_rghost.AutoSize = true;
			this.chk_rghost.Location = new System.Drawing.Point(19, 33);
			this.chk_rghost.Name = "chk_rghost";
			this.chk_rghost.Size = new System.Drawing.Size(62, 17);
			this.chk_rghost.TabIndex = 2;
			this.chk_rghost.Text = "RGhost";
			this.chk_rghost.UseVisualStyleBackColor = true;
			// 
			// chk_vocaroo
			// 
			this.chk_vocaroo.AutoSize = true;
			this.chk_vocaroo.Location = new System.Drawing.Point(408, 33);
			this.chk_vocaroo.Name = "chk_vocaroo";
			this.chk_vocaroo.Size = new System.Drawing.Size(66, 17);
			this.chk_vocaroo.TabIndex = 1;
			this.chk_vocaroo.Text = "Vocaroo";
			this.chk_vocaroo.UseVisualStyleBackColor = true;
			// 
			// bwdl
			// 
			this.bwdl.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwdl_DoWork);
			// 
			// prg_dl
			// 
			this.prg_dl.Enabled = false;
			this.prg_dl.Location = new System.Drawing.Point(18, 317);
			this.prg_dl.Name = "prg_dl";
			this.prg_dl.Size = new System.Drawing.Size(520, 23);
			this.prg_dl.TabIndex = 13;
			// 
			// lbl_dl
			// 
			this.lbl_dl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_dl.AutoSize = true;
			this.lbl_dl.Location = new System.Drawing.Point(258, 290);
			this.lbl_dl.Name = "lbl_dl";
			this.lbl_dl.Size = new System.Drawing.Size(0, 13);
			this.lbl_dl.TabIndex = 14;
			// 
			// btn_brs
			// 
			this.btn_brs.Location = new System.Drawing.Point(242, 181);
			this.btn_brs.Name = "btn_brs";
			this.btn_brs.Size = new System.Drawing.Size(52, 23);
			this.btn_brs.TabIndex = 15;
			this.btn_brs.Text = "...";
			this.btn_brs.UseVisualStyleBackColor = true;
			this.btn_brs.Click += new System.EventHandler(this.btn_brs_Click);
			// 
			// grp_counter
			// 
			this.grp_counter.Controls.Add(this.txt_counter_help);
			this.grp_counter.Controls.Add(this.nud_end);
			this.grp_counter.Controls.Add(this.nud_start);
			this.grp_counter.Controls.Add(this.lbl_end);
			this.grp_counter.Controls.Add(this.lbl_start);
			this.grp_counter.Location = new System.Drawing.Point(541, 69);
			this.grp_counter.Name = "grp_counter";
			this.grp_counter.Size = new System.Drawing.Size(171, 348);
			this.grp_counter.TabIndex = 16;
			this.grp_counter.TabStop = false;
			this.grp_counter.Text = "Counter";
			// 
			// txt_counter_help
			// 
			this.txt_counter_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txt_counter_help.Location = new System.Drawing.Point(9, 182);
			this.txt_counter_help.Multiline = true;
			this.txt_counter_help.Name = "txt_counter_help";
			this.txt_counter_help.ReadOnly = true;
			this.txt_counter_help.Size = new System.Drawing.Size(154, 160);
			this.txt_counter_help.TabIndex = 6;
			this.txt_counter_help.Text = "Counter can be used to download files from different pages. {0} in url will be re" +
    "placed with counter value\r\n";
			// 
			// nud_end
			// 
			this.nud_end.Location = new System.Drawing.Point(9, 144);
			this.nud_end.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.nud_end.Name = "nud_end";
			this.nud_end.Size = new System.Drawing.Size(154, 20);
			this.nud_end.TabIndex = 5;
			// 
			// nud_start
			// 
			this.nud_start.Location = new System.Drawing.Point(9, 68);
			this.nud_start.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.nud_start.Name = "nud_start";
			this.nud_start.Size = new System.Drawing.Size(154, 20);
			this.nud_start.TabIndex = 4;
			// 
			// lbl_end
			// 
			this.lbl_end.AutoSize = true;
			this.lbl_end.Location = new System.Drawing.Point(9, 112);
			this.lbl_end.Name = "lbl_end";
			this.lbl_end.Size = new System.Drawing.Size(26, 13);
			this.lbl_end.TabIndex = 2;
			this.lbl_end.Text = "End";
			// 
			// lbl_start
			// 
			this.lbl_start.AutoSize = true;
			this.lbl_start.Location = new System.Drawing.Point(6, 38);
			this.lbl_start.Name = "lbl_start";
			this.lbl_start.Size = new System.Drawing.Size(29, 13);
			this.lbl_start.TabIndex = 1;
			this.lbl_start.Text = "Start";
			// 
			// chk_use_counter
			// 
			this.chk_use_counter.AutoSize = true;
			this.chk_use_counter.Location = new System.Drawing.Point(541, 30);
			this.chk_use_counter.Name = "chk_use_counter";
			this.chk_use_counter.Size = new System.Drawing.Size(84, 17);
			this.chk_use_counter.TabIndex = 0;
			this.chk_use_counter.Text = "Use counter";
			this.chk_use_counter.UseVisualStyleBackColor = true;
			this.chk_use_counter.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// frm_main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 425);
			this.Controls.Add(this.grp_counter);
			this.Controls.Add(this.chk_use_counter);
			this.Controls.Add(this.btn_brs);
			this.Controls.Add(this.lbl_dl);
			this.Controls.Add(this.prg_dl);
			this.Controls.Add(this.grp_patches);
			this.Controls.Add(this.cmb_regex);
			this.Controls.Add(this.grp_conflicts);
			this.Controls.Add(this.nudsleep);
			this.Controls.Add(this.chksleep);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.btn_go);
			this.Controls.Add(this.txt_path);
			this.Controls.Add(this.lbl_path);
			this.Controls.Add(this.lbl_regex);
			this.Controls.Add(this.lbl_url);
			this.Controls.Add(this.txt_url);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frm_main";
			this.Text = "Regex Downloader";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.nudsleep)).EndInit();
			this.grp_conflicts.ResumeLayout(false);
			this.grp_conflicts.PerformLayout();
			this.grp_patches.ResumeLayout(false);
			this.grp_patches.PerformLayout();
			this.grp_counter.ResumeLayout(false);
			this.grp_counter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_end)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_start)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.Label lbl_regex;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chksleep;
        private System.Windows.Forms.NumericUpDown nudsleep;
        private System.Windows.Forms.GroupBox grp_conflicts;
        private System.Windows.Forms.RadioButton rdskip;
        private System.Windows.Forms.RadioButton rdautorename;
        private System.Windows.Forms.RadioButton rdoverwrite;
        private System.Windows.Forms.ComboBox cmb_regex;
        private System.Windows.Forms.GroupBox grp_patches;
        private System.Windows.Forms.CheckBox chk_rghost;
        private System.Windows.Forms.CheckBox chk_vocaroo;
        private System.ComponentModel.BackgroundWorker bwdl;
        private System.Windows.Forms.ProgressBar prg_dl;
        private System.Windows.Forms.Label lbl_dl;
				private System.Windows.Forms.Button btn_brs;
				private System.Windows.Forms.FolderBrowserDialog fbd1;
				private System.Windows.Forms.GroupBox grp_counter;
				private System.Windows.Forms.TextBox txt_counter_help;
				private System.Windows.Forms.NumericUpDown nud_end;
				private System.Windows.Forms.NumericUpDown nud_start;
				private System.Windows.Forms.Label lbl_end;
				private System.Windows.Forms.Label lbl_start;
				private System.Windows.Forms.CheckBox chk_use_counter;
    }
}

