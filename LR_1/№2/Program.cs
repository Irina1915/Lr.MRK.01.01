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
            // С клавиатуры ввести массив из n вещественных чисел.
            Console.WriteLine("Сколько элементов будет в массиве: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; i + 1 < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
        }
    }
}
