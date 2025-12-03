using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._12._25
{
    public class HourlySalaryEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public int OvertimeHours { get; set; }
        public decimal OvertimeMultiplier { get; set; } = 1.5m; // Коэффициент сверхурочных

        public HourlySalaryEmployee(int id, string fullName, string email,
                                  decimal hourlyRate, int hoursWorked, int overtimeHours = 0)
            : base(id, fullName, email)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
            OvertimeHours = overtimeHours;
        }

        public override decimal CalculateSalary()
        {
            decimal regularPay = HourlyRate * Math.Min(HoursWorked, 160); // Норма часов в месяц
            decimal overtimePay = OvertimeHours > 0
                ? HourlyRate * OvertimeMultiplier * OvertimeHours
                : 0;

            return regularPay + overtimePay;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип оплаты: Почасовая оплата");
            Console.WriteLine($"Ставка в час: {HourlyRate} руб.");
            Console.WriteLine($"Отработано часов: {HoursWorked}");
            Console.WriteLine($"Сверхурочные часы: {OvertimeHours}");
        }
    }

}
