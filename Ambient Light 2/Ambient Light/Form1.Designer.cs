namespace Ambient_Light
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBoxstartup = new System.Windows.Forms.CheckBox();
            this.BtnRed = new System.Windows.Forms.Button();
            this.BtnGreen = new System.Windows.Forms.Button();
            this.BtnBlue = new System.Windows.Forms.Button();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.BtnWhite = new System.Windows.Forms.Button();
            this.numericUpDownWhite = new System.Windows.Forms.NumericUpDown();
            this.BtnSingleLive = new System.Windows.Forms.Button();
            this.BtnLiveOnOff = new System.Windows.Forms.Button();
            this.groupBoxStartup = new System.Windows.Forms.GroupBox();
            this.groupBoxStartupmode = new System.Windows.Forms.GroupBox();
            this.radioButtonColorFlow = new System.Windows.Forms.RadioButton();
            this.radioButtonLive = new System.Windows.Forms.RadioButton();
            this.groupBoxStartupColor = new System.Windows.Forms.GroupBox();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.BtnCustom = new System.Windows.Forms.Button();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonWhite = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonColor = new System.Windows.Forms.RadioButton();
            this.radioButtonOff = new System.Windows.Forms.RadioButton();
            this.radioButtonMode = new System.Windows.Forms.RadioButton();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.BtnColorFlow = new System.Windows.Forms.Button();
            this.numericUpDownFadeSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLedOff = new System.Windows.Forms.Button();
            this.timerAmbiRefresh = new System.Windows.Forms.Timer(this.components);
            this.BtnCustomColor = new System.Windows.Forms.Button();
            this.backgroundWorkerLive = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerColorFlow = new System.ComponentModel.BackgroundWorker();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWhite)).BeginInit();
            this.groupBoxStartup.SuspendLayout();
            this.groupBoxStartupmode.SuspendLayout();
            this.groupBoxStartupColor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFadeSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxstartup
            // 
            this.checkBoxstartup.AutoSize = true;
            this.checkBoxstartup.Location = new System.Drawing.Point(9, 19);
            this.checkBoxstartup.Name = "checkBoxstartup";
            this.checkBoxstartup.Size = new System.Drawing.Size(98, 17);
            this.checkBoxstartup.TabIndex = 0;
            this.checkBoxstartup.Text = "Start on startup";
            this.checkBoxstartup.UseVisualStyleBackColor = true;
            // 
            // BtnRed
            // 
            this.BtnRed.BackColor = System.Drawing.Color.Red;
            this.BtnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRed.Location = new System.Drawing.Point(12, 12);
            this.BtnRed.Name = "BtnRed";
            this.BtnRed.Size = new System.Drawing.Size(75, 23);
            this.BtnRed.TabIndex = 2;
            this.BtnRed.UseVisualStyleBackColor = false;
            this.BtnRed.Click += new System.EventHandler(this.BtnRed_Click);
            // 
            // BtnGreen
            // 
            this.BtnGreen.BackColor = System.Drawing.Color.Lime;
            this.BtnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGreen.Location = new System.Drawing.Point(12, 41);
            this.BtnGreen.Name = "BtnGreen";
            this.BtnGreen.Size = new System.Drawing.Size(75, 23);
            this.BtnGreen.TabIndex = 3;
            this.BtnGreen.UseVisualStyleBackColor = false;
            this.BtnGreen.Click += new System.EventHandler(this.BtnGreen_Click);
            // 
            // BtnBlue
            // 
            this.BtnBlue.BackColor = System.Drawing.Color.Blue;
            this.BtnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBlue.Location = new System.Drawing.Point(12, 70);
            this.BtnBlue.Name = "BtnBlue";
            this.BtnBlue.Size = new System.Drawing.Size(75, 23);
            this.BtnBlue.TabIndex = 4;
            this.BtnBlue.UseVisualStyleBackColor = false;
            this.BtnBlue.Click += new System.EventHandler(this.BtnBlue_Click);
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(93, 15);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownRed.TabIndex = 5;
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.numericUpDownRed_ValueChanged);
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(93, 44);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownGreen.TabIndex = 6;
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.numericUpDownGreen_ValueChanged);
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(93, 73);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownBlue.TabIndex = 7;
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.numericUpDownBlue_ValueChanged);
            // 
            // BtnWhite
            // 
            this.BtnWhite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWhite.Location = new System.Drawing.Point(12, 99);
            this.BtnWhite.Name = "BtnWhite";
            this.BtnWhite.Size = new System.Drawing.Size(75, 23);
            this.BtnWhite.TabIndex = 8;
            this.BtnWhite.UseVisualStyleBackColor = false;
            this.BtnWhite.Click += new System.EventHandler(this.BtnWhite_Click);
            // 
            // numericUpDownWhite
            // 
            this.numericUpDownWhite.Location = new System.Drawing.Point(93, 102);
            this.numericUpDownWhite.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownWhite.Name = "numericUpDownWhite";
            this.numericUpDownWhite.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownWhite.TabIndex = 9;
            this.numericUpDownWhite.ValueChanged += new System.EventHandler(this.numericUpDownWhite_ValueChanged);
            // 
            // BtnSingleLive
            // 
            this.BtnSingleLive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSingleLive.Location = new System.Drawing.Point(196, 12);
            this.BtnSingleLive.Name = "BtnSingleLive";
            this.BtnSingleLive.Size = new System.Drawing.Size(76, 23);
            this.BtnSingleLive.TabIndex = 10;
            this.BtnSingleLive.Text = "Single Live";
            this.BtnSingleLive.UseVisualStyleBackColor = true;
            this.BtnSingleLive.Click += new System.EventHandler(this.BtnSingleLive_Click);
            // 
            // BtnLiveOnOff
            // 
            this.BtnLiveOnOff.Location = new System.Drawing.Point(6, 19);
            this.BtnLiveOnOff.Name = "BtnLiveOnOff";
            this.BtnLiveOnOff.Size = new System.Drawing.Size(89, 23);
            this.BtnLiveOnOff.TabIndex = 11;
            this.BtnLiveOnOff.Text = "Live On / Off";
            this.BtnLiveOnOff.UseVisualStyleBackColor = true;
            this.BtnLiveOnOff.Click += new System.EventHandler(this.BtnLiveOnOff_Click);
            // 
            // groupBoxStartup
            // 
            this.groupBoxStartup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStartup.Controls.Add(this.groupBoxStartupmode);
            this.groupBoxStartup.Controls.Add(this.groupBoxStartupColor);
            this.groupBoxStartup.Controls.Add(this.panel1);
            this.groupBoxStartup.Controls.Add(this.checkBoxstartup);
            this.groupBoxStartup.Location = new System.Drawing.Point(11, 243);
            this.groupBoxStartup.Name = "groupBoxStartup";
            this.groupBoxStartup.Size = new System.Drawing.Size(260, 174);
            this.groupBoxStartup.TabIndex = 12;
            this.groupBoxStartup.TabStop = false;
            this.groupBoxStartup.Text = "Startup";
            // 
            // groupBoxStartupmode
            // 
            this.groupBoxStartupmode.Controls.Add(this.radioButtonColorFlow);
            this.groupBoxStartupmode.Controls.Add(this.radioButtonLive);
            this.groupBoxStartupmode.Location = new System.Drawing.Point(152, 74);
            this.groupBoxStartupmode.Name = "groupBoxStartupmode";
            this.groupBoxStartupmode.Size = new System.Drawing.Size(102, 94);
            this.groupBoxStartupmode.TabIndex = 17;
            this.groupBoxStartupmode.TabStop = false;
            this.groupBoxStartupmode.Text = "Mode";
            // 
            // radioButtonColorFlow
            // 
            this.radioButtonColorFlow.AutoSize = true;
            this.radioButtonColorFlow.Location = new System.Drawing.Point(6, 42);
            this.radioButtonColorFlow.Name = "radioButtonColorFlow";
            this.radioButtonColorFlow.Size = new System.Drawing.Size(74, 17);
            this.radioButtonColorFlow.TabIndex = 0;
            this.radioButtonColorFlow.TabStop = true;
            this.radioButtonColorFlow.Text = "Color Flow";
            this.radioButtonColorFlow.UseVisualStyleBackColor = true;
            // 
            // radioButtonLive
            // 
            this.radioButtonLive.AutoSize = true;
            this.radioButtonLive.Location = new System.Drawing.Point(6, 19);
            this.radioButtonLive.Name = "radioButtonLive";
            this.radioButtonLive.Size = new System.Drawing.Size(45, 17);
            this.radioButtonLive.TabIndex = 0;
            this.radioButtonLive.TabStop = true;
            this.radioButtonLive.Text = "Live";
            this.radioButtonLive.UseVisualStyleBackColor = true;
            // 
            // groupBoxStartupColor
            // 
            this.groupBoxStartupColor.Controls.Add(this.radioButtonRed);
            this.groupBoxStartupColor.Controls.Add(this.radioButtonGreen);
            this.groupBoxStartupColor.Controls.Add(this.BtnCustom);
            this.groupBoxStartupColor.Controls.Add(this.radioButtonBlue);
            this.groupBoxStartupColor.Controls.Add(this.radioButtonCustom);
            this.groupBoxStartupColor.Controls.Add(this.radioButtonWhite);
            this.groupBoxStartupColor.Location = new System.Drawing.Point(7, 74);
            this.groupBoxStartupColor.Name = "groupBoxStartupColor";
            this.groupBoxStartupColor.Size = new System.Drawing.Size(139, 94);
            this.groupBoxStartupColor.TabIndex = 16;
            this.groupBoxStartupColor.TabStop = false;
            this.groupBoxStartupColor.Text = "Color";
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(6, 19);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(45, 17);
            this.radioButtonRed.TabIndex = 2;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(6, 41);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(54, 17);
            this.radioButtonGreen.TabIndex = 4;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // BtnCustom
            // 
            this.BtnCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCustom.Location = new System.Drawing.Point(56, 64);
            this.BtnCustom.Name = "BtnCustom";
            this.BtnCustom.Size = new System.Drawing.Size(69, 23);
            this.BtnCustom.TabIndex = 13;
            this.BtnCustom.Text = "Custom";
            this.BtnCustom.UseVisualStyleBackColor = true;
            this.BtnCustom.Click += new System.EventHandler(this.BtnCustom_Click);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(5, 64);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBlue.TabIndex = 3;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Location = new System.Drawing.Point(65, 42);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(60, 17);
            this.radioButtonCustom.TabIndex = 6;
            this.radioButtonCustom.TabStop = true;
            this.radioButtonCustom.Text = "Custom";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            // 
            // radioButtonWhite
            // 
            this.radioButtonWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonWhite.AutoSize = true;
            this.radioButtonWhite.Location = new System.Drawing.Point(65, 19);
            this.radioButtonWhite.Name = "radioButtonWhite";
            this.radioButtonWhite.Size = new System.Drawing.Size(53, 17);
            this.radioButtonWhite.TabIndex = 5;
            this.radioButtonWhite.TabStop = true;
            this.radioButtonWhite.Text = "White";
            this.radioButtonWhite.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonColor);
            this.panel1.Controls.Add(this.radioButtonOff);
            this.panel1.Controls.Add(this.radioButtonMode);
            this.panel1.Location = new System.Drawing.Point(6, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 25);
            this.panel1.TabIndex = 15;
            // 
            // radioButtonColor
            // 
            this.radioButtonColor.AutoSize = true;
            this.radioButtonColor.Location = new System.Drawing.Point(3, 3);
            this.radioButtonColor.Name = "radioButtonColor";
            this.radioButtonColor.Size = new System.Drawing.Size(71, 17);
            this.radioButtonColor.TabIndex = 14;
            this.radioButtonColor.TabStop = true;
            this.radioButtonColor.Text = "Use Color";
            this.radioButtonColor.UseVisualStyleBackColor = true;
            // 
            // radioButtonOff
            // 
            this.radioButtonOff.AutoSize = true;
            this.radioButtonOff.Location = new System.Drawing.Point(101, 3);
            this.radioButtonOff.Name = "radioButtonOff";
            this.radioButtonOff.Size = new System.Drawing.Size(39, 17);
            this.radioButtonOff.TabIndex = 14;
            this.radioButtonOff.TabStop = true;
            this.radioButtonOff.Text = "Off";
            this.radioButtonOff.UseVisualStyleBackColor = true;
            // 
            // radioButtonMode
            // 
            this.radioButtonMode.AutoSize = true;
            this.radioButtonMode.Location = new System.Drawing.Point(162, 3);
            this.radioButtonMode.Name = "radioButtonMode";
            this.radioButtonMode.Size = new System.Drawing.Size(74, 17);
            this.radioButtonMode.TabIndex = 14;
            this.radioButtonMode.TabStop = true;
            this.radioButtonMode.Text = "Use Mode";
            this.radioButtonMode.UseVisualStyleBackColor = true;
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMode.Controls.Add(this.BtnColorFlow);
            this.groupBoxMode.Controls.Add(this.BtnLiveOnOff);
            this.groupBoxMode.Location = new System.Drawing.Point(12, 128);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(259, 109);
            this.groupBoxMode.TabIndex = 13;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // BtnColorFlow
            // 
            this.BtnColorFlow.Location = new System.Drawing.Point(6, 48);
            this.BtnColorFlow.Name = "BtnColorFlow";
            this.BtnColorFlow.Size = new System.Drawing.Size(89, 23);
            this.BtnColorFlow.TabIndex = 11;
            this.BtnColorFlow.Text = "Color Flow";
            this.BtnColorFlow.UseVisualStyleBackColor = true;
            this.BtnColorFlow.Click += new System.EventHandler(this.BtnColorFlow_Click);
            // 
            // numericUpDownFadeSpeed
            // 
            this.numericUpDownFadeSpeed.Location = new System.Drawing.Point(232, 102);
            this.numericUpDownFadeSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFadeSpeed.Name = "numericUpDownFadeSpeed";
            this.numericUpDownFadeSpeed.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownFadeSpeed.TabIndex = 13;
            this.numericUpDownFadeSpeed.ValueChanged += new System.EventHandler(this.numericUpDownFadeSpeed_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fade Speed:";
            // 
            // BtnLedOff
            // 
            this.BtnLedOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLedOff.Location = new System.Drawing.Point(196, 41);
            this.BtnLedOff.Name = "BtnLedOff";
            this.BtnLedOff.Size = new System.Drawing.Size(75, 23);
            this.BtnLedOff.TabIndex = 14;
            this.BtnLedOff.Text = "LEDs Off";
            this.BtnLedOff.UseVisualStyleBackColor = true;
            this.BtnLedOff.Click += new System.EventHandler(this.BtnLedOff_Click);
            // 
            // timerAmbiRefresh
            // 
            this.timerAmbiRefresh.Interval = 10;
            this.timerAmbiRefresh.Tick += new System.EventHandler(this.timerAmbiRefresh_Tick);
            // 
            // BtnCustomColor
            // 
            this.BtnCustomColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCustomColor.Location = new System.Drawing.Point(196, 70);
            this.BtnCustomColor.Name = "BtnCustomColor";
            this.BtnCustomColor.Size = new System.Drawing.Size(75, 23);
            this.BtnCustomColor.TabIndex = 15;
            this.BtnCustomColor.Text = "Custom";
            this.BtnCustomColor.UseVisualStyleBackColor = true;
            this.BtnCustomColor.Click += new System.EventHandler(this.BtnCustomColor_Click);
            // 
            // backgroundWorkerLive
            // 
            this.backgroundWorkerLive.WorkerSupportsCancellation = true;
            this.backgroundWorkerLive.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLive_DoWork);
            // 
            // backgroundWorkerColorFlow
            // 
            this.backgroundWorkerColorFlow.WorkerSupportsCancellation = true;
            this.backgroundWorkerColorFlow.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerColorFlow_DoWork);
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTray.Icon")));
            this.notifyIconTray.Text = "Tray";
            this.notifyIconTray.Click += new System.EventHandler(this.notifyIconTray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 429);
            this.Controls.Add(this.numericUpDownFadeSpeed);
            this.Controls.Add(this.BtnCustomColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLedOff);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.groupBoxStartup);
            this.Controls.Add(this.BtnSingleLive);
            this.Controls.Add(this.numericUpDownWhite);
            this.Controls.Add(this.BtnWhite);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.BtnBlue);
            this.Controls.Add(this.BtnGreen);
            this.Controls.Add(this.BtnRed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 468);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ambi Light";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWhite)).EndInit();
            this.groupBoxStartup.ResumeLayout(false);
            this.groupBoxStartup.PerformLayout();
            this.groupBoxStartupmode.ResumeLayout(false);
            this.groupBoxStartupmode.PerformLayout();
            this.groupBoxStartupColor.ResumeLayout(false);
            this.groupBoxStartupColor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFadeSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxstartup;
        private System.Windows.Forms.Button BtnRed;
        private System.Windows.Forms.Button BtnGreen;
        private System.Windows.Forms.Button BtnBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.Windows.Forms.Button BtnWhite;
        private System.Windows.Forms.NumericUpDown numericUpDownWhite;
        private System.Windows.Forms.Button BtnSingleLive;
        private System.Windows.Forms.Button BtnLiveOnOff;
        private System.Windows.Forms.GroupBox groupBoxStartup;
        private System.Windows.Forms.Button BtnCustom;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.RadioButton radioButtonWhite;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.Button BtnLedOff;
        private System.Windows.Forms.RadioButton radioButtonColor;
        private System.Windows.Forms.RadioButton radioButtonMode;
        private System.Windows.Forms.Timer timerAmbiRefresh;
        private System.Windows.Forms.NumericUpDown numericUpDownFadeSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCustomColor;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLive;
        private System.Windows.Forms.Button BtnColorFlow;
        private System.ComponentModel.BackgroundWorker backgroundWorkerColorFlow;
        private System.Windows.Forms.GroupBox groupBoxStartupmode;
        private System.Windows.Forms.RadioButton radioButtonColorFlow;
        private System.Windows.Forms.RadioButton radioButtonLive;
        private System.Windows.Forms.GroupBox groupBoxStartupColor;
        private System.Windows.Forms.RadioButton radioButtonOff;
        private System.Windows.Forms.NotifyIcon notifyIconTray;
    }
}

