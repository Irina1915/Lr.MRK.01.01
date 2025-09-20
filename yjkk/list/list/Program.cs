using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("Исходный размер списка = " + list.Count);
            list.Add("Маша");
            list.Add("Ирина");
            list.Add("Кира");
            list.Add("Егор");
            list.Add("Алина");
            Console.WriteLine("Размер списка после добавления элемента " + list.Count);

        }
    }
}
