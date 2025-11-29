using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassesAplication
{
    class Storage
    {
        private int id_;
        private string location_;
        private Dictionary<Product, int> products_ = new Dictionary<Product, int>();

        public void SetId(int id)
        {
            id_ = id;
        }
        public void SetLocation(string location)
        {
            location_ = location;
        }
        public void SetProductQuantity(Product product, int quantity)
        {
            products_.Add(product, quantity);
        }
         
        public void SetProductQantity()
        {
            foreach (Product product in products_.Keys)
            {
                Console.WriteLine(product.GetName() + " - " + products_[product]);
            }
        }
        public void GetProductQantity()
        {
            foreach(Product product in products_.Keys)
            {
                Console.WriteLine($"Товар: {product.GetName() + " " + products_[product]} шт.");
            }
        }


        public void CalculateMoney()
        {
            double sum = 0;
            foreach(Product product in products_.Keys)
            {
                sum += product.GetPrice() * products_[product];
            }
            Console.WriteLine(sum);
        }

        //public void PrintStorageInfo()
        //{
        //    double totalSum = 0;
        //    foreach (var item in products_) // Цикл перебирает данные, item(товар, ключ), products_ перебирает все элементы коллекции
        //    {
        //        Product product = item.Key; //Получаем объект товара
        //        int quantity = item.Value; // Получаем количество этого товара
        //        double productTotal = product.GetPrice() * quantity; // Считаем общую стоимость для этого товара

        //        totalSum += productTotal;

        //        Console.WriteLine($"Товар: {product.GetName()}"); // Выводится название товара и его количество
        //        Console.WriteLine($"  Количество: {quantity} шт."); // его кол-во
        //        Console.WriteLine($"  Общая сумма: {productTotal} руб.");
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine($"  Общая сумма всех товаров: {totalSum} руб.");
        //}
    }
}
