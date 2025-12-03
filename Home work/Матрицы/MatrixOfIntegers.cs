using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Матрицы
{
    internal class MatrixOfIntegers
    {
        // Приватные поля для хранения состояния матрицы
        private int rows_;     // Количество строк в матрице
        private int cols_;     // Количество столбцов в матрице
        private int[] data_;   // Одномерный массив для хранения элементов матрицы в построчном порядке

        // Количество строк
        public int GetRows()
        {
            return rows_;
        }
        public void SetRows(int rows)
        {
            rows_ = rows;
        }

        // Количество столбцов
        public int GetCols()
        {
            return cols_;
        }
        public void SetCols(int cols)
        {
            cols_ = cols;
        }

        // Данные матрицы
        public int[] GetData()
        {
            return data_;
        }
        public void SetData(int[] data)
        {
            data_ = data;
        }

        // Получить значение из ячейки
        public int GetValue(int row, int col)
        {
            return data_[row * cols_ + col]; // Вычисление индекса в одномерном массиве
        }

        // Установить значение в ячейку
        public void SetValue(int row, int col, int value)
        {
            data_[row * cols_ + col] = value;  // Вычисление индекса и записывает значение
        }

        // Получить всю строку
        public int[] GetRow(int row)
        {
            int[] result = new int[cols_];    // Создает массив длинной в кол-во столбцов
            for (int j = 0; j < cols_; j++)
            {
                result[j] = GetValue(row, j); // Копирует элементы строки в массив
            }
            return result;
        }

        // Получить весь столбец
        public int[] GetColumn(int col)
        {
            int[] result = new int[rows_];    // Создает массив длинной в кол-во строк
            for (int i = 0; i < rows_; i++)
            {
                result[i] = GetValue(i, col); // Копирует элементы столбца в массив
            }
            return result;
        }

        // Проверить квадратная ли матрица
        public bool IsSquare()
        {
            return rows_ == cols_;
        }
    }
}
