using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject
{
    internal interface IBook
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int PubYear { get; set; }



    }
}
