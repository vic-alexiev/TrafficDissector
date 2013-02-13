namespace TrafficDissector.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailedSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injectPacketsFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injectPacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injectIPv4PacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injectTCPPacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injectUDPPacketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dnsMXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteCommandLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portScannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPacketsInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelFilter = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxFilters = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonApply = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFirst = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLast = new System.Windows.Forms.ToolStripButton();
            this.splitContainerCapturedPackets = new System.Windows.Forms.SplitContainer();
            this.listViewPackets = new System.Windows.Forms.ListView();
            this.columnHeaderNumber = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSource = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSourceName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSourcePort = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDestination = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDestinationName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDestinationPort = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderProtocol = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderInfo = new System.Windows.Forms.ColumnHeader();
            this.splitContainerPacketInfo = new System.Windows.Forms.SplitContainer();
            this.treeViewPacketInfo = new System.Windows.Forms.TreeView();
            this.dataGridViewPacketData = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAscii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openCaptureFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripSeparatorQuit = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.splitContainerCapturedPackets.Panel1.SuspendLayout();
            this.splitContainerCapturedPackets.Panel2.SuspendLayout();
            this.splitContainerCapturedPackets.SuspendLayout();
            this.splitContainerPacketInfo.Panel1.SuspendLayout();
            this.splitContainerPacketInfo.Panel2.SuspendLayout();
            this.splitContainerPacketInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacketData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.captureToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.injectionToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(916, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparatorQuit,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFileToolStripMenuItem.Text = "Open...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit ";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devicesToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.captureToolStripMenuItem.Text = "Capture";
            // 
            // devicesToolStripMenuItem
            // 
            this.devicesToolStripMenuItem.Name = "devicesToolStripMenuItem";
            this.devicesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.devicesToolStripMenuItem.Text = "Devices...";
            this.devicesToolStripMenuItem.Click += new System.EventHandler(this.devicesToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Enabled = false;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.detailedSummaryToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Enabled = false;
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // detailedSummaryToolStripMenuItem
            // 
            this.detailedSummaryToolStripMenuItem.Name = "detailedSummaryToolStripMenuItem";
            this.detailedSummaryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.detailedSummaryToolStripMenuItem.Text = "Detailed Summary";
            this.detailedSummaryToolStripMenuItem.Click += new System.EventHandler(this.detailedSummaryToolStripMenuItem_Click);
            // 
            // injectionToolStripMenuItem
            // 
            this.injectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.injectPacketsFromFileToolStripMenuItem,
            this.injectPacketToolStripMenuItem,
            this.injectIPv4PacketToolStripMenuItem,
            this.injectTCPPacketToolStripMenuItem,
            this.injectUDPPacketToolStripMenuItem});
            this.injectionToolStripMenuItem.Name = "injectionToolStripMenuItem";
            this.injectionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.injectionToolStripMenuItem.Text = "Injection";
            // 
            // injectPacketsFromFileToolStripMenuItem
            // 
            this.injectPacketsFromFileToolStripMenuItem.Name = "injectPacketsFromFileToolStripMenuItem";
            this.injectPacketsFromFileToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.injectPacketsFromFileToolStripMenuItem.Text = "Inject packets from file";
            this.injectPacketsFromFileToolStripMenuItem.Click += new System.EventHandler(this.injectPacketsFromFileToolStripMenuItem_Click);
            // 
            // injectPacketToolStripMenuItem
            // 
            this.injectPacketToolStripMenuItem.Name = "injectPacketToolStripMenuItem";
            this.injectPacketToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.injectPacketToolStripMenuItem.Text = "Inject Ethernet packet";
            this.injectPacketToolStripMenuItem.Click += new System.EventHandler(this.injectEthernetPacketToolStripMenuItem_Click);
            // 
            // injectIPv4PacketToolStripMenuItem
            // 
            this.injectIPv4PacketToolStripMenuItem.Name = "injectIPv4PacketToolStripMenuItem";
            this.injectIPv4PacketToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.injectIPv4PacketToolStripMenuItem.Text = "Inject IPv4 packet";
            this.injectIPv4PacketToolStripMenuItem.Click += new System.EventHandler(this.injectIPv4PacketToolStripMenuItem_Click);
            // 
            // injectTCPPacketToolStripMenuItem
            // 
            this.injectTCPPacketToolStripMenuItem.Name = "injectTCPPacketToolStripMenuItem";
            this.injectTCPPacketToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.injectTCPPacketToolStripMenuItem.Text = "Inject TCP packet";
            this.injectTCPPacketToolStripMenuItem.Click += new System.EventHandler(this.injectTCPPacketToolStripMenuItem_Click);
            // 
            // injectUDPPacketToolStripMenuItem
            // 
            this.injectUDPPacketToolStripMenuItem.Name = "injectUDPPacketToolStripMenuItem";
            this.injectUDPPacketToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.injectUDPPacketToolStripMenuItem.Text = "Inject UDP packet";
            this.injectUDPPacketToolStripMenuItem.Click += new System.EventHandler(this.injectUDPPacketToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dnsMXToolStripMenuItem,
            this.pingToolStripMenuItem,
            this.whoisToolStripMenuItem,
            this.wqlToolStripMenuItem,
            this.remoteCommandLineToolStripMenuItem,
            this.portScannerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // dnsMXToolStripMenuItem
            // 
            this.dnsMXToolStripMenuItem.Name = "dnsMXToolStripMenuItem";
            this.dnsMXToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.dnsMXToolStripMenuItem.Text = "DNS MX";
            this.dnsMXToolStripMenuItem.Click += new System.EventHandler(this.dnsMXToolStripMenuItem_Click);
            // 
            // pingToolStripMenuItem
            // 
            this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            this.pingToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pingToolStripMenuItem.Text = "Ping";
            this.pingToolStripMenuItem.Click += new System.EventHandler(this.pingToolStripMenuItem_Click);
            // 
            // whoisToolStripMenuItem
            // 
            this.whoisToolStripMenuItem.Name = "whoisToolStripMenuItem";
            this.whoisToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.whoisToolStripMenuItem.Text = "WHOIS";
            this.whoisToolStripMenuItem.Click += new System.EventHandler(this.whoisToolStripMenuItem_Click);
            // 
            // wqlToolStripMenuItem
            // 
            this.wqlToolStripMenuItem.Name = "wqlToolStripMenuItem";
            this.wqlToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.wqlToolStripMenuItem.Text = "WQL Query Analyzer";
            this.wqlToolStripMenuItem.Click += new System.EventHandler(this.wqlToolStripMenuItem_Click);
            // 
            // remoteCommandLineToolStripMenuItem
            // 
            this.remoteCommandLineToolStripMenuItem.Name = "remoteCommandLineToolStripMenuItem";
            this.remoteCommandLineToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.remoteCommandLineToolStripMenuItem.Text = "Remote Command Line";
            this.remoteCommandLineToolStripMenuItem.Click += new System.EventHandler(this.remoteCommandLineToolStripMenuItem_Click);
            // 
            // portScannerToolStripMenuItem
            // 
            this.portScannerToolStripMenuItem.Name = "portScannerToolStripMenuItem";
            this.portScannerToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.portScannerToolStripMenuItem.Text = "Port Scanner";
            this.portScannerToolStripMenuItem.Click += new System.EventHandler(this.portScannerToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelState,
            this.toolStripStatusLabelPacketsInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 589);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(916, 22);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabelState
            // 
            this.toolStripStatusLabelState.Name = "toolStripStatusLabelState";
            this.toolStripStatusLabelState.Size = new System.Drawing.Size(127, 17);
            this.toolStripStatusLabelState.Text = "Ready to load or capture";
            // 
            // toolStripStatusLabelPacketsInfo
            // 
            this.toolStripStatusLabelPacketsInfo.Name = "toolStripStatusLabelPacketsInfo";
            this.toolStripStatusLabelPacketsInfo.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabelPacketsInfo.Text = "|No packets";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelFilter,
            this.toolStripComboBoxFilters,
            this.toolStripButtonApply,
            this.toolStripSeparator,
            this.toolStripButtonFirst,
            this.toolStripButtonLast});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(916, 25);
            this.toolStrip.TabIndex = 3;
            // 
            // toolStripLabelFilter
            // 
            this.toolStripLabelFilter.Name = "toolStripLabelFilter";
            this.toolStripLabelFilter.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabelFilter.Text = "Filter:";
            // 
            // toolStripComboBoxFilters
            // 
            this.toolStripComboBoxFilters.Name = "toolStripComboBoxFilters";
            this.toolStripComboBoxFilters.Size = new System.Drawing.Size(201, 25);
            // 
            // toolStripButtonApply
            // 
            this.toolStripButtonApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonApply.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonApply.Image")));
            this.toolStripButtonApply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonApply.Name = "toolStripButtonApply";
            this.toolStripButtonApply.Size = new System.Drawing.Size(38, 22);
            this.toolStripButtonApply.Text = "Apply";
            this.toolStripButtonApply.Click += new System.EventHandler(this.toolStripButtonApply_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonFirst
            // 
            this.toolStripButtonFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFirst.Enabled = false;
            this.toolStripButtonFirst.Image = global::TrafficDissector.Properties.Resources.GoToFirstPacket;
            this.toolStripButtonFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFirst.Name = "toolStripButtonFirst";
            this.toolStripButtonFirst.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFirst.ToolTipText = "Go to the first packet";
            this.toolStripButtonFirst.Click += new System.EventHandler(this.toolStripButtonFirst_Click);
            // 
            // toolStripButtonLast
            // 
            this.toolStripButtonLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLast.Enabled = false;
            this.toolStripButtonLast.Image = global::TrafficDissector.Properties.Resources.GoToLastPacket;
            this.toolStripButtonLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLast.Name = "toolStripButtonLast";
            this.toolStripButtonLast.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLast.ToolTipText = "Go to the last packet";
            this.toolStripButtonLast.Click += new System.EventHandler(this.toolStripButtonLast_Click);
            // 
            // splitContainerCapturedPackets
            // 
            this.splitContainerCapturedPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCapturedPackets.Location = new System.Drawing.Point(0, 49);
            this.splitContainerCapturedPackets.Name = "splitContainerCapturedPackets";
            this.splitContainerCapturedPackets.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerCapturedPackets.Panel1
            // 
            this.splitContainerCapturedPackets.Panel1.Controls.Add(this.listViewPackets);
            // 
            // splitContainerCapturedPackets.Panel2
            // 
            this.splitContainerCapturedPackets.Panel2.Controls.Add(this.splitContainerPacketInfo);
            this.splitContainerCapturedPackets.Size = new System.Drawing.Size(916, 540);
            this.splitContainerCapturedPackets.SplitterDistance = 270;
            this.splitContainerCapturedPackets.TabIndex = 4;
            // 
            // listViewPackets
            // 
            this.listViewPackets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNumber,
            this.columnHeaderSource,
            this.columnHeaderSourceName,
            this.columnHeaderSourcePort,
            this.columnHeaderDestination,
            this.columnHeaderDestinationName,
            this.columnHeaderDestinationPort,
            this.columnHeaderProtocol,
            this.columnHeaderInfo});
            this.listViewPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPackets.FullRowSelect = true;
            this.listViewPackets.HideSelection = false;
            this.listViewPackets.Location = new System.Drawing.Point(0, 0);
            this.listViewPackets.MultiSelect = false;
            this.listViewPackets.Name = "listViewPackets";
            this.listViewPackets.Size = new System.Drawing.Size(916, 270);
            this.listViewPackets.TabIndex = 2;
            this.listViewPackets.UseCompatibleStateImageBehavior = false;
            this.listViewPackets.View = System.Windows.Forms.View.Details;
            this.listViewPackets.Resize += new System.EventHandler(this.listViewPackets_Resize);
            this.listViewPackets.SelectedIndexChanged += new System.EventHandler(this.listViewPackets_SelectedIndexChanged);
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "¹";
            this.columnHeaderNumber.Width = 40;
            // 
            // columnHeaderSource
            // 
            this.columnHeaderSource.Text = "Source";
            this.columnHeaderSource.Width = 100;
            // 
            // columnHeaderSourceName
            // 
            this.columnHeaderSourceName.Text = "Name";
            this.columnHeaderSourceName.Width = 110;
            // 
            // columnHeaderSourcePort
            // 
            this.columnHeaderSourcePort.Text = "Source Port";
            this.columnHeaderSourcePort.Width = 80;
            // 
            // columnHeaderDestination
            // 
            this.columnHeaderDestination.Text = "Destination";
            this.columnHeaderDestination.Width = 100;
            // 
            // columnHeaderDestinationName
            // 
            this.columnHeaderDestinationName.Text = "Name";
            this.columnHeaderDestinationName.Width = 110;
            // 
            // columnHeaderDestinationPort
            // 
            this.columnHeaderDestinationPort.Text = "Dest. Port";
            this.columnHeaderDestinationPort.Width = 80;
            // 
            // columnHeaderProtocol
            // 
            this.columnHeaderProtocol.Text = "Protocol";
            // 
            // columnHeaderInfo
            // 
            this.columnHeaderInfo.Text = "Info";
            this.columnHeaderInfo.Width = 231;
            // 
            // splitContainerPacketInfo
            // 
            this.splitContainerPacketInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPacketInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPacketInfo.Name = "splitContainerPacketInfo";
            // 
            // splitContainerPacketInfo.Panel1
            // 
            this.splitContainerPacketInfo.Panel1.Controls.Add(this.treeViewPacketInfo);
            // 
            // splitContainerPacketInfo.Panel2
            // 
            this.splitContainerPacketInfo.Panel2.Controls.Add(this.dataGridViewPacketData);
            this.splitContainerPacketInfo.Size = new System.Drawing.Size(916, 266);
            this.splitContainerPacketInfo.SplitterDistance = 379;
            this.splitContainerPacketInfo.TabIndex = 1;
            // 
            // treeViewPacketInfo
            // 
            this.treeViewPacketInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewPacketInfo.Location = new System.Drawing.Point(0, 0);
            this.treeViewPacketInfo.Name = "treeViewPacketInfo";
            this.treeViewPacketInfo.ShowLines = false;
            this.treeViewPacketInfo.Size = new System.Drawing.Size(379, 266);
            this.treeViewPacketInfo.TabIndex = 0;
            // 
            // dataGridViewPacketData
            // 
            this.dataGridViewPacketData.AllowUserToAddRows = false;
            this.dataGridViewPacketData.AllowUserToDeleteRows = false;
            this.dataGridViewPacketData.AllowUserToResizeColumns = false;
            this.dataGridViewPacketData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            this.dataGridViewPacketData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPacketData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacketData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.ColumnA,
            this.ColumnB,
            this.ColumnC,
            this.ColumnD,
            this.ColumnE,
            this.ColumnF,
            this.ColumnAscii});
            this.dataGridViewPacketData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPacketData.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPacketData.Name = "dataGridViewPacketData";
            this.dataGridViewPacketData.ReadOnly = true;
            this.dataGridViewPacketData.RowHeadersWidth = 62;
            this.dataGridViewPacketData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPacketData.RowTemplate.Height = 20;
            this.dataGridViewPacketData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPacketData.Size = new System.Drawing.Size(533, 266);
            this.dataGridViewPacketData.TabIndex = 0;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "0";
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            this.Column0.Width = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 23;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 23;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 23;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 23;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 23;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 23;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 23;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 23;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 23;
            // 
            // ColumnA
            // 
            this.ColumnA.HeaderText = "A";
            this.ColumnA.Name = "ColumnA";
            this.ColumnA.ReadOnly = true;
            this.ColumnA.Width = 23;
            // 
            // ColumnB
            // 
            this.ColumnB.HeaderText = "B";
            this.ColumnB.Name = "ColumnB";
            this.ColumnB.ReadOnly = true;
            this.ColumnB.Width = 23;
            // 
            // ColumnC
            // 
            this.ColumnC.HeaderText = "C";
            this.ColumnC.Name = "ColumnC";
            this.ColumnC.ReadOnly = true;
            this.ColumnC.Width = 23;
            // 
            // ColumnD
            // 
            this.ColumnD.HeaderText = "D";
            this.ColumnD.Name = "ColumnD";
            this.ColumnD.ReadOnly = true;
            this.ColumnD.Width = 23;
            // 
            // ColumnE
            // 
            this.ColumnE.HeaderText = "E";
            this.ColumnE.Name = "ColumnE";
            this.ColumnE.ReadOnly = true;
            this.ColumnE.Width = 23;
            // 
            // ColumnF
            // 
            this.ColumnF.HeaderText = "F";
            this.ColumnF.Name = "ColumnF";
            this.ColumnF.ReadOnly = true;
            this.ColumnF.Width = 23;
            // 
            // ColumnAscii
            // 
            this.ColumnAscii.HeaderText = "ASCII";
            this.ColumnAscii.Name = "ColumnAscii";
            this.ColumnAscii.ReadOnly = true;
            // 
            // openCaptureFileDialog
            // 
            this.openCaptureFileDialog.DefaultExt = "pcap";
            this.openCaptureFileDialog.FileName = "*.pcap";
            this.openCaptureFileDialog.Filter = "Capture Files (*.pcap;*.cap)|*.pcap;*.cap|Text Documents (*.txt)|*.txt|All Files|" +
                "*.*";
            this.openCaptureFileDialog.SupportMultiDottedExtensions = true;
            this.openCaptureFileDialog.Title = "Select an output capture file";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "pcap";
            this.saveFileDialog.FileName = "*.pcap";
            this.saveFileDialog.Filter = "Capture Files (*.pcap;*.cap)|*.pcap;*.cap|Text Documents (*.txt)|*.txt|All Files|" +
                "*.*";
            this.saveFileDialog.SupportMultiDottedExtensions = true;
            this.saveFileDialog.Title = "Save As";
            // 
            // toolStripSeparatorQuit
            // 
            this.toolStripSeparatorQuit.Name = "toolStripSeparatorQuit";
            this.toolStripSeparatorQuit.Size = new System.Drawing.Size(149, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 611);
            this.Controls.Add(this.splitContainerCapturedPackets);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traffic Dissector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainerCapturedPackets.Panel1.ResumeLayout(false);
            this.splitContainerCapturedPackets.Panel2.ResumeLayout(false);
            this.splitContainerCapturedPackets.ResumeLayout(false);
            this.splitContainerPacketInfo.Panel1.ResumeLayout(false);
            this.splitContainerPacketInfo.Panel2.ResumeLayout(false);
            this.splitContainerPacketInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacketData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem devicesToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.SplitContainer splitContainerCapturedPackets;
        private System.Windows.Forms.ListView listViewPackets;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderSource;
        private System.Windows.Forms.ColumnHeader columnHeaderSourceName;
        private System.Windows.Forms.ColumnHeader columnHeaderSourcePort;
        private System.Windows.Forms.ColumnHeader columnHeaderDestination;
        private System.Windows.Forms.ColumnHeader columnHeaderDestinationName;
        private System.Windows.Forms.ColumnHeader columnHeaderDestinationPort;
        private System.Windows.Forms.ColumnHeader columnHeaderProtocol;
        private System.Windows.Forms.ColumnHeader columnHeaderInfo;
        private System.Windows.Forms.SplitContainer splitContainerPacketInfo;
        private System.Windows.Forms.TreeView treeViewPacketInfo;
        private System.Windows.Forms.DataGridView dataGridViewPacketData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAscii;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFilter;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFilters;
        private System.Windows.Forms.ToolStripButton toolStripButtonApply;
        private System.Windows.Forms.OpenFileDialog openCaptureFileDialog;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailedSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem injectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem injectPacketsFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem injectPacketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem injectIPv4PacketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem injectTCPPacketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem injectUDPPacketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteCommandLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPacketsInfo;
        private System.Windows.Forms.ToolStripButton toolStripButtonFirst;
        private System.Windows.Forms.ToolStripButton toolStripButtonLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portScannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dnsMXToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorQuit;
    }
}

