using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä1
{
    /// <summary>
    /// This class contains person propreties.
    /// </summary>
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + SSN;
        }

    }
}
