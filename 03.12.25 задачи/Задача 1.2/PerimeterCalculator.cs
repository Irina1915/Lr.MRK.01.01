using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Задача_1._2
{
    public class PerimeterCalculator : IVisitor
    {
        public void Visit(Circle circle)
        {
            double perimeter = 2 * Math.PI * circle.Radius;
            Console.WriteLine($"Периметр круга: {perimeter:F2}");
        }

        public void Visit(Rectangle rectangle)
        {
            double perimeter = 2 * (rectangle.Width + rectangle.Height);
            Console.WriteLine($"Периметр прямоугольника: {perimeter:F2}");
        }

        public void Visit(Triangle triangle)
        {
            double perimeter = triangle.SideA + triangle.SideB + triangle.SideC;
            Console.WriteLine($"Периметр треугольника: {perimeter:F2}");
        }
    }

}
