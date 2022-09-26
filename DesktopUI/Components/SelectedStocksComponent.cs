using DesktopUI.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Components.SelectedStocksComponent
{
    class SelectedStocksComponent
    {
        public static void Action(List<Entity.Concrete.Stock> selectedStocks)
        {
            SelectedStocksManager.x(selectedStocks);
        }
    }
}
