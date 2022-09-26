using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI.Components.Business.Stock
{
    public class StockComponent
    {
        public static void Action(List<Entity.Concrete.Stock> stocks)
        {
            DesktopUI.Business.StockManager.MapFilePropertiesOnStock(stocks);                     
        }
    }
}
