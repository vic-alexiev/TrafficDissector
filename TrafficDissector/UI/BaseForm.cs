using SharpPcap.Containers;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace TrafficDissector.UI
{
    public partial class BaseForm : Form
    {
        #region Constructor

        public BaseForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Protected Methods

        protected NetworkInterface GetMatchingNetworkInterface(PcapInterface pcapInterface, NetworkInterface[] nics)
        {
            foreach (NetworkInterface adapter in nics)
            {
                // if the name and id match then we have found the NetworkInterface
                // that matches the PcapInterface
                if (pcapInterface.Name.Contains(adapter.Id))
                {
                    return adapter;
                }
            }

            return null;
        }

        #endregion
    }
}