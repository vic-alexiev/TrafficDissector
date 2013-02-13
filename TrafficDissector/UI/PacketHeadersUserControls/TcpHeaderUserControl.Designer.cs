namespace TrafficDissector.UI.PacketHeadersUserControls
{
    partial class TcpHeaderUserControl
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
            this.groupBoxTcpHeader = new System.Windows.Forms.GroupBox();
            this.labelHeaderLength = new System.Windows.Forms.Label();
            this.textBoxFlags = new System.Windows.Forms.TextBox();
            this.textBoxUrgentPointer = new System.Windows.Forms.TextBox();
            this.labelUrgentPointer = new System.Windows.Forms.Label();
            this.textBoxWindowSize = new System.Windows.Forms.TextBox();
            this.labelWindowSize = new System.Windows.Forms.Label();
            this.textBoxHeaderLength = new System.Windows.Forms.TextBox();
            this.labelFlags = new System.Windows.Forms.Label();
            this.textBoxAckNumber = new System.Windows.Forms.TextBox();
            this.labelAckNumber = new System.Windows.Forms.Label();
            this.textBoxSeqNumber = new System.Windows.Forms.TextBox();
            this.labelSeqNumber = new System.Windows.Forms.Label();
            this.textBoxDestinationPort = new System.Windows.Forms.TextBox();
            this.labelDestinationPort = new System.Windows.Forms.Label();
            this.textBoxSourcePort = new System.Windows.Forms.TextBox();
            this.labelSourcePort = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxTcpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTcpHeader
            // 
            this.groupBoxTcpHeader.Controls.Add(this.labelHeaderLength);
            this.groupBoxTcpHeader.Controls.Add(this.textBoxFlags);
            this.groupBoxTcpHeader.Controls.Add(this.textBoxUrgentPointer);
            this.groupBoxTcpHeader.Controls.Add(this.labelUrgentPointer);
            this.groupBoxTcpHeader.Controls.Add(this.textBoxWindowSize);
            this.groupBoxTcpHeader.Controls.Add(this.labelWindowSize);
            this.groupBoxTcpHeader.Controls.Add(this.textBoxHeaderLength);
            this.groupBoxTcpHeader.Controls.Add(this.labelFlags);
            this.groupBoxTcpHeader.Controls.Add(this.textBoxAckNumber);
            this.groupBoxTcpHeader.Controls.Add(this.labelAckNumber);
            this.groupBoxTcpHeader.Controls.Add(this.textBoxSeqNumber);
            this.groupBoxTcpHeader.Controls.Add(this.labelSeqNumber);
            this.groupBoxTcpHeader.Controls.Add(this.textBoxDestinationPort);
            this.groupBoxTcpHeader.Controls.Add(this.labelDestinationPort);
            this.groupBoxTcpHeader.Controls.Add(this.textBoxSourcePort);
            this.groupBoxTcpHeader.Controls.Add(this.labelSourcePort);
            this.groupBoxTcpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTcpHeader.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTcpHeader.Name = "groupBoxTcpHeader";
            this.groupBoxTcpHeader.Size = new System.Drawing.Size(317, 137);
            this.groupBoxTcpHeader.TabIndex = 0;
            this.groupBoxTcpHeader.TabStop = false;
            this.groupBoxTcpHeader.Text = "TCP header";
            // 
            // labelHeaderLength
            // 
            this.labelHeaderLength.AutoSize = true;
            this.labelHeaderLength.Location = new System.Drawing.Point(12, 78);
            this.labelHeaderLength.Name = "labelHeaderLength";
            this.labelHeaderLength.Size = new System.Drawing.Size(62, 13);
            this.labelHeaderLength.TabIndex = 15;
            this.labelHeaderLength.Text = "Data offset:";
            // 
            // textBoxFlags
            // 
            this.textBoxFlags.Location = new System.Drawing.Point(236, 75);
            this.textBoxFlags.MaxLength = 3;
            this.textBoxFlags.Name = "textBoxFlags";
            this.textBoxFlags.Size = new System.Drawing.Size(65, 20);
            this.textBoxFlags.TabIndex = 14;
            // 
            // textBoxUrgentPointer
            // 
            this.textBoxUrgentPointer.Location = new System.Drawing.Point(236, 101);
            this.textBoxUrgentPointer.MaxLength = 5;
            this.textBoxUrgentPointer.Name = "textBoxUrgentPointer";
            this.textBoxUrgentPointer.Size = new System.Drawing.Size(65, 20);
            this.textBoxUrgentPointer.TabIndex = 13;
            // 
            // labelUrgentPointer
            // 
            this.labelUrgentPointer.AutoSize = true;
            this.labelUrgentPointer.Location = new System.Drawing.Point(163, 104);
            this.labelUrgentPointer.Name = "labelUrgentPointer";
            this.labelUrgentPointer.Size = new System.Drawing.Size(62, 13);
            this.labelUrgentPointer.TabIndex = 12;
            this.labelUrgentPointer.Text = "Urg pointer:";
            // 
            // textBoxWindowSize
            // 
            this.textBoxWindowSize.Location = new System.Drawing.Point(91, 101);
            this.textBoxWindowSize.MaxLength = 5;
            this.textBoxWindowSize.Name = "textBoxWindowSize";
            this.textBoxWindowSize.Size = new System.Drawing.Size(65, 20);
            this.textBoxWindowSize.TabIndex = 11;
            // 
            // labelWindowSize
            // 
            this.labelWindowSize.AutoSize = true;
            this.labelWindowSize.Location = new System.Drawing.Point(12, 104);
            this.labelWindowSize.Name = "labelWindowSize";
            this.labelWindowSize.Size = new System.Drawing.Size(70, 13);
            this.labelWindowSize.TabIndex = 10;
            this.labelWindowSize.Text = "Window size:";
            // 
            // textBoxHeaderLength
            // 
            this.textBoxHeaderLength.Location = new System.Drawing.Point(91, 75);
            this.textBoxHeaderLength.MaxLength = 2;
            this.textBoxHeaderLength.Name = "textBoxHeaderLength";
            this.textBoxHeaderLength.Size = new System.Drawing.Size(65, 20);
            this.textBoxHeaderLength.TabIndex = 9;
            // 
            // labelFlags
            // 
            this.labelFlags.AutoSize = true;
            this.labelFlags.Location = new System.Drawing.Point(163, 78);
            this.labelFlags.Name = "labelFlags";
            this.labelFlags.Size = new System.Drawing.Size(35, 13);
            this.labelFlags.TabIndex = 8;
            this.labelFlags.Text = "Flags:";
            // 
            // textBoxAckNumber
            // 
            this.textBoxAckNumber.Location = new System.Drawing.Point(236, 49);
            this.textBoxAckNumber.MaxLength = 10;
            this.textBoxAckNumber.Name = "textBoxAckNumber";
            this.textBoxAckNumber.Size = new System.Drawing.Size(65, 20);
            this.textBoxAckNumber.TabIndex = 7;
            // 
            // labelAckNumber
            // 
            this.labelAckNumber.AutoSize = true;
            this.labelAckNumber.Location = new System.Drawing.Point(163, 52);
            this.labelAckNumber.Name = "labelAckNumber";
            this.labelAckNumber.Size = new System.Drawing.Size(67, 13);
            this.labelAckNumber.TabIndex = 6;
            this.labelAckNumber.Text = "Ack number:";
            // 
            // textBoxSeqNumber
            // 
            this.textBoxSeqNumber.Location = new System.Drawing.Point(91, 49);
            this.textBoxSeqNumber.MaxLength = 10;
            this.textBoxSeqNumber.Name = "textBoxSeqNumber";
            this.textBoxSeqNumber.Size = new System.Drawing.Size(65, 20);
            this.textBoxSeqNumber.TabIndex = 5;
            // 
            // labelSeqNumber
            // 
            this.labelSeqNumber.AutoSize = true;
            this.labelSeqNumber.Location = new System.Drawing.Point(12, 52);
            this.labelSeqNumber.Name = "labelSeqNumber";
            this.labelSeqNumber.Size = new System.Drawing.Size(67, 13);
            this.labelSeqNumber.TabIndex = 4;
            this.labelSeqNumber.Text = "Seq number:";
            // 
            // textBoxDestinationPort
            // 
            this.textBoxDestinationPort.Location = new System.Drawing.Point(236, 23);
            this.textBoxDestinationPort.MaxLength = 5;
            this.textBoxDestinationPort.Name = "textBoxDestinationPort";
            this.textBoxDestinationPort.Size = new System.Drawing.Size(65, 20);
            this.textBoxDestinationPort.TabIndex = 3;
            // 
            // labelDestinationPort
            // 
            this.labelDestinationPort.AutoSize = true;
            this.labelDestinationPort.Location = new System.Drawing.Point(163, 26);
            this.labelDestinationPort.Name = "labelDestinationPort";
            this.labelDestinationPort.Size = new System.Drawing.Size(47, 13);
            this.labelDestinationPort.TabIndex = 2;
            this.labelDestinationPort.Text = "Dst port:";
            // 
            // textBoxSourcePort
            // 
            this.textBoxSourcePort.Location = new System.Drawing.Point(91, 23);
            this.textBoxSourcePort.MaxLength = 5;
            this.textBoxSourcePort.Name = "textBoxSourcePort";
            this.textBoxSourcePort.Size = new System.Drawing.Size(65, 20);
            this.textBoxSourcePort.TabIndex = 1;
            // 
            // labelSourcePort
            // 
            this.labelSourcePort.AutoSize = true;
            this.labelSourcePort.Location = new System.Drawing.Point(12, 26);
            this.labelSourcePort.Name = "labelSourcePort";
            this.labelSourcePort.Size = new System.Drawing.Size(47, 13);
            this.labelSourcePort.TabIndex = 0;
            this.labelSourcePort.Text = "Src port:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // TcpHeaderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxTcpHeader);
            this.Name = "TcpHeaderUserControl";
            this.Size = new System.Drawing.Size(317, 137);
            this.groupBoxTcpHeader.ResumeLayout(false);
            this.groupBoxTcpHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTcpHeader;
        private System.Windows.Forms.Label labelSourcePort;
        private System.Windows.Forms.TextBox textBoxAckNumber;
        private System.Windows.Forms.Label labelAckNumber;
        private System.Windows.Forms.TextBox textBoxSeqNumber;
        private System.Windows.Forms.Label labelSeqNumber;
        private System.Windows.Forms.TextBox textBoxDestinationPort;
        private System.Windows.Forms.Label labelDestinationPort;
        private System.Windows.Forms.TextBox textBoxSourcePort;
        private System.Windows.Forms.TextBox textBoxWindowSize;
        private System.Windows.Forms.Label labelWindowSize;
        private System.Windows.Forms.TextBox textBoxHeaderLength;
        private System.Windows.Forms.Label labelFlags;
        private System.Windows.Forms.TextBox textBoxUrgentPointer;
        private System.Windows.Forms.Label labelUrgentPointer;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelHeaderLength;
        private System.Windows.Forms.TextBox textBoxFlags;
    }
}
