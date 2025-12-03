using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Задача_1._2.ClassIShape;

namespace Задача_1._2
{
    public class PerimeterCalculator : IVisitor
    {
        public double TotalPerimeter { get; private set; }

        public void Visit(Circle circle)
        {
            double perimeter = 2 * Math.PI * circle.Radius;
            TotalPerimeter += perimeter;
            Console.WriteLine($"Периметр круга радиусом {circle.Radius:F2} = {perimeter:F2}");
        }

        public void Visit(Rectangle rectangle)
        {
            double perimeter = 2 * (rectangle.Width + rectangle.Height);
            TotalPerimeter += perimeter;
            Console.WriteLine($"Периметр прямоугольника {rectangle.Width:F2}x{rectangle.Height:F2} = {perimeter:F2}");
        }

        public void Visit(Triangle triangle)
        {
            double perimeter = triangle.SideA + triangle.SideB + triangle.SideC;
            TotalPerimeter += perimeter;
            Console.WriteLine($"Периметр треугольника со сторонами {triangle.SideA:F2}, {triangle.SideB:F2}, {triangle.SideC:F2} = {perimeter:F2}");
        }

        public void Reset()
        {
            TotalPerimeter = 0;
        }
    }

}
