namespace TrafficDissector.UI
{
    partial class DetailedSummaryForm
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
            this.richTextBoxUdpStatistics = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabControlStatistics = new System.Windows.Forms.TabControl();
            this.tabPageIPGlobalStatistics = new System.Windows.Forms.TabPage();
            this.richTextBoxIPGlobalStatistics = new System.Windows.Forms.RichTextBox();
            this.tabPageIcmpStatistics = new System.Windows.Forms.TabPage();
            this.richTextBoxIcmpStatistics = new System.Windows.Forms.RichTextBox();
            this.tabPageTcpStatistics = new System.Windows.Forms.TabPage();
            this.richTextBoxTcpStatistics = new System.Windows.Forms.RichTextBox();
            this.tabPageUdpStatistics = new System.Windows.Forms.TabPage();
            this.tabControlStatistics.SuspendLayout();
            this.tabPageIPGlobalStatistics.SuspendLayout();
            this.tabPageIcmpStatistics.SuspendLayout();
            this.tabPageTcpStatistics.SuspendLayout();
            this.tabPageUdpStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxUdpStatistics
            // 
            this.richTextBoxUdpStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxUdpStatistics.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxUdpStatistics.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxUdpStatistics.Name = "richTextBoxUdpStatistics";
            this.richTextBoxUdpStatistics.ReadOnly = true;
            this.richTextBoxUdpStatistics.Size = new System.Drawing.Size(472, 300);
            this.richTextBoxUdpStatistics.TabIndex = 0;
            this.richTextBoxUdpStatistics.Text = "";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(423, 350);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // tabControlStatistics
            // 
            this.tabControlStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlStatistics.Controls.Add(this.tabPageIPGlobalStatistics);
            this.tabControlStatistics.Controls.Add(this.tabPageIcmpStatistics);
            this.tabControlStatistics.Controls.Add(this.tabPageTcpStatistics);
            this.tabControlStatistics.Controls.Add(this.tabPageUdpStatistics);
            this.tabControlStatistics.Location = new System.Drawing.Point(12, 12);
            this.tabControlStatistics.Name = "tabControlStatistics";
            this.tabControlStatistics.SelectedIndex = 0;
            this.tabControlStatistics.Size = new System.Drawing.Size(486, 332);
            this.tabControlStatistics.TabIndex = 2;
            // 
            // tabPageIPGlobalStatistics
            // 
            this.tabPageIPGlobalStatistics.Controls.Add(this.richTextBoxIPGlobalStatistics);
            this.tabPageIPGlobalStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPageIPGlobalStatistics.Name = "tabPageIPGlobalStatistics";
            this.tabPageIPGlobalStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIPGlobalStatistics.Size = new System.Drawing.Size(478, 306);
            this.tabPageIPGlobalStatistics.TabIndex = 2;
            this.tabPageIPGlobalStatistics.Text = "IP Global Statistics";
            this.tabPageIPGlobalStatistics.UseVisualStyleBackColor = true;
            // 
            // richTextBoxIPGlobalStatistics
            // 
            this.richTextBoxIPGlobalStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxIPGlobalStatistics.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxIPGlobalStatistics.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxIPGlobalStatistics.Name = "richTextBoxIPGlobalStatistics";
            this.richTextBoxIPGlobalStatistics.ReadOnly = true;
            this.richTextBoxIPGlobalStatistics.Size = new System.Drawing.Size(472, 300);
            this.richTextBoxIPGlobalStatistics.TabIndex = 0;
            this.richTextBoxIPGlobalStatistics.Text = "";
            // 
            // tabPageIcmpStatistics
            // 
            this.tabPageIcmpStatistics.Controls.Add(this.richTextBoxIcmpStatistics);
            this.tabPageIcmpStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPageIcmpStatistics.Name = "tabPageIcmpStatistics";
            this.tabPageIcmpStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIcmpStatistics.Size = new System.Drawing.Size(478, 306);
            this.tabPageIcmpStatistics.TabIndex = 3;
            this.tabPageIcmpStatistics.Text = "ICMP Statistics";
            this.tabPageIcmpStatistics.UseVisualStyleBackColor = true;
            // 
            // richTextBoxIcmpStatistics
            // 
            this.richTextBoxIcmpStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxIcmpStatistics.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxIcmpStatistics.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxIcmpStatistics.Name = "richTextBoxIcmpStatistics";
            this.richTextBoxIcmpStatistics.ReadOnly = true;
            this.richTextBoxIcmpStatistics.Size = new System.Drawing.Size(472, 300);
            this.richTextBoxIcmpStatistics.TabIndex = 0;
            this.richTextBoxIcmpStatistics.Text = "";
            // 
            // tabPageTcpStatistics
            // 
            this.tabPageTcpStatistics.Controls.Add(this.richTextBoxTcpStatistics);
            this.tabPageTcpStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPageTcpStatistics.Name = "tabPageTcpStatistics";
            this.tabPageTcpStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTcpStatistics.Size = new System.Drawing.Size(478, 306);
            this.tabPageTcpStatistics.TabIndex = 1;
            this.tabPageTcpStatistics.Text = "TCP Statistics";
            this.tabPageTcpStatistics.UseVisualStyleBackColor = true;
            // 
            // richTextBoxTcpStatistics
            // 
            this.richTextBoxTcpStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxTcpStatistics.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxTcpStatistics.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxTcpStatistics.Name = "richTextBoxTcpStatistics";
            this.richTextBoxTcpStatistics.ReadOnly = true;
            this.richTextBoxTcpStatistics.Size = new System.Drawing.Size(472, 300);
            this.richTextBoxTcpStatistics.TabIndex = 0;
            this.richTextBoxTcpStatistics.Text = "";
            // 
            // tabPageUdpStatistics
            // 
            this.tabPageUdpStatistics.Controls.Add(this.richTextBoxUdpStatistics);
            this.tabPageUdpStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPageUdpStatistics.Name = "tabPageUdpStatistics";
            this.tabPageUdpStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUdpStatistics.Size = new System.Drawing.Size(478, 306);
            this.tabPageUdpStatistics.TabIndex = 0;
            this.tabPageUdpStatistics.Text = "UDP Statistics";
            this.tabPageUdpStatistics.UseVisualStyleBackColor = true;
            // 
            // DetailedSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(510, 385);
            this.Controls.Add(this.tabControlStatistics);
            this.Controls.Add(this.buttonClose);
            this.MinimumSize = new System.Drawing.Size(418, 335);
            this.Name = "DetailedSummaryForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detailed Summary";
            this.tabControlStatistics.ResumeLayout(false);
            this.tabPageIPGlobalStatistics.ResumeLayout(false);
            this.tabPageIcmpStatistics.ResumeLayout(false);
            this.tabPageTcpStatistics.ResumeLayout(false);
            this.tabPageUdpStatistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxUdpStatistics;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabControl tabControlStatistics;
        private System.Windows.Forms.TabPage tabPageUdpStatistics;
        private System.Windows.Forms.TabPage tabPageTcpStatistics;
        private System.Windows.Forms.RichTextBox richTextBoxTcpStatistics;
        private System.Windows.Forms.TabPage tabPageIPGlobalStatistics;
        private System.Windows.Forms.RichTextBox richTextBoxIPGlobalStatistics;
        private System.Windows.Forms.TabPage tabPageIcmpStatistics;
        private System.Windows.Forms.RichTextBox richTextBoxIcmpStatistics;
    }
}