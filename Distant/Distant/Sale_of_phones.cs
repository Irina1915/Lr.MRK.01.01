using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distant
{
    internal class Sale_of_phones
    {
        public DateTime Date { get; set; }     // Дата продажи (метка времени)
        public string PhoneModel { get; set; } // Модель телефона
        public int Quantity { get; set; }      // Количество проданных единиц
        public double Price { get; set; }      // Цена за единицу для клиента
        public double Cost { get; set; }       // Затраты магазина на телефоны

        // Вычисление выгоды магазина
        public double Profit => (Price - Cost) * Quantity;

        // Вычисление дохода магазина
        public double Revenue => Price * Quantity;
    }
}
