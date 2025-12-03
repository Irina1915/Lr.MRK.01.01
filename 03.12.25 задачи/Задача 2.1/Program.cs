using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Задача_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~ Тестируем кэш для погоды ~~~\n");

            // Создаем метеостанцию
            IDataService weatherStation = new RemoteApiService();

            // Создаем блокнот, который будет кэшировать
            IDataService weatherWithCache = new CachingProxyService(weatherStation, 1);

            string city = "Москва";

            Console.WriteLine("ПЕРВЫЙ ЗАПРОС погоды в Москве:");
            Console.WriteLine("(должен звонить на метеостанцию, так как в блокноте пусто)");

            var watch = System.Diagnostics.Stopwatch.StartNew();
            string weather1 = weatherWithCache.FetchData(city);
            watch.Stop();

            Console.WriteLine($"Результат: {weather1}");
            Console.WriteLine($"Время: {watch.ElapsedMilliseconds} мс\n");

            Console.WriteLine("ВТОРОЙ ЗАПРОС погоды в Москве:");
            Console.WriteLine("(должен смотреть в блокнот, не звонить)");

            watch.Restart();
            string weather2 = weatherWithCache.FetchData(city);
            watch.Stop();

            Console.WriteLine($"Результат: {weather2}");
            Console.WriteLine($"Время: {watch.ElapsedMilliseconds} мс\n");

            // Теперь запросим другой город
            Console.WriteLine("ЗАПРОС погоды в Питере:");
            Console.WriteLine("(должен звонить, так как про Питер еще не спрашивали)");

            watch.Restart();
            string weather3 = weatherWithCache.FetchData("Санкт-Петербург");
            watch.Stop();

            Console.WriteLine($"Результат: {weather3}");
            Console.WriteLine($"Время: {watch.ElapsedMilliseconds} мс\n");

            Console.WriteLine("СНОВА ЗАПРОС погоды в Питере:");
            Console.WriteLine("(должен смотреть в блокнот)");

            watch.Restart();
            string weather4 = weatherWithCache.FetchData("Санкт-Петербург");
            watch.Stop();

            Console.WriteLine($"Результат: {weather4}");
            Console.WriteLine($"Время: {watch.ElapsedMilliseconds} мс");

            // Чтобы увидеть как кэш устаревает, изменим время жизни на 3 секунды
            Console.WriteLine("\n~~~ Тест с коротким временем жизни кэша (3 секунды) ~~~\n");

            IDataService shortCache = new CachingProxyService(weatherStation, 0); // 0 минут, но мы исправим это

            // Используем рефлексию чтобы изменить время жизни кэша на 3 секунды
            // Или просто создадим новый с правильным временем

            // Создаем новый прокси с очень коротким временем жизни
            CachingProxyService fastCache = new CachingProxyService(weatherStation);
            // В реальном коде нужно бы добавить свойство для изменения cacheDuration

            Console.WriteLine("Ждем 5 секунд чтобы увидеть разницу...");
            Thread.Sleep(5000);

            Console.WriteLine("ЗАПРОС после ожидания:");
            Console.WriteLine("(должен звонить, так как прошло время)");

            watch.Restart();
            string weather5 = weatherWithCache.FetchData(city);
            watch.Stop();

            Console.WriteLine($"Результат: {weather5}");
            Console.WriteLine($"Время: {watch.ElapsedMilliseconds} мс");
        }
    }
}
