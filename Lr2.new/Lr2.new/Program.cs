using Lr2.;
using Lr2new;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lr2.@new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Для рыболовного магазина требуется разработать информационную подсистему учета продаж.
            //Сведения о товарах разнесены по категориям: спиннинги, поплавочная снасть, фидер, лески и т.д.
            //По каждому товару вносятся изменения его цены, история изменений сохраняется.
            //По запросу пользователя – «название товарной категории» -вывести на экран список товаров от дешевых к дорогим. 
            //Стоимость определяется по средней цене за весь период.

            Tovar[] tovars = new Tovar[20];

            string[] kategoria = new string[] { "", "", "" };
            for (int i = 0; i < 2; i++)
            {
                tovars[i].Name = "Tovar " + (i + 1);
                tovars[i].Kategoria = "Kategoria " + (i + 1);
                tovars[i].Price = random.Next(500, 2500) + random.NextDouble();
            }
            

        }
    }
}
