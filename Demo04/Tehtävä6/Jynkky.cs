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
    }
}
