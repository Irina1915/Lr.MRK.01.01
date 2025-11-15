using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11._25
{
    internal class Sale_of_laptop
    {
        public string LaptopModel { get; internal set; }
        public DateTime Date { get; internal set; }

        public class Sale_of_laptops
        {
            public DateTime Date { get; set; }
            public string LaptopModel { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }

            public double Revenue
            {
                get { return Quantity * Price; }
            }
        }
    }
}
