using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2new
{
    internal class InputModel
    {
        public (List<string>[], List<int>[]) InputTovarsByCenre()
        {
            List<string>[] tovarsByKategoria = new List<string>[2];
            List<int>[] counts = new List<int>[4];

            //Заполняем товар Спиннинг (нулевой индекс)
            tovarsByKategoria[0].Add("Спиннинг b6");
            counts[0].Add(10);
            tovarsByKategoria[0].Add("Спиннинг k2");
            counts[0].Add(5);
            tovarsByKategoria[0].Add("Спиннинг y78");
            counts[0].Add(1);

            //Заполняем товар Поплавочные снасти (первый индекс)
            tovarsByKategoria[0].Add("Попловочная снасть 1");
            counts[1].Add(6);
            tovarsByKategoria[0].Add("Попловочная снасть 2");
            counts[1].Add(5);
            tovarsByKategoria[0].Add("Попловочная снасть 3");
            counts[1].Add(4);

            //Заполняем товар Фидеры (второй индекс)
            tovarsByKategoria[0].Add("Фидер 1");
            counts[2].Add(2);
            tovarsByKategoria[0].Add("Фидер 2");
            counts[2].Add(9);
            tovarsByKategoria[0].Add("Фидер 3");
            counts[3].Add(5);

            //Заполняем товар Лески (третий индекс)
            tovarsByKategoria[0].Add("Леска 1");
            counts[4].Add(1);
            tovarsByKategoria[0].Add("Леска 2");
            counts[4].Add(8);
            tovarsByKategoria[0].Add("Леска 3");
            counts[4].Add(3);

            return (tovarsByKategoria, counts);
        }
        public string InputUserQuery()
        {
            Console.WriteLine("Введите, пожалуйста, категорию (Спиннинги, Поплавочные снасти, Фидеры, Лески): ");
            return Console.ReadLine();
        }
    }
}
