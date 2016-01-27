using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object from Persons
            Persons myFriends = new Persons();


            //create a few people...
            Person person1 = new Person { FirstName = "Santeri", LastName = "Suo", SSN = "230593-215D" };
            Person person2 = new Person { FirstName = "Jorma", LastName = "Suo", SSN = "230594-216D" };
            Person person3 = new Person { FirstName = "Jaska", LastName = "Jokunen", SSN = "140296-315E" };

            // add persons to collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            //print collection
            myFriends.PrintCollection();

            //get one person from collection
            Console.WriteLine("Get one person from collection: ");

            Person person4 = myFriends.GetPerson(100);
            if (person4 != null)
            {
                Console.WriteLine(person1.ToString());
            } else
            {
                Console.WriteLine("Can not find person in that position");
            }


            //find person with SNN
            string ssn = "140296-315E";

            Console.WriteLine("Find person with SSN");
            Person person5 = myFriends.FindPerson(ssn);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
                else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}