using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Задача_1._2
{
    public interface IVisitor  // Интерфейс для каждого посетителя
    {
        void Visit(Circle circle);        // Метод для обработки круга
        void Visit(Rectangle rectangle);  // Метод для обработки прямоугольника
        void Visit(Triangle triangle);    // Метод для обработки треугольника
    }
}
