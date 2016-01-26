
/*
* Copyright (C) Anton Kiri
*
*
* Olio-ohjelmointi
*
*
* 11.02.16
* Anton Kiri
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä4
{
    class Engine
    {
        public string Power { get; set; }
        public string Thrust { get; set; }
        public string Size { get; set; }

        public override string ToString()
        {
            return "Power (kW): " + Power + " Thrust (N): " + Thrust + " Diamiter (m) " + Size;

        }

    }
}
   
