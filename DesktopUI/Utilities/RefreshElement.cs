using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI.Utilities
{
    public static class RefreshElement
    {
        public static void DataGridView(DataGridView dataGridView=null,Form form=null)
        {
            if (form!=null)
            {
                foreach (var dgv in form.Controls)
                {
                    if (dgv is DataGridView)
                    {
                        RefreshElement.DataGridView((DataGridView)dgv);
                    }
                }
                return;
            }
            dataGridView.Refresh();
        }
        public static void RichTextBox(RichTextBox richTextBox)
        {
            richTextBox.Refresh();
        }
        public static void DataGridViewCheckBox(DataGridView dataGridView)
        {
            dataGridView.Refresh();
        }
        public static void ComboBox(ComboBox comboBox)
        {
            comboBox.Refresh();
        }
        public static void Form(Form form)
        {
            form.Refresh();
        }
    }
}
