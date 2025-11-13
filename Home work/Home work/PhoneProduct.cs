using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work
{
    internal class PhoneProduct
    {
        private string model;
        private int stockQuantity;
        private int saleTime;

        public PhoneProduct(string model, int stockQuantity, int saleTime, decimal price)
        {
            this.model = model;
            this.stockQuantity = stockQuantity;
            this.saleTime = saleTime;
            Price = price;
        }

        public IComparable Price { get; internal set; }

        public class PhoneProduc
        {
            public string Model { get; set; }
            public int StockQuantity { get; set; }
            public int SaleTime { get; set; }
            public decimal Price { get; set; }

            public PhoneProduc(string model, int stockQuantity, int saleTime, decimal price)
            {
                Model = model;
                StockQuantity = stockQuantity;
                SaleTime = saleTime;
                Price = price;
            }

            public override string ToString()
            {
                return $"{Model} | В наличии: {StockQuantity} шт. | Время продажи: {SaleTime} мин. | Цена: {Price:C}";
            }
        }
    }
}
