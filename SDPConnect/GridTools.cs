using System;
using System.Drawing;
using System.Windows.Forms;

namespace SDPConnect
{
    class GridTools
    {
        internal static void AdjustColumn(DataGridViewColumn col, string header, int width, int index, DataGridViewAutoSizeColumnMode mode = DataGridViewAutoSizeColumnMode.ColumnHeader)
        {
            if (col == null) return;
            col.HeaderText = header;
            col.MinimumWidth = width;
            col.DisplayIndex = index;
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        internal static void HideColumn(DataGridViewColumn col)
        {
            if (col == null) return;
            col.Visible = false;
        }

        internal static Color GetRowColor(RowStatus status)
        {
            switch (status)
            {
                case RowStatus.Added:
                    return Color.Black;
                case RowStatus.Treated:
                    return Color.Blue;
                case RowStatus.Finished:
                    return Color.Green;
                    case RowStatus.Faulted:
                    return Color.Red;
                default:
                    return Color.Black;
            }
        }

    }
}
