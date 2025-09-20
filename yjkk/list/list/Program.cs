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
            List<string> ishod = new List<string>();
            Console.WriteLine("Исходный размер списка = " + ishod.Count);
            ishod.Add("Маша");
            ishod.Add("Ирина");
            ishod.Add("Кира");
            ishod.Add("Егор");
            ishod.Add("Алина");
            Console.WriteLine("Размер списка после добавления элемента " + ishod.Count);

            List<string> conez = new List<string>();
            Console.WriteLine("Введите текст: ");
            conez.Add(Console.ReadLine());
        }
    }
}
