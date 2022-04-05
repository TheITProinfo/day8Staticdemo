using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8Staticdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            stu1.RealName = "Tom";
            Student stu2 = new Student();
            stu2.RealName = "Jerry";
            Student stu3 = new Student();

            stu3.RealName = "Alice";

            Console.WriteLine("Total\t {0} students on the system",Student.AllCount);
            Console.ReadLine();
        }
    }
}
