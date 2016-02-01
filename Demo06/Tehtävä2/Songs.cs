using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2
{
    class Songs 
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Lenght { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public Songs()
        {
            Name = "Unknown track";
            Artist = "Unknown artist";
            Lenght = "<N/A>";
        }

        /// <summary>
        /// return song data via override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return " - Song name: " + Name + " --- Artist: " + Artist + " --- Lenght: " + Lenght;
        }
    }
}
