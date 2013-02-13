namespace TrafficDissector.UI.PacketHeadersUserControls
{
    partial class EthernetHeaderUserControl
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
            this.groupBoxEthernetHeader = new System.Windows.Forms.GroupBox();
            this.comboBoxEthernetProtocols = new System.Windows.Forms.ComboBox();
            this.textBoxSourceHwAddress = new System.Windows.Forms.TextBox();
            this.textBoxDestinationHwAddress = new System.Windows.Forms.TextBox();
            this.labelEthernetProtocol = new System.Windows.Forms.Label();
            this.labelSourceHwAddress = new System.Windows.Forms.Label();
            this.labelDestinationHwAddress = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxEthernetHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEthernetHeader
            // 
            this.groupBoxEthernetHeader.Controls.Add(this.comboBoxEthernetProtocols);
            this.groupBoxEthernetHeader.Controls.Add(this.textBoxSourceHwAddress);
            this.groupBoxEthernetHeader.Controls.Add(this.textBoxDestinationHwAddress);
            this.groupBoxEthernetHeader.Controls.Add(this.labelEthernetProtocol);
            this.groupBoxEthernetHeader.Controls.Add(this.labelSourceHwAddress);
            this.groupBoxEthernetHeader.Controls.Add(this.labelDestinationHwAddress);
            this.groupBoxEthernetHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEthernetHeader.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEthernetHeader.Name = "groupBoxEthernetHeader";
            this.groupBoxEthernetHeader.Size = new System.Drawing.Size(288, 113);
            this.groupBoxEthernetHeader.TabIndex = 7;
            this.groupBoxEthernetHeader.TabStop = false;
            this.groupBoxEthernetHeader.Text = "Ethernet header";
            // 
            // comboBoxEthernetProtocols
            // 
            this.comboBoxEthernetProtocols.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEthernetProtocols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEthernetProtocols.FormattingEnabled = true;
            this.comboBoxEthernetProtocols.Location = new System.Drawing.Point(91, 75);
            this.comboBoxEthernetProtocols.Name = "comboBoxEthernetProtocols";
            this.comboBoxEthernetProtocols.Size = new System.Drawing.Size(181, 21);
            this.comboBoxEthernetProtocols.Sorted = true;
            this.comboBoxEthernetProtocols.TabIndex = 9;
            // 
            // textBoxSourceHwAddress
            // 
            this.textBoxSourceHwAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSourceHwAddress.Location = new System.Drawing.Point(91, 49);
            this.textBoxSourceHwAddress.MaxLength = 17;
            this.textBoxSourceHwAddress.Name = "textBoxSourceHwAddress";
            this.textBoxSourceHwAddress.Size = new System.Drawing.Size(181, 20);
            this.textBoxSourceHwAddress.TabIndex = 13;
            // 
            // textBoxDestinationHwAddress
            // 
            this.textBoxDestinationHwAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDestinationHwAddress.Location = new System.Drawing.Point(91, 23);
            this.textBoxDestinationHwAddress.MaxLength = 17;
            this.textBoxDestinationHwAddress.Name = "textBoxDestinationHwAddress";
            this.textBoxDestinationHwAddress.Size = new System.Drawing.Size(181, 20);
            this.textBoxDestinationHwAddress.TabIndex = 12;
            // 
            // labelEthernetProtocol
            // 
            this.labelEthernetProtocol.AutoSize = true;
            this.labelEthernetProtocol.Location = new System.Drawing.Point(12, 78);
            this.labelEthernetProtocol.Name = "labelEthernetProtocol";
            this.labelEthernetProtocol.Size = new System.Drawing.Size(34, 13);
            this.labelEthernetProtocol.TabIndex = 11;
            this.labelEthernetProtocol.Text = "Type:";
            // 
            // labelSourceHwAddress
            // 
            this.labelSourceHwAddress.AutoSize = true;
            this.labelSourceHwAddress.Location = new System.Drawing.Point(12, 52);
            this.labelSourceHwAddress.Name = "labelSourceHwAddress";
            this.labelSourceHwAddress.Size = new System.Drawing.Size(44, 13);
            this.labelSourceHwAddress.TabIndex = 10;
            this.labelSourceHwAddress.Text = "Source:";
            // 
            // labelDestinationHwAddress
            // 
            this.labelDestinationHwAddress.AutoSize = true;
            this.labelDestinationHwAddress.Location = new System.Drawing.Point(12, 26);
            this.labelDestinationHwAddress.Name = "labelDestinationHwAddress";
            this.labelDestinationHwAddress.Size = new System.Drawing.Size(63, 13);
            this.labelDestinationHwAddress.TabIndex = 8;
            this.labelDestinationHwAddress.Text = "Destination:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EthernetHeaderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxEthernetHeader);
            this.Name = "EthernetHeaderUserControl";
            this.Size = new System.Drawing.Size(288, 113);
            this.groupBoxEthernetHeader.ResumeLayout(false);
            this.groupBoxEthernetHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEthernetHeader;
        private System.Windows.Forms.ComboBox comboBoxEthernetProtocols;
        private System.Windows.Forms.TextBox textBoxSourceHwAddress;
        private System.Windows.Forms.TextBox textBoxDestinationHwAddress;
        private System.Windows.Forms.Label labelEthernetProtocol;
        private System.Windows.Forms.Label labelSourceHwAddress;
        private System.Windows.Forms.Label labelDestinationHwAddress;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
