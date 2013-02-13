using System.Windows.Forms;

namespace TrafficDissector.Visualization
{
    internal static class StatusStripVisualizer
    {
        internal static void SetLabelText(string itemName, string text, StatusStrip statusStrip)
        {
            statusStrip.Items[itemName].Text = text;
        }
    }
}
