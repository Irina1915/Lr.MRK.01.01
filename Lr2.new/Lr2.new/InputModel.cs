using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2new
{
    internal class InputModule
    {
        static public (List<string>[], List<int>[]) InputTovarsByKatalog()
        {
            List<string>[] TovarsByKatalog = new List<string>[3] { new List<string>(),
                                                                new List<string>(),
                                                                new List<string>()
            };

            List<int>[] counts = new List<int>[3]{ new List<int>(),
                                                   new List<int>(),
                                                   new List<int>()
            };

            TovarsByKatalog[0].Add("Спиннинг1");
            counts[0].Add(10);
            TovarsByKatalog[0].Add("Спиннинг2");
            counts[0].Add(5);
            TovarsByKatalog[0].Add("Спиннинг3");
            counts[0].Add(1);

            TovarsByKatalog[1].Add("Леска1");
            counts[1].Add(2);
            TovarsByKatalog[1].Add("Леска2");
            counts[1].Add(25);

            TovarsByKatalog[2].Add("Фридер1");
            counts[2].Add(30);

            return (TovarsByKatalog, counts);
        }
        static public string InputUserQuery()
        {
            Console.Write("Введите, пожалуйста, каталог (Спиннинги/Лески/Фридеры): ");
            return Console.ReadLine();
        }

    }

}
