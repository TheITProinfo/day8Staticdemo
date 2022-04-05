using System;
using System.Collections.Generic;
//using System.IO;
//using System.IO;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day8ClassExercise;

namespace day8NamespaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////File f1 = new File();

            string p1=Path.GetFileName("test");

            Ticket t1 = new Ticket(200);
            t1.ShowTicket();
        }
    }

}
