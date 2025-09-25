using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] read = new int[4000];
            for (int i = 0; i < read.Length; i++)
            {
                Random rnd = new Random();
                int month = rnd.Next(1, 5001); // Получаем число в диапазоне от 1 до 5000
            }

        }
    }
}
