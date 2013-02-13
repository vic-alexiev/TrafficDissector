namespace TrafficDissector.UI
{
    partial class PortScannerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonClose = new System.Windows.Forms.Button();
            this.chooseDeviceUserControl = new TrafficDissector.UI.ChooseDeviceUserControl();
            this.progressBarScanProgress = new System.Windows.Forms.ProgressBar();
            this.buttonStartScan = new System.Windows.Forms.Button();
            this.labelScannerType = new System.Windows.Forms.Label();
            this.comboBoxScannerType = new System.Windows.Forms.ComboBox();
            this.labelTargetHosts = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.textBoxFromPort = new System.Windows.Forms.TextBox();
            this.textBoxToPort = new System.Windows.Forms.TextBox();
            this.labelPorts = new System.Windows.Forms.Label();
            this.labelColon = new System.Windows.Forms.Label();
            this.labelScanMethod = new System.Windows.Forms.Label();
            this.labelDelay = new System.Windows.Forms.Label();
            this.labelTimeout = new System.Windows.Forms.Label();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.textBoxTimeout = new System.Windows.Forms.TextBox();
            this.groupBoxScanOptions = new System.Windows.Forms.GroupBox();
            this.comboBoxScanMethod = new System.Windows.Forms.ComboBox();
            this.groupBoxTarget = new System.Windows.Forms.GroupBox();
            this.labelRightSeparator = new System.Windows.Forms.Label();
            this.labelLeftSeparator = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveLog = new System.Windows.Forms.Button();
            this.backgroundWorkerScan = new System.ComponentModel.BackgroundWorker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxScanResult = new System.Windows.Forms.TextBox();
            this.groupBoxScanOptions.SuspendLayout();
            this.groupBoxTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(459, 381);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // chooseDeviceUserControl
            // 
            this.chooseDeviceUserControl.Location = new System.Drawing.Point(12, 250);
            this.chooseDeviceUserControl.Name = "chooseDeviceUserControl";
            this.chooseDeviceUserControl.Size = new System.Drawing.Size(258, 60);
            this.chooseDeviceUserControl.TabIndex = 2;
            // 
            // progressBarScanProgress
            // 
            this.progressBarScanProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarScanProgress.Location = new System.Drawing.Point(12, 352);
            this.progressBarScanProgress.Name = "progressBarScanProgress";
            this.progressBarScanProgress.Size = new System.Drawing.Size(522, 23);
            this.progressBarScanProgress.TabIndex = 6;
            // 
            // buttonStartScan
            // 
            this.buttonStartScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStartScan.Location = new System.Drawing.Point(195, 316);
            this.buttonStartScan.Name = "buttonStartScan";
            this.buttonStartScan.Size = new System.Drawing.Size(75, 23);
            this.buttonStartScan.TabIndex = 4;
            this.buttonStartScan.Text = "Start Scan";
            this.buttonStartScan.UseVisualStyleBackColor = true;
            this.buttonStartScan.Click += new System.EventHandler(this.buttonStartScan_Click);
            // 
            // labelScannerType
            // 
            this.labelScannerType.AutoSize = true;
            this.labelScannerType.Location = new System.Drawing.Point(12, 26);
            this.labelScannerType.Name = "labelScannerType";
            this.labelScannerType.Size = new System.Drawing.Size(77, 13);
            this.labelScannerType.TabIndex = 0;
            this.labelScannerType.Text = "Scanner Type:";
            // 
            // comboBoxScannerType
            // 
            this.comboBoxScannerType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxScannerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScannerType.FormattingEnabled = true;
            this.comboBoxScannerType.Location = new System.Drawing.Point(105, 23);
            this.comboBoxScannerType.Name = "comboBoxScannerType";
            this.comboBoxScannerType.Size = new System.Drawing.Size(137, 21);
            this.comboBoxScannerType.TabIndex = 1;
            // 
            // labelTargetHosts
            // 
            this.labelTargetHosts.AutoSize = true;
            this.labelTargetHosts.Location = new System.Drawing.Point(12, 26);
            this.labelTargetHosts.Name = "labelTargetHosts";
            this.labelTargetHosts.Size = new System.Drawing.Size(43, 13);
            this.labelTargetHosts.TabIndex = 0;
            this.labelTargetHosts.Text = "Host(s):";
            // 
            // textBoxHost
            // 
            this.textBoxHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHost.Location = new System.Drawing.Point(105, 23);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(137, 20);
            this.textBoxHost.TabIndex = 1;
            this.textBoxHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFromPort
            // 
            this.textBoxFromPort.Location = new System.Drawing.Point(105, 49);
            this.textBoxFromPort.MaxLength = 5;
            this.textBoxFromPort.Name = "textBoxFromPort";
            this.textBoxFromPort.Size = new System.Drawing.Size(56, 20);
            this.textBoxFromPort.TabIndex = 3;
            this.textBoxFromPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxToPort
            // 
            this.textBoxToPort.Location = new System.Drawing.Point(186, 49);
            this.textBoxToPort.MaxLength = 5;
            this.textBoxToPort.Name = "textBoxToPort";
            this.textBoxToPort.Size = new System.Drawing.Size(56, 20);
            this.textBoxToPort.TabIndex = 5;
            this.textBoxToPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPorts
            // 
            this.labelPorts.AutoSize = true;
            this.labelPorts.Location = new System.Drawing.Point(12, 52);
            this.labelPorts.Name = "labelPorts";
            this.labelPorts.Size = new System.Drawing.Size(40, 13);
            this.labelPorts.TabIndex = 2;
            this.labelPorts.Text = "Port(s):";
            // 
            // labelColon
            // 
            this.labelColon.AutoSize = true;
            this.labelColon.Location = new System.Drawing.Point(168, 52);
            this.labelColon.Name = "labelColon";
            this.labelColon.Size = new System.Drawing.Size(10, 13);
            this.labelColon.TabIndex = 4;
            this.labelColon.Text = ":";
            // 
            // labelScanMethod
            // 
            this.labelScanMethod.AutoSize = true;
            this.labelScanMethod.Location = new System.Drawing.Point(12, 53);
            this.labelScanMethod.Name = "labelScanMethod";
            this.labelScanMethod.Size = new System.Drawing.Size(46, 13);
            this.labelScanMethod.TabIndex = 2;
            this.labelScanMethod.Text = "Method:";
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(12, 80);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(59, 13);
            this.labelDelay.TabIndex = 4;
            this.labelDelay.Text = "Delay (ms):";
            // 
            // labelTimeout
            // 
            this.labelTimeout.AutoSize = true;
            this.labelTimeout.Location = new System.Drawing.Point(12, 106);
            this.labelTimeout.Name = "labelTimeout";
            this.labelTimeout.Size = new System.Drawing.Size(70, 13);
            this.labelTimeout.TabIndex = 6;
            this.labelTimeout.Text = "Timeout (ms):";
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(105, 77);
            this.textBoxDelay.MaxLength = 10;
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(56, 20);
            this.textBoxDelay.TabIndex = 5;
            this.textBoxDelay.Text = "0";
            this.textBoxDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTimeout
            // 
            this.textBoxTimeout.Location = new System.Drawing.Point(105, 103);
            this.textBoxTimeout.Name = "textBoxTimeout";
            this.textBoxTimeout.Size = new System.Drawing.Size(56, 20);
            this.textBoxTimeout.TabIndex = 7;
            this.textBoxTimeout.Text = "500";
            this.textBoxTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxScanOptions
            // 
            this.groupBoxScanOptions.Controls.Add(this.comboBoxScanMethod);
            this.groupBoxScanOptions.Controls.Add(this.textBoxTimeout);
            this.groupBoxScanOptions.Controls.Add(this.labelScannerType);
            this.groupBoxScanOptions.Controls.Add(this.textBoxDelay);
            this.groupBoxScanOptions.Controls.Add(this.comboBoxScannerType);
            this.groupBoxScanOptions.Controls.Add(this.labelTimeout);
            this.groupBoxScanOptions.Controls.Add(this.labelDelay);
            this.groupBoxScanOptions.Controls.Add(this.labelScanMethod);
            this.groupBoxScanOptions.Location = new System.Drawing.Point(12, 12);
            this.groupBoxScanOptions.Name = "groupBoxScanOptions";
            this.groupBoxScanOptions.Size = new System.Drawing.Size(258, 140);
            this.groupBoxScanOptions.TabIndex = 0;
            this.groupBoxScanOptions.TabStop = false;
            this.groupBoxScanOptions.Text = "Scan Options";
            // 
            // comboBoxScanMethod
            // 
            this.comboBoxScanMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxScanMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScanMethod.FormattingEnabled = true;
            this.comboBoxScanMethod.Location = new System.Drawing.Point(105, 50);
            this.comboBoxScanMethod.Name = "comboBoxScanMethod";
            this.comboBoxScanMethod.Size = new System.Drawing.Size(137, 21);
            this.comboBoxScanMethod.TabIndex = 3;
            // 
            // groupBoxTarget
            // 
            this.groupBoxTarget.Controls.Add(this.textBoxHost);
            this.groupBoxTarget.Controls.Add(this.labelPorts);
            this.groupBoxTarget.Controls.Add(this.labelColon);
            this.groupBoxTarget.Controls.Add(this.textBoxToPort);
            this.groupBoxTarget.Controls.Add(this.textBoxFromPort);
            this.groupBoxTarget.Controls.Add(this.labelTargetHosts);
            this.groupBoxTarget.Location = new System.Drawing.Point(12, 158);
            this.groupBoxTarget.Name = "groupBoxTarget";
            this.groupBoxTarget.Size = new System.Drawing.Size(258, 86);
            this.groupBoxTarget.TabIndex = 1;
            this.groupBoxTarget.TabStop = false;
            this.groupBoxTarget.Text = "Target";
            // 
            // labelRightSeparator
            // 
            this.labelRightSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRightSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRightSeparator.Location = new System.Drawing.Point(276, 327);
            this.labelRightSeparator.Name = "labelRightSeparator";
            this.labelRightSeparator.Size = new System.Drawing.Size(258, 2);
            this.labelRightSeparator.TabIndex = 5;
            // 
            // labelLeftSeparator
            // 
            this.labelLeftSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLeftSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLeftSeparator.Location = new System.Drawing.Point(12, 327);
            this.labelLeftSeparator.Name = "labelLeftSeparator";
            this.labelLeftSeparator.Size = new System.Drawing.Size(177, 2);
            this.labelLeftSeparator.TabIndex = 3;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "scanlog.txt";
            this.saveFileDialog.Filter = "Text Documents (*.txt)|*.txt";
            this.saveFileDialog.Title = "Save scan result";
            // 
            // buttonSaveLog
            // 
            this.buttonSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveLog.Location = new System.Drawing.Point(378, 381);
            this.buttonSaveLog.Name = "buttonSaveLog";
            this.buttonSaveLog.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveLog.TabIndex = 7;
            this.buttonSaveLog.Text = "Save Log";
            this.buttonSaveLog.UseVisualStyleBackColor = true;
            this.buttonSaveLog.Click += new System.EventHandler(this.buttonSaveLog_Click);
            // 
            // backgroundWorkerScan
            // 
            this.backgroundWorkerScan.WorkerReportsProgress = true;
            this.backgroundWorkerScan.WorkerSupportsCancellation = true;
            this.backgroundWorkerScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerScan_DoWork);
            this.backgroundWorkerScan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerScan_RunWorkerCompleted);
            this.backgroundWorkerScan.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerScan_ProgressChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // textBoxScanResult
            // 
            this.textBoxScanResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxScanResult.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxScanResult.Location = new System.Drawing.Point(276, 12);
            this.textBoxScanResult.Multiline = true;
            this.textBoxScanResult.Name = "textBoxScanResult";
            this.textBoxScanResult.ReadOnly = true;
            this.textBoxScanResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxScanResult.Size = new System.Drawing.Size(258, 298);
            this.textBoxScanResult.TabIndex = 10;
            // 
            // PortScannerForm
            // 
            this.AcceptButton = this.buttonStartScan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(546, 416);
            this.Controls.Add(this.textBoxScanResult);
            this.Controls.Add(this.buttonSaveLog);
            this.Controls.Add(this.labelLeftSeparator);
            this.Controls.Add(this.labelRightSeparator);
            this.Controls.Add(this.groupBoxTarget);
            this.Controls.Add(this.groupBoxScanOptions);
            this.Controls.Add(this.buttonStartScan);
            this.Controls.Add(this.progressBarScanProgress);
            this.Controls.Add(this.chooseDeviceUserControl);
            this.Controls.Add(this.buttonClose);
            this.MinimumSize = new System.Drawing.Size(554, 450);
            this.Name = "PortScannerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port Scanner";
            this.groupBoxScanOptions.ResumeLayout(false);
            this.groupBoxScanOptions.PerformLayout();
            this.groupBoxTarget.ResumeLayout(false);
            this.groupBoxTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private ChooseDeviceUserControl chooseDeviceUserControl;
        private System.Windows.Forms.ProgressBar progressBarScanProgress;
        private System.Windows.Forms.Button buttonStartScan;
        private System.Windows.Forms.Label labelScannerType;
        private System.Windows.Forms.ComboBox comboBoxScannerType;
        private System.Windows.Forms.Label labelTargetHosts;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.TextBox textBoxFromPort;
        private System.Windows.Forms.TextBox textBoxToPort;
        private System.Windows.Forms.Label labelPorts;
        private System.Windows.Forms.Label labelColon;
        private System.Windows.Forms.Label labelScanMethod;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.Label labelTimeout;
        private System.Windows.Forms.TextBox textBoxDelay;
        private System.Windows.Forms.TextBox textBoxTimeout;
        private System.Windows.Forms.GroupBox groupBoxScanOptions;
        private System.Windows.Forms.ComboBox comboBoxScanMethod;
        private System.Windows.Forms.GroupBox groupBoxTarget;
        private System.Windows.Forms.Label labelRightSeparator;
        private System.Windows.Forms.Label labelLeftSeparator;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonSaveLog;
        private System.ComponentModel.BackgroundWorker backgroundWorkerScan;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox textBoxScanResult;
    }
}