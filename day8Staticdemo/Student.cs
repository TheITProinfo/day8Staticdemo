using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8Staticdemo
{
    public class Student
    {
        public static int AllCount = 0;
        private string _realName;

        public string RealName
        {
            get { return _realName; }
            set { _realName = value; }
        }

        // constructor method
        public Student()
        {
            AllCount++;
        }



    }
}
