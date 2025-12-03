using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Матрицы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Разработать класс матрица целых чисел, операции возможность показать количество строк
            // столбцов матрицы, указать значения определенной строки или столбца, указать значение ячейки,
            // получить значение ячейки, для квадратной матрицы прочитать определитель.
            // Реализовать функцию умножения матриц

            // Создание матрицы
            MatrixOfIntegers matrix = new MatrixOfIntegers();
            matrix.SetRows(3);
            matrix.SetCols(3);
            matrix.SetData(new int[9]);

            // Заполнение матрицы циклом
            int value = 1;
            for (int i = 0; i < matrix.GetRows(); i++)
            {
                for (int j = 0; j < matrix.GetCols(); j++)
                {
                    matrix.SetValue(i, j, value);
                    value++;
                }
            }
            Console.WriteLine("------ ИНФОРМАЦИЯ О МАТРИЦЕ ------");

            // 1. Показ матрицы
            Console.WriteLine("1. Матрица 3x3:");
            for (int i = 0; i < matrix.GetRows(); i++)          // Цикл по всем строкам матрицы
            {
                for (int j = 0; j < matrix.GetCols(); j++)      // Цикл по всем столбцам матрицы
                {
                    Console.Write(matrix.GetValue(i, j) + " ");
                }
                Console.WriteLine();
            }
            // 2. Показ количество строк и столбцов
            Console.WriteLine("2. Размер матрицы:");
            Console.WriteLine($"Количество строк: {matrix.GetRows()}");
            Console.WriteLine($"Количество столбцов: {matrix.GetCols()}");

            // 3. Вопросы о конкретной строке
            Console.Write("3. Введите номер строки для показа (0-2): ");
            int rowNumber = int.Parse(Console.ReadLine());         // Преобразуем ввод пользователя в число
            if (rowNumber >= 0 && rowNumber < matrix.GetRows())    // Проверка, что номер строки находится в диапазоне
            {
                int[] row = matrix.GetRow(rowNumber);   // Поллучение массива с элементами строки, которую мы указали
                Console.WriteLine($"Строка {rowNumber}: " + string.Join(", ", row));
            }
            else
            {
                Console.WriteLine("Неверный номер строки!");
            }

            // 4. Вопросы о конкретном столбце
            Console.Write("4. Введите номер столбца для показа (0-2): ");
            int colNumber = int.Parse(Console.ReadLine());

            if (colNumber >= 0 && colNumber < matrix.GetCols())
            {
                int[] column = matrix.GetColumn(colNumber);
                Console.WriteLine($"Столбец {colNumber}: " + string.Join(", ", column));
            }
            else
            {
                Console.WriteLine("Неверный номер столбца!");
            }

            // 5. Вопросы о кенкретной ячейке
            Console.Write("5. Введите номер строки для ячейки (0-2): ");
            int cellRow = int.Parse(Console.ReadLine());
            Console.Write("Введите номер столбца для ячейки (0-2): ");
            int cellCol = int.Parse(Console.ReadLine());

            if (cellRow >= 0 && cellRow < matrix.GetRows() && cellCol >= 0 && cellCol < matrix.GetCols())
            {
                Console.WriteLine($"Ячейка [{cellRow},{cellCol}]: {matrix.GetValue(cellRow, cellCol)}");
            }
            else
            {
                Console.WriteLine("Неверные координаты ячейки!");
            }

            // 6. Проверка квадратная ли матрица
            Console.WriteLine("6. Проверка на квадратность:");
            if (matrix.IsSquare())
            {
                Console.WriteLine("Матрица квадратная");
            }
            else
            {
                Console.WriteLine("Матрица не квадратная");
            }
            Console.WriteLine("------ ВСЕ ОПЕРАЦИИ ЗАВЕРШЕНЫ ------");
        }
    }
}

