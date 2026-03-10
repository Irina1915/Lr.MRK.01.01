using LiveCharts;
using LiveCharts.Wpf;
using SalesLibrary;
using SalesLibrary.Presenters;
using SalesLibrary.Views;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;
using System.Windows.Media;

namespace ChartTest.Views
{
    class SalesPieChart : LiveCharts.WinForms.PieChart
                                       
    {
        private LineSeries seriesData_;
        public SalesPieChart()
        {
            seriesData_ = new LineSeries
            {
                Title = "Продажи",

                Stroke = new SolidColorBrush(Colors.Blue),
                StrokeThickness = 2,

                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 7,

            };
        }
        private SalesPresenter presenter_;

        public void SetPresenter (SalesPresenter presenter)
        {
            presenter_ = presenter;
        }

        public void UpdateView()
        {
            List<Item> allItems = presenter_.GetAllItems();
            SeriesCollection seriesData = new SeriesCollection();
            foreach(Item item in allItems)
            {
                seriesData.Add(new PieSeries
                {
                    Title = item.Name,
                    Values = new ChartValues<double>() { presenter_.GetProfitPercentByItem(item)}
                });

            }
            Series = seriesData;
        }
    }
}
