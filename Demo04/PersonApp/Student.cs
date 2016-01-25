using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Student : Person
    {
        public string StudentID { get; set; }


        public Student()
        {
        }

        public Student(string firstname, string lastname, string ID) 
            : base(firstname, lastname)
        {
            StudentID = ID;
        }
        public void StudentMethod()
        {
            Console.WriteLine("Student is asleep");
        }
        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
}
