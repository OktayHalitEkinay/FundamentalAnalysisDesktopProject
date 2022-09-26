using DesktopUI.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI
{
    public class Common
    {
        public static List<Calculation> CalculateFinancialValuesForSelectedItems(List<StockItem> stockItemDataList, string firstSelectedTimePeriod, string secondSelectedTimePeriod)
        {
            List<Calculation> calculations = new List<Calculation>();
            foreach (var stockItem in stockItemDataList)
            {
                Calculation calculation = SetCalculationFields(firstSelectedTimePeriod, secondSelectedTimePeriod, stockItem);
                calculations.Add(calculation);
            }
            return calculations;
        }
        public static Calculation SetCalculationFields(string firstSelectedTimePeriod, string secondSelectedTimePeriod, StockItem stockItem)
        {

            Calculation calculation = new Calculation();
            if (stockItem.StartDateState &&
                stockItem.EndDateState &&
                stockItem.StockHasTheItemState)
            {
                calculation.FirstPrice = stockItem.HistoryPriceDictionary.FirstOrDefault(i => i.Key == firstSelectedTimePeriod).Value;
                calculation.SecondPrice = stockItem.HistoryPriceDictionary.FirstOrDefault(i => i.Key == secondSelectedTimePeriod).Value;
            }

            calculation.StockName = stockItem.StockName;
            calculation.ItemName = stockItem.ItemName;
            calculation.NumericalQuantity = CalculateQuantityDifference(calculation.FirstPrice, calculation.SecondPrice);
            calculation.ProportionalQuantity = CalculateProportionalDifference(calculation.FirstPrice, calculation.SecondPrice);
            calculation.StartDate = firstSelectedTimePeriod;
            calculation.EndDate = secondSelectedTimePeriod;
            calculation.StartDateState = stockItem.StartDateState;
            calculation.EndDateState = stockItem.EndDateState;
            calculation.StockHasTheItemState = stockItem.StockHasTheItemState;
            return calculation;
        }
        public static double CalculateQuantityDifference(double firstPriceData, double secondPriceData)
        {
            return firstPriceData - secondPriceData;
        }
        public static double CalculateProportionalDifference(double firstPriceData, double secondPriceData)
        {

            return (firstPriceData - secondPriceData) * 100 / secondPriceData;
        }
        public static List<StockItem> GetItemsData(List<Stock> sStocks,List<Item> sItems, string firstSelectedTimePeriod, string secondSelectedTimePeriod)
        {
            return ReadTablo(sStocks, sItems,firstSelectedTimePeriod,secondSelectedTimePeriod);
        }
        public static List<StockItem> ReadTablo(List<Stock> sStocks, List<Item> sReferenceItems, string firstSelectedTimePeriod, string secondSelectedTimePeriod)
        {
            List<StockItem> stockItemDataList = new List<StockItem>();
            foreach (var sItem in sReferenceItems)
            {
                foreach (var sstock in sStocks)
                {
                    int fieldCount = ReadHelper.GetFieldCount(sstock.Path, sItem.BelongingTable) + 1;
                    int rowCount = ReadHelper.GetRowCount(sstock.Path, sItem.BelongingTable) + 1;
                    string lastFieldToRead = ReadHelper.GetAlphabet().FirstOrDefault(m => m.Key == fieldCount).Value;
                    List<string> rows = ExcelRead.ReadLocal<string>(sstock.Path, sItem.BelongingTable, "A2", "A" + rowCount);
                    int itemRowNumber = rows.IndexOf(sItem.Name) + 2;
                    stockItemDataList.Add(SetStockItemFields(sstock, sItem, lastFieldToRead, rows, itemRowNumber, firstSelectedTimePeriod,secondSelectedTimePeriod));
                }
            }
            return stockItemDataList;
        }
        public static StockItem SetStockItemFields(Stock sstock, Item sItem, string lastFieldToRead, List<string> rows, int itemRowNumber, string firstSelectedTimePeriod, string secondSelectedTimePeriod)
        {
            //string firstSelectedTimePeriod = FirstYearTxtBx.Text + "/" + firstMonth;
            //string secondSelectedTimePeriod = SecondYearTxtBx.Text + "/" + secondMonth;
            StockItem stockItem = new StockItem();
            stockItem.StockName = sstock.Name;
            stockItem.ItemName = sItem.Name;
            stockItem.HistoryData = ExcelRead.ReadLocal<string>(sstock.Path, sItem.BelongingTable, "B1", lastFieldToRead.ToString() + 1.ToString());
            CheckStockHasRelatedItem(rows, sItem.Name, stockItem);

            if (stockItem.StockHasTheItemState)
            {
                stockItem.PriceData = ExcelRead.ReadLocal<double>(sstock.Path, sItem.BelongingTable, "B" + itemRowNumber.ToString(), lastFieldToRead.ToString() + itemRowNumber.ToString());
            }
            else
            {
                stockItem.PriceData = new List<double>();
            }


            for (int i = 0; i < stockItem.HistoryData.Count; i++)
            {
                if (stockItem.HistoryData[i] == null)
                {
                    stockItem.HistoryData[i] = "";
                }
            }
            stockItem.HistoryPriceDictionary = stockItem.HistoryData.Zip(stockItem.PriceData, (k, v) => new { Key = k, Value = v })
             .ToDictionary(x => x.Key, x => x.Value);
            CheckStockHasRelatedItem(rows, sItem.Name, stockItem);
            CheckStockHasRelatedStartDate(firstSelectedTimePeriod, stockItem);
            CheckStockHasRelatedEndDate(secondSelectedTimePeriod, stockItem);
            return stockItem;
        }
        public static void CheckStockHasRelatedEndDate(string secondSelectedTimePeriod, StockItem stockItem)
        {
            stockItem.EndDateState = stockItem.HistoryData.Any(hist => hist == secondSelectedTimePeriod);
        }
        public static void CheckStockHasRelatedStartDate(string firstSelectedTimePeriod, StockItem stockItem)
        {
            stockItem.StartDateState = stockItem.HistoryData.Any(hist => hist == firstSelectedTimePeriod);
        }
        public static void CheckStockHasRelatedItem(List<string> rows, string item, StockItem stockItem)
        {
            stockItem.StockHasTheItemState = rows.Contains(item);
        }
        public static bool CheckForReportType(string reportType)
        {
            if (reportType == "")
            {
                MessageBox.Show("Lütfen Rapor Tipini Seçiniz!");
                return false;
            }
            return true;
        }
        public static bool CheckForSelectedStocks(List<Stock> selectedStocks)
        {
            if (selectedStocks.Count == 0)
            {
                MessageBox.Show("Lütfen En Az 1 Adet Hisse Seçiniz!");
                return false;
            }
            return true;

        }
        public static bool CheckForItems(List<Item> selectedItems)
        {
            if (selectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen En Az 1 Adet Kalem Seçiniz!");
                return false;
            }
            return true;
        }
        public static bool CheckForValidDate(string firstYear, string secondYear, int firstMonth, int secondMonth)
        {
            if (string.IsNullOrEmpty(firstYear))
            {
                MessageBox.Show("Lütfen 1. Yıl Bilgisini Giriniz!");
                return false;
            }
            if (string.IsNullOrEmpty(secondYear))
            {
                MessageBox.Show("Lütfen 2. Yıl Bilgisini Giriniz!");
                return false;
            }
            if (firstMonth == 0)
            {
                MessageBox.Show("Lütfen 1. Çeyrek Bilgisini Giriniz!");
                return false;
            }
            if (secondMonth == 0)
            {
                MessageBox.Show("Lütfen 2. Çeyrek Bilgisini Giriniz!");
                return false;
            }
            return true;
        }
        public static bool CheckForDate(string firstYear, string secondYear, int firstMonth, int secondMonth)
        {
            DateTime firstDate = CreateDate(Int32.Parse(firstYear), firstMonth);
            DateTime secondDate = CreateDate(Int32.Parse(secondYear), secondMonth);
            if (firstDate > secondDate)
            {
                return true;
            }
            MessageBox.Show("2. Tarih 1. Tarihten Daha Evvel veya 1. Tarihe Eşit Olamaz!");
            return false;//false dönerse kontrolden geçememiş demektir.
        }
        private static DateTime CreateDate(int year, int month)
        {
            return new DateTime(year, month, 1);
        }
        public static List<string> PrepareReport(List<Calculation> calculations)
        {
            List<string> reports = new List<string>();
            foreach (var calculation in calculations)
            {
                if (calculation.StartDateState && calculation.EndDateState && calculation.StockHasTheItemState)
                {
                    reports.Add((Environment.NewLine + calculation.StockName + "->" + calculation.ItemName + "->" + calculation.StartDate + "--" + calculation.EndDate + "-> %" + calculation.ProportionalQuantity + "->" + calculation.NumericalQuantity));
                }
                else
                {
                    if (!calculation.StartDateState)
                    {
                        reports.Add(Environment.NewLine + calculation.StockName + "->" + calculation.ItemName + "->" + calculation.StartDate + "->" + " zamanına ait kayıt bulunamamıştır.");
                    }
                    if (!calculation.EndDateState)
                    {
                        reports.Add(Environment.NewLine + calculation.StockName + "->" + calculation.ItemName + "->" + calculation.EndDate + "->" + " zamanına ait kayıt bulunamamıştır.");
                    }
                    if (!calculation.StockHasTheItemState)
                    {
                        reports.Add(Environment.NewLine + calculation.StockName + "->" + calculation.ItemName + "->" + "kalemine ait kayıt bulunamamıştır.");
                    }
                }
            }
            reports.Add(Environment.NewLine + "********");
            return reports;
        }

        public static void CreateQuarterCmbBx(ComboBox quarterCmbBx, Dictionary<int, string> quarterDictionary)
        {
            foreach (var quarter in quarterDictionary)
            {
                quarterCmbBx.Items.Add(quarter.Value);
            }
        }
        public static void CreateYearDictionary(Dictionary<int, string> yearDictionary)
        {
            int currentYear = Int32.Parse(DateTime.Now.Year.ToString());
            for (int i = 0; i < 5; i++)
            {
                yearDictionary.Add(currentYear - i, (currentYear - i).ToString());
            }
        }
        public static void CreateQuarterDictionary(Dictionary<int, string> quarterDictionary)
        {
            for (int i = 0; i < 4; i++)
            {
                quarterDictionary.Add(3 * (i + 1), (i + 1).ToString() + ". Çeyrek");
            }
        }

        public static void CreateReportTypeCombobox(Dictionary<string, int> ReportTypeDictionary, ComboBox ReportTypeCmbBox)
        {
            ReportTypeDictionary.Add("Metin", 1);
            ReportTypeDictionary.Add("Tablo", 2);
            foreach (var time in ReportTypeDictionary)
            {
                ReportTypeCmbBox.Items.Add(time.Key);
            }
        }
        public static void Print(List<string> reports, RichTextBox richTextBox)
        {
            richTextBox.Visible = true;
            foreach (var report in reports)
            {
                richTextBox.AppendText(report);
            }
        }
    }
}
