using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This class holds persons objects and give a few methods...
/// </summary>
namespace Tehtävä1
{
    class Persons
    {
        /// <summary>
        ///  persons holds person objects
        /// </summary>
        private List<Person> persons;
        
        /// <summary>
        /// Default constructor initializes a collection
        /// </summary>
        public Persons()
        {
            persons = new List<Person>();
        }
        /// <summary>
        ///Adds a person to collection 
        /// </summary>
        /// <param name="person">Added person</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        /// <summary>
        /// Returns a person to caller application from collection.
        /// </summary>
        /// <param name="index">Person index in collection</param>
        /// <returns>Returned person object</returns>
        public Person GetPerson(int index)
        {
            if (index < persons.Count) return persons.ElementAt(index);
            else return null;
        }
        public Person FindPerson(string ssn)
        {
            foreach(Person person in persons)
            {
                if (ssn.Equals(person.SSN))
                {
                    //person with ssn found...
                    return person;
                }
            }
            //person with ssn not found...
            return null;
        }
       
        public void PrintCollection()
        {
            Console.WriteLine("Persons in a collection:");
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }

    }
}
