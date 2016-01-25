using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Teacher : Person
    {
        public string Room { get; set; }

        public Teacher()
        {
        }

        public Teacher(string firstname, string lastname, string room) 
            : base(firstname, lastname)
        {
            Room = room;
        }
        public void TeacherMethod()
        {
            Console.WriteLine("Teacher is wasting student time...");
        }
        public override string ToString()
        {
            return base.ToString() + " " + Room;
        }
    }

}
