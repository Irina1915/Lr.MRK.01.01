using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1._2
{
    public interface IShape  // Интерфейс для каждой фигуры
    {
        void Accept(IVisitor visitor); // Метод принятия посетителя
    }
}
