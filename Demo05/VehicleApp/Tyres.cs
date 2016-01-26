using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Tyres
    {
        public string Model { get; set; }
        public string Name { get; set;  }
        public string Size { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "Model: " + Model + "Size " + Size;

        }

    }
}
