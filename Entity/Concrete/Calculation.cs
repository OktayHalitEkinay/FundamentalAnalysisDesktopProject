using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Calculation
    {
        public string StockName { get; set; }
        public string ItemName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public double FirstPrice { get; set; }
        public double SecondPrice { get; set; }
        public double ProportionalQuantity { get; set; }
        public double NumericalQuantity { get; set; }
        public bool StartDateState { get; set; }
        public bool EndDateState { get; set; }
        public bool StockHasTheItemState { get; set; }

    }
}
