using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Задача_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем список фигур и заполняем его
            List<IShape> shapes = new List<IShape>
            {
            new Circle(6),
            new Rectangle(4, 5),
            new Triangle(7, 8, 2)
            };

            // Создаем посетителей
            AreaCalculator areaCalculator = new AreaCalculator();
            PerimeterCalculator perimeterCalculator = new PerimeterCalculator();

            Console.WriteLine("----Расчет площадей----");
            // Применяем посетителя для расчета площади ко всем фигурам
            foreach (IShape shape in shapes)
            {
                shape.Accept(areaCalculator);
            }
            Console.WriteLine(" "); // Для красивого оформления и отступа

            Console.WriteLine("----Расчет периметров----");
            // Применяем посетителя для расчета периметра ко всем фигурам
            foreach (IShape shape in shapes)
            {
                shape.Accept(perimeterCalculator);
            }
        }
    }
}

