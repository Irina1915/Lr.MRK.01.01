using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Задача_2._1
{
    public class RemoteApiService : IDataService
    {
        public string FetchData(string resourceId)
        {
            // Имитация долгого сетевого запроса
            Console.WriteLine($"Запрос к удаленному API для {resourceId}...");
            Thread.Sleep(2000); // 2 секунды ожидания

            // Имитация реальных данных
            string data = $"Данные для {resourceId} сгенерированы в {DateTime.Now:HH:mm:ss}";
            Console.WriteLine($"API вернул данные для {resourceId}");

            return data;
        }
    }

}
