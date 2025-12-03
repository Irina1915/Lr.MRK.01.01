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
            Console.WriteLine("----Расчет зарплат сотрудников----");

            // Создаем сотрудника с фиксированной зарплатой
            FixedSalaryEmployee manager = new FixedSalaryEmployee();
            manager.Id = 1;
            manager.FullName = "Козырева Мария Михайловна";
            manager.Email = "kozereva@gmail.com";
            manager.MonthlySalary = 100000;

            // Создаем сотрудника с почасовой оплатой
            HourlySalaryEmployee developer = new HourlySalaryEmployee();
            developer.Id = 2;
            developer.FullName = "Будина Ирина Сергеевна";
            developer.Email = "budina@gmail.com";
            developer.HourlyRate = 500;
            developer.HoursWorked = 160;
            developer.OvertimeHours = 20;

            // Создаем фрилансера
            FreelanceEmployee freelancer = new FreelanceEmployee();
            freelancer.Id = 3;
            freelancer.FullName = "Кулешова Кира Александровна";
            freelancer.Email = "kulishova@gmail.com";
            freelancer.ProjectPayment = 20000;
            freelancer.CompletedProjects = 3;

            // Созданем список и включаем туда наших сотрудников
            List<Employee> AllEmployees = new List<Employee>();
            AllEmployees.Add(manager);
            AllEmployees.Add(developer);
            AllEmployees.Add(freelancer);

            // Выводим информацию о сотрудниках на консоль
            Console.WriteLine("                          ");
            Console.WriteLine("Информация о сотрудниках: ");
            foreach (Employee employee in AllEmployees)
            {
                Console.WriteLine($"1. ID: {employee.Id}");
                Console.WriteLine($"2. ФИО: {employee.FullName}");
                Console.WriteLine($"3. Email: {employee.Email}");
                Console.WriteLine($"4. Зарплата: {employee.CalculateSalary():F2} рублей");


                // Узнаем тип каждого сотрудника
                if (employee is FixedSalaryEmployee)
                {
                    Console.WriteLine("5. Тип: Фиксированная зарплата");
                }
                else
                {
                    if (employee is HourlySalaryEmployee)
                        Console.WriteLine("5. Тип: Почасовая оплата");
                    else
                    {
                        if (employee is FreelanceEmployee)
                            Console.WriteLine("5. Тип: Фрилансер");
                    }
                }
                Console.WriteLine($"   ");
            }

            // Работа полиморфизма
            Console.WriteLine("Демонстрация полиморфизма:");
            foreach (Employee employee in AllEmployees)
            {
                // Используем метод CalculateSalary
                Console.WriteLine($"{employee.FullName} получит {employee.CalculateSalary():F2} рублей");
            }

            // Подсчет общую сумму зарплат
            Console.WriteLine($"   ");
            Console.WriteLine("Общяя сумма зарплат:");
            decimal total = 0;
            foreach (Employee employee in AllEmployees)
            {
                total += employee.CalculateSalary();
            }
            Console.WriteLine($"Всего нужно выплатить: {total:F2} рублей");
            Console.WriteLine($"Средняя зарплата: {total / AllEmployees.Count:F2} рублей");

            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}

