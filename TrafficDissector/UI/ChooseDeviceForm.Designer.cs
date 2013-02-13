namespace TrafficDissector.UI
{
    partial class ChooseDeviceForm
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
            this.groupBoxChooseDevice = new System.Windows.Forms.GroupBox();
            this.tabControlDeviceProperties = new System.Windows.Forms.TabControl();
            this.tabPageDeviceProperties = new System.Windows.Forms.TabPage();
            this.richTextBoxDeviceProperties = new System.Windows.Forms.RichTextBox();
            this.tabPageDeviceStatistics = new System.Windows.Forms.TabPage();
            this.richTextBoxDeviceStatistics = new System.Windows.Forms.RichTextBox();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxChooseDevice.SuspendLayout();
            this.tabControlDeviceProperties.SuspendLayout();
            this.tabPageDeviceProperties.SuspendLayout();
            this.tabPageDeviceStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxChooseDevice
            // 
            this.groupBoxChooseDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxChooseDevice.Controls.Add(this.tabControlDeviceProperties);
            this.groupBoxChooseDevice.Controls.Add(this.comboBoxDevices);
            this.groupBoxChooseDevice.Location = new System.Drawing.Point(12, 12);
            this.groupBoxChooseDevice.Name = "groupBoxChooseDevice";
            this.groupBoxChooseDevice.Size = new System.Drawing.Size(557, 296);
            this.groupBoxChooseDevice.TabIndex = 0;
            this.groupBoxChooseDevice.TabStop = false;
            this.groupBoxChooseDevice.Text = "Choose device";
            // 
            // tabControlDeviceProperties
            // 
            this.tabControlDeviceProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlDeviceProperties.Controls.Add(this.tabPageDeviceProperties);
            this.tabControlDeviceProperties.Controls.Add(this.tabPageDeviceStatistics);
            this.tabControlDeviceProperties.Location = new System.Drawing.Point(6, 64);
            this.tabControlDeviceProperties.Name = "tabControlDeviceProperties";
            this.tabControlDeviceProperties.SelectedIndex = 0;
            this.tabControlDeviceProperties.Size = new System.Drawing.Size(545, 226);
            this.tabControlDeviceProperties.TabIndex = 2;
            // 
            // tabPageDeviceProperties
            // 
            this.tabPageDeviceProperties.Controls.Add(this.richTextBoxDeviceProperties);
            this.tabPageDeviceProperties.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeviceProperties.Name = "tabPageDeviceProperties";
            this.tabPageDeviceProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeviceProperties.Size = new System.Drawing.Size(537, 200);
            this.tabPageDeviceProperties.TabIndex = 0;
            this.tabPageDeviceProperties.Text = "Properties";
            this.tabPageDeviceProperties.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDeviceProperties
            // 
            this.richTextBoxDeviceProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDeviceProperties.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDeviceProperties.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxDeviceProperties.Name = "richTextBoxDeviceProperties";
            this.richTextBoxDeviceProperties.ReadOnly = true;
            this.richTextBoxDeviceProperties.Size = new System.Drawing.Size(531, 194);
            this.richTextBoxDeviceProperties.TabIndex = 1;
            this.richTextBoxDeviceProperties.Text = "";
            // 
            // tabPageDeviceStatistics
            // 
            this.tabPageDeviceStatistics.Controls.Add(this.richTextBoxDeviceStatistics);
            this.tabPageDeviceStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeviceStatistics.Name = "tabPageDeviceStatistics";
            this.tabPageDeviceStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeviceStatistics.Size = new System.Drawing.Size(537, 200);
            this.tabPageDeviceStatistics.TabIndex = 1;
            this.tabPageDeviceStatistics.Text = "Statistics";
            this.tabPageDeviceStatistics.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDeviceStatistics
            // 
            this.richTextBoxDeviceStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDeviceStatistics.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDeviceStatistics.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxDeviceStatistics.Name = "richTextBoxDeviceStatistics";
            this.richTextBoxDeviceStatistics.ReadOnly = true;
            this.richTextBoxDeviceStatistics.Size = new System.Drawing.Size(531, 194);
            this.richTextBoxDeviceStatistics.TabIndex = 0;
            this.richTextBoxDeviceStatistics.Text = "";
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(6, 25);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(545, 21);
            this.comboBoxDevices.TabIndex = 0;
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Location = new System.Drawing.Point(413, 314);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(494, 314);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonStart.Location = new System.Drawing.Point(332, 314);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // ChooseDeviceForm
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(581, 349);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.groupBoxChooseDevice);
            this.MinimumSize = new System.Drawing.Size(589, 383);
            this.Name = "ChooseDeviceForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Devices";
            this.groupBoxChooseDevice.ResumeLayout(false);
            this.tabControlDeviceProperties.ResumeLayout(false);
            this.tabPageDeviceProperties.ResumeLayout(false);
            this.tabPageDeviceStatistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxChooseDevice;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.RichTextBox richTextBoxDeviceProperties;
        private System.Windows.Forms.TabControl tabControlDeviceProperties;
        private System.Windows.Forms.TabPage tabPageDeviceProperties;
        private System.Windows.Forms.TabPage tabPageDeviceStatistics;
        private System.Windows.Forms.RichTextBox richTextBoxDeviceStatistics;
        private System.Windows.Forms.Button buttonStart;
    }
}