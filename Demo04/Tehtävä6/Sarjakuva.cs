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
    class Sarjakuva
    {
        private int comic;
        private readonly int minvol = 0;
        private readonly int maxvol = 200;
        public int Comic
        {
            get
            {
                return Comic;
            }

            set
            {
                Comic = comic;
                if (comic > maxvol)
                    Console.WriteLine("Hyllyssä ei ole tilaa kaikille sarjakuvillesi");
                else
                    Console.WriteLine("Sinulla on " + comic + " sarjakuvaa hyllyssä" + "Tilaa on vielä " + (comic - maxvol) + " sarjakuvalle");
                if (comic < minvol)
                    Console.WriteLine("Miksi sinulla on hylly?????");
                else
                    Console.WriteLine("Sinulla on" + comic + " sarjakuvaa hyllyssä" + "Tilaa on vielä " + (comic - maxvol) + " sarjakuvalle");
            }
        }

    }
}
    

