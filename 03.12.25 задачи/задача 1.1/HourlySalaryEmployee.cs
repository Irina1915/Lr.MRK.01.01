using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._12._25
{
    public class HourlySalaryEmployee : Employee // Почасовая оплата и сверхурочные
    {
        public decimal HourlyRate;         // Ставка за час
        public int HoursWorked;            // Количество отработанных часов
        public int OvertimeHours;          // Сверхурочные часы

        public override decimal CalculateSalary()
        {
            decimal regular = HoursWorked * HourlyRate;           // Регулярная оплата
            decimal overtime = OvertimeHours * HourlyRate * 1.5m; // Сверхурочные
            return regular + overtime;                            // общая сумма
        }
    }

}
