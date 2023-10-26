using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp05_10_23
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[2];
            books[0] = new Book()
            {
                Name = "Home",
                Author = "Serik",
                Genre = "biography",
                Pages = "200",
                Language = "rus",
                Date = DateTime.Now,

            };


            books[1] = new Book()
            {
                Name = "Hom",
                Author = "Seri",
                Genre = "biograph",
                Pages = "204",
                Language = "kaz",
                Date = DateTime.Now,

            };
            for (int i = 0; i < books.Length; i++)
            {
                books[i].ShowInformation(); 
            }
            Console.ReadKey();


        }
    }
}
