using System;
using System.Collections.Generic;
using System.Linq;
using BookProject;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookProject
{
    public class BookOperation
    {
        private List<Book> ListBooks;
        public BookOperation()
        {
            ListBooks = new List<Book>();
        }
        public bool Add(Object book)
        {
            if (!ListBooks.Contains((Book)book) && book !=null) 
            {
                ListBooks.Add((Book)book);
                return true;

            }
            return false;

        }
        public void DisplayAll()
        {
            for(int i = 0; i < ListBooks?.Count; i++) {
                Console.WriteLine(ListBooks[i]);
            }
        }
        
        public int CheckEdit(string book)
        {
            for(int i = 0; i < ListBooks?.Count;i++)
            {
                if (ListBooks[i].BookName == book)
                {
                    return i;
                }
            }
            return -1;

        }
        public bool Edit(string book , string name)
        {

            int result = CheckEdit(book);
            if (result > -1) 
            {
                ListBooks[result].BookName = name;   
            return true;
            }
            return false;
        }
        public bool Edit(string book , string name , string author ) 
        {
            
            int result = CheckEdit(book);
            if (result > -1)
            {
                ListBooks[result].AuthorName = author;
                return true;
            }
            return false;
        }
        public bool Edit(string book, string name, string author , int year)
        {
            int result = CheckEdit(book);
            if (result > -1)
            {
                ListBooks[result].PubYear = year;
                return true;
            }
            return false;
        }
        public bool Delete(string book) {
            for (int i = 0; i < ListBooks?.Count; i++)
            {
                if (ListBooks[i].BookName == book)
                {
                    ListBooks.RemoveAt(i);
                    return true;
                }
            }
         return false;
        }
        public bool Search(string book)
        {
            for(int i = 0; i < ListBooks.Count; i++)
            {
                if (ListBooks[i].BookName == book)
                {
                    Console.WriteLine(ListBooks[i]);
                    return true; 
                }
    
            }
            return false; 
        }


    }
}
