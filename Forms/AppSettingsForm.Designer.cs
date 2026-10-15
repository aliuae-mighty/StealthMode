namespace StealthMode.Forms
{
    partial class AppSettingsForm
    {
        private System.Windows.Forms.GroupBox gbPlaybackOptions;
        private System.Windows.Forms.TableLayoutPanel tlpPlaybackOptions;
        public System.Windows.Forms.Label lbLoop;
        
        private System.Windows.Forms.TableLayoutPanel tlpSettings;
        private System.Windows.Forms.GroupBox gbSettingsFormParameters;
        private System.Windows.Forms.TableLayoutPanel tlpWindowTitle;
        public System.Windows.Forms.Label lbSettingsTitle;
        public System.Windows.Forms.TextBox tbSettingsFormTitle;
        private System.Windows.Forms.GroupBox gbSettingsEventParameters;
        private System.Windows.Forms.TableLayoutPanel tlpSettingsTable;
        private System.Windows.Forms.TableLayoutPanel tlpTurnOffAllEvents;
        public System.Windows.Forms.Label lbTurnOffAllEventsAt;
        public System.Windows.Forms.Label lbSettingsAlwaysOnTop;
        public System.Windows.Forms.Label lbSettingsMinimizeToTray;
        public System.Windows.Forms.Label lbSettingsMinimizeOnPlay;
        public System.Windows.Forms.Label lbSettingsShowStatusOverlay;
        private System.Windows.Forms.TableLayoutPanel tblSettingsSaveExit;
        private System.Windows.Forms.Button btnSettingsSave;
        public System.Windows.Forms.CheckBox cbSettingsMinimizeToTray;
        public System.Windows.Forms.CheckBox cbSettingsShowStatusOverlay;
        public System.Windows.Forms.CheckBox cbSettingsMinimizeOnPlay;
        public System.Windows.Forms.CheckBox checkTurnOffAllEvents;
        public System.Windows.Forms.CheckBox cbSettingsAlwaysOnTop;
        public System.Windows.Forms.ComboBox cbTurnOffAllEventsMinutes;
        public System.Windows.Forms.ComboBox cbTurnOffAllEventsHours;


        private void InitializeComponent()
        {
            this.tlpSettings = new System.Windows.Forms.TableLayoutPanel();
            this.gbPlaybackOptions = new System.Windows.Forms.GroupBox();
            this.tlpPlaybackOptions = new System.Windows.Forms.TableLayoutPanel();
            this.lbLoop = new System.Windows.Forms.Label();
            this.gbSettingsEventParameters = new System.Windows.Forms.GroupBox();
            this.tlpSettingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTurnOffAllEvents = new System.Windows.Forms.TableLayoutPanel();
            this.cbTurnOffAllEventsMinutes = new System.Windows.Forms.ComboBox();
            this.cbTurnOffAllEventsHours = new System.Windows.Forms.ComboBox();
            this.checkTurnOffAllEvents = new System.Windows.Forms.CheckBox();
            this.lbTurnOffAllEventsAt = new System.Windows.Forms.Label();
            this.cbSettingsAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.lbSettingsAlwaysOnTop = new System.Windows.Forms.Label();
            this.cbSettingsShowStatusOverlay = new System.Windows.Forms.CheckBox();
            this.cbSettingsMinimizeOnPlay = new System.Windows.Forms.CheckBox();
            this.lbSettingsMinimizeToTray = new System.Windows.Forms.Label();
            this.lbSettingsMinimizeOnPlay = new System.Windows.Forms.Label();
            this.lbSettingsShowStatusOverlay = new System.Windows.Forms.Label();
            this.cbSettingsMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.gbSettingsFormParameters = new System.Windows.Forms.GroupBox();
            this.tlpWindowTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lbSettingsTitle = new System.Windows.Forms.Label();
            this.tbSettingsFormTitle = new System.Windows.Forms.TextBox();
            this.tblSettingsSaveExit = new System.Windows.Forms.TableLayoutPanel();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.tlpSettings.SuspendLayout();
            this.gbPlaybackOptions.SuspendLayout();
            this.tlpPlaybackOptions.SuspendLayout();
            this.gbSettingsEventParameters.SuspendLayout();
            this.tlpSettingsTable.SuspendLayout();
            this.tlpTurnOffAllEvents.SuspendLayout();
            this.gbSettingsFormParameters.SuspendLayout();
            this.tlpWindowTitle.SuspendLayout();
            this.tblSettingsSaveExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpSettings
            // 
            this.tlpSettings.ColumnCount = 1;
            this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettings.Controls.Add(this.gbPlaybackOptions, 0, 0);
            this.tlpSettings.Controls.Add(this.gbSettingsEventParameters, 0, 1);
            this.tlpSettings.Controls.Add(this.gbSettingsFormParameters, 0, 2);
            this.tlpSettings.Controls.Add(this.tblSettingsSaveExit, 0, 3);
            this.tlpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSettings.Location = new System.Drawing.Point(0, 0);
            this.tlpSettings.Name = "tlpSettings";
            this.tlpSettings.RowCount = 4;
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.3871F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.06452F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.68472F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSettings.Size = new System.Drawing.Size(403, 348);
            this.tlpSettings.TabIndex = 3;
            // 
            // gbPlaybackOptions
            // 
            this.gbPlaybackOptions.Controls.Add(this.tlpPlaybackOptions);
            this.gbPlaybackOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPlaybackOptions.Location = new System.Drawing.Point(3, 3);
            this.gbPlaybackOptions.Name = "gbPlaybackOptions";
            this.gbPlaybackOptions.Size = new System.Drawing.Size(397, 51);
            this.gbPlaybackOptions.TabIndex = 8;
            this.gbPlaybackOptions.TabStop = false;
            this.gbPlaybackOptions.Text = "Playback Options";
            // 
            // tlpPlaybackOptions
            // 
            this.tlpPlaybackOptions.ColumnCount = 2;
            this.tlpPlaybackOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.34884F));
            this.tlpPlaybackOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.65116F));
            this.tlpPlaybackOptions.Controls.Add(this.lbLoop, 0, 0);
            this.tlpPlaybackOptions.Controls.Add(this.nudInterval, 1, 0);
            this.tlpPlaybackOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPlaybackOptions.Location = new System.Drawing.Point(3, 16);
            this.tlpPlaybackOptions.Name = "tlpPlaybackOptions";
            this.tlpPlaybackOptions.RowCount = 1;
            this.tlpPlaybackOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPlaybackOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPlaybackOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPlaybackOptions.Size = new System.Drawing.Size(391, 28);
            this.tlpPlaybackOptions.TabIndex = 1;
            // 
            // lbLoop
            // 
            this.lbLoop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoop.AutoSize = true;
            this.lbLoop.BackColor = System.Drawing.Color.Transparent;
            this.lbLoop.Location = new System.Drawing.Point(3, 7);
            this.lbLoop.Name = "lbLoop";
            this.lbLoop.Size = new System.Drawing.Size(132, 13);
            this.lbLoop.TabIndex = 1;
            this.lbLoop.Text = "Interval (seconds)";
            // 
            // gbSettingsEventParameters
            // 
            this.gbSettingsEventParameters.Controls.Add(this.tlpSettingsTable);
            this.gbSettingsEventParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSettingsEventParameters.Location = new System.Drawing.Point(3, 60);
            this.gbSettingsEventParameters.Name = "gbSettingsEventParameters";
            this.gbSettingsEventParameters.Size = new System.Drawing.Size(397, 174);
            this.gbSettingsEventParameters.TabIndex = 2;
            this.gbSettingsEventParameters.TabStop = false;
            this.gbSettingsEventParameters.Text = "Behavior Options";
            // 
            // tlpSettingsTable
            // 
            this.tlpSettingsTable.ColumnCount = 2;
            this.tlpSettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.58139F));
            this.tlpSettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.4186F));
            this.tlpSettingsTable.Controls.Add(this.tlpTurnOffAllEvents, 1, 4);
            this.tlpSettingsTable.Controls.Add(this.lbTurnOffAllEventsAt, 0, 4);
            this.tlpSettingsTable.Controls.Add(this.cbSettingsAlwaysOnTop, 1, 3);
            this.tlpSettingsTable.Controls.Add(this.lbSettingsAlwaysOnTop, 0, 3);
            this.tlpSettingsTable.Controls.Add(this.cbSettingsShowStatusOverlay, 1, 2);
            this.tlpSettingsTable.Controls.Add(this.cbSettingsMinimizeOnPlay, 1, 1);
            this.tlpSettingsTable.Controls.Add(this.lbSettingsMinimizeToTray, 0, 0);
            this.tlpSettingsTable.Controls.Add(this.lbSettingsMinimizeOnPlay, 0, 1);
            this.tlpSettingsTable.Controls.Add(this.lbSettingsShowStatusOverlay, 0, 2);
            this.tlpSettingsTable.Controls.Add(this.cbSettingsMinimizeToTray, 1, 0);
            this.tlpSettingsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpSettingsTable.Location = new System.Drawing.Point(3, 16);
            this.tlpSettingsTable.Name = "tlpSettingsTable";
            this.tlpSettingsTable.RowCount = 5;
            this.tlpSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSettingsTable.Size = new System.Drawing.Size(391, 150);
            this.tlpSettingsTable.TabIndex = 1;
            // 
            // tlpTurnOffAllEvents
            // 
            this.tlpTurnOffAllEvents.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpTurnOffAllEvents.ColumnCount = 3;
            this.tlpTurnOffAllEvents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.13043F));
            this.tlpTurnOffAllEvents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.02174F));
            this.tlpTurnOffAllEvents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.84783F));
            this.tlpTurnOffAllEvents.Controls.Add(this.cbTurnOffAllEventsMinutes, 0, 0);
            this.tlpTurnOffAllEvents.Controls.Add(this.cbTurnOffAllEventsHours, 0, 0);
            this.tlpTurnOffAllEvents.Controls.Add(this.checkTurnOffAllEvents, 0, 0);
            this.tlpTurnOffAllEvents.Location = new System.Drawing.Point(139, 120);
            this.tlpTurnOffAllEvents.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTurnOffAllEvents.Name = "tlpTurnOffAllEvents";
            this.tlpTurnOffAllEvents.RowCount = 1;
            this.tlpTurnOffAllEvents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTurnOffAllEvents.Size = new System.Drawing.Size(138, 30);
            this.tlpTurnOffAllEvents.TabIndex = 2;
            // 
            // cbTurnOffAllEventsMinutes
            // 
            this.cbTurnOffAllEventsMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTurnOffAllEventsMinutes.FormattingEnabled = true;
            this.cbTurnOffAllEventsMinutes.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cbTurnOffAllEventsMinutes.Location = new System.Drawing.Point(81, 4);
            this.cbTurnOffAllEventsMinutes.Margin = new System.Windows.Forms.Padding(2);
            this.cbTurnOffAllEventsMinutes.Name = "cbTurnOffAllEventsMinutes";
            this.cbTurnOffAllEventsMinutes.Size = new System.Drawing.Size(55, 21);
            this.cbTurnOffAllEventsMinutes.TabIndex = 16;
            // 
            // cbTurnOffAllEventsHours
            // 
            this.cbTurnOffAllEventsHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTurnOffAllEventsHours.FormattingEnabled = true;
            this.cbTurnOffAllEventsHours.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbTurnOffAllEventsHours.Location = new System.Drawing.Point(21, 4);
            this.cbTurnOffAllEventsHours.Margin = new System.Windows.Forms.Padding(2);
            this.cbTurnOffAllEventsHours.Name = "cbTurnOffAllEventsHours";
            this.cbTurnOffAllEventsHours.Size = new System.Drawing.Size(56, 21);
            this.cbTurnOffAllEventsHours.TabIndex = 15;
            // 
            // checkTurnOffAllEvents
            // 
            this.checkTurnOffAllEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkTurnOffAllEvents.AutoSize = true;
            this.checkTurnOffAllEvents.Location = new System.Drawing.Point(3, 8);
            this.checkTurnOffAllEvents.Name = "checkTurnOffAllEvents";
            this.checkTurnOffAllEvents.Size = new System.Drawing.Size(13, 14);
            this.checkTurnOffAllEvents.TabIndex = 14;
            this.checkTurnOffAllEvents.UseVisualStyleBackColor = true;
            // 
            // lbTurnOffAllEventsAt
            // 
            this.lbTurnOffAllEventsAt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTurnOffAllEventsAt.AutoSize = true;
            this.lbTurnOffAllEventsAt.BackColor = System.Drawing.Color.Transparent;
            this.lbTurnOffAllEventsAt.Location = new System.Drawing.Point(3, 128);
            this.lbTurnOffAllEventsAt.Name = "lbTurnOffAllEventsAt";
            this.lbTurnOffAllEventsAt.Size = new System.Drawing.Size(133, 13);
            this.lbTurnOffAllEventsAt.TabIndex = 9;
            this.lbTurnOffAllEventsAt.Text = "Turn Off All Events at";
            // 
            // cbSettingsAlwaysOnTop
            // 
            this.cbSettingsAlwaysOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSettingsAlwaysOnTop.AutoSize = true;
            this.cbSettingsAlwaysOnTop.Location = new System.Drawing.Point(142, 98);
            this.cbSettingsAlwaysOnTop.Name = "cbSettingsAlwaysOnTop";
            this.cbSettingsAlwaysOnTop.Size = new System.Drawing.Size(246, 14);
            this.cbSettingsAlwaysOnTop.TabIndex = 8;
            this.cbSettingsAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // lbSettingsAlwaysOnTop
            // 
            this.lbSettingsAlwaysOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSettingsAlwaysOnTop.AutoSize = true;
            this.lbSettingsAlwaysOnTop.BackColor = System.Drawing.Color.Transparent;
            this.lbSettingsAlwaysOnTop.Location = new System.Drawing.Point(3, 98);
            this.lbSettingsAlwaysOnTop.Name = "lbSettingsAlwaysOnTop";
            this.lbSettingsAlwaysOnTop.Size = new System.Drawing.Size(133, 13);
            this.lbSettingsAlwaysOnTop.TabIndex = 7;
            this.lbSettingsAlwaysOnTop.Text = "Always on Top";
            // 
            // cbSettingsShowStatusOverlay
            // 
            this.cbSettingsShowStatusOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSettingsShowStatusOverlay.AutoSize = true;
            this.cbSettingsShowStatusOverlay.Checked = true;
            this.cbSettingsShowStatusOverlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSettingsShowStatusOverlay.Location = new System.Drawing.Point(142, 68);
            this.cbSettingsShowStatusOverlay.Name = "cbSettingsShowStatusOverlay";
            this.cbSettingsShowStatusOverlay.Size = new System.Drawing.Size(246, 14);
            this.cbSettingsShowStatusOverlay.TabIndex = 6;
            this.cbSettingsShowStatusOverlay.UseVisualStyleBackColor = true;
            // 
            // cbSettingsMinimizeOnPlay
            // 
            this.cbSettingsMinimizeOnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSettingsMinimizeOnPlay.AutoSize = true;
            this.cbSettingsMinimizeOnPlay.Checked = true;
            this.cbSettingsMinimizeOnPlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSettingsMinimizeOnPlay.Location = new System.Drawing.Point(142, 38);
            this.cbSettingsMinimizeOnPlay.Name = "cbSettingsMinimizeOnPlay";
            this.cbSettingsMinimizeOnPlay.Size = new System.Drawing.Size(246, 14);
            this.cbSettingsMinimizeOnPlay.TabIndex = 5;
            this.cbSettingsMinimizeOnPlay.UseVisualStyleBackColor = true;
            // 
            // lbSettingsMinimizeToTray
            // 
            this.lbSettingsMinimizeToTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSettingsMinimizeToTray.AutoSize = true;
            this.lbSettingsMinimizeToTray.BackColor = System.Drawing.Color.Transparent;
            this.lbSettingsMinimizeToTray.Location = new System.Drawing.Point(3, 8);
            this.lbSettingsMinimizeToTray.Name = "lbSettingsMinimizeToTray";
            this.lbSettingsMinimizeToTray.Size = new System.Drawing.Size(133, 13);
            this.lbSettingsMinimizeToTray.TabIndex = 1;
            this.lbSettingsMinimizeToTray.Text = "Minimize to System Tray";
            // 
            // lbSettingsMinimizeOnPlay
            // 
            this.lbSettingsMinimizeOnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSettingsMinimizeOnPlay.AutoSize = true;
            this.lbSettingsMinimizeOnPlay.BackColor = System.Drawing.Color.Transparent;
            this.lbSettingsMinimizeOnPlay.Location = new System.Drawing.Point(3, 38);
            this.lbSettingsMinimizeOnPlay.Name = "lbSettingsMinimizeOnPlay";
            this.lbSettingsMinimizeOnPlay.Size = new System.Drawing.Size(133, 13);
            this.lbSettingsMinimizeOnPlay.TabIndex = 2;
            this.lbSettingsMinimizeOnPlay.Text = "Minimize on Play / Record";
            // 
            // lbSettingsShowStatusOverlay
            // 
            this.lbSettingsShowStatusOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSettingsShowStatusOverlay.AutoSize = true;
            this.lbSettingsShowStatusOverlay.BackColor = System.Drawing.Color.Transparent;
            this.lbSettingsShowStatusOverlay.Location = new System.Drawing.Point(3, 68);
            this.lbSettingsShowStatusOverlay.Name = "lbSettingsShowStatusOverlay";
            this.lbSettingsShowStatusOverlay.Size = new System.Drawing.Size(133, 13);
            this.lbSettingsShowStatusOverlay.TabIndex = 3;
            this.lbSettingsShowStatusOverlay.Text = "Show Status Overlay";
            // 
            // cbSettingsMinimizeToTray
            // 
            this.cbSettingsMinimizeToTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSettingsMinimizeToTray.AutoSize = true;
            this.cbSettingsMinimizeToTray.Checked = true;
            this.cbSettingsMinimizeToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSettingsMinimizeToTray.Location = new System.Drawing.Point(142, 8);
            this.cbSettingsMinimizeToTray.Name = "cbSettingsMinimizeToTray";
            this.cbSettingsMinimizeToTray.Size = new System.Drawing.Size(246, 14);
            this.cbSettingsMinimizeToTray.TabIndex = 4;
            this.cbSettingsMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // gbSettingsFormParameters
            // 
            this.gbSettingsFormParameters.Controls.Add(this.tlpWindowTitle);
            this.gbSettingsFormParameters.Location = new System.Drawing.Point(3, 240);
            this.gbSettingsFormParameters.Name = "gbSettingsFormParameters";
            this.gbSettingsFormParameters.Size = new System.Drawing.Size(397, 62);
            this.gbSettingsFormParameters.TabIndex = 3;
            this.gbSettingsFormParameters.TabStop = false;
            this.gbSettingsFormParameters.Text = "Window && Interface";
            // 
            // tlpWindowTitle
            // 
            this.tlpWindowTitle.ColumnCount = 2;
            this.tlpWindowTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.88372F));
            this.tlpWindowTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.11628F));
            this.tlpWindowTitle.Controls.Add(this.lbSettingsTitle, 0, 0);
            this.tlpWindowTitle.Controls.Add(this.tbSettingsFormTitle, 1, 0);
            this.tlpWindowTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpWindowTitle.Location = new System.Drawing.Point(3, 16);
            this.tlpWindowTitle.Name = "tlpWindowTitle";
            this.tlpWindowTitle.RowCount = 1;
            this.tlpWindowTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpWindowTitle.Size = new System.Drawing.Size(391, 34);
            this.tlpWindowTitle.TabIndex = 1;
            // 
            // lbSettingsTitle
            // 
            this.lbSettingsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSettingsTitle.AutoSize = true;
            this.lbSettingsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbSettingsTitle.Location = new System.Drawing.Point(3, 10);
            this.lbSettingsTitle.Name = "lbSettingsTitle";
            this.lbSettingsTitle.Size = new System.Drawing.Size(130, 13);
            this.lbSettingsTitle.TabIndex = 1;
            this.lbSettingsTitle.Text = "Window Title";
            // 
            // tbSettingsFormTitle
            // 
            this.tbSettingsFormTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbSettingsFormTitle.Location = new System.Drawing.Point(139, 7);
            this.tbSettingsFormTitle.Name = "tbSettingsFormTitle";
            this.tbSettingsFormTitle.Size = new System.Drawing.Size(249, 20);
            this.tbSettingsFormTitle.TabIndex = 2;
            this.tbSettingsFormTitle.Text = "Stealth";
            // 
            // tblSettingsSaveExit
            // 
            this.tblSettingsSaveExit.ColumnCount = 2;
            this.tblSettingsSaveExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.35593F));
            this.tblSettingsSaveExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.64407F));
            this.tblSettingsSaveExit.Controls.Add(this.btnSettingsSave, 1, 0);
            this.tblSettingsSaveExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSettingsSaveExit.Location = new System.Drawing.Point(2, 312);
            this.tblSettingsSaveExit.Margin = new System.Windows.Forms.Padding(2);
            this.tblSettingsSaveExit.Name = "tblSettingsSaveExit";
            this.tblSettingsSaveExit.RowCount = 1;
            this.tblSettingsSaveExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSettingsSaveExit.Size = new System.Drawing.Size(399, 34);
            this.tblSettingsSaveExit.TabIndex = 5;
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettingsSave.Location = new System.Drawing.Point(326, 2);
            this.btnSettingsSave.Margin = new System.Windows.Forms.Padding(2, 2, 5, 2);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(68, 30);
            this.btnSettingsSave.TabIndex = 4;
            this.btnSettingsSave.Text = "Save";
            this.btnSettingsSave.UseVisualStyleBackColor = true;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // nudInterval
            // 
            this.nudInterval.Location = new System.Drawing.Point(141, 3);
            this.nudInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudInterval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(40, 20);
            this.nudInterval.TabIndex = 2;
            this.nudInterval.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // AppSettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(403, 348);
            this.Controls.Add(this.tlpSettings);
            this.Name = "AppSettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.AppSettingsForm_Load);
            this.tlpSettings.ResumeLayout(false);
            this.gbPlaybackOptions.ResumeLayout(false);
            this.tlpPlaybackOptions.ResumeLayout(false);
            this.tlpPlaybackOptions.PerformLayout();
            this.gbSettingsEventParameters.ResumeLayout(false);
            this.tlpSettingsTable.ResumeLayout(false);
            this.tlpSettingsTable.PerformLayout();
            this.tlpTurnOffAllEvents.ResumeLayout(false);
            this.tlpTurnOffAllEvents.PerformLayout();
            this.gbSettingsFormParameters.ResumeLayout(false);
            this.tlpWindowTitle.ResumeLayout(false);
            this.tlpWindowTitle.PerformLayout();
            this.tblSettingsSaveExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            this.ResumeLayout(false);

        }

        public System.Windows.Forms.NumericUpDown nudInterval;
    }
}