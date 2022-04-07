using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8InheritanceDemo
{
    class Developer:Student
    {
        

        private int _proiects;

        public int Proiects
        {
            get { return _proiects; }
            set { _proiects = value; }
        }

        

        public void WriteCode()
        {
            Console.WriteLine("I am writing code");
        }
    }
}
