using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Задача_1._2.ClassIShape;

namespace Задача_1._2
{
    public class AreaCalculator : IVisitor
    {
        public double TotalArea { get; private set; }

        public void Visit(Circle circle)
        {
            double area = Math.PI * circle.Radius * circle.Radius;
            TotalArea += area;
            Console.WriteLine($"Площадь круга радиусом {circle.Radius:F2} = {area:F2}");
        }

        public void Visit(Rectangle rectangle)
        {
            double area = rectangle.Width * rectangle.Height;
            TotalArea += area;
            Console.WriteLine($"Площадь прямоугольника {rectangle.Width:F2}x{rectangle.Height:F2} = {area:F2}");
        }

        public void Visit(Triangle triangle)
        {
            // Используем формулу Герона
            double p = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            double area = Math.Sqrt(p * (p - triangle.SideA) * (p - triangle.SideB) * (p - triangle.SideC));
            TotalArea += area;
            Console.WriteLine($"Площадь треугольника со сторонами {triangle.SideA:F2}, {triangle.SideB:F2}, {triangle.SideC:F2} = {area:F2}");
        }

        public void Reset()
        {
            TotalArea = 0;
        }
    }
}
