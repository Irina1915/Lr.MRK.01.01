using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._12._25
{
    public class FixedSalaryEmployee : Employee
    {
        public decimal MonthlySalary { get; set; }

        public FixedSalaryEmployee(int id, string fullName, string email, decimal monthlySalary)
            : base(id, fullName, email)
        {
            MonthlySalary = monthlySalary;
        }

        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип оплаты: Фиксированная месячная оплата");
            Console.WriteLine($"Месячный оклад: {MonthlySalary} руб.");
        }
    }

}
