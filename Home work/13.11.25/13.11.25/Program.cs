using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _13._11._25.Sale_of_phones;

namespace _13._11._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------АНАЛИЗ ПРОДАЖ МОБИЛЬНЫХ ТЕЛЕФОНОВ------");
            // Создал список и заполнил его данными
            List<Sale_of_phones> Phone = new List<Sale_of_phones>();
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 12), PhoneModel = "Iphone 16", Quantity = 7, Price = 89900 });
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 12), PhoneModel = "Samsung Galaxy A51", Quantity = 4, Price = 69900 });
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 13), PhoneModel = "IPhone Pro 15", Quantity = 5, Price = 119000 });
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 13), PhoneModel = "Samsung Galaxy A51", Quantity = 1, Price = 55900 });
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 14), PhoneModel = "Samsung Galaxy S27", Quantity = 3, Price = 81900 });
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 14), PhoneModel = "Iphone 16", Quantity = 2, Price = 99000 });
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 15), PhoneModel = "Samsung Galaxy S27", Quantity = 2, Price = 89900 });
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 15), PhoneModel = "IPhone Pro 15", Quantity = 5, Price = 99000 });
            // Задаем временной диапазон для анализа данных
            DateTime startDate = new DateTime(2025, 11, 12);
            DateTime endDate = new DateTime(2025, 11, 15);
            // а) Общая сумма проданного за период
            Console.WriteLine($"а) Общая сумма проданных телефонов за период: " + Functions.FindSalesPrice(Phone, startDate, endDate) + " рублей");
            // б) Самый продаваемый телефон и телефон с наименьшими продажами
            string bestSellingPhone = Functions.FindBestPhoneModel(Phone);
            string worstSellingPhone = Functions.FindWorstPhoneModel(Phone);
            Console.WriteLine("б) Самый продаваемый телефон и телефон с наименьшими продажами");
            Console.WriteLine($"       Самый продаваемый телефон: {bestSellingPhone}");
            Console.WriteLine($"       Телефон с наименьшими продажами: {worstSellingPhone}");
            // в) Два телефона, приносящие наибольшую прибыль
            string[] profitablePhones = Functions.FindProfitablePhones(Phone);
            Console.WriteLine("в) Два телефона, приносящие наибольшую прибыль:");
            Console.WriteLine($"       1. {profitablePhones[0]}");
            Console.WriteLine($"       2. {profitablePhones[1]}");
            // Отображение временного ряда, сортировка по дате
            Console.WriteLine("Временной ряд продаж:");
            Console.WriteLine("Дата            Модель                  Количество      Выручка");
            Console.WriteLine("---------------------------------------------------------------------");
            var timeSeries = Phone.OrderBy(sale => sale.Date);                 // сортировка всех продаж по дате
            foreach (var sale in timeSeries)
            {
                Console.WriteLine($"{sale.Date:dd.MM.yyyy}      {sale.PhoneModel,-20}    {sale.Quantity}               {sale.Revenue} рублей");
            }
        }
    }
}
