using SharpPcap;
using System.Windows.Forms;

namespace TrafficDissector.UI
{
    public partial class ChooseDeviceUserControl : UserControl
    {
        #region Properties

        public PcapDevice Device
        {
            get { return (PcapDevice)comboBoxDevices.SelectedItem; }
        }

        #endregion


        #region Constructor

        public ChooseDeviceUserControl()
        {
            InitializeComponent();
            FillComboBoxDevices();
        }

        #endregion


        #region Private Methods

        private void FillComboBoxDevices()
        {
            comboBoxDevices.DataSource = Pcap.GetAllDevices();
            comboBoxDevices.DisplayMember = "Description";
            comboBoxDevices.SelectedIndex = -1;
        }

        #endregion


        #region Public Methods

        public bool ValidateChosenDevice()
        {
            errorProvider.Clear();

            if (comboBoxDevices.SelectedItem as PcapDevice == null)
            {
                errorProvider.SetError(comboBoxDevices, "A network device must be chosen.");
                return false;
            }

            return true;
        }

        #endregion
    }
}
