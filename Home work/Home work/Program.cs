using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Продажа мобильных телефонов
            /// Характеристики: количество на складе, время продажи, цена
            List<PhoneProduct> phoneProducts = GeneratePhoneProducts(10); // Создание списка из 10 случайных товаров
            Console.WriteLine("          Продажа мобильных телефонов");
            Console.WriteLine($"             Всего товаров: {phoneProducts.Count}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("ТОП-10 по цене: ");
            var topByPrice = FindTopProducts(phoneProducts, p => p.Price, 10); // Поиск топ-10 по цене
            PrintResults(topByPrice); // Вывод результатов
        }

        static List<PhoneProduct> GeneratePhoneProducts(int count)
        {
            var products = new List<PhoneProduct>(); // Пустой список
            var random = new Random(); // Генератор рандома
            var phoneBrands = new List<string>{
        "iPhone 15 Pro       ",
        "Samsung Galaxy S24  ",
        "Xiaomi 13T Pro      ",
        "Google Pixel 8      ",
        "OnePlus 11          ",
        "Huawei P60 Pro      ",
        "Realme GT 3         ",
        "Nothing Phone 2     ",
        "Sony Xperia 1 V     ",
        "Motorola Edge 40    "}; // Список моделей телефонов

            for (int i = 0; i < count; i++) // Начало цикла, который будет создавать случайные товары
            {
                string model = phoneBrands[random.Next(phoneBrands.Count)];
                int stockQuantity = random.Next(1, 101); // Количество на складе от 1 до 100
                int saleTime = random.Next(5, 61); // Время продажи от 5 до 60 минут
                decimal price = random.Next(5000, 150001); // Цена от 5000 до 150000
                products.Add(new PhoneProduct(model, stockQuantity, saleTime, price)); // Добавление товара в список
            }
            return products; // Возврат результата
        }

        static List<PhoneProduct> FindTopProducts(List<PhoneProduct> products,
            Func<PhoneProduct, IComparable> selector, int topCount)
        {
            return products
                .OrderByDescending(selector) // Сортировка по убыванию значения, возвращаемого selector
                .Take(topCount)              // Взятие указанного количества элементов
                .ToList();                   // Преобразование в List
        }

        static void PrintResults(List<PhoneProduct> products) // Объявление метода
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i]}"); // Цикл вывода результата
            }
        }
    }
}
