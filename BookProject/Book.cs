using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject
{
    internal class Book : IBook
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int PubYear { get; set; }

        public Book(string name , string author , int year)
        {
            BookName = name;
            AuthorName = author;
            PubYear = year;
        }

        public override string ToString() => $"Book {BookName} for Author : {AuthorName} Published in {PubYear}";
    }
}
