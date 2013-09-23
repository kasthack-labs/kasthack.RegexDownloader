namespace RegexDownloaderGUI
{
    partial class FrmMain
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TxtDwnUrl = new System.Windows.Forms.TextBox();
            this.LblRegex = new System.Windows.Forms.Label();
            this.LblSavePath = new System.Windows.Forms.Label();
            this.TxtSavePath = new System.Windows.Forms.TextBox();
            this.BtnDwnRun = new System.Windows.Forms.Button();
            this.ChkRegexRelativePath = new System.Windows.Forms.CheckBox();
            this.ChkRequestSleep = new System.Windows.Forms.CheckBox();
            this.NudRequsetSleep = new System.Windows.Forms.NumericUpDown();
            this.GrpConflicts = new System.Windows.Forms.GroupBox();
            this.RdConflictSkip = new System.Windows.Forms.RadioButton();
            this.RdConflictAutorename = new System.Windows.Forms.RadioButton();
            this.RdConflictOverwrite = new System.Windows.Forms.RadioButton();
            this.CmbRegex = new System.Windows.Forms.ComboBox();
            this.ChkPatchRghost = new System.Windows.Forms.CheckBox();
            this.ChkPatchVocaroo = new System.Windows.Forms.CheckBox();
            this.BwDwn = new System.ComponentModel.BackgroundWorker();
            this.PrgDwn = new System.Windows.Forms.ProgressBar();
            this.BtnBrowseOutput = new System.Windows.Forms.Button();
            this.FbdBrs = new System.Windows.Forms.FolderBrowserDialog();
            this.GrpCounter = new System.Windows.Forms.GroupBox();
            this.NudCounterEnd = new System.Windows.Forms.NumericUpDown();
            this.NudCounterStart = new System.Windows.Forms.NumericUpDown();
            this.LblCounterEnd = new System.Windows.Forms.Label();
            this.LblCounterStart = new System.Windows.Forms.Label();
            this.GrpInput = new System.Windows.Forms.GroupBox();
            this.RdDwnAslist = new System.Windows.Forms.RadioButton();
            this.RdDwnPagesonly = new System.Windows.Forms.RadioButton();
            this.RdDwnMatches = new System.Windows.Forms.RadioButton();
            this.LblDwnAction = new System.Windows.Forms.Label();
            this.ChkCounterEnabled = new System.Windows.Forms.CheckBox();
            this.LblDwnUrl = new System.Windows.Forms.Label();
            this.GrpDownload = new System.Windows.Forms.GroupBox();
            this.btnRunExplorer = new System.Windows.Forms.Button();
            this.LblUrlPatches = new System.Windows.Forms.Label();
            this.LblDwnStat = new System.Windows.Forms.Label();
            this.RDDwnAsRecList = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.NudRequsetSleep)).BeginInit();
            this.GrpConflicts.SuspendLayout();
            this.GrpCounter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCounterEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCounterStart)).BeginInit();
            this.GrpInput.SuspendLayout();
            this.GrpDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtDwnUrl
            // 
            this.TxtDwnUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDwnUrl.Location = new System.Drawing.Point(53, 17);
            this.TxtDwnUrl.Name = "TxtDwnUrl";
            this.TxtDwnUrl.Size = new System.Drawing.Size(398, 20);
            this.TxtDwnUrl.TabIndex = 0;
            this.TxtDwnUrl.Text = "http://z.falsetrue.net/lol.php";
            // 
            // LblRegex
            // 
            this.LblRegex.AutoSize = true;
            this.LblRegex.Location = new System.Drawing.Point(17, 28);
            this.LblRegex.Name = "LblRegex";
            this.LblRegex.Size = new System.Drawing.Size(38, 13);
            this.LblRegex.TabIndex = 2;
            this.LblRegex.Text = "Regex";
            // 
            // LblSavePath
            // 
            this.LblSavePath.AutoSize = true;
            this.LblSavePath.Location = new System.Drawing.Point(17, 172);
            this.LblSavePath.Name = "LblSavePath";
            this.LblSavePath.Size = new System.Drawing.Size(63, 13);
            this.LblSavePath.TabIndex = 4;
            this.LblSavePath.Text = "Output path";
            // 
            // TxtSavePath
            // 
            this.TxtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSavePath.Location = new System.Drawing.Point(17, 198);
            this.TxtSavePath.Name = "TxtSavePath";
            this.TxtSavePath.Size = new System.Drawing.Size(503, 20);
            this.TxtSavePath.TabIndex = 5;
            this.TxtSavePath.Text = "B:\\z.falsetrue.net";
            // 
            // BtnDwnRun
            // 
            this.BtnDwnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDwnRun.Location = new System.Drawing.Point(13, 410);
            this.BtnDwnRun.Name = "BtnDwnRun";
            this.BtnDwnRun.Size = new System.Drawing.Size(686, 72);
            this.BtnDwnRun.TabIndex = 6;
            this.BtnDwnRun.Text = "GO";
            this.BtnDwnRun.UseVisualStyleBackColor = true;
            this.BtnDwnRun.Click += new System.EventHandler(this.BtnGoClick);
            // 
            // ChkRegexRelativePath
            // 
            this.ChkRegexRelativePath.AutoSize = true;
            this.ChkRegexRelativePath.Checked = true;
            this.ChkRegexRelativePath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkRegexRelativePath.Location = new System.Drawing.Point(20, 93);
            this.ChkRegexRelativePath.Name = "ChkRegexRelativePath";
            this.ChkRegexRelativePath.Size = new System.Drawing.Size(133, 17);
            this.ChkRegexRelativePath.TabIndex = 7;
            this.ChkRegexRelativePath.Text = "Relative path for regex";
            this.ChkRegexRelativePath.UseVisualStyleBackColor = true;
            // 
            // ChkRequestSleep
            // 
            this.ChkRequestSleep.AutoSize = true;
            this.ChkRequestSleep.Location = new System.Drawing.Point(20, 116);
            this.ChkRequestSleep.Name = "ChkRequestSleep";
            this.ChkRequestSleep.Size = new System.Drawing.Size(159, 17);
            this.ChkRequestSleep.TabIndex = 8;
            this.ChkRequestSleep.Text = "Sleep between requests(ms)";
            this.ChkRequestSleep.UseVisualStyleBackColor = true;
            // 
            // NudRequsetSleep
            // 
            this.NudRequsetSleep.Location = new System.Drawing.Point(214, 116);
            this.NudRequsetSleep.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.NudRequsetSleep.Name = "NudRequsetSleep";
            this.NudRequsetSleep.Size = new System.Drawing.Size(117, 20);
            this.NudRequsetSleep.TabIndex = 9;
            this.NudRequsetSleep.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // GrpConflicts
            // 
            this.GrpConflicts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpConflicts.Controls.Add(this.RdConflictSkip);
            this.GrpConflicts.Controls.Add(this.RdConflictAutorename);
            this.GrpConflicts.Controls.Add(this.RdConflictOverwrite);
            this.GrpConflicts.Location = new System.Drawing.Point(361, 106);
            this.GrpConflicts.Name = "GrpConflicts";
            this.GrpConflicts.Size = new System.Drawing.Size(306, 79);
            this.GrpConflicts.TabIndex = 10;
            this.GrpConflicts.TabStop = false;
            this.GrpConflicts.Text = "Name confilcts solving";
            // 
            // RdConflictSkip
            // 
            this.RdConflictSkip.AutoSize = true;
            this.RdConflictSkip.Checked = true;
            this.RdConflictSkip.Location = new System.Drawing.Point(187, 29);
            this.RdConflictSkip.Name = "RdConflictSkip";
            this.RdConflictSkip.Size = new System.Drawing.Size(83, 17);
            this.RdConflictSkip.TabIndex = 2;
            this.RdConflictSkip.TabStop = true;
            this.RdConflictSkip.Text = "Skip loading";
            this.RdConflictSkip.UseVisualStyleBackColor = true;
            // 
            // RdConflictAutorename
            // 
            this.RdConflictAutorename.AutoSize = true;
            this.RdConflictAutorename.Location = new System.Drawing.Point(99, 29);
            this.RdConflictAutorename.Name = "RdConflictAutorename";
            this.RdConflictAutorename.Size = new System.Drawing.Size(82, 17);
            this.RdConflictAutorename.TabIndex = 1;
            this.RdConflictAutorename.TabStop = true;
            this.RdConflictAutorename.Text = "Autorename";
            this.RdConflictAutorename.UseVisualStyleBackColor = true;
            // 
            // RdConflictOverwrite
            // 
            this.RdConflictOverwrite.AutoSize = true;
            this.RdConflictOverwrite.Location = new System.Drawing.Point(23, 29);
            this.RdConflictOverwrite.Name = "RdConflictOverwrite";
            this.RdConflictOverwrite.Size = new System.Drawing.Size(70, 17);
            this.RdConflictOverwrite.TabIndex = 0;
            this.RdConflictOverwrite.TabStop = true;
            this.RdConflictOverwrite.Text = "Overwrite";
            this.RdConflictOverwrite.UseVisualStyleBackColor = true;
            // 
            // CmbRegex
            // 
            this.CmbRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbRegex.FormattingEnabled = true;
            this.CmbRegex.Items.AddRange(new object[] {
            "//images\\.4chan\\.org\\/b\\/src\\/[0-9]+\\.(jpg|png|gif|jpeg)",
            "http://([a-zA-Z0-9\\-\\.]+\\.)?(([[a-zA-Z0-9]+)\\.([a-zA-Z]))/([a-zA-Z0-9\\/\\.\\-_%\\?]+" +
                ")?",
            "\\/[a-z]+\\/src\\/[0-9]+\\.(jpg|png|gif)",
            "\\/src\\/(jpg|png|gif|jpeg|pdf|doc|rar|7z)\\/[0-9]+\\/[0-9]+\\.(jpg|png|gif|jpeg|pdf|d" +
                "oc|rar|7z)",
            "http://rghost.ru/[0-9]+",
            "http://vocaroo.com/i/[a-zA-Z0-9]+",
            "http://anonymousdelivers.us/[0-9]+"});
            this.CmbRegex.Location = new System.Drawing.Point(20, 51);
            this.CmbRegex.Name = "CmbRegex";
            this.CmbRegex.Size = new System.Drawing.Size(431, 21);
            this.CmbRegex.TabIndex = 11;
            this.CmbRegex.Text = "\\/[a-z]+\\/src\\/[0-9]+\\.(jpg|png|gif)";
            // 
            // ChkPatchRghost
            // 
            this.ChkPatchRghost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkPatchRghost.AutoSize = true;
            this.ChkPatchRghost.Location = new System.Drawing.Point(483, 51);
            this.ChkPatchRghost.Name = "ChkPatchRghost";
            this.ChkPatchRghost.Size = new System.Drawing.Size(62, 17);
            this.ChkPatchRghost.TabIndex = 2;
            this.ChkPatchRghost.Text = "RGhost";
            this.ChkPatchRghost.UseVisualStyleBackColor = true;
            // 
            // ChkPatchVocaroo
            // 
            this.ChkPatchVocaroo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkPatchVocaroo.AutoSize = true;
            this.ChkPatchVocaroo.Location = new System.Drawing.Point(483, 83);
            this.ChkPatchVocaroo.Name = "ChkPatchVocaroo";
            this.ChkPatchVocaroo.Size = new System.Drawing.Size(66, 17);
            this.ChkPatchVocaroo.TabIndex = 1;
            this.ChkPatchVocaroo.Text = "Vocaroo";
            this.ChkPatchVocaroo.UseVisualStyleBackColor = true;
            // 
            // BwDwn
            // 
            this.BwDwn.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwdl_DoWork);
            // 
            // PrgDwn
            // 
            this.PrgDwn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrgDwn.Enabled = false;
            this.PrgDwn.Location = new System.Drawing.Point(12, 503);
            this.PrgDwn.Name = "PrgDwn";
            this.PrgDwn.Size = new System.Drawing.Size(687, 38);
            this.PrgDwn.TabIndex = 13;
            // 
            // BtnBrowseOutput
            // 
            this.BtnBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrowseOutput.Location = new System.Drawing.Point(535, 196);
            this.BtnBrowseOutput.Name = "BtnBrowseOutput";
            this.BtnBrowseOutput.Size = new System.Drawing.Size(52, 23);
            this.BtnBrowseOutput.TabIndex = 15;
            this.BtnBrowseOutput.Text = "...";
            this.BtnBrowseOutput.UseVisualStyleBackColor = true;
            this.BtnBrowseOutput.Click += new System.EventHandler(this.btn_brs_Click);
            // 
            // GrpCounter
            // 
            this.GrpCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpCounter.Controls.Add(this.NudCounterEnd);
            this.GrpCounter.Controls.Add(this.NudCounterStart);
            this.GrpCounter.Controls.Add(this.LblCounterEnd);
            this.GrpCounter.Controls.Add(this.LblCounterStart);
            this.GrpCounter.Location = new System.Drawing.Point(115, 47);
            this.GrpCounter.Name = "GrpCounter";
            this.GrpCounter.Size = new System.Drawing.Size(336, 53);
            this.GrpCounter.TabIndex = 16;
            this.GrpCounter.TabStop = false;
            // 
            // NudCounterEnd
            // 
            this.NudCounterEnd.Location = new System.Drawing.Point(217, 19);
            this.NudCounterEnd.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NudCounterEnd.Name = "NudCounterEnd";
            this.NudCounterEnd.Size = new System.Drawing.Size(112, 20);
            this.NudCounterEnd.TabIndex = 5;
            // 
            // NudCounterStart
            // 
            this.NudCounterStart.Location = new System.Drawing.Point(52, 19);
            this.NudCounterStart.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NudCounterStart.Name = "NudCounterStart";
            this.NudCounterStart.Size = new System.Drawing.Size(112, 20);
            this.NudCounterStart.TabIndex = 4;
            // 
            // LblCounterEnd
            // 
            this.LblCounterEnd.AutoSize = true;
            this.LblCounterEnd.Location = new System.Drawing.Point(175, 23);
            this.LblCounterEnd.Name = "LblCounterEnd";
            this.LblCounterEnd.Size = new System.Drawing.Size(26, 13);
            this.LblCounterEnd.TabIndex = 2;
            this.LblCounterEnd.Text = "End";
            // 
            // LblCounterStart
            // 
            this.LblCounterStart.AutoSize = true;
            this.LblCounterStart.Location = new System.Drawing.Point(9, 23);
            this.LblCounterStart.Name = "LblCounterStart";
            this.LblCounterStart.Size = new System.Drawing.Size(29, 13);
            this.LblCounterStart.TabIndex = 1;
            this.LblCounterStart.Text = "Start";
            // 
            // GrpInput
            // 
            this.GrpInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpInput.Controls.Add(this.RDDwnAsRecList);
            this.GrpInput.Controls.Add(this.RdDwnAslist);
            this.GrpInput.Controls.Add(this.RdDwnPagesonly);
            this.GrpInput.Controls.Add(this.RdDwnMatches);
            this.GrpInput.Controls.Add(this.LblDwnAction);
            this.GrpInput.Controls.Add(this.ChkCounterEnabled);
            this.GrpInput.Controls.Add(this.GrpCounter);
            this.GrpInput.Controls.Add(this.LblDwnUrl);
            this.GrpInput.Controls.Add(this.TxtDwnUrl);
            this.GrpInput.Location = new System.Drawing.Point(13, 13);
            this.GrpInput.Name = "GrpInput";
            this.GrpInput.Size = new System.Drawing.Size(686, 133);
            this.GrpInput.TabIndex = 17;
            this.GrpInput.TabStop = false;
            this.GrpInput.Text = "Input";
            // 
            // RdDwnAslist
            // 
            this.RdDwnAslist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RdDwnAslist.AutoSize = true;
            this.RdDwnAslist.Location = new System.Drawing.Point(460, 87);
            this.RdDwnAslist.Name = "RdDwnAslist";
            this.RdDwnAslist.Size = new System.Drawing.Size(138, 17);
            this.RdDwnAslist.TabIndex = 20;
            this.RdDwnAslist.TabStop = true;
            this.RdDwnAslist.Text = "Use file as download list";
            this.RdDwnAslist.UseVisualStyleBackColor = true;
            // 
            // RdDwnPagesonly
            // 
            this.RdDwnPagesonly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RdDwnPagesonly.AutoSize = true;
            this.RdDwnPagesonly.Location = new System.Drawing.Point(460, 64);
            this.RdDwnPagesonly.Name = "RdDwnPagesonly";
            this.RdDwnPagesonly.Size = new System.Drawing.Size(194, 17);
            this.RdDwnPagesonly.TabIndex = 19;
            this.RdDwnPagesonly.TabStop = true;
            this.RdDwnPagesonly.Text = "Download pages using counter only";
            this.RdDwnPagesonly.UseVisualStyleBackColor = true;
            this.RdDwnPagesonly.CheckedChanged += new System.EventHandler(this.RdDwnPagesonly_CheckedChanged);
            // 
            // RdDwnMatches
            // 
            this.RdDwnMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RdDwnMatches.AutoSize = true;
            this.RdDwnMatches.Location = new System.Drawing.Point(460, 40);
            this.RdDwnMatches.Name = "RdDwnMatches";
            this.RdDwnMatches.Size = new System.Drawing.Size(166, 17);
            this.RdDwnMatches.TabIndex = 18;
            this.RdDwnMatches.TabStop = true;
            this.RdDwnMatches.Text = "Download all matches from url";
            this.RdDwnMatches.UseVisualStyleBackColor = true;
            // 
            // LblDwnAction
            // 
            this.LblDwnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDwnAction.AutoSize = true;
            this.LblDwnAction.Location = new System.Drawing.Point(457, 20);
            this.LblDwnAction.Name = "LblDwnAction";
            this.LblDwnAction.Size = new System.Drawing.Size(40, 13);
            this.LblDwnAction.TabIndex = 17;
            this.LblDwnAction.Text = "Action:";
            // 
            // ChkCounterEnabled
            // 
            this.ChkCounterEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkCounterEnabled.AutoSize = true;
            this.ChkCounterEnabled.Location = new System.Drawing.Point(20, 57);
            this.ChkCounterEnabled.Name = "ChkCounterEnabled";
            this.ChkCounterEnabled.Size = new System.Drawing.Size(84, 43);
            this.ChkCounterEnabled.TabIndex = 2;
            this.ChkCounterEnabled.Text = "Use counter\r\nreplaces {0}\r\nin url";
            this.ChkCounterEnabled.UseVisualStyleBackColor = true;
            this.ChkCounterEnabled.CheckedChanged += new System.EventHandler(this.ChkCounterEnabled_CheckedChanged);
            // 
            // LblDwnUrl
            // 
            this.LblDwnUrl.AutoSize = true;
            this.LblDwnUrl.Location = new System.Drawing.Point(14, 20);
            this.LblDwnUrl.Name = "LblDwnUrl";
            this.LblDwnUrl.Size = new System.Drawing.Size(23, 13);
            this.LblDwnUrl.TabIndex = 1;
            this.LblDwnUrl.Text = "Url:";
            // 
            // GrpDownload
            // 
            this.GrpDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpDownload.Controls.Add(this.btnRunExplorer);
            this.GrpDownload.Controls.Add(this.LblUrlPatches);
            this.GrpDownload.Controls.Add(this.ChkPatchRghost);
            this.GrpDownload.Controls.Add(this.ChkPatchVocaroo);
            this.GrpDownload.Controls.Add(this.BtnBrowseOutput);
            this.GrpDownload.Controls.Add(this.CmbRegex);
            this.GrpDownload.Controls.Add(this.LblRegex);
            this.GrpDownload.Controls.Add(this.GrpConflicts);
            this.GrpDownload.Controls.Add(this.NudRequsetSleep);
            this.GrpDownload.Controls.Add(this.TxtSavePath);
            this.GrpDownload.Controls.Add(this.ChkRequestSleep);
            this.GrpDownload.Controls.Add(this.LblSavePath);
            this.GrpDownload.Controls.Add(this.ChkRegexRelativePath);
            this.GrpDownload.Location = new System.Drawing.Point(13, 152);
            this.GrpDownload.Name = "GrpDownload";
            this.GrpDownload.Size = new System.Drawing.Size(686, 241);
            this.GrpDownload.TabIndex = 18;
            this.GrpDownload.TabStop = false;
            this.GrpDownload.Text = "Download";
            // 
            // btnRunExplorer
            // 
            this.btnRunExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunExplorer.Location = new System.Drawing.Point(602, 196);
            this.btnRunExplorer.Name = "btnRunExplorer";
            this.btnRunExplorer.Size = new System.Drawing.Size(66, 23);
            this.btnRunExplorer.TabIndex = 16;
            this.btnRunExplorer.Text = "Open";
            this.btnRunExplorer.UseVisualStyleBackColor = true;
            this.btnRunExplorer.Click += new System.EventHandler(this.btnRunExplorer_Click);
            // 
            // LblUrlPatches
            // 
            this.LblUrlPatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUrlPatches.AutoSize = true;
            this.LblUrlPatches.Location = new System.Drawing.Point(480, 28);
            this.LblUrlPatches.Name = "LblUrlPatches";
            this.LblUrlPatches.Size = new System.Drawing.Size(65, 13);
            this.LblUrlPatches.TabIndex = 3;
            this.LblUrlPatches.Text = "Url Patches:";
            // 
            // LblDwnStat
            // 
            this.LblDwnStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDwnStat.AutoSize = true;
            this.LblDwnStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDwnStat.Location = new System.Drawing.Point(332, 514);
            this.LblDwnStat.Name = "LblDwnStat";
            this.LblDwnStat.Size = new System.Drawing.Size(53, 13);
            this.LblDwnStat.TabIndex = 19;
            this.LblDwnStat.Text = "Pending";
            // 
            // RDDwnAsRecList
            // 
            this.RDDwnAsRecList.AutoSize = true;
            this.RDDwnAsRecList.Location = new System.Drawing.Point(460, 111);
            this.RDDwnAsRecList.Name = "RDDwnAsRecList";
            this.RDDwnAsRecList.Size = new System.Drawing.Size(210, 17);
            this.RDDwnAsRecList.TabIndex = 21;
            this.RDDwnAsRecList.TabStop = true;
            this.RDDwnAsRecList.Text = "Download matches from all pages in list";
            this.RDDwnAsRecList.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 565);
            this.Controls.Add(this.LblDwnStat);
            this.Controls.Add(this.GrpDownload);
            this.Controls.Add(this.GrpInput);
            this.Controls.Add(this.PrgDwn);
            this.Controls.Add(this.BtnDwnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Regex Downloader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.NudRequsetSleep)).EndInit();
            this.GrpConflicts.ResumeLayout(false);
            this.GrpConflicts.PerformLayout();
            this.GrpCounter.ResumeLayout(false);
            this.GrpCounter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCounterEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCounterStart)).EndInit();
            this.GrpInput.ResumeLayout(false);
            this.GrpInput.PerformLayout();
            this.GrpDownload.ResumeLayout(false);
            this.GrpDownload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDwnUrl;
        private System.Windows.Forms.Label LblRegex;
        private System.Windows.Forms.Label LblSavePath;
        private System.Windows.Forms.TextBox TxtSavePath;
        private System.Windows.Forms.Button BtnDwnRun;
        private System.Windows.Forms.CheckBox ChkRegexRelativePath;
        private System.Windows.Forms.CheckBox ChkRequestSleep;
        private System.Windows.Forms.NumericUpDown NudRequsetSleep;
        private System.Windows.Forms.GroupBox GrpConflicts;
        private System.Windows.Forms.RadioButton RdConflictSkip;
        private System.Windows.Forms.RadioButton RdConflictAutorename;
        private System.Windows.Forms.RadioButton RdConflictOverwrite;
        private System.Windows.Forms.ComboBox CmbRegex;
        private System.Windows.Forms.CheckBox ChkPatchRghost;
        private System.Windows.Forms.CheckBox ChkPatchVocaroo;
        private System.ComponentModel.BackgroundWorker BwDwn;
        private System.Windows.Forms.ProgressBar PrgDwn;
				private System.Windows.Forms.Button BtnBrowseOutput;
				private System.Windows.Forms.FolderBrowserDialog FbdBrs;
                private System.Windows.Forms.GroupBox GrpCounter;
				private System.Windows.Forms.NumericUpDown NudCounterEnd;
				private System.Windows.Forms.NumericUpDown NudCounterStart;
				private System.Windows.Forms.Label LblCounterEnd;
				private System.Windows.Forms.Label LblCounterStart;
				private System.Windows.Forms.GroupBox GrpInput;
				private System.Windows.Forms.RadioButton RdDwnAslist;
				private System.Windows.Forms.RadioButton RdDwnPagesonly;
				private System.Windows.Forms.RadioButton RdDwnMatches;
				private System.Windows.Forms.Label LblDwnAction;
				private System.Windows.Forms.CheckBox ChkCounterEnabled;
                private System.Windows.Forms.Label LblDwnUrl;
                private System.Windows.Forms.GroupBox GrpDownload;
                private System.Windows.Forms.Button btnRunExplorer;
                private System.Windows.Forms.Label LblUrlPatches;
                private System.Windows.Forms.Label LblDwnStat;
                private System.Windows.Forms.RadioButton RDDwnAsRecList;
    }
}

