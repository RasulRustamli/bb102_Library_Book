using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Library
    {
        Book[] Books = new Book[0];
        public void Addbook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length-1] = book;
        }
        public void Getbook(int id)
        {
            foreach (Book book in Books)
            {
                if (book.Id == id)
                {
                    Console.WriteLine($"name{book.Name}");
                }
            }
        }
        public void RemoveBook(int id)
        {
          
        }
    }
}
