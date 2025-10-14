using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Дана последовательность из 4000 случайных чисел от 1 до 5000. Сохранить в отдельной структуре данных сумму пар соседних элементов, находящихся на четных позициях (0 и 2, 2 и 4, 4 и 6 и т.д). Результат вывести на экран в формате: [a1, a2, a3, ….., an], где а – очередное найденное число.
            Random rnd = new Random();
            int size = 4000;
            int[] sequence = new int[size];

            for (int i = 0; i < size; i++)
            {
                sequence[i] = rnd.Next(1, 5001); // числа от 1 до 5000
            }

            List<int> sums = new List<int>();

            // Перебираем четные позиции: 0, 2, 4, ... до size-2
            for (int i = 0; i < size - 2; i += 2)
            {
                int sum = sequence[i] + sequence[i + 2];
                sums.Add(sum);
            }

            // Вывод результата
            Console.WriteLine("Результат в формате: [a1, a2, a3, ….., an]");
            Console.WriteLine("[" + string.Join(", ", sums) + "]");
        }
    }
}
    
