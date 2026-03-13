using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    internal class SalesModel
    {
        private Dictionary<Films, List<Viewing>> viewingsByFilms_ =
            new Dictionary<Films, List<Viewing>>();

        public void AddSales(Films films, List<Viewing> viewings)
        {
            if (viewingsByFilms_.ContainsKey(films))
            {
                viewingsByFilms_[films].AddRange(viewings);
            }
            else
            {
                viewingsByFilms_.Add(films, viewings);
            }
        }

        public List<Viewing> LoadSalesForItem(string filmsName)
        {
            List<Films> allFilms = viewingsByFilms_.Keys.ToList();
            Films targetFilms = allFilms.Find(films => films.Name == filmsName);
            if (targetFilms != null)
            {
                return viewingsByFilms_[targetFilms];
            }

            return new List<Viewing>();
        }

        public bool Load()
        {
            AddSales(new Films { Name = "Человек-паук", Price = 5000 },
                new List<Viewing>() {
                    new Viewing {Time = new System.DateTime(2026, 3, 13), Count = 1 } ,
                    new Viewing {Time = new System.DateTime(2026, 4, 9), Count = 2 } ,
                    new Viewing {Time = new System.DateTime(2026, 6, 10), Count = 2 } ,
                    new Viewing {Time = new System.DateTime(2026, 3, 21), Count = 3 } ,

                });

            AddSales(new Films { Name = "Гадкий я", Price = 270 },
                new List<Viewing>() {
                    new Viewing {Time = new System.DateTime(2026, 3, 16), Count = 1 } ,
                    new Viewing {Time = new System.DateTime(2026, 7, 5), Count = 5 } ,
                    new Viewing {Time = new System.DateTime(2026, 6, 1), Count = 3 } ,
                    new Viewing {Time = new System.DateTime(2026, 3, 30), Count = 1 } ,

               });

            return true;
        }

        public List<Films> GetAllFilms()
        {
            return viewingsByFilms_.Keys.ToList();
        }

        public double GetTotalProfit()
        {
            double result = 0.0;
            foreach (KeyValuePair<Films, List<Viewing>> keyValue in viewingsByFilms_)
            {
                Films item = keyValue.Key;
                result += keyValue.Value.Sum(sale => sale.Count * item.Price);
            }

            return result;
        }

        public Films GetItem(string filmsName)
        {
            foreach (KeyValuePair<Films, List<Viewing>> keyValue in viewingsByFilms_)
            {
                Films films = keyValue.Key;
                if (films.Name == filmsName)
                {
                    return films;
                }
            }

            return null;
        }

    }
}
