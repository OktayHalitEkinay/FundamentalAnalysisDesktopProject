using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesktopUI.Utilities
{
    public static class ReadHelper
    {
        public static void CheckForCellOrder(ref int scol, ref int fcol, ref int srow, ref int frow)
        {
            int temp = 0;
            if (scol > fcol)
            {
                temp = fcol;
                fcol = scol;
                scol = temp;
            }
            if (srow > frow)
            {
                temp = frow;
                frow = srow;
                srow = temp;
            }
            if (scol==fcol)
            {
                fcol++;
            }
        }
        public static int GetAlphabeticOrderOfLetter(string letter)
        {
            Dictionary<int, string> alphabet = GetAlphabet();
            return alphabet.FirstOrDefault(l => l.Value == letter).Key;
        }
        public static Dictionary<int, string> GetAlphabet()
        {
            Dictionary<int, string> alphabet = new Dictionary<int, string>()
            {
                    {1,"A"},
                    {2,"B"},
                    {3,"C"},
                    {4,"D"},
                    {5,"E"},
                    {6,"F"},
                    {7,"G"},
                    {8,"H"},
                    {9,"I"},
                    {10,"J"},
                    {11,"K"},
                    {12,"L"},
                    {13,"M"},
                    {14,"N"},
                    {15,"O"},
                    {16,"P"},
                    {17,"Q"},
                    {18,"R"},
                    {19,"S"},
                    {20,"T"},
                    {21,"U"},
                    {22,"V"},
                    {23,"W"},
                    {24,"X"},
                    {25,"Y"},
                    {26,"Z"},
                    {27,"AA"},
                    {28,"AB"},
                    {29,"AC"},
                    {30,"AD"},
                    {31,"AE"},
                    {32,"AF"},
            };
            return alphabet;
        }
        public static string GetAlphabeticValue(string sampleString)
        {
            return (Regex.Replace(sampleString, @"[\d-]", string.Empty)).ToString();
        }
        public static int GetNumericValue(string sampleString)
        {
            return Int32.Parse(Regex.Match(sampleString, @"\d+").Value);
        }
        public static IExcelDataReader SetExcelReader(string path, string sheet)
        {
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            IExcelDataReader excelReader;



            if (Path.GetExtension(path).ToUpper() == ".XLS")
            {
                excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            }
            else
            {
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            }

            while (excelReader.Name != sheet)
            {
                excelReader.NextResult();
            }

            return excelReader;
        }
        public static int GetFieldCount(string path, string sheet)
        {
            int count = 0;
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            IExcelDataReader excelReader;



            if (Path.GetExtension(path).ToUpper() == ".XLS")
            {
                excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            }
            else
            {
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            }

            while (excelReader.Name != sheet)
            {
                excelReader.NextResult();
            }
            count = excelReader.FieldCount;
            excelReader.Close();            
            return count;
        }
        public static int GetRowCount(string path, string sheet)
        {
            int count = 0;
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            IExcelDataReader excelReader;



            if (Path.GetExtension(path).ToUpper() == ".XLS")
            {
                excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            }
            else
            {
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            }

            while (excelReader.Name != sheet)
            {
                excelReader.NextResult();
            }
            count = excelReader.RowCount;
            excelReader.Close();
            return count;
        }
    }
}
