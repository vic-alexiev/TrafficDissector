namespace TrafficDissector.UI
{
    partial class DnsMXForm
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
            this.labelDomain = new System.Windows.Forms.Label();
            this.labelDnsServer = new System.Windows.Forms.Label();
            this.textBoxDomain = new System.Windows.Forms.TextBox();
            this.textBoxDnsServer = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.richTextBoxMXServers = new System.Windows.Forms.RichTextBox();
            this.labelMXServers = new System.Windows.Forms.Label();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(241, 234);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Location = new System.Drawing.Point(12, 45);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(46, 13);
            this.labelDomain.TabIndex = 2;
            this.labelDomain.Text = "Domain:";
            // 
            // labelDnsServer
            // 
            this.labelDnsServer.AutoSize = true;
            this.labelDnsServer.Location = new System.Drawing.Point(12, 19);
            this.labelDnsServer.Name = "labelDnsServer";
            this.labelDnsServer.Size = new System.Drawing.Size(67, 13);
            this.labelDnsServer.TabIndex = 0;
            this.labelDnsServer.Text = "DNS Server:";
            // 
            // textBoxDomain
            // 
            this.textBoxDomain.Location = new System.Drawing.Point(85, 42);
            this.textBoxDomain.MaxLength = 100;
            this.textBoxDomain.Name = "textBoxDomain";
            this.textBoxDomain.Size = new System.Drawing.Size(124, 20);
            this.textBoxDomain.TabIndex = 3;
            // 
            // textBoxDnsServer
            // 
            this.textBoxDnsServer.Location = new System.Drawing.Point(85, 16);
            this.textBoxDnsServer.MaxLength = 100;
            this.textBoxDnsServer.Name = "textBoxDnsServer";
            this.textBoxDnsServer.Size = new System.Drawing.Size(124, 20);
            this.textBoxDnsServer.TabIndex = 1;
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFind.Location = new System.Drawing.Point(241, 40);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // richTextBoxMXServers
            // 
            this.richTextBoxMXServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxMXServers.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxMXServers.Location = new System.Drawing.Point(85, 87);
            this.richTextBoxMXServers.Name = "richTextBoxMXServers";
            this.richTextBoxMXServers.ReadOnly = true;
            this.richTextBoxMXServers.Size = new System.Drawing.Size(231, 141);
            this.richTextBoxMXServers.TabIndex = 7;
            this.richTextBoxMXServers.Text = "";
            // 
            // labelMXServers
            // 
            this.labelMXServers.AutoSize = true;
            this.labelMXServers.Location = new System.Drawing.Point(12, 90);
            this.labelMXServers.Name = "labelMXServers";
            this.labelMXServers.Size = new System.Drawing.Size(65, 13);
            this.labelMXServers.TabIndex = 6;
            this.labelMXServers.Text = "MX Servers:";
            // 
            // labelSeparator
            // 
            this.labelSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator.Location = new System.Drawing.Point(15, 70);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(301, 2);
            this.labelSeparator.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DnsMXForm
            // 
            this.AcceptButton = this.buttonFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(328, 269);
            this.Controls.Add(this.labelSeparator);
            this.Controls.Add(this.labelMXServers);
            this.Controls.Add(this.richTextBoxMXServers);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.labelDomain);
            this.Controls.Add(this.labelDnsServer);
            this.Controls.Add(this.textBoxDomain);
            this.Controls.Add(this.textBoxDnsServer);
            this.Controls.Add(this.buttonClose);
            this.MinimumSize = new System.Drawing.Size(336, 303);
            this.Name = "DnsMXForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNS MX";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.Label labelDnsServer;
        private System.Windows.Forms.TextBox textBoxDomain;
        private System.Windows.Forms.TextBox textBoxDnsServer;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.RichTextBox richTextBoxMXServers;
        private System.Windows.Forms.Label labelMXServers;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}