using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8InheritanceDemo
{
    class Student:Person
    {
        

        private int _stId;

        public int StId
        {
            get { return _stId; }
            set { _stId = value; }
        }


        public void learn()
        {
            Console.WriteLine("I am learning");
        }

        public void SayHeight()
        {
            Console.WriteLine("I am {0}",height);
        }
        
       

        
        // constructor method of class Student
        public Student(string name,int age,string gender,int stid):base(name,age,gender)
        {
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;
            this.StId = stid;

        }

        //public Student()

    }
}
