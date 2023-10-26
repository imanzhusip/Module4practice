using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp07
{
   public abstract class BaspaSoz
    {
        public string EditionName { get; set; }
        public DateTime CreateDate { get; set; }
        public string BIN { get; set; }
        public string Director { get; set; }
        public string Specialisation { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        public virtual void ShowContact()
        {
            Console.WriteLine(BIN);
            Console.WriteLine(EditionName);
            Console.WriteLine(Phone);
            Console.WriteLine(Email);

        }

        public abstract void ShowInformation();






    }
}
