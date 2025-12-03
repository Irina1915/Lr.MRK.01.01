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
            Console.WriteLine("=== Демонстрация кэширующего прокси ===\n");

            // Создаем реальный сервис и прокси с кэшем на 1 минуту
            IDataService realService = new RemoteApiService();
            IDataService proxyService = new CachingProxyService(realService, cacheMinutes: 1);

            string resourceId = "weather/moscow";

            Console.WriteLine("Первый запрос (должен идти в API):");
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            string result1 = proxyService.FetchData(resourceId);
            stopwatch.Stop();
            Console.WriteLine($"Результат: {result1}");
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс\n");

            Console.WriteLine("Второй запрос (должен браться из кэша):");
            stopwatch.Restart();
            string result2 = proxyService.FetchData(resourceId);
            stopwatch.Stop();
            Console.WriteLine($"Результат: {result2}");
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс\n");

            // Ждем немного и делаем запрос с другим ID
            Console.WriteLine("Запрос с другим ID (должен идти в API):");
            stopwatch.Restart();
            string result3 = proxyService.FetchData("currency/USD");
            stopwatch.Stop();
            Console.WriteLine($"Результат: {result3}");
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс\n");

            Console.WriteLine("Повторный запрос для второго ID (должен браться из кэша):");
            stopwatch.Restart();
            string result4 = proxyService.FetchData("currency/USD");
            stopwatch.Stop();
            Console.WriteLine($"Результат: {result4}");
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс\n");

            // Ждем, пока кэш устареет
            Console.WriteLine("Ждем 2 секунды (больше времени жизни кэша)...");
            Thread.Sleep(2000);

            Console.WriteLine("Запрос после ожидания (должен идти в API, так как кэш устарел):");
            stopwatch.Restart();
            string result5 = proxyService.FetchData(resourceId);
            stopwatch.Stop();
            Console.WriteLine($"Результат: {result5}");
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        }
    }
}
