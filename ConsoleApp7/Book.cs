using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Book
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }
        public string Code { get; set; }

        public Book(string name,string authorname,int pagecount,double price)
        {
            _id++;
            Id = _id;
            Name = name;
            AuthorName = authorname;
                
            PageCount = pagecount;
            Price = price;

            string[] names=Name.Split(' ');
            foreach (var item in names)
            {
                Code += item[0];
            }
            Code += Id;
         
        }

    }
}
