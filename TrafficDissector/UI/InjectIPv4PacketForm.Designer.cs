namespace TrafficDissector.UI
{
    partial class InjectIPv4PacketForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonInject = new System.Windows.Forms.Button();
            this.iPv4HeaderUserControl = new TrafficDissector.UI.PacketHeadersUserControls.IPv4HeaderUserControl();
            this.chooseDeviceUserControl = new TrafficDissector.UI.ChooseDeviceUserControl();
            this.ethernetHeaderUserControl = new TrafficDissector.UI.PacketHeadersUserControls.EthernetHeaderUserControl();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(254, 378);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonInject
            // 
            this.buttonInject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInject.Location = new System.Drawing.Point(173, 378);
            this.buttonInject.Name = "buttonInject";
            this.buttonInject.Size = new System.Drawing.Size(75, 23);
            this.buttonInject.TabIndex = 7;
            this.buttonInject.Text = "Inject";
            this.buttonInject.UseVisualStyleBackColor = true;
            this.buttonInject.Click += new System.EventHandler(this.buttonInject_Click);
            // 
            // iPv4HeaderUserControl
            // 
            this.iPv4HeaderUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.iPv4HeaderUserControl.Location = new System.Drawing.Point(12, 131);
            this.iPv4HeaderUserControl.Name = "iPv4HeaderUserControl";
            this.iPv4HeaderUserControl.Size = new System.Drawing.Size(317, 165);
            this.iPv4HeaderUserControl.TabIndex = 16;
            // 
            // chooseDeviceUserControl
            // 
            this.chooseDeviceUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseDeviceUserControl.Location = new System.Drawing.Point(12, 302);
            this.chooseDeviceUserControl.Name = "chooseDeviceUserControl";
            this.chooseDeviceUserControl.Size = new System.Drawing.Size(317, 60);
            this.chooseDeviceUserControl.TabIndex = 15;
            // 
            // ethernetHeaderUserControl
            // 
            this.ethernetHeaderUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ethernetHeaderUserControl.Location = new System.Drawing.Point(12, 12);
            this.ethernetHeaderUserControl.Name = "ethernetHeaderUserControl";
            this.ethernetHeaderUserControl.Size = new System.Drawing.Size(317, 113);
            this.ethernetHeaderUserControl.TabIndex = 12;
            // 
            // InjectIPv4PacketForm
            // 
            this.AcceptButton = this.buttonInject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(341, 413);
            this.Controls.Add(this.iPv4HeaderUserControl);
            this.Controls.Add(this.chooseDeviceUserControl);
            this.Controls.Add(this.ethernetHeaderUserControl);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonInject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InjectIPv4PacketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inject IPv4 packet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonInject;
        private ChooseDeviceUserControl chooseDeviceUserControl;
        private TrafficDissector.UI.PacketHeadersUserControls.EthernetHeaderUserControl ethernetHeaderUserControl;
        private TrafficDissector.UI.PacketHeadersUserControls.IPv4HeaderUserControl iPv4HeaderUserControl;
    }
}