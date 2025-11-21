using Lr2.@new;
using Lr2new;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lr2.@new
{
    internal class Program
    {
        static void Print(List<string> tovars)
        {
            Console.WriteLine(String.Join(", ", tovars));
        }
        static void Main()
        {
            string[] katalog = new string[] { "Спиннинги", "Лески", "Фридеры" };
            var (tovars, counts) = InputModule.InputTovarsByKatalog();
            string userQuery = InputModule.InputUserQuery();
            int indexKatalog = SearchingModule.FindIndexKatalog(userQuery, katalog);
            if (indexKatalog < 0)
            {
                Console.WriteLine("Указан несуществующий жанр");
                return;
            }
            var (TovarsUserKatalog, countsUserKatalog) = SearchingModule.FindAllTovarsByKatalog(indexKatalog, tovars, counts);
            AnalysisDataModule.Sorttovars(TovarsUserKatalog, countsUserKatalog);
            Print(TovarsUserKatalog);
        }
    }
}
