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
    class Program
    {
        static void Print(List<string> tovars)
        {
            Console.WriteLine(String.Join(","));
        }
        static void Main()
        {
            string[] genres = new string[] { "Спиннинги", "Поплавочные снасти", "Фидеры", "Лески" };
            var (tovars, counts) = InputModel.InputTovarsByCenre();

            string userQuery = InputModel.InputUserQuery();

            int indexGenre = SearchingModule.FindIndexGenre(userQuery, genres);
            var (tovarsUserGenre, coutsUserGenre) = SearchingModule.FindAllTovarsByCenre(indexGenre, tovars, counts);

            AnalysisDataModule.SortTovars(tovarsUserGenre, coutsUserGenre);
            Print(tovarsUserGenre);
        }
    }
}
