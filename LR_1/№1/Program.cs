using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. С клавиатуры ввести массив из n целых чисел. Определить, есть ли в массиве одинаковые элементы.

            Console.WriteLine("Введите количество элементов массива (n):");
            int n;
            // Вводим количество элементов и проверяем, что оно является положительным целым числом
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Пожалуйста, введите положительное целое число для n:");
            }

            int[] array = new int[n]; // Создаем массив длины n

           
        }
    }
}
