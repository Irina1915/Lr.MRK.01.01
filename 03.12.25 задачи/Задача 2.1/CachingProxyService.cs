using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2._1
{
    public class CachingProxyService : IDataService
    {
        private readonly IDataService _realService;
        private readonly Dictionary<string, (string data, DateTime expiry)> _cache = new();
        private readonly TimeSpan _cacheDuration;

        public CachingProxyService(IDataService realService, int cacheMinutes = 1)
        {
            _realService = realService;
            _cacheDuration = TimeSpan.FromMinutes(cacheMinutes);
        }

        public string FetchData(string resourceId)
        {
            // Проверяем, есть ли данные в кэше и не устарели ли они
            if (_cache.TryGetValue(resourceId, out var cachedItem))
            {
                if (DateTime.Now < cachedItem.expiry)
                {
                    Console.WriteLine($"Данные для {resourceId} взяты из кэша");
                    return cachedItem.data;
                }
                else
                {
                    Console.WriteLine($"Кэш для {resourceId} устарел");
                    _cache.Remove(resourceId);
                }
            }

            // Если нет в кэше или устарел - идем в реальный сервис
            string freshData = _realService.FetchData(resourceId);

            // Сохраняем в кэш с временем жизни
            DateTime expiryTime = DateTime.Now.Add(_cacheDuration);
            _cache[resourceId] = (freshData, expiryTime);
            Console.WriteLine($"Данные для {resourceId} сохранены в кэш до {expiryTime:HH:mm:ss}");

            return freshData;
        }

        // Метод для очистки кэша (опционально)
        public void ClearCache()
        {
            _cache.Clear();
            Console.WriteLine("Кэш очищен");
        }
    }
}
