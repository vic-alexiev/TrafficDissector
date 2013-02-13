namespace TrafficDissector.UI
{
    partial class InjectEthernetPacketForm
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
            this.buttonInject = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.ethernetHeaderUserControl = new TrafficDissector.UI.PacketHeadersUserControls.EthernetHeaderUserControl();
            this.chooseDeviceUserControl = new TrafficDissector.UI.ChooseDeviceUserControl();
            this.labelPacketLength = new System.Windows.Forms.Label();
            this.textBoxPacketLength = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInject
            // 
            this.buttonInject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInject.Location = new System.Drawing.Point(173, 253);
            this.buttonInject.Name = "buttonInject";
            this.buttonInject.Size = new System.Drawing.Size(75, 23);
            this.buttonInject.TabIndex = 4;
            this.buttonInject.Text = "Inject";
            this.buttonInject.UseVisualStyleBackColor = true;
            this.buttonInject.Click += new System.EventHandler(this.buttonInject_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(254, 253);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // ethernetHeaderUserControl
            // 
            this.ethernetHeaderUserControl.Location = new System.Drawing.Point(12, 12);
            this.ethernetHeaderUserControl.Name = "ethernetHeaderUserControl";
            this.ethernetHeaderUserControl.Size = new System.Drawing.Size(317, 113);
            this.ethernetHeaderUserControl.TabIndex = 0;
            // 
            // chooseDeviceUserControl
            // 
            this.chooseDeviceUserControl.Location = new System.Drawing.Point(12, 177);
            this.chooseDeviceUserControl.Name = "chooseDeviceUserControl";
            this.chooseDeviceUserControl.Size = new System.Drawing.Size(317, 60);
            this.chooseDeviceUserControl.TabIndex = 3;
            // 
            // labelPacketLength
            // 
            this.labelPacketLength.AutoSize = true;
            this.labelPacketLength.Location = new System.Drawing.Point(26, 143);
            this.labelPacketLength.Name = "labelPacketLength";
            this.labelPacketLength.Size = new System.Drawing.Size(43, 13);
            this.labelPacketLength.TabIndex = 1;
            this.labelPacketLength.Text = "Length:";
            // 
            // textBoxPacketLength
            // 
            this.textBoxPacketLength.Location = new System.Drawing.Point(103, 140);
            this.textBoxPacketLength.MaxLength = 4;
            this.textBoxPacketLength.Name = "textBoxPacketLength";
            this.textBoxPacketLength.Size = new System.Drawing.Size(51, 20);
            this.textBoxPacketLength.TabIndex = 2;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // InjectEthernetPacketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(341, 288);
            this.Controls.Add(this.textBoxPacketLength);
            this.Controls.Add(this.labelPacketLength);
            this.Controls.Add(this.chooseDeviceUserControl);
            this.Controls.Add(this.ethernetHeaderUserControl);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonInject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InjectEthernetPacketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inject Ethernet Packet";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInject;
        private System.Windows.Forms.Button buttonClose;
        private TrafficDissector.UI.PacketHeadersUserControls.EthernetHeaderUserControl ethernetHeaderUserControl;
        private ChooseDeviceUserControl chooseDeviceUserControl;
        private System.Windows.Forms.Label labelPacketLength;
        private System.Windows.Forms.TextBox textBoxPacketLength;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}