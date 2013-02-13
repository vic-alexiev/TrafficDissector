using SharpPcap.Packets;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TrafficDissector.Visualization
{
    internal static class DataGridViewVisualizer
    {
        internal static void FillDataGridView(Packet packet, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            string[] stringArray = BitConverter.ToString(packet.Bytes).Split('-');

            int rowsCount = stringArray.Length / 16;
            if (stringArray.Length % 16 != 0)
            {
                rowsCount++;
            }

            for (int i = 0; i < rowsCount; i++)
            {
                int rowSize = i < rowsCount - 1 ? 16 : stringArray.Length % 16;

                string[] tempStringArray = new string[rowSize];
                byte[] tempBytes = new byte[rowSize];

                Array.Copy(stringArray, i * 16, tempStringArray, 0, rowSize);
                dataGridView.Rows.Add(tempStringArray);

                Array.Copy(packet.Bytes, i * 16, tempBytes, 0, rowSize);

                char[] asciiChars = Encoding.UTF7.GetChars(tempBytes);
                string ascii = new string(asciiChars);
                ascii = Regex.Replace(ascii, @"[^\u0020-\u007E]", ".");
                dataGridView.Rows[i].Cells[dataGridView.Columns.Count - 1].Value = ascii;

                dataGridView.Rows[i].HeaderCell.Value = String.Format("{0:X4}", i * 16);
            }
        }
    }
}
