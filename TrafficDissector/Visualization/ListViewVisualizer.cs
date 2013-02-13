using System.Drawing;
using System.Windows.Forms;

namespace TrafficDissector.Visualization
{
    internal static class ListViewVisualizer
    {
        internal static ListViewItem GenerateListViewItem(
            Color color,
            string index,
            string sourceAddress,
            string sourceName,
            string sourcePort,
            string destinationAddress,
            string destinationName,
            string destinationPort,
            string protocol,
            string info)
        {
            ListViewItem item = new ListViewItem(index);
            item.BackColor = color;

            item.SubItems.Add(sourceAddress);
            item.SubItems.Add(sourceName);
            item.SubItems.Add(sourcePort);
            item.SubItems.Add(destinationAddress);
            item.SubItems.Add(destinationName);
            item.SubItems.Add(destinationPort);
            item.SubItems.Add(protocol);
            item.SubItems.Add(info);

            return item;
        }

        internal static void AddListViewItem(ListViewItem item, ListView listView)
        {
            ListViewItem addedItem = listView.Items.Add(item);
        }
    }
}
