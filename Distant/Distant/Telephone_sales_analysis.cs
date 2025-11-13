using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distant
{
    internal class Telephone_sales_analysis
    {
        // Поле для списка объектов класса Sale_of_phones, salesData хранение всех данных о продажах
        private List<Sale_of_phones> salesData;
        // Конструктор класса, принимает список продаж
        public Telephone_sales_analysis(List<Sale_of_phones> data)
        {
            salesData = data;
        }

        // а) Метод для определения общей суммы проданного за период
        public double ReceivingTotalIncome(DateTime startDate, DateTime endDate)
        {
            // Фильтрование продаж по заданным периодам времени
            var periodSales = salesData.Where(sale => sale.Date >= startDate && sale.Date <= endDate);
            // Суммирование выручки от всех отфильтрованных продаж
            return periodSales.Sum(sale => sale.Revenue);
        }
        // б) Метод для определения самого продаваемого телефона и телефона с наименьшими продажами
        public void TheBestAndWorstPhone(out string BestPhone, out string WorstPhone)
        {
            // Группируем продажи по модели телефона
            var PhoneGroups = salesData.GroupBy(sale => sale.PhoneModel);
            // Для каждой группы вычисляем общее количество проданных единиц
            var PhoneStats = PhoneGroups.Select(group => new
            {
                PhoneModel = group.Key,                   // Название модели
                TotalSold = group.Sum(s => s.Quantity)    // Сумма проданных единиц
            })
                .OrderByDescending(x => x.TotalSold)     // Сортировка по убыванию количества
                .ToList();                               // Преобразование его в список

            // Самый лучший телефон (первый в списке)
            BestPhone = PhoneStats.First().PhoneModel;
            // Самый худший телефон (последний в списке)
            WorstPhone = PhoneStats.Last().PhoneModel;
        }
        // в) Метод для определения двух телефонов, приносящих наибольшую прибыль
        public List<string> GetTopTwoProfitablePhones()
        {

            // Группируем продажи по модели телефона
            var PhoneGroups = salesData.GroupBy(sale => sale.PhoneModel);

            // Для каждой группы вычисляем общую прибыль
            var ProfitablePhones = PhoneGroups.Select(group => new
            {
                PhoneModel = group.Key,                    // Название модели
                TotalProfit = group.Sum(s => s.Profit)    // Суммарная прибыль
            })
                .OrderByDescending(x => x.TotalProfit)   // Сортировка по убыванию прибыли
                .Take(2)                                 // Выдаем две первые записи
                .Select(x => x.PhoneModel)               // Выдача только названия моделей
                .ToList();                               // Преобразование в список
            return ProfitablePhones;
        }
        // Метод представления данных как временной ряд
        public void DisplayTimeSeries()
        {
            // Сортируем данные по дате для представления как временного ряда
            var timeSeries = salesData.OrderBy(sale => sale.Date);
            Console.WriteLine("Дата\t\tМодель\t\t\tКоличество\tВыручка");
            Console.WriteLine("---------------------------------------------------------------------");
            // Выводим каждую запись в формате временного ряда
            foreach (var sale in timeSeries)
            {
                Console.WriteLine($"{sale.Date:dd.MM.yyyy}\t{sale.PhoneModel,-20}\t{sale.Quantity}\t\t{sale.Revenue} рублей");
            }
        }
    }
}
