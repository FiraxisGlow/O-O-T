﻿/*
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
    class Volyme
    {
        private readonly int minvolyme = 0;
        private readonly int maxvolyme = 9;
        private int volyme;

        //method
        public int VoL
        {
            get
            {
                return volyme;
            }
            set
            {
                volyme = value;
                if (maxvolyme > volyme)
                    if (minvolyme < volyme)
                        
                    Console.WriteLine("Äänenvoimakkuus on: " + volyme);
                    else
                    {
                        if (volyme > maxvolyme)
                            if (volyme < minvolyme)
                                Console.WriteLine("Radio ei tue tätä äänenvoimakkuutta");
                    }
                
            }
        
        }

        public override string ToString()
        {
            return volyme.ToString();
        }

    }
}