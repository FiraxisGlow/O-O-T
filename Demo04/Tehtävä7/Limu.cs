using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä7
{
    class Limu : Juoma
    {
     
            public string Sugar { get; set; }

            public Limsa()
            {
            }

            public Jaffa(string firstname, string lastname, string limu)
                : base(firstname, lastname)
            {
                 = limu;
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
