using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2._1
{
    // Это наш блокнот, куда записываем ответы
    public class CachingProxyService : IDataService
    {
        private IDataService realService; // Ссылка на метеостанцию
        private Dictionary<string, CacheItem> cache;
        private TimeSpan cacheDuration;

        // Вспомогательный класс для хранения данных в кэше
        private class CacheItem
        {
            public string Data { get; set; }
            public DateTime Expiry { get; set; }
        }

        public CachingProxyService(IDataService realService, int cacheMinutes = 1)
        {
            this.realService = realService;
            this.cache = new Dictionary<string, CacheItem>();
            cacheDuration = TimeSpan.FromMinutes(cacheMinutes); // Запоминаем на 1 минуту
        }

        public string FetchData(string resourceId)
        {
            // Шаг 1: Проверяем блокнот
            if (cache.ContainsKey(resourceId))
            {
                CacheItem cachedItem = cache[resourceId];
                // Смотрим, не устарела ли запись
                if (DateTime.Now < cachedItem.Expiry) // Если еще актуально
                {
                    Console.WriteLine($"Беру из блокнота: {resourceId}");
                    return cachedItem.Data;
                }
                else
                {
                    Console.WriteLine($"Запись устарела, выбрасываю");
                    cache.Remove(resourceId); // Выкидываем старую запись
                }
            }

            // Шаг 2: Если в блокноте нет или устарело - звоним на метеостанцию
            Console.WriteLine($"Нет в блокноте, придется звонить...");
            string freshData = realService.FetchData(resourceId);

            // Шаг 3: Записываем в блокнот
            DateTime expiryTime = DateTime.Now.Add(cacheDuration);
            CacheItem newItem = new CacheItem
            {
                Data = freshData,
                Expiry = expiryTime
            };
            cache[resourceId] = newItem;
            Console.WriteLine($"Записал в блокнот (актуально до: {expiryTime:HH:mm:ss})");

            return freshData;
        }
    }
}

