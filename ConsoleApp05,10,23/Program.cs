using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp05_10_23
{
    public abstract class Engine
    {
        public double Speed { get; set; }
        public double Volume { get; set; }
        public double FuelType { get; set; }
        public abstract void Move();
        public virtual double co2()
        {
            return 2.5;
        }
    }


}

