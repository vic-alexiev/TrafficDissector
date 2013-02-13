namespace TrafficDissector.UI.PacketHeadersUserControls
{
    partial class UdpHeaderUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxUdpHeader = new System.Windows.Forms.GroupBox();
            this.textBoxDestinationPort = new System.Windows.Forms.TextBox();
            this.labelDestinationPort = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.textBoxSourcePort = new System.Windows.Forms.TextBox();
            this.labelSourcePort = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxUdpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUdpHeader
            // 
            this.groupBoxUdpHeader.Controls.Add(this.textBoxDestinationPort);
            this.groupBoxUdpHeader.Controls.Add(this.labelDestinationPort);
            this.groupBoxUdpHeader.Controls.Add(this.textBoxLength);
            this.groupBoxUdpHeader.Controls.Add(this.labelLength);
            this.groupBoxUdpHeader.Controls.Add(this.textBoxSourcePort);
            this.groupBoxUdpHeader.Controls.Add(this.labelSourcePort);
            this.groupBoxUdpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxUdpHeader.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUdpHeader.Name = "groupBoxUdpHeader";
            this.groupBoxUdpHeader.Size = new System.Drawing.Size(317, 87);
            this.groupBoxUdpHeader.TabIndex = 0;
            this.groupBoxUdpHeader.TabStop = false;
            this.groupBoxUdpHeader.Text = "UDP header";
            // 
            // textBoxDestinationPort
            // 
            this.textBoxDestinationPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDestinationPort.Location = new System.Drawing.Point(236, 23);
            this.textBoxDestinationPort.MaxLength = 5;
            this.textBoxDestinationPort.Name = "textBoxDestinationPort";
            this.textBoxDestinationPort.Size = new System.Drawing.Size(65, 20);
            this.textBoxDestinationPort.TabIndex = 11;
            // 
            // labelDestinationPort
            // 
            this.labelDestinationPort.AutoSize = true;
            this.labelDestinationPort.Location = new System.Drawing.Point(163, 26);
            this.labelDestinationPort.Name = "labelDestinationPort";
            this.labelDestinationPort.Size = new System.Drawing.Size(47, 13);
            this.labelDestinationPort.TabIndex = 10;
            this.labelDestinationPort.Text = "Dst port:";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLength.Location = new System.Drawing.Point(91, 49);
            this.textBoxLength.MaxLength = 5;
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(65, 20);
            this.textBoxLength.TabIndex = 9;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(12, 52);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(43, 13);
            this.labelLength.TabIndex = 8;
            this.labelLength.Text = "Length:";
            // 
            // textBoxSourcePort
            // 
            this.textBoxSourcePort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSourcePort.Location = new System.Drawing.Point(91, 23);
            this.textBoxSourcePort.MaxLength = 5;
            this.textBoxSourcePort.Name = "textBoxSourcePort";
            this.textBoxSourcePort.Size = new System.Drawing.Size(65, 20);
            this.textBoxSourcePort.TabIndex = 7;
            // 
            // labelSourcePort
            // 
            this.labelSourcePort.AutoSize = true;
            this.labelSourcePort.Location = new System.Drawing.Point(12, 26);
            this.labelSourcePort.Name = "labelSourcePort";
            this.labelSourcePort.Size = new System.Drawing.Size(47, 13);
            this.labelSourcePort.TabIndex = 6;
            this.labelSourcePort.Text = "Src port:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UdpHeaderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxUdpHeader);
            this.Name = "UdpHeaderUserControl";
            this.Size = new System.Drawing.Size(317, 87);
            this.groupBoxUdpHeader.ResumeLayout(false);
            this.groupBoxUdpHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUdpHeader;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.TextBox textBoxSourcePort;
        private System.Windows.Forms.Label labelSourcePort;
        private System.Windows.Forms.TextBox textBoxDestinationPort;
        private System.Windows.Forms.Label labelDestinationPort;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
