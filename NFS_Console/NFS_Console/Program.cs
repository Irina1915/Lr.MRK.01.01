using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NFS_Console
{
    class Program
    {
        static void PrintModel(Car avto) //функция
        {
            Console.WriteLine(avto.GetModel());
        }

        static void LadaVsMers(List<Car> avtos)
        {
            int t = 1;
            while (true)
            {
                Console.WriteLine("_________________________________________________________________________________");
                foreach (Car avto in avtos)
                {
                    int move = (avto.GetSpeed() / 50 * t);
                    for (int i = 1; i < move; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(avto.GetModel());
                    Console.WriteLine("_________________________________________________________________________________");
                }
                t++;
                Thread.Sleep(2000);
                Console.Clear();
            }
            foreach (Car avto in avtos)
            {
                Console.WriteLine(avto.GetSpeed());
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Car avto = new Car(); // 1 машина
            avto.SetModel("Lada");
            avto.SetSpeed(150);
            // Console.WriteLine(avto.GetModul() + " " + avto.GetSpeed());
            PrintModel(avto);

            Car avto2 = new Car(); // 2 машина
            avto2.SetModel("Mers");
            avto2.SetSpeed(60);
            // Console.WriteLine(avto.GetModul() + " " + avto.GetSpeed());
            PrintModel(avto2);

            List<Car> avtos = new List<Car>();   
            avtos.Add(avto);
            avtos.Add(avto2);
        }
       
    }
}
