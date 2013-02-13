using TrafficDissector.Data;
using TrafficDissector.Visualization;
using SharpPcap;
using SharpPcap.Packets;
using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TrafficDissector.UI
{
    internal enum ActionType
    {
        OpeningCaptureFile,
        Quitting,
        StartingNewCapture
    }

    internal partial class MainForm : BaseForm
    {
        #region Private Fields

        private PcapDevice device = null;
        private long packetsCount = 0;
        private bool capturedPacketsHaveBeenSaved = true;
        private ConcurrentDictionary<long, Packet> packetsDictionary =
            new ConcurrentDictionary<long, Packet>();

        #endregion


        #region Delegates

        private delegate void AddListViewItemDelegate(ListViewItem item, ListView listView);
        private delegate void UpdateTreeViewDelegate(Packet packet, TreeView treeView);
        private delegate void FillGridViewDelegate(Packet packet, DataGridView gridView);
        private delegate void ShowDisplayedPacketsCountDelegate(string itemName, string text, StatusStrip statusStrip);

        #endregion


        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            FillComboBoxFilters();
        }

        #endregion


        #region Event Handlers

        #region File

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCaptureFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (packetsDictionary.Count == 0)
            {
                MessageBox.Show("Currently there are no captured packets.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            SaveCapturedPacketsToFile();
        }

        #endregion

        #region Capture

        private void devicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ChooseDeviceForm chooseDeviceForm = new ChooseDeviceForm(device))
            {
                chooseDeviceForm.ButtonStopPressed += new EventHandler(chooseDeviceForm_ButtonStopPressed);

                if (chooseDeviceForm.ShowDialog() == DialogResult.OK)
                {
                    device = chooseDeviceForm.Device;
                    StartCapture();
                }
            }
        }

        private void chooseDeviceForm_ButtonStopPressed(object sender, EventArgs e)
        {
            StopCapture();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartCapture();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopCapture();
        }

        #endregion

        #region Statistics

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SummaryForm summaryForm = new SummaryForm(device))
            {
                summaryForm.ShowDialog();
            }
        }

        private void detailedSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DetailedSummaryForm detailedSummaryForm = new DetailedSummaryForm())
            {
                detailedSummaryForm.ShowDialog();
            }
        }

        #endregion

        #region Injection

        private void injectPacketsFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InjectPacketsFromFileForm injectPacketsFromFileForm = new InjectPacketsFromFileForm())
            {
                injectPacketsFromFileForm.ShowDialog();
            }
        }

        private void injectEthernetPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InjectEthernetPacketForm injectEthernetPacketForm = new InjectEthernetPacketForm())
            {
                injectEthernetPacketForm.ShowDialog();
            }
        }

        private void injectIPv4PacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InjectIPv4PacketForm injectIPv4PacketForm = new InjectIPv4PacketForm())
            {
                injectIPv4PacketForm.ShowDialog();
            }
        }

        private void injectTCPPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InjectTcpPacketForm injectTcpPacketForm = new InjectTcpPacketForm())
            {
                injectTcpPacketForm.ShowDialog();
            }
        }

        private void injectUDPPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InjectUdpPacketForm injectUdpPacketForm = new InjectUdpPacketForm())
            {
                injectUdpPacketForm.ShowDialog();
            }
        }

        #endregion

        #region Tools

        private void dnsMXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DnsMXForm dnsMXForm = new DnsMXForm())
            {
                dnsMXForm.ShowDialog();
            }
        }

        private void pingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PingForm pingForm = new PingForm())
            {
                pingForm.ShowDialog();
            }
        }

        private void whoisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (WhoIsForm whoIsForm = new WhoIsForm())
            {
                whoIsForm.ShowDialog();
            }
        }

        private void wqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (WqlQueryAnalyzerForm wmiForm = new WqlQueryAnalyzerForm())
            {
                wmiForm.ShowDialog();
            }
        }

        private void remoteCommandLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (RemoteCommandLineForm commandLineForm = new RemoteCommandLineForm())
            {
                commandLineForm.ShowDialog();
            }
        }

        private void portScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PortScannerForm portScannerForm = new PortScannerForm())
            {
                portScannerForm.ShowDialog();
            }
        }

        #endregion

        private void toolStripButtonApply_Click(object sender, EventArgs e)
        {
            // The user hasn't chosen an interface yet.
            // First a device must be selected.
            if (device == null) return;

            try
            {
                device.SetFilter(toolStripComboBoxFilters.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonFirst_Click(object sender, EventArgs e)
        {
            if (packetsCount > 0)
            {
                listViewPackets.Items[0].Selected = true;
                listViewPackets.Items[0].EnsureVisible();
            }
        }

        private void toolStripButtonLast_Click(object sender, EventArgs e)
        {
            if (packetsCount > 0)
            {
                listViewPackets.Items[(int)packetsCount - 1].Selected = true;
                listViewPackets.Items[(int)packetsCount - 1].EnsureVisible();

            }
        }

        private void device_OnPacketArrival(object sender, PcapCaptureEventArgs e)
        {
            DisplayPacketData(e.Packet);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device != null)
            {
                if (device.Started)
                {
                    StopCapture();
                }

                if (!capturedPacketsHaveBeenSaved)
                {
                    DialogResult userWish = ShowDialogAskingUserToSaveCaptureData(ActionType.Quitting);

                    if (userWish == DialogResult.OK)
                    {
                        SaveCapturedPacketsToFile();
                    }
                    else if (userWish == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        private void listViewPackets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPackets.SelectedItems.Count == 0) return;

            int selectedIndex = Convert.ToInt32(listViewPackets.SelectedItems[0].Text);

            Packet packet = (Packet)packetsDictionary[selectedIndex];

            TreeViewVisualizer.UpdateTreeView(packet, treeViewPacketInfo);

            DataGridViewVisualizer.FillDataGridView((Packet)packetsDictionary[selectedIndex], dataGridViewPacketData);
        }

        private void listViewPackets_Resize(object sender, EventArgs e)
        {
            listViewPackets.Columns[listViewPackets.Columns.Count - 1].Width = -2;
        }

        #endregion


        #region Private Methods

        private void OpenCaptureFile()
        {
            if (!capturedPacketsHaveBeenSaved)
            {
                DialogResult userWish = ShowDialogAskingUserToSaveCaptureData(ActionType.OpeningCaptureFile);

                if (userWish == DialogResult.OK)
                {
                    SaveCapturedPacketsToFile();
                }
                else if (userWish == DialogResult.Cancel)
                {
                    return;
                }
            }

            // Nullify the packets counter and clear the structures that keep
            // the captured packets info
            ClearDataStructures();

            capturedPacketsHaveBeenSaved = true;

            if (openCaptureFileDialog.ShowDialog() != DialogResult.OK)
            {
                SetNavigationButtonsEnabledState(false);
                return;
            }

            // Get an offline file pcap device
            PcapDevice offlineDevice = new PcapOfflineDevice(openCaptureFileDialog.FileName);

            try
            {
                Cursor = Cursors.WaitCursor;

                // Open the device for capturing 
                offlineDevice.Open();

                // Register our handler function to the "packet arrival" event
                offlineDevice.OnPacketArrival += new Pcap.PacketArrivalEvent(device_OnPacketArrival);

                // Start capture "INFINTE" number of packets 
                // This method will return when EOF reached. 
                offlineDevice.Capture(Pcap.INFINITE);

                // Set the MainForm text
                SetMainFormText(String.Format("{0} - Traffic Dissector", Path.GetFileName(openCaptureFileDialog.FileName)));

                // Set the status labels texts
                SetStatusLabelsTexts(String.Format("File: \"{0}\"", openCaptureFileDialog.FileName), packetsCount == 0 ? "|No packets" : String.Format("|Displayed packets: {0}", packetsCount));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the pcap device 
                offlineDevice.Close();

                Cursor = Cursors.Default;
            }
        }

        private void StartCapture()
        {
            if (!capturedPacketsHaveBeenSaved)
            {
                DialogResult userWish = ShowDialogAskingUserToSaveCaptureData(ActionType.StartingNewCapture);

                if (userWish == DialogResult.OK)
                {
                    SaveCapturedPacketsToFile();
                }
                else if (userWish == DialogResult.Cancel)
                {
                    return;
                }
            }

            // Nullify the packets counter and clear the structures that keep
            // the captured packets info
            ClearDataStructures();

            try
            {
                Cursor = Cursors.WaitCursor;

                // Open the device for capturing 
                device.Open(true, 1000);

                // tcpdump filter to capture only TCP/IP packets 
                device.SetFilter(toolStripComboBoxFilters.Text);

                // Register our handler function to the "packet arrival" event 
                device.OnPacketArrival += new Pcap.PacketArrivalEvent(device_OnPacketArrival);

                // Start the capturing process
                device.StartCapture();

                // Enable the navigation buttons
                SetNavigationButtonsEnabledState(true);

                // Set the MainForm text
                SetMainFormText(String.Format("{0}: Capturing - Traffic Dissector", device.Description));

                // Set the status labels texts
                SetStatusLabelsTexts("Live capture in progress", "|No packets");

                SetMenuItemsEnabledState(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                device.Close();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void StopCapture()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                device.Close();

                if (packetsCount > 0)
                {
                    // There are captured packets and they haven't been saved.
                    capturedPacketsHaveBeenSaved = false;
                }
                else
                {
                    // No captured packets - nothing to save.
                    capturedPacketsHaveBeenSaved = true;
                }

                // Set the MainForm text
                SetMainFormText("Traffic Dissector");

                // Set the status labels texts
                SetStatusLabelsTexts("Ready to load or capture", packetsCount == 0 ? "|No packets" : String.Format("|Displayed packets: {0}", packetsCount));

                SetMenuItemsEnabledState(true);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void FillComboBoxFilters()
        {
            toolStripComboBoxFilters.Items.Add("tcp");
            toolStripComboBoxFilters.Items.Add("icmp");
            toolStripComboBoxFilters.Items.Add("tcp port 80 || udp port 80");
            toolStripComboBoxFilters.Items.Add("ip");
            toolStripComboBoxFilters.Items.Add("ip or tcp");
        }

        private void DisplayPacketData(Packet packet)
        {
            packetsCount++;
            packetsDictionary.AddOrUpdate(packetsCount, packet, (i, p) => p);

            ListViewItem packetItem;

            if (packet is ARPPacket)
            {
                ARPPacket arpPacket = (ARPPacket)packet;

                packetItem = ListViewVisualizer.GenerateListViewItem(
                    Color.LightPink,
                    packetsCount.ToString(),
                    TreeViewVisualizer.GetHyphenatedHwAddress(arpPacket.ARPSenderHwAddress),
                    String.Empty,
                    String.Empty,
                    TreeViewVisualizer.GetHyphenatedHwAddress(arpPacket.ARPTargetHwAddress),
                    String.Empty,
                    String.Empty,
                    "ARP",
                    arpPacket.ToString());
            }
            else if (packet is ICMPPacket)
            {
                ICMPPacket icmpPacket = (ICMPPacket)packet;

                packetItem = ListViewVisualizer.GenerateListViewItem(
                    Color.Thistle,
                    packetsCount.ToString(),
                    icmpPacket.SourceAddress.ToString(),
                    DnsTable.GetHostByAddress(icmpPacket.SourceAddress),
                    String.Empty,
                    icmpPacket.DestinationAddress.ToString(),
                    DnsTable.GetHostByAddress(icmpPacket.DestinationAddress),
                    String.Empty,
                    "ICMP",
                    icmpPacket.ToString());
            }
            else if (packet is TCPPacket)
            {
                TCPPacket tcpPacket = (TCPPacket)packet;

                packetItem = ListViewVisualizer.GenerateListViewItem(
                    Color.LightSkyBlue,
                    packetsCount.ToString(),
                    tcpPacket.SourceAddress.ToString(),
                    DnsTable.GetHostByAddress(tcpPacket.SourceAddress),
                    tcpPacket.SourcePort.ToString(),
                    tcpPacket.DestinationAddress.ToString(),
                    DnsTable.GetHostByAddress(tcpPacket.DestinationAddress),
                    tcpPacket.DestinationPort.ToString(),
                    "TCP",
                    tcpPacket.ToString());
            }
            else if (packet is UDPPacket)
            {
                UDPPacket udpPacket = (UDPPacket)packet;

                packetItem = ListViewVisualizer.GenerateListViewItem(
                    Color.LemonChiffon,
                    packetsCount.ToString(),
                    udpPacket.SourceAddress.ToString(),
                    DnsTable.GetHostByAddress(udpPacket.SourceAddress),
                    udpPacket.SourcePort.ToString(),
                    udpPacket.DestinationAddress.ToString(),
                    DnsTable.GetHostByAddress(udpPacket.DestinationAddress),
                    udpPacket.DestinationPort.ToString(),
                    "UDP",
                    udpPacket.ToString());
            }
            else
            {
                packetItem = ListViewVisualizer.GenerateListViewItem(
                    Color.Linen,
                    packetsCount.ToString(),
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    "unknown",
                    String.Empty);
            }

            AddListViewItemDelegate addListViewItemDelegate = new AddListViewItemDelegate(ListViewVisualizer.AddListViewItem);
            listViewPackets.Invoke(addListViewItemDelegate, new object[] { packetItem, listViewPackets });

            ShowDisplayedPacketsCountDelegate showDisplayedPacketsDelegate = new ShowDisplayedPacketsCountDelegate(StatusStripVisualizer.SetLabelText);
            statusStrip.Invoke(showDisplayedPacketsDelegate, new object[] { toolStripStatusLabelPacketsInfo.Name, String.Format("|Displayed packets: {0}", packetsCount), statusStrip });

            if (packetsCount == 1)
            {
                UpdateTreeViewDelegate updateTreeViewDelegate = new UpdateTreeViewDelegate(TreeViewVisualizer.UpdateTreeView);
                treeViewPacketInfo.Invoke(updateTreeViewDelegate, new object[] { (Packet)packetsDictionary[1], treeViewPacketInfo });

                FillGridViewDelegate fillGridViewDelegate = new FillGridViewDelegate(DataGridViewVisualizer.FillDataGridView);
                dataGridViewPacketData.Invoke(fillGridViewDelegate, new object[] { (Packet)packetsDictionary[1], dataGridViewPacketData });
            }
        }

        private void ClearDataStructures()
        {
            if (packetsCount > 0)
            {
                packetsCount = 0;
                listViewPackets.Items.Clear();
                treeViewPacketInfo.Nodes.Clear();
                dataGridViewPacketData.Rows.Clear();
                packetsDictionary.Clear();
            }
        }

        private void SetMenuItemsEnabledState(bool enabled)
        {
            startToolStripMenuItem.Enabled = enabled;
            stopToolStripMenuItem.Enabled = !enabled;
            openFileToolStripMenuItem.Enabled = enabled;
            saveAsToolStripMenuItem.Enabled = enabled;
            summaryToolStripMenuItem.Enabled = !enabled;
        }

        private void SaveCapturedPacketsToFile()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                device.Open();

                // Open or create a capture output file
                device.DumpOpen(saveFileDialog.FileName);

                foreach (Packet packet in packetsDictionary.Values)
                {
                    device.Dump(packet);
                }

                device.DumpFlush();

                // Set the flag packetsHaveBeenSaved to true - the displayed packets
                // have just been saved.
                capturedPacketsHaveBeenSaved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                device.DumpClose();
                device.Close();

                Cursor = Cursors.Default;
            }
        }

        private void SetNavigationButtonsEnabledState(bool enabled)
        {
            toolStripButtonFirst.Enabled = enabled;
            toolStripButtonLast.Enabled = enabled;
        }

        private void SetStatusLabelsTexts(string state, string packetsInfo)
        {
            toolStripStatusLabelState.Text = state;

            if (toolStripStatusLabelPacketsInfo.Text != packetsInfo)
            {
                toolStripStatusLabelPacketsInfo.Text = packetsInfo;
            }
        }

        private void SetMainFormText(string text)
        {
            this.Text = text;
        }

        private DialogResult ShowDialogAskingUserToSaveCaptureData(ActionType action)
        {
            DialogResult answer;

            switch (action)
            {
                case ActionType.OpeningCaptureFile:
                    {
                        answer = MessageBox.Show(
                            "If you open a new capture file without saving," +
                            "\nyour capture data will be lost." +
                            "\nSave capture file before opening a new one?",
                            "Save capture?",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                        break;
                    }
                case ActionType.Quitting:
                    {
                        answer = MessageBox.Show(
                            "If you quit the program without saving," +
                            "\nyour capture data will be lost." +
                            "\nSave capture file before program quit?",
                            "Save capture?",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                        break;
                    }
                case ActionType.StartingNewCapture:
                    {
                        answer = MessageBox.Show(
                            "If you start a new capture without saving," +
                            "\nyour current capture data will be lost." +
                            "\nSave capture file before starting a new capture?",
                            "Save capture?",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                        break;
                    }
                default:
                    {
                        answer = DialogResult.Cancel;
                        break;
                    }
            }

            if (answer == DialogResult.Yes)
            {
                return saveFileDialog.ShowDialog();
            }
            else
            {
                return answer;
            }
        }

        #endregion
    }
}