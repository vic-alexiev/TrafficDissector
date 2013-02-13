namespace TrafficDissector.UI
{
    partial class InjectUdpPacketForm
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
            this.ethernetHeaderUserControl = new TrafficDissector.UI.PacketHeadersUserControls.EthernetHeaderUserControl();
            this.iPv4HeaderUserControl = new TrafficDissector.UI.PacketHeadersUserControls.IPv4HeaderUserControl();
            this.udpHeaderUserControl = new TrafficDissector.UI.PacketHeadersUserControls.UdpHeaderUserControl();
            this.chooseDeviceUserControl = new TrafficDissector.UI.ChooseDeviceUserControl();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonInject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ethernetHeaderUserControl
            // 
            this.ethernetHeaderUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ethernetHeaderUserControl.Location = new System.Drawing.Point(12, 12);
            this.ethernetHeaderUserControl.Name = "ethernetHeaderUserControl";
            this.ethernetHeaderUserControl.Size = new System.Drawing.Size(317, 113);
            this.ethernetHeaderUserControl.TabIndex = 0;
            // 
            // iPv4HeaderUserControl
            // 
            this.iPv4HeaderUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.iPv4HeaderUserControl.Location = new System.Drawing.Point(12, 131);
            this.iPv4HeaderUserControl.Name = "iPv4HeaderUserControl";
            this.iPv4HeaderUserControl.Size = new System.Drawing.Size(317, 165);
            this.iPv4HeaderUserControl.TabIndex = 1;
            // 
            // udpHeaderUserControl
            // 
            this.udpHeaderUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.udpHeaderUserControl.Location = new System.Drawing.Point(12, 302);
            this.udpHeaderUserControl.Name = "udpHeaderUserControl";
            this.udpHeaderUserControl.Size = new System.Drawing.Size(317, 86);
            this.udpHeaderUserControl.TabIndex = 2;
            // 
            // chooseDeviceUserControl
            // 
            this.chooseDeviceUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseDeviceUserControl.Location = new System.Drawing.Point(12, 394);
            this.chooseDeviceUserControl.Name = "chooseDeviceUserControl";
            this.chooseDeviceUserControl.Size = new System.Drawing.Size(317, 60);
            this.chooseDeviceUserControl.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(254, 470);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonInject
            // 
            this.buttonInject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInject.Location = new System.Drawing.Point(173, 470);
            this.buttonInject.Name = "buttonInject";
            this.buttonInject.Size = new System.Drawing.Size(75, 23);
            this.buttonInject.TabIndex = 5;
            this.buttonInject.Text = "Inject";
            this.buttonInject.UseVisualStyleBackColor = true;
            this.buttonInject.Click += new System.EventHandler(this.buttonInject_Click);
            // 
            // InjectUdpPacketForm
            // 
            this.AcceptButton = this.buttonInject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(341, 505);
            this.Controls.Add(this.buttonInject);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.chooseDeviceUserControl);
            this.Controls.Add(this.udpHeaderUserControl);
            this.Controls.Add(this.iPv4HeaderUserControl);
            this.Controls.Add(this.ethernetHeaderUserControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InjectUdpPacketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inject UDP packet";
            this.ResumeLayout(false);

        }

        #endregion

        private TrafficDissector.UI.PacketHeadersUserControls.EthernetHeaderUserControl ethernetHeaderUserControl;
        private TrafficDissector.UI.PacketHeadersUserControls.IPv4HeaderUserControl iPv4HeaderUserControl;
        private TrafficDissector.UI.PacketHeadersUserControls.UdpHeaderUserControl udpHeaderUserControl;
        private ChooseDeviceUserControl chooseDeviceUserControl;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonInject;
    }
}