using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Firstname = "Adolf";
            person.Lastname = "Hitler";
            person.Age = 90;
            person.Address = "Manala";
            person.Phonenumber = "020202";
            Console.WriteLine(person.ToString());

            Teacher teacher = new Teacher("Panu", "Alkoholi", "D404");
            teacher.Address = "Piippukatu 2";
            teacher.Age = 35;
            teacher.Phonenumber = "01010548687";
            Console.WriteLine(teacher.ToString());

            Student student = new Student();
            student.Firstname = "Jarmo";
            student.Lastname = "Pekkarinen";
            student.Age = 21;
            student.Address = "Kalmankuja 5";
            student.Phonenumber = "0503598754";
            Console.WriteLine(student.ToString());

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();

            
        }

    }
}
