using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Задача_1._2.ClassIShape;

namespace Задача_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем список фигур
            List<IShape> shapes = new List<IShape>
        {
            new Circle(5.0),
            new Rectangle(4.0, 6.0),
            new Triangle(3.0, 4.0, 5.0),
            new Circle(2.5),
            new Rectangle(3.0, 7.0)
        };

            Console.WriteLine("=== Расчет площадей ===");
            AreaCalculator areaCalculator = new AreaCalculator();

            foreach (var shape in shapes)
            {
                shape.Accept(areaCalculator);
            }

            Console.WriteLine($"\nОбщая площадь всех фигур: {areaCalculator.TotalArea:F2}\n");

            Console.WriteLine("=== Расчет периметров ===");
            PerimeterCalculator perimeterCalculator = new PerimeterCalculator();

            foreach (var shape in shapes)
            {
                shape.Accept(perimeterCalculator);
            }

            Console.WriteLine($"\nОбщий периметр всех фигур: {perimeterCalculator.TotalPerimeter:F2}\n");

            // Пример использования с отдельной функцией
            Console.WriteLine("=== Использование вспомогательного метода ===");
            CalculateForShapes(shapes);
        }

        static void CalculateForShapes(List<IShape> shapes)
        {
            AreaCalculator areaCalc = new AreaCalculator();
            PerimeterCalculator perimeterCalc = new PerimeterCalculator();

            foreach (var shape in shapes)
            {
                shape.Accept(areaCalc);
                shape.Accept(perimeterCalc);
            }

            Console.WriteLine($"\nИтоги:");
            Console.WriteLine($"Общая площадь: {areaCalc.TotalArea:F2}");
            Console.WriteLine($"Общий периметр: {perimeterCalc.TotalPerimeter:F2}");
        }
    }
}

