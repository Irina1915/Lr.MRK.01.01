using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_3
{
    internal class Product
    {
        private string name_;
        private double price_;
        private int expiryDate_;

        public Product(string name, double price, int date) 
        {
            name_ = name;
            price_ = price;
            expiryDate_ = date;
        }

        public string Name
        {
            get { return name_; }
        }

        public string Price
        {
            get { return price_.ToString(); }
        }

        public string Data
        {
            get { return expiryDate_.ToString(); }
        }

    }
}
