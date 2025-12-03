using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1._2
{

    public class Rectangle : IShape  // класс прямоугольник
    {
        public double Width;   // ширина
        public double Height;  // высота

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
