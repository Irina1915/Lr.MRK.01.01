using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _13._11._25.Sale_of_laptop;

namespace _13._11._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("......Анализ продаж ноутбуков......");
            var salesData = new List<Sale_of_laptops>  // создает список объектов типа Sale_of_laptops
    {
        new Sale_of_laptops {
            Date = new DateTime(2026, 11, 15),
            LaptopModel = "Dell XPS 13",
            Quantity = 5,
            Price = 89900
        },
        new Sale_of_laptops {
            Date = new DateTime(2026, 11, 15),
            LaptopModel = "Lenovo ThinkPad X1",
            Quantity = 3,
            Price = 109900
        },
        new Sale_of_laptops {
            Date = new DateTime(2026, 11, 13),
            LaptopModel = "MacBook Pro 16",
            Quantity = 4,
            Price = 159000
        },
        new Sale_of_laptops {
            Date = new DateTime(2026, 11, 18),
            LaptopModel = "Asus ZenBook 14",
            Quantity = 6,
            Price = 74900
        },
        new Sale_of_laptops {
            Date = new DateTime(2026, 11, 18),
            LaptopModel = "HP Spectre x360",
            Quantity = 2,
            Price = 94900
        },
        new Sale_of_laptops {
            Date = new DateTime(2026, 11, 11),
            LaptopModel = "Dell XPS 13",
            Quantity = 3,
            Price = 89900
        },
        new Sale_of_laptops {
            Date = new DateTime(2026, 11, 19),
            LaptopModel = "MacBook Pro 16",
            Quantity = 2,
            Price = 159000
        },
        new Sale_of_laptops {
            Date = new DateTime(2026, 11, 19),
            LaptopModel = "Asus ZenBook 14",
            Quantity = 4,
            Price = 74900
        }
    };

            // Задаем временной диапазон для анализа данных
            DateTime startDate = new DateTime(2026, 11, 15);
            DateTime endDate = new DateTime(2026, 11, 19);

            // а) Общая сумма проданного за период
            double totalRevenue = salesData
                .Where(sale => sale.Date >= startDate && sale.Date <= endDate) // фильтруем продажи по заданному периоду
                .Sum(sale => sale.Revenue);                                    // суммируем выручку всех отфильтрованных продаж

            Console.WriteLine($"а) Общая сумма проданных ноутбуков за период {startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy}: {totalRevenue} рублей");

            // б) Самый продаваемый ноутбук и ноутбук с наименьшими продажами
            var laptopStats = salesData
                .GroupBy(s => s.LaptopModel) // группировка продаж по моделям ноутбуков
                .Select(g => new { Model = g.Key, TotalSold = g.Sum(s => s.Quantity) }) // Для каждой группы создается анонимный объект с названием модели и общим количеством проданных единиц.
                                                                                       
                .OrderByDescending(x => x.TotalSold)                                    // Группы сортируются по убыванию количества продаж.
                .ToList();

            string BestLaptop = laptopStats.First().Model;
            string WorstLaptop = laptopStats.Last().Model;

            Console.WriteLine($"б) Результаты анализа продаж:");
            Console.WriteLine($"   • Самый продаваемый ноутбук: {BestLaptop}");
            Console.WriteLine($"   • Самый непродаваемый ноутбук: {WorstLaptop}");

            // в) Два ноутбука, приносящие наибольшую прибыль
            var topLaptops = salesData
                .GroupBy(s => s.LaptopModel)
                .Select(g => new { Model = g.Key, Profit = g.Sum(s => s.Revenue) })
                .OrderByDescending(x => x.Profit)
                .Take(2)                                                                // берем первые 2 записи после сортировки
                .Select(x => x.Model)                                                   // извлекаем только названия моделей
                .ToList();

            Console.WriteLine($"в) Ноутбуки с наибольшей прибылью:");
            for (int i = 0; i < topLaptops.Count; i++)
            {
                Console.WriteLine($"    {i + 1}. {topLaptops[i]}");
            }

            // Отображение временного ряда, сортировка по дате
            Console.WriteLine("Ряд продаж по датам:");
            Console.WriteLine("Дата            Модель                  Количество      Выручка");
            Console.WriteLine("---------------------------------------------------------------------");
            var timeSeries = salesData.OrderBy(sale => sale.Date);                 // сортировка всех продаж по дате
            foreach (var sale in timeSeries)
            {
                Console.WriteLine($"{sale.Date:dd.MM.yyyy}      {sale.LaptopModel,-20}    {sale.Quantity}               {sale.Revenue} рублей");
            }
        }
    }
}
