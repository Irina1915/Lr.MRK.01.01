using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Analysis
{
    internal class ProfitAnalyzer
    {
        public static double CalculateProfitPercentByItem(string filmsName, SalesModel model)
        {
            /// 1. Получить выручку товара (услуги, ....) itemName
            List<Viewing> filmsViewing = model.LoadSalesForItem(filmsName);
            Films targetFilms = model.GetItem(filmsName);
            if (targetFilms == null)
            {
                return 0.0;
            }
            double itemTotal = filmsViewing.Sum(sale => sale.Count * targetFilms.Price);

            /// 2. Получить общую выручку
            double total = model.GetTotalProfit();
            if (total == 0.0)
            {
                return 0.0;
            }

            return itemTotal / total * 100.0;
        }

    }
}
