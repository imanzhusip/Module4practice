using ConsoleApp07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp05_10_23
{
    public class Book : BaspaSoz

    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Pages { get; set; }
        public DateTime Date { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }


        public override void ShowInformation()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Author);
            Console.WriteLine(Genre);
        }




    }
}
