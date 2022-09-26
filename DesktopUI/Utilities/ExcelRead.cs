using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Utilities
{
    public static class ExcelRead
    {
        public static List<object> ReadRow(string path, string sheet, int row)
        {

            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            IExcelDataReader excelReader;
            List<object> liste = new List<object>();
            int counter = 0;

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
            while (excelReader.Read())
            {
                counter++;
                if (counter > row - 1 && counter < row + 1)//Hangi satır okunacaksa onu araya al.
                {
                    for (int i = 1; i < excelReader.FieldCount; i++)
                    {
                        if (excelReader.GetFieldType(i) == null)
                        {
                            if (row > 1)//Tarih satırının altındaki satırlar okunuyorsa.
                            {
                                liste.Add(0);
                            }
                            else//Tarih satırı(1. satır) okunuyorsa.
                            {
                                liste.Add("");
                            }
                        }
                        else
                        {
                            liste.Add(excelReader.GetValue(i));
                        }
                    }
                }
            }
            excelReader.Close();
            return liste;
        }
        public static List<object> ReadColumn(string path, string sheet, int row)
        {

            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            IExcelDataReader excelReader;
            List<object> liste = new List<object>();
            int counter = 0;

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
            while (excelReader.Read())
            {
                counter++;
                if (counter > row - 1 && counter < row + 1)//Hangi satır okunacaksa onu araya al.
                {
                    for (int i = 1; i < excelReader.FieldCount; i++)
                    {
                        //if (excelReader.GetFieldType(i) == null)
                        //{
                        //    excelReader.GetFieldType(i - 1);
                        //    liste.Add(null);//İlgili hücre boş ise onun yerine null ekliyor.
                        //}
                        //else
                        //{
                        liste.Add(excelReader.GetValue(i));
                        //}
                    }
                }
            }
            excelReader.Close();
            return liste;
        }
        public static List<object> ReadCell(string path, string sheet, int row)
        {

            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            IExcelDataReader excelReader;
            List<object> liste = new List<object>();
            int counter = 0;

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
            while (excelReader.Read())
            {
                counter++;
                if (counter > row - 1 && counter < row + 1)//Hangi satır okunacaksa onu araya al.
                {
                    for (int i = 1; i < excelReader.FieldCount; i++)
                    {
                        if (excelReader.GetValue(i) == null)
                        {
                            excelReader.GetFieldType(i - 1);
                            liste.Add(null);//İlgili hücre boş ise onun yerine null ekliyor.
                        }
                        else
                        {
                            liste.Add(excelReader.GetValue(i));
                        }
                    }
                }
            }
            excelReader.Close();
            return liste;
        }
        public static List<T> ReadLocal<T>(string path, string sheet, string scell, string fcell)
        {
            List<T> liste = new List<T>();
            IExcelDataReader excelReader = ReadHelper.SetExcelReader(path, sheet);
            
            int scol = 0;
            int fcol = 0;
            int srow = 0;
            int frow = 0;
            srow = ReadHelper.GetNumericValue(scell);
            scol = ReadHelper.GetAlphabeticOrderOfLetter(ReadHelper.GetAlphabeticValue(scell));
            frow = ReadHelper.GetNumericValue(fcell);
            fcol = ReadHelper.GetAlphabeticOrderOfLetter(ReadHelper.GetAlphabeticValue(fcell));
            ReadHelper.CheckForCellOrder(ref scol, ref fcol, ref srow, ref frow);
            int counter = 0;
            while (excelReader.Read())
            {
                counter++;
                if (counter > srow - 1 && counter < frow + 1)//Hangi satır okunacaksa onu araya al.
                {
                    for (int i = scol - 1; i < fcol-1; i++)
                    {
                        if (excelReader.GetValue(i)==null)
                        {
                            liste.Add(default(T)); //Eğer ilgili hücre boş ise onun yerine default değer koyuyor.
                        }
                        else
                        {
                            liste.Add((T)excelReader.GetValue(i));
                        }                        
                    }
                }
            }
            excelReader.Close();
            return liste;
        }
    }
}

