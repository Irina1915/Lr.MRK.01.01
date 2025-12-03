using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._12._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Система управления сотрудниками ===\n");

            // Создаем сотрудников разных типов
            Employee[] employees = new Employee[]
            {
                new FixedSalaryEmployee(1, "Иванов Иван Иванович", "ivanov@company.com", 50000m),
                new HourlySalaryEmployee(2, "Петров Петр Петрович", "petrov@company.com", 500m, 160, 10),
                new FreelancerEmployee(3, "Сидорова Анна Сергеевна", "sidorova@company.com", 80000m, 13m)
            };

            // Выводим информацию о каждом сотруднике
            foreach (var employee in employees)
            {
                employee.DisplayInfo();
                Console.WriteLine(new string('-', 40));
            }

            // Пример расчета общей суммы зарплат
            decimal totalSalary = 0;
            foreach (var employee in employees)
            {
                totalSalary += employee.CalculateSalary();
            }
            Console.WriteLine($"\nОбщая сумма зарплат всех сотрудников: {totalSalary} руб.");
        }
    }
}

