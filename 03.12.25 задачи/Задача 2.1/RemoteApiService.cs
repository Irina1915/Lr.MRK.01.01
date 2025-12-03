using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Задача_2._1
{
    // Это настоящая метеостанция (долго отвечает)
    public class RemoteApiService : IDataService
    {
        public string FetchData(string resourceId)
        {
            // Делаем вид, что звоним по телефону и ждем ответ
            Console.WriteLine($"Звоню на метеостанцию, спрашиваю про: {resourceId}");
            Thread.Sleep(2000); // Ждем 2 секунды (как будто долгий звонок)

            // Получаем ответ
            Random random = new Random();
            string data = $"Погода для {resourceId}: {random.Next(-10, 25)}°C";
            Console.WriteLine($"Получил ответ от метеостанции");

            return data;
        }
    }

}
