using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._12._25
{
    public class FreelanceEmployee : Employee // Оплата за проект и ставка НДФЛ 
    {
        public decimal ProjectPayment; // Оплата за проект
        public int CompletedProjects;  // Количесвто выполненных проектов

        public override decimal CalculateSalary()
        {
            decimal total = ProjectPayment * CompletedProjects;  // Общий доход
            decimal tax = total * 0.13m; // Вычитание налога 13%
            return total - tax;         // Доход
        }
    }
}
