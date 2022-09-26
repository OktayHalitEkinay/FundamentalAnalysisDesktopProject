using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class StockItem
    {
        public string StockName { get; set; }
        public string ItemName { get; set; }
        public List<double> PriceData { get; set; }
        public List<string> HistoryData { get; set; }
        public Dictionary<string, double> HistoryPriceDictionary { get; set; }
        public bool StartDateState { get; set; }
        public bool EndDateState { get; set; }
        public bool StockHasTheItemState { get; set; }
    }
}
