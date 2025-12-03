using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._12._25
{
    public abstract class Employee  // Абстрактный класс, котрый нелья использовать напрямую
    {
        public int Id;              // ID-номер сотрудника
        public string FullName;     // ФИО
        public string Email;        // Электронная почта

        public abstract decimal CalculateSalary();
    }
}

