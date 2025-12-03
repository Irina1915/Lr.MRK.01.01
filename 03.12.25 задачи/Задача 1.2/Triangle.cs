using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1._2
{
    public class Triangle : IShape  // Класс треугольника
    {
        public double SideA;   // Сторона A
        public double SideB;   // Сторона B
        public double SideC;   // Сторона C

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;  // Сохраням сторону A в SideA
            SideB = sideB;  // Сохраням сторону A в SideB
            SideC = sideC;  // Сохраням сторону A в SideC
        }

        public void Accept(IVisitor visitor)  // Принимаем каждого посетителя
        {
            visitor.Visit(this);
        }
    }
}
