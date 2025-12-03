using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Задача_1._2
{
    public class AreaCalculator : IVisitor
    {
        public void Visit(Circle circle)
        {
            double area = Math.PI * circle.Radius * circle.Radius;
            Console.WriteLine($"Площадь круга: {area:F2}");
        }

        public void Visit(Rectangle rectangle)
        {
            double area = rectangle.Width * rectangle.Height;
            Console.WriteLine($"Площадь прямоугольника: {area:F2}");
        }

        public void Visit(Triangle triangle)
        {
            // Формула Герона
            double p = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            double area = Math.Sqrt(p * (p - triangle.SideA) *
                                   (p - triangle.SideB) * (p - triangle.SideC));
            Console.WriteLine($"Площадь треугольника: {area:F2}");
        }
    }
}
