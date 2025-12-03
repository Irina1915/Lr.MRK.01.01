using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1._2
{
    public class Circle : IShape  // Класс для круга
    {
        public double Radius;   // Радиус круга

        public Circle(double radius)
        {
            Radius = radius; // Сохраняем радиус в свойство Radius
        }

        public void Accept(IVisitor visitor) // Принимаем каждого посетителя
        {
            visitor.Visit(this);
        }
    }
}
