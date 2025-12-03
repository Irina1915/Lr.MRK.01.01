using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._12._25
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        protected Employee(int id, string fullName, string email)
        {
            Id = id;
            FullName = fullName;
            Email = email;
        }
        // Абстрактный метод для расчета зарплаты
        public abstract decimal CalculateSalary();

        // Виртуальный метод для вывода информации
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"ФИО: {FullName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Зарплата: {CalculateSalary()} руб.");
        }
    }
}

