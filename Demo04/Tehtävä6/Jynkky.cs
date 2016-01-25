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
    class Jynkky
    {
     
    
        //properties
        private int video;
        private readonly int minv = 0;
        private readonly int maxv = 250;
        public int Video
        {
            get
            {
                return Video;
            }

            set
            {
                Video = video;
                if (video > maxv)
                    Console.WriteLine("Hyllyssä ei ole tilaa kaikelle sinun jynkylle...");
                else
                    Console.WriteLine("Sinulla on " + video + " jynkky videota.");
                if (video < minv)
                    Console.WriteLine("Et omista jynkkyä, ainakaan fyysisesten videoiden muodossa.");
                else
                    Console.WriteLine("Sinulla on" + video + " jynkky videota.");

            }
        }

        public override string ToString()
        {
            return video.ToString();
         
            
        }

    }
}
