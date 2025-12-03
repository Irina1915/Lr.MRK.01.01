using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._12._25
{
    public class FreelancerEmployee : Employee
    {
        public decimal ProjectPayment { get; set; }
        public decimal TaxRate { get; set; } // Ставка НДФЛ в процентах

        public FreelancerEmployee(int id, string fullName, string email,
                                decimal projectPayment, decimal taxRate = 13m)
            : base(id, fullName, email)
        {
            ProjectPayment = projectPayment;
            TaxRate = taxRate;
        }

        public override decimal CalculateSalary()
        {
            decimal taxAmount = ProjectPayment * (TaxRate / 100);
            return ProjectPayment - taxAmount; // Зарплата после вычета налогов
        }

        // Метод для получения суммы налога
        public decimal GetTaxAmount()
        {
            return ProjectPayment * (TaxRate / 100);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип оплаты: Оплата за проект");
            Console.WriteLine($"Оплата проекта: {ProjectPayment} руб.");
            Console.WriteLine($"Ставка НДФЛ: {TaxRate}%");
            Console.WriteLine($"Сумма налога: {GetTaxAmount()} руб.");
        }
    }

}
