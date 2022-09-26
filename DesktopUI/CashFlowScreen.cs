using DesktopUI.Components.Business.Stock;
using DesktopUI.Utilities;
using Entity.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI
{
    public partial class CashFlowScreen : Form
    {
        #region GeneralVariables
        List<Item> selectedItems = new List<Item>();
        List<Stock> stocks = new List<Stock>();
        List<Stock> selectedStocks = new List<Stock>();
        int firstMonth;
        int secondMonth;
        Dictionary<int, string> YearDictionary = new Dictionary<int, string>();
        Dictionary<int, string> QuarterDictionary = new Dictionary<int, string>();
        string firstQuarterCmbBx = "Çeyrek";
        string secondQuarterCmbBx = "Çeyrek";
        string reportTypesCmbBx = "Rapor tipi seçiniz...";
        Dictionary<string, int> ReportTypeDictionary = new Dictionary<string, int>();
        string reportType = "";
        private Form mainForm;
        #endregion
        public CashFlowScreen(Form _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        protected override void OnLoad(EventArgs e)
        {
            StockDgv.AllowUserToAddRows = false;//kullanıcının yeni satır eklemesi için gelen default ibare kaldırıldı.Çünkü işaretlendiğinde null hatası verdiriyor.
            SelectedStockDgv.AllowUserToAddRows = false;//kullanıcının yeni satır eklemesi için gelen default ibare kaldırıldı.Çünkü işaretlendiğinde null hatası verdiriyor.          
            Common.CreateReportTypeCombobox(ReportTypeDictionary, ReportTypesCmbBx);
            Common.CreateQuarterDictionary(QuarterDictionary);
            Common.CreateQuarterCmbBx(FirstQuarterCmbBx, QuarterDictionary);
            Common.CreateQuarterCmbBx(SecondQuarterCmbBx, QuarterDictionary);
            Common.CreateYearDictionary(YearDictionary);

        }
        #region Stock
        private void StockLoadBtn_Click(object sender, EventArgs e)
        {
            StockComponent.Action(stocks);
            StockDgv.Columns["analyze"].ReadOnly = false;
            foreach (var stock in stocks)
            {
                StockDgv.Rows.Add(stock.Name);
            }
        }
        private void StockDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && StockDgv.Columns["analyze"].ReadOnly != true)
            {
                this.StockDgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
                DataGridViewRow selectedRow = StockDgv.Rows[e.RowIndex];
                bool cellValue = (bool)selectedRow.Cells["analyze"].Value;

                if (cellValue && !selectedStocks.Contains(stocks.FirstOrDefault(stock => stock.Name == (selectedRow.Cells["stock"].Value).ToString())))
                {
                    selectedStocks.Add(stocks.FirstOrDefault(stock => stock.Name == (selectedRow.Cells["stock"].Value).ToString()));
                    SelectedStockDgv.Rows.Add((selectedRow.Cells["stock"].Value).ToString());
                }
                else
                {
                    selectedStocks.Remove(stocks.FirstOrDefault(stock => stock.Name == (selectedRow.Cells["stock"].Value).ToString()));
                    foreach (DataGridViewRow row in SelectedStockDgv.Rows)
                    {
                        string x = (selectedRow.Cells["stock"].Value).ToString();
                        string y = (row.Cells["SelectedStocks"].Value).ToString();
                        if (x != null && y != null && x == y)
                        {
                            SelectedStockDgv.Rows.RemoveAt(row.Index);
                            break;
                        }

                    }
                }
            }

        }
        private void SelectAllStocksChkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAllChkBx.Checked)
            {
                this.StockDgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
                foreach (DataGridViewRow row in this.StockDgv.Rows)
                {
                    if (row.Cells[1].Value == null)
                    {
                        row.Cells[1].Value = false;
                    }
                    if (!(bool)(row.Cells[1].Value))
                    {
                        row.Cells[1].Value = true;
                        if (!selectedStocks.Contains(stocks.FirstOrDefault(stock => stock.Name == (row.Cells["stock"].Value).ToString())))
                        {
                            selectedStocks.Add(stocks.FirstOrDefault(stock => stock.Name == (row.Cells["stock"].Value).ToString()));
                            SelectedStockDgv.Rows.Add((row.Cells["stock"].Value).ToString());
                        }
                    }

                }
            }
            else
            {
                selectedStocks.Clear();
                SelectedStockDgv.Rows.Clear();
                SelectedStockDgv.Refresh();
                foreach (DataGridViewRow row in this.StockDgv.Rows)
                {
                    row.Cells[1].Value = false;
                }

            }
        }
        #endregion

        #region Analyze
        private void AnalyzeBtn_Click(object sender, EventArgs e)
        {
            string firstSelectedTimePeriod = FirstYearTxtBx.Text + "/" + firstMonth;
            string secondSelectedTimePeriod = SecondYearTxtBx.Text + "/" + secondMonth;
            if (
                Common.CheckForSelectedStocks(selectedStocks) &&
                Common.CheckForItems(selectedItems) &&
                Common.CheckForValidDate(FirstYearTxtBx.Text, SecondYearTxtBx.Text, firstMonth, secondMonth) &&
                Common.CheckForDate(FirstYearTxtBx.Text, SecondYearTxtBx.Text, firstMonth, secondMonth) &&
                Common.CheckForReportType(reportType))
            {
                Common.Print(Common.PrepareReport(Common.CalculateFinancialValuesForSelectedItems(Common.GetItemsData(selectedStocks, selectedItems, firstSelectedTimePeriod, secondSelectedTimePeriod), firstSelectedTimePeriod, secondSelectedTimePeriod)), ReportRtb);
            }
            else
            {
                return;
            }
        }

        #region FinancialItemGrpBx
        private void CashFlowProvidedByCompanyOperationsChkBx_CheckedChanged(object sender, EventArgs e)
        {
            string itemName = "İŞLETME FAALİYETLERİNDEN NAKİT AKIŞLARI";
            string belongingTable = "Nakit Akım Tablosu";
            if (CashFlowProvidedByCompanyOperationsChkBx.CheckState == CheckState.Unchecked)
            {
                foreach (var item in selectedItems)
                {
                    if (item.Name == itemName)
                    {
                        selectedItems.Remove(item);
                        break;
                    }
                }
            }
            else if (CashFlowProvidedByCompanyOperationsChkBx.CheckState == CheckState.Checked)
            {
                if (!selectedItems.Any(i => i.Name == itemName))
                {
                    selectedItems.Add(new Item { Name = itemName, BelongingTable = belongingTable });
                }
            }
        }
        private void PeriodIncomeLossChkBx_CheckedChanged(object sender, EventArgs e)
        {
            string itemName = "Dönem Karı (Zararı)";
            string belongingTable = "Nakit Akım Tablosu";
            if (PeriodIncomeLossChkBx.CheckState == CheckState.Unchecked)
            {
                foreach (var item in selectedItems)
                {
                    if (item.Name == itemName)
                    {
                        selectedItems.Remove(item);
                        break;
                    }
                }
            }
            else if (PeriodIncomeLossChkBx.CheckState == CheckState.Checked)
            {
                if (!selectedItems.Any(i => i.Name == itemName))
                {
                    selectedItems.Add(new Item { Name = itemName, BelongingTable = belongingTable });
                }
            }
        }
        private void CashOutflowsFromPurchaseTangibleIntangibleAssetsChkBx_CheckedChanged(object sender, EventArgs e)
        {
            string itemName = "Maddi ve Maddi Olmayan Duran Varlıkların Alımından Kaynaklanan Nakit Çıkışları";
            string belongingTable = "Nakit Akım Tablosu";
            if (CashOutflowsFromPurchaseTangibleIntangibleAssetsChkBx.CheckState == CheckState.Unchecked)
            {
                foreach (var item in selectedItems)
                {
                    if (item.Name == itemName)
                    {
                        selectedItems.Remove(item);
                        break;
                    }
                }
            }
            else if (CashOutflowsFromPurchaseTangibleIntangibleAssetsChkBx.CheckState == CheckState.Checked)
            {
                if (!selectedItems.Any(i => i.Name == itemName))
                {
                    selectedItems.Add(new Item { Name = itemName, BelongingTable = belongingTable });
                }
            }
        }
        private void CashInflowsFromBorrowingChkBx_CheckedChanged(object sender, EventArgs e)
        {
            string itemName = "Borçlanmadan Kaynaklanan Nakit Girişleri";
            string belongingTable = "Nakit Akım Tablosu";
            if (CashInflowsFromBorrowingChkBx.CheckState == CheckState.Unchecked)
            {
                foreach (var item in selectedItems)
                {
                    if (item.Name == itemName)
                    {
                        selectedItems.Remove(item);
                        break;
                    }
                }
            }
            else if (CashInflowsFromBorrowingChkBx.CheckState == CheckState.Checked)
            {
                if (!selectedItems.Any(i => i.Name == itemName))
                {
                    selectedItems.Add(new Item { Name = itemName, BelongingTable = belongingTable });
                }
            }
        }
        private void CashFlowProvidedByOperationsChkBx_CheckedChanged(object sender, EventArgs e)
        {
            string itemName = "Faaliyetlerden Elde Edilen Nakit Akışları";
            string belongingTable = "Nakit Akım Tablosu";
            if (CashFlowProvidedByOperationsChkBx.CheckState == CheckState.Unchecked)
            {
                foreach (var item in selectedItems)
                {
                    if (item.Name == itemName)
                    {
                        selectedItems.Remove(item);
                        break;
                    }
                }
            }
            else if (CashFlowProvidedByOperationsChkBx.CheckState == CheckState.Checked)
            {
                if (!selectedItems.Any(i => i.Name == itemName))
                {
                    selectedItems.Add(new Item { Name = itemName, BelongingTable = belongingTable });
                }
            }
        }
        #endregion
        #region ReferenceItemGrpBx
        private void EquityChkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (EquityChkBx.CheckState == CheckState.Unchecked)
            {
                foreach (var item in selectedItems)
                {
                    if (item.Name == "Özkaynaklar")
                    {
                        selectedItems.Remove(item);
                        break;
                    }
                }
            }
            else if (EquityChkBx.CheckState == CheckState.Checked)
            {
                if (!selectedItems.Any(i => i.Name == "Özkaynaklar"))
                {
                    selectedItems.Add(new Item { Name = "Özkaynaklar", BelongingTable = "Bilanço" });
                }
            }
        }
        private void SalesChkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (SalesChkBx.CheckState == CheckState.Unchecked)
            {
                foreach (var item in selectedItems)
                {
                    if (item.Name == "Satış Gelirleri")
                    {
                        selectedItems.Remove(item);
                        break;
                    }
                }
            }
            else if (SalesChkBx.CheckState == CheckState.Checked)
            {
                if (!selectedItems.Any(i => i.Name == "Satış Gelirleri"))
                {
                    selectedItems.Add(new Item { Name = "Satış Gelirleri", BelongingTable = "Gelir Tablosu" });
                }
            }
        }
        #endregion
        #region TimePeriodPnl       
        private void FirstQuarterCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FirstQuarterCmbBx.SelectedIndex != -1)
            {
                this.firstMonth = QuarterDictionary.FirstOrDefault(quarter => quarter.Value == FirstQuarterCmbBx.Items[FirstQuarterCmbBx.SelectedIndex].ToString()).Key;
            }
        }
        private void SecondQuarterCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SecondQuarterCmbBx.SelectedIndex != -1)
            {
                this.secondMonth = QuarterDictionary.FirstOrDefault(quarter => quarter.Value == SecondQuarterCmbBx.Items[SecondQuarterCmbBx.SelectedIndex].ToString()).Key;
            }
        }
        #endregion
        #region ReportTypePnl
        private void ReportTypesCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReportTypesCmbBx.SelectedIndex != -1)
            {
                reportType = ReportTypesCmbBx.SelectedItem.ToString();
            }
        }
        #endregion
        #endregion

        #region Clear

        #region Buttons
        private void ClearStockBtn_Click(object sender, EventArgs e)
        {
            ClearStock();
        }
        private void ClearSelectedStockBtn_Click(object sender, EventArgs e)
        {
            ClearSelectedStock();
        }
        private void ClearReportBtn_Click(object sender, EventArgs e)
        {
            ClearReport();
        }
        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            ClearStock();
            ClearSelectedStock();
            ClearAnalyzeGrpBx();
            ClearReport();
            ClearSelectedReferenceItems();
            ClearSelectedFinancialReferenceItems();
        }
        private void ClearAnalyzeGrpBxBtn_Click(object sender, EventArgs e)
        {
            ClearAnalyzeGrpBx();
        }

        #endregion

        #region Methods
        private void ClearStock()
        {
            Clear.DataGridView(StockDgv);
            Clear.DataGridViewCheckBox(StockDgv, 1);
            SelectAllChkBx.Checked = false;
            stocks.Clear();
        }
        private void ClearReport()
        {
            Clear.RichTextBox(ReportRtb);
        }
        private void ClearSelectedStock()
        {
            Clear.DataGridView(SelectedStockDgv);
            Clear.DataGridViewCheckBox(StockDgv, 1);
            selectedStocks.Clear();
        }
        private void ClearAnalyzeGrpBx()
        {
            foreach (var control in FinancialItemGrpBx.Controls)
            {
                ((CheckBox)control).Checked = false;
            }
            foreach (var control in ReferenceItemGrpBx.Controls)
            {
                ((CheckBox)control).Checked = false;
            }
            foreach (var control in TimePeriodPnl.Controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
            }
            ReportTypesCmbBx.SelectedIndex = -1;
            FirstQuarterCmbBx.Text = firstQuarterCmbBx;
            SecondQuarterCmbBx.Text = secondQuarterCmbBx;
            ReportTypesCmbBx.Text = reportTypesCmbBx;
            FirstYearTxtBx.Text = "";
            SecondYearTxtBx.Text = "";

            firstMonth = 0;
            secondMonth = 0;
            reportType = "";
        }
        private void ClearSelectedFinancialReferenceItems()
        {
            selectedItems.Clear();
        }
        private void ClearSelectedReferenceItems()
        {
            selectedItems.Clear();
        }
        #endregion

        #endregion

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void MainScreenBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void ExportTxtBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save As TXT";
            sfd.Filter = "(*.txt)|*.txt";
            sfd.InitialDirectory = @"C:\";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ReportRtb.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }


    }
}
