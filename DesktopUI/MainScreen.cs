using DesktopUI.Components.Business.Stock;
using DesktopUI.Components.SelectedStocksComponent;
using DesktopUI.Utilities;
using Entity.Concrete;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {          
           
        }
        public static class FormState
        {
            public static Form PreviousPage;
        }


        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            BalanceScreen balanceScreen = new BalanceScreen(this);
            balanceScreen.Show();
            this.Hide();
        }

        private void IncomeBtn_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            IncomeScreen incomeScreen = new IncomeScreen(this);
            incomeScreen.Show();
            this.Hide();
        }

        private void CashFlowTableBtn_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            CashFlowScreen cashFlowScreen = new CashFlowScreen(this);
            cashFlowScreen.Show();
            this.Hide();
        }
    }
}
