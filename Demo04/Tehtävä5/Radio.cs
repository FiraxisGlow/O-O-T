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
                    hz = maxhz;
                {
                    Console.WriteLine("Taajuus asetettiin " + hz);
                    if (Freaquency < minhz)
                        hz = minhz;
                    Console.WriteLine("Taajuus asetettiin: " + hz);
                    { 
                
                    else
                    
                        Console.WriteLine("Onneksi olkoon, rikoit radion!");
                    }
                }
            }

        }    

        public override string ToString()
        {
            return hz.ToString();
        }
    
    }
}
