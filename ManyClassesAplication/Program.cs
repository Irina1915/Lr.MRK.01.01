using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassesAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mers = new Product();
            mers.SetName("Мерседес");
            mers.SetPrice(1000000);

            Product yaz = new Product();
            yaz.SetName("Уазик");
            yaz.SetPrice(10000000);

            Storage storage = new Storage();
            storage.SetId(123);
            storage.SetLocation("Торжок, Ул. Студенческая 3");
            storage.SetProductQuantity(mers, 2);
            storage.SetProductQuantity(yaz, 5);

            storage.GetProductQuantity();
            storage.CalculateMoney();

            Console.WriteLine();

            Report report = new Report();

            ReportRow row1 = new ReportRow();
            row1.Product = "Mers";
            row1.Quantity = 2;
            row1.Price = 1000000;

            ReportRow row2 = new ReportRow();
            row2.Product = "Vaz";
            row2.Quantity = 5;
            row2.Price = 10000000;

            report.AddRecord(row1);
            report.AddRecord(row2);

            Console.WriteLine("Содержимое отчета:");
            Console.WriteLine(report);
            report.CalculateSum();
        }

    }
}
