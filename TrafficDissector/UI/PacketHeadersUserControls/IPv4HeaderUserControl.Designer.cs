namespace TrafficDissector.UI.PacketHeadersUserControls
{
    partial class IPv4HeaderUserControl
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
            this.groupBoxIPv4Header = new System.Windows.Forms.GroupBox();
            this.textBoxDS = new System.Windows.Forms.TextBox();
            this.labelDS = new System.Windows.Forms.Label();
            this.comboBoxIPProtocols = new System.Windows.Forms.ComboBox();
            this.textBoxTotalLength = new System.Windows.Forms.TextBox();
            this.labelTotalLength = new System.Windows.Forms.Label();
            this.textBoxFlags = new System.Windows.Forms.TextBox();
            this.labelFlags = new System.Windows.Forms.Label();
            this.labelProtocol = new System.Windows.Forms.Label();
            this.textBoxTTL = new System.Windows.Forms.TextBox();
            this.labelTTL = new System.Windows.Forms.Label();
            this.textBoxDestinationAddress = new System.Windows.Forms.TextBox();
            this.textBoxSourceAddress = new System.Windows.Forms.TextBox();
            this.labelDestinationAddress = new System.Windows.Forms.Label();
            this.labelSourceAddress = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxIPv4Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIPv4Header
            // 
            this.groupBoxIPv4Header.Controls.Add(this.textBoxDS);
            this.groupBoxIPv4Header.Controls.Add(this.labelDS);
            this.groupBoxIPv4Header.Controls.Add(this.comboBoxIPProtocols);
            this.groupBoxIPv4Header.Controls.Add(this.textBoxTotalLength);
            this.groupBoxIPv4Header.Controls.Add(this.labelTotalLength);
            this.groupBoxIPv4Header.Controls.Add(this.textBoxFlags);
            this.groupBoxIPv4Header.Controls.Add(this.labelFlags);
            this.groupBoxIPv4Header.Controls.Add(this.labelProtocol);
            this.groupBoxIPv4Header.Controls.Add(this.textBoxTTL);
            this.groupBoxIPv4Header.Controls.Add(this.labelTTL);
            this.groupBoxIPv4Header.Controls.Add(this.textBoxDestinationAddress);
            this.groupBoxIPv4Header.Controls.Add(this.textBoxSourceAddress);
            this.groupBoxIPv4Header.Controls.Add(this.labelDestinationAddress);
            this.groupBoxIPv4Header.Controls.Add(this.labelSourceAddress);
            this.groupBoxIPv4Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIPv4Header.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIPv4Header.Name = "groupBoxIPv4Header";
            this.groupBoxIPv4Header.Size = new System.Drawing.Size(317, 165);
            this.groupBoxIPv4Header.TabIndex = 12;
            this.groupBoxIPv4Header.TabStop = false;
            this.groupBoxIPv4Header.Text = "IPv4 header";
            // 
            // textBoxDS
            // 
            this.textBoxDS.Location = new System.Drawing.Point(91, 23);
            this.textBoxDS.MaxLength = 3;
            this.textBoxDS.Name = "textBoxDS";
            this.textBoxDS.Size = new System.Drawing.Size(65, 20);
            this.textBoxDS.TabIndex = 14;
            // 
            // labelDS
            // 
            this.labelDS.AutoSize = true;
            this.labelDS.Location = new System.Drawing.Point(12, 26);
            this.labelDS.Name = "labelDS";
            this.labelDS.Size = new System.Drawing.Size(73, 13);
            this.labelDS.TabIndex = 13;
            this.labelDS.Text = "Diff. Services:";
            // 
            // comboBoxIPProtocols
            // 
            this.comboBoxIPProtocols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIPProtocols.FormattingEnabled = true;
            this.comboBoxIPProtocols.Location = new System.Drawing.Point(91, 75);
            this.comboBoxIPProtocols.Name = "comboBoxIPProtocols";
            this.comboBoxIPProtocols.Size = new System.Drawing.Size(210, 21);
            this.comboBoxIPProtocols.Sorted = true;
            this.comboBoxIPProtocols.TabIndex = 12;
            // 
            // textBoxTotalLength
            // 
            this.textBoxTotalLength.Location = new System.Drawing.Point(236, 23);
            this.textBoxTotalLength.MaxLength = 5;
            this.textBoxTotalLength.Name = "textBoxTotalLength";
            this.textBoxTotalLength.Size = new System.Drawing.Size(65, 20);
            this.textBoxTotalLength.TabIndex = 11;
            // 
            // labelTotalLength
            // 
            this.labelTotalLength.AutoSize = true;
            this.labelTotalLength.Location = new System.Drawing.Point(163, 26);
            this.labelTotalLength.Name = "labelTotalLength";
            this.labelTotalLength.Size = new System.Drawing.Size(66, 13);
            this.labelTotalLength.TabIndex = 10;
            this.labelTotalLength.Text = "Total length:";
            // 
            // textBoxFlags
            // 
            this.textBoxFlags.Location = new System.Drawing.Point(91, 49);
            this.textBoxFlags.MaxLength = 1;
            this.textBoxFlags.Name = "textBoxFlags";
            this.textBoxFlags.Size = new System.Drawing.Size(65, 20);
            this.textBoxFlags.TabIndex = 9;
            // 
            // labelFlags
            // 
            this.labelFlags.AutoSize = true;
            this.labelFlags.Location = new System.Drawing.Point(12, 52);
            this.labelFlags.Name = "labelFlags";
            this.labelFlags.Size = new System.Drawing.Size(35, 13);
            this.labelFlags.TabIndex = 8;
            this.labelFlags.Text = "Flags:";
            // 
            // labelProtocol
            // 
            this.labelProtocol.AutoSize = true;
            this.labelProtocol.Location = new System.Drawing.Point(12, 78);
            this.labelProtocol.Name = "labelProtocol";
            this.labelProtocol.Size = new System.Drawing.Size(49, 13);
            this.labelProtocol.TabIndex = 6;
            this.labelProtocol.Text = "Protocol:";
            // 
            // textBoxTTL
            // 
            this.textBoxTTL.Location = new System.Drawing.Point(236, 49);
            this.textBoxTTL.MaxLength = 3;
            this.textBoxTTL.Name = "textBoxTTL";
            this.textBoxTTL.Size = new System.Drawing.Size(65, 20);
            this.textBoxTTL.TabIndex = 5;
            // 
            // labelTTL
            // 
            this.labelTTL.AutoSize = true;
            this.labelTTL.Location = new System.Drawing.Point(163, 52);
            this.labelTTL.Name = "labelTTL";
            this.labelTTL.Size = new System.Drawing.Size(64, 13);
            this.labelTTL.TabIndex = 4;
            this.labelTTL.Text = "Time to live:";
            // 
            // textBoxDestinationAddress
            // 
            this.textBoxDestinationAddress.Location = new System.Drawing.Point(91, 128);
            this.textBoxDestinationAddress.MaxLength = 15;
            this.textBoxDestinationAddress.Name = "textBoxDestinationAddress";
            this.textBoxDestinationAddress.Size = new System.Drawing.Size(103, 20);
            this.textBoxDestinationAddress.TabIndex = 3;
            // 
            // textBoxSourceAddress
            // 
            this.textBoxSourceAddress.Location = new System.Drawing.Point(91, 102);
            this.textBoxSourceAddress.MaxLength = 15;
            this.textBoxSourceAddress.Name = "textBoxSourceAddress";
            this.textBoxSourceAddress.Size = new System.Drawing.Size(103, 20);
            this.textBoxSourceAddress.TabIndex = 2;
            // 
            // labelDestinationAddress
            // 
            this.labelDestinationAddress.AutoSize = true;
            this.labelDestinationAddress.Location = new System.Drawing.Point(12, 131);
            this.labelDestinationAddress.Name = "labelDestinationAddress";
            this.labelDestinationAddress.Size = new System.Drawing.Size(66, 13);
            this.labelDestinationAddress.TabIndex = 1;
            this.labelDestinationAddress.Text = "Dst address:";
            // 
            // labelSourceAddress
            // 
            this.labelSourceAddress.AutoSize = true;
            this.labelSourceAddress.Location = new System.Drawing.Point(12, 105);
            this.labelSourceAddress.Name = "labelSourceAddress";
            this.labelSourceAddress.Size = new System.Drawing.Size(66, 13);
            this.labelSourceAddress.TabIndex = 0;
            this.labelSourceAddress.Text = "Src address:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // IPv4HeaderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxIPv4Header);
            this.Name = "IPv4HeaderUserControl";
            this.Size = new System.Drawing.Size(317, 165);
            this.groupBoxIPv4Header.ResumeLayout(false);
            this.groupBoxIPv4Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIPv4Header;
        private System.Windows.Forms.TextBox textBoxDS;
        private System.Windows.Forms.Label labelDS;
        private System.Windows.Forms.ComboBox comboBoxIPProtocols;
        private System.Windows.Forms.TextBox textBoxTotalLength;
        private System.Windows.Forms.Label labelTotalLength;
        private System.Windows.Forms.TextBox textBoxFlags;
        private System.Windows.Forms.Label labelFlags;
        private System.Windows.Forms.Label labelProtocol;
        private System.Windows.Forms.TextBox textBoxTTL;
        private System.Windows.Forms.Label labelTTL;
        private System.Windows.Forms.TextBox textBoxDestinationAddress;
        private System.Windows.Forms.TextBox textBoxSourceAddress;
        private System.Windows.Forms.Label labelDestinationAddress;
        private System.Windows.Forms.Label labelSourceAddress;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
