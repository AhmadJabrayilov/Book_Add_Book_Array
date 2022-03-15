using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Book_Array.Models
{
    internal class Book:Product
    { 
        //field
        public string genre;
        public Book(string genre, int No, string name, double price, int count) : base(No, name, price, count)
        {
            this.genre = genre;
        }

        public Book()
        {

        }
    }
}
