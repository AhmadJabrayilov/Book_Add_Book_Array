using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Book_Array.Models
{
    internal class Product
    {
        //fields
        public int No;
        public string name;
        public double price;
        public int count;

        public Product(int No, string name, double price, int count)
        {
            this.No = No;
            this.name = name;
            this.price = price;
            this.count = count;
        }

        public Product()
        {
                
        }

    }
}
