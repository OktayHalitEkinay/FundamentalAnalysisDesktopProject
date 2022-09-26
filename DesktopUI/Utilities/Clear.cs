using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI.Utilities
{
    public class Clear
    {
        public static void DataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
        }
        public static void RichTextBox(RichTextBox richTextBox)
        {
            richTextBox.Clear();
            richTextBox.Refresh();
        }
        public static void DataGridViewCheckBox(DataGridView dataGridView, int columnIndex)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Cells[columnIndex].Value = false;
            }
            dataGridView.Refresh();
        }
        public static void ComboBox(ComboBox comboBox)
        {
            comboBox.SelectedIndex = -1;
            comboBox.Refresh();
        }


    }
}
