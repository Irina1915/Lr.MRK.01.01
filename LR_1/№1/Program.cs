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

            Console.WriteLine($"Введите {n} целых чисел:");
            // Цикл для ввода каждого элемента массива
            for (int i = 0; i < n; i++)
            {
                // Ввод и проверка, что введено целое число
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Некорректный ввод. Введите целое число:");
                }
            }

            // Проверка, есть ли в массиве повторяющиеся элементы
            bool hasDuplicates = array.Distinct().Count() != array.Length;
            // Если количество уникальных элементов не равно длине массива, значит есть дубли

            Console.WriteLine($"Массив содержит одинаковые элементы: {hasDuplicates}");
            // Вывод результата проверки
        }
    }
}
