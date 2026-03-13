using ClassLibrary.Analysis;
using ClassLibrary.Models;
using ClassLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Presenters
{
    internal class SalesPresenter
    {
        private SalesModel model_ = new SalesModel();
        private List<ISalesView> views_;
        public SalesPresenter(List<ISalesView> views)
        {
            views_ = views;

            model_.Load();
        }

        public void ShowSalesByItem(string filmsName)
        {
            List<Viewing> viewing = model_.LoadSalesForItem(filmsName);
            foreach (ISalesView view in views_)
            {
                view.Show(viewing);
            }
        }


        public List<Films> GetAllFilms()
        {
            return model_.GetAllFilms();
        }


        public double GetProfitPercentByItem(Films selectedItem)
        {
            double result = ProfitAnalyzer.CalculateProfitPercentByItem(selectedItem.Name,
                                                               model_);
            return Math.Round(result, 2);
        }

    }

}
