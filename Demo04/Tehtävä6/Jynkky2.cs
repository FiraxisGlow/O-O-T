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

namespace Tehtävä6
{
    class Jynkky2
    {
        //properties
        private int magazine;
        private readonly double min = 0;
        private readonly double max = 250;

        public int Magazine
        {
            get
            {
                return Magazine;
            }

            set
            {
                Magazine = magazine;
                if (magazine > max)
                    Console.WriteLine("Hyllyyn ei mahdu enempää lehtiä, hanki lisää säilytystilaa.");
                else
                    Console.WriteLine("Sinulla on " + magazine + " lehteä.");
                if (magazine < min)
                    Console.WriteLine("Et omista jynkkyä, ainakaan fyysisten lehtien muodossa.");
                else
                    Console.WriteLine("Sinulla on" + magazine + " jynkky lehteä");
            }
        }
            public override string ToString()
        {
            return magazine.ToString();
        }
    }
}

