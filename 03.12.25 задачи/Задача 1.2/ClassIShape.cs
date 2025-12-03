using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1._2
{
    internal class ClassIShape
    {
        public class Circle : IShape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public void Accept(IVisitor visitor)
            {
                visitor.Visit(this);
            }
        }

        public class Rectangle : IShape
        {
            public double Width { get; set; }
            public double Height { get; set; }

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

        public class Triangle : IShape
        {
            public double SideA { get; set; }
            public double SideB { get; set; }
            public double SideC { get; set; }

            public Triangle(double sideA, double sideB, double sideC)
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }

            public void Accept(IVisitor visitor)
            {
                visitor.Visit(this);
            }
        }
    }
}
