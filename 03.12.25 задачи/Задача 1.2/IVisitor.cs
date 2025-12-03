using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Задача_1._2
{
    public interface IVisitor
    {
        void Visit(Circle circle);
        void Visit(Rectangle rectangle);
        void Visit(Triangle triangle);
    }

}
