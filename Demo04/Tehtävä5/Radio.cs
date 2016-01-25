/*
* Copyright (C) Anton Kiri
*
*
* DEMO 4 T5
*
*
* 20.1.2016
* Anton Kiri
*
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä5
{
    class Radio
    {
        private int hz;

        private readonly int maxhz = 26000;
        private readonly int minhz = 2000;
    
        public int Freaquency
        {

            get {

                return hz;
            }

            set
            {
                if (minhz <= Freaquency)
                    if (maxhz <= Freaquency)
                        hz = value;
                    Console.WriteLine("Taajuus on: " + hz);
            
                    if (Freaquency > maxhz)
                        Console.WriteLine("Taajuus asetettiin 26000Hz");
                    if (Freaquency < minhz)
                        Console.WriteLine("Taajuus asetettiin 2000Hz");
                else
                {
                    Console.WriteLine("Taajuus on radion taajuusalueen ulkopuolella");
                }
               
            }
        }

        public override string ToString()
        {
            return hz.ToString();
        }

    }
}
