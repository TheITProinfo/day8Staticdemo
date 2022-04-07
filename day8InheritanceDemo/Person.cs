using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8InheritanceDemo
{
    public class Person
    {
        protected string height;


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public void SayHello()
        {
            Console.WriteLine("I can speak");
        }
        
        // constructor method of class Person
        public Person(string name,int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;

        }

        public Person()
        { 
        }
            
            
    }

}
