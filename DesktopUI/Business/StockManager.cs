using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Business
{
    public static class StockManager
    {      
        public static void MapFilePropertiesOnStock(List<Stock> stocks)
        {
            string[] _pathsOfFiles = FileManager.GetPathsOfFiles();
            foreach (var filePath in _pathsOfFiles)
            {
                string fileName = Path.GetFileName(filePath);
                string[] splittedFileName = fileName.Split(' ');
                string stockName = splittedFileName[0];
                stocks.Add(new Stock { Name = stockName, Path = filePath });
            }
        }
    }
}
