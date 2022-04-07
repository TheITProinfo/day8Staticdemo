using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8InheritanceDemo
{
    class Teacher:Person
    {
        
        private double _wage;

        public double Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }

        

        public void research()
        {
            Console.WriteLine("I am researching");
        }
    }
}
