namespace TrafficDissector.UI
{
    partial class InjectPacketsFromFileForm
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
            this.groupBoxCaptureFile = new System.Windows.Forms.GroupBox();
            this.buttonBrowseCaptureFile = new System.Windows.Forms.Button();
            this.textBoxCaptureFile = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.openCaptureFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.chooseDeviceUserControl = new TrafficDissector.UI.ChooseDeviceUserControl();
            this.groupBoxCaptureFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCaptureFile
            // 
            this.groupBoxCaptureFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCaptureFile.Controls.Add(this.buttonBrowseCaptureFile);
            this.groupBoxCaptureFile.Controls.Add(this.textBoxCaptureFile);
            this.groupBoxCaptureFile.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCaptureFile.Name = "groupBoxCaptureFile";
            this.groupBoxCaptureFile.Size = new System.Drawing.Size(293, 52);
            this.groupBoxCaptureFile.TabIndex = 0;
            this.groupBoxCaptureFile.TabStop = false;
            this.groupBoxCaptureFile.Text = "Capture file to be sent";
            // 
            // buttonBrowseCaptureFile
            // 
            this.buttonBrowseCaptureFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseCaptureFile.Location = new System.Drawing.Point(261, 17);
            this.buttonBrowseCaptureFile.Name = "buttonBrowseCaptureFile";
            this.buttonBrowseCaptureFile.Size = new System.Drawing.Size(26, 23);
            this.buttonBrowseCaptureFile.TabIndex = 1;
            this.buttonBrowseCaptureFile.Text = "...";
            this.buttonBrowseCaptureFile.UseVisualStyleBackColor = true;
            this.buttonBrowseCaptureFile.Click += new System.EventHandler(this.buttonBrowseCaptureFile_Click);
            // 
            // textBoxCaptureFile
            // 
            this.textBoxCaptureFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCaptureFile.Location = new System.Drawing.Point(6, 19);
            this.textBoxCaptureFile.Name = "textBoxCaptureFile";
            this.textBoxCaptureFile.ReadOnly = true;
            this.textBoxCaptureFile.Size = new System.Drawing.Size(249, 20);
            this.textBoxCaptureFile.TabIndex = 0;
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Location = new System.Drawing.Point(149, 154);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(230, 154);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // openCaptureFileDialog
            // 
            this.openCaptureFileDialog.DefaultExt = "pcap";
            this.openCaptureFileDialog.FileName = "output.pcap";
            this.openCaptureFileDialog.Filter = "Capture Files (*.pcap;*.cap)|*.pcap;*.cap|Text Documents (*.txt)|*.txt|All Files|" +
                "*.*";
            this.openCaptureFileDialog.SupportMultiDottedExtensions = true;
            this.openCaptureFileDialog.Title = "Select an output capture file";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // chooseDeviceUserControl
            // 
            this.chooseDeviceUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseDeviceUserControl.Location = new System.Drawing.Point(12, 70);
            this.chooseDeviceUserControl.Name = "chooseDeviceUserControl";
            this.chooseDeviceUserControl.Size = new System.Drawing.Size(293, 60);
            this.chooseDeviceUserControl.TabIndex = 3;
            // 
            // InjectPacketsFromFileForm
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(317, 189);
            this.Controls.Add(this.chooseDeviceUserControl);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.groupBoxCaptureFile);
            this.MinimumSize = new System.Drawing.Size(325, 223);
            this.Name = "InjectPacketsFromFileForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inject packets from file";
            this.groupBoxCaptureFile.ResumeLayout(false);
            this.groupBoxCaptureFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCaptureFile;
        private System.Windows.Forms.TextBox textBoxCaptureFile;
        private System.Windows.Forms.Button buttonBrowseCaptureFile;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.OpenFileDialog openCaptureFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private ChooseDeviceUserControl chooseDeviceUserControl;
    }
}