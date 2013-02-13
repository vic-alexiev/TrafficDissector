namespace TrafficDissector.UI
{
    partial class InjectTcpPacketForm
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
            this.iPv4HeaderUserControl = new TrafficDissector.UI.PacketHeadersUserControls.IPv4HeaderUserControl();
            this.ethernetHeaderUserControl = new TrafficDissector.UI.PacketHeadersUserControls.EthernetHeaderUserControl();
            this.tcpHeaderUserControl = new TrafficDissector.UI.PacketHeadersUserControls.TcpHeaderUserControl();
            this.chooseDeviceUserControl = new TrafficDissector.UI.ChooseDeviceUserControl();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonInject = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // ethernetHeaderUserControl
            // 
            this.ethernetHeaderUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ethernetHeaderUserControl.Location = new System.Drawing.Point(12, 12);
            this.ethernetHeaderUserControl.Name = "ethernetHeaderUserControl";
            this.ethernetHeaderUserControl.Size = new System.Drawing.Size(317, 113);
            this.ethernetHeaderUserControl.TabIndex = 0;
            // 
            // tcpHeaderUserControl
            // 
            this.tcpHeaderUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcpHeaderUserControl.Location = new System.Drawing.Point(12, 302);
            this.tcpHeaderUserControl.Name = "tcpHeaderUserControl";
            this.tcpHeaderUserControl.Size = new System.Drawing.Size(317, 139);
            this.tcpHeaderUserControl.TabIndex = 2;
            // 
            // chooseDeviceUserControl
            // 
            this.chooseDeviceUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseDeviceUserControl.Location = new System.Drawing.Point(12, 447);
            this.chooseDeviceUserControl.Name = "chooseDeviceUserControl";
            this.chooseDeviceUserControl.Size = new System.Drawing.Size(317, 60);
            this.chooseDeviceUserControl.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(254, 523);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonInject
            // 
            this.buttonInject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInject.Location = new System.Drawing.Point(173, 523);
            this.buttonInject.Name = "buttonInject";
            this.buttonInject.Size = new System.Drawing.Size(75, 23);
            this.buttonInject.TabIndex = 9;
            this.buttonInject.Text = "Inject";
            this.buttonInject.UseVisualStyleBackColor = true;
            this.buttonInject.Click += new System.EventHandler(this.buttonInject_Click);
            // 
            // InjectTcpPacketForm
            // 
            this.AcceptButton = this.buttonInject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(341, 558);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonInject);
            this.Controls.Add(this.chooseDeviceUserControl);
            this.Controls.Add(this.tcpHeaderUserControl);
            this.Controls.Add(this.iPv4HeaderUserControl);
            this.Controls.Add(this.ethernetHeaderUserControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InjectTcpPacketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inject TCP packet";
            this.ResumeLayout(false);

        }

        #endregion

        private TrafficDissector.UI.PacketHeadersUserControls.EthernetHeaderUserControl ethernetHeaderUserControl;
        private TrafficDissector.UI.PacketHeadersUserControls.IPv4HeaderUserControl iPv4HeaderUserControl;
        private TrafficDissector.UI.PacketHeadersUserControls.TcpHeaderUserControl tcpHeaderUserControl;
        private ChooseDeviceUserControl chooseDeviceUserControl;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonInject;
    }
}