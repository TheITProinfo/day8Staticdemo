using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Student stu1 = new Student("Tom",25,"male",1000);
            //stu1.Name = "Tom";
            //stu1.Age = 25;
            //stu1.Gender = "male";
            //stu1.StId = 1000;
            stu1.SayHello();
            stu1.learn();////



            Developer devp1 = new Developer();
            devp1.Proiects = 100; //
            devp1.WriteCode(); //
            devp1.StId = 2001; // inheriate from student 
            devp1.learn();   /// inheriate from student
            devp1.Name = "Bob"; // inheriate form Person
            devp1.Age = 34;
            devp1.Gender = "Male";
            devp1.SayHello();
            Console.WriteLine("I am {0}",devp1.Name);

            Console.ReadLine();
        }
    }
}
