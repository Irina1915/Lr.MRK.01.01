using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------АНАЛИЗ ПРОДАЖ МОБИЛЬНЫХ ТЕЛЕФОНОВ------");
            var salesData = CreateSampleData();
            var analyzer = new Telephone_sales_analysis(salesData);
            DateTime startDate = new DateTime(2026, 11, 10);
            DateTime endDate = new DateTime(2026, 11, 19);
            double totalRevenue = analyzer.ReceivingTotalIncome(startDate, endDate);
            // а) Общая сумма проданного за период
            Console.WriteLine($"а) Общая сумма проданных телефонов за период {startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy}: {totalRevenue} рублей");
            // б) Самый продаваемый телефон и телефон с наименьшими продажами
            analyzer.TheBestAndWorstPhone(out string BestPhone, out string WorstPhone);
            Console.WriteLine($"б) Результаты анализа продаж:");
            Console.WriteLine($"   • Самый продаваемый телефон: {BestPhone}");
            Console.WriteLine($"   • Самый непродаваемый телефон: {WorstPhone}");
            // в) Два телефона, приносящие наибольшую прибыль
            var topProfitablePhones = analyzer.GetTopTwoProfitablePhones();
            Console.WriteLine($"в) Телефоны с наибольшей прибылью:");
            for (int i = 0; i < topProfitablePhones.Count; i++)
            {
                Console.WriteLine($"    {i + 1}. {topProfitablePhones[i]}");
            }
            // Отображение временного ряда
            Console.WriteLine("4. Временной ряд продаж:");
            analyzer.DisplayTimeSeries();
        }

        // Метод для создания тестовых данных
        private static List<Sale_of_phones> CreateSampleData()
        {
            return new List<Sale_of_phones>
        {
            new Sale_of_phones {
                Date = new DateTime(2026, 11, 10),
                PhoneModel = "Redmi Not 12+",
                Quantity = 30,
                Price = 75900,
                Cost = 64000
            },
            new Sale_of_phones {
                Date = new DateTime(2026, 11, 10),
                PhoneModel = "Redmi Not 12",
                Quantity = 6,
                Price = 54500,
                Cost = 43000
            },
            new Sale_of_phones {
                Date = new DateTime(2026, 11, 16),
                PhoneModel = "IPhone 17",
                Quantity = 2,
                Price = 119000,
                Cost = 80000
            },
            new Sale_of_phones {
                Date = new DateTime(2026, 11, 16),
                PhoneModel = "Honor 10 Lite",
                Quantity = 7,
                Price = 46900,
                Cost = 37000
            },
            new Sale_of_phones {
                Date = new DateTime(2026, 11, 18),
                PhoneModel = "Samsung Live 24",
                Quantity = 8,
                Price = 81900,
                Cost = 65000
            },
            new Sale_of_phones {
                Date = new DateTime(2026, 11, 18),
                PhoneModel = "Huawey",
                Quantity = 1,
                Price = 55000,
                Cost = 35000
            },
            
            // Данные за 13 января
            new Sale_of_phones {
                Date = new DateTime(2026, 11, 19),
                PhoneModel = "IPhone 16",
                Quantity = 5,
                Price = 89900,
                Cost = 60000
            },
            new Sale_of_phones {
                Date = new DateTime(2026, 11, 19),
                PhoneModel = "Redmi 12 4G",
                Quantity = 3,
                Price = 80000,
                Cost = 62300
            }
        };
        }
    }
    }

