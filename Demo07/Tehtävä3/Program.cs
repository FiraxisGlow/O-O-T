using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tehtävä3
{
    class Program
    {
        static void Main(string[] args)
        {
            //created list
            List<Ohjelma> programs = new List<Ohjelma>();
            
            //creating list objects and initializing
            programs.Add (new Ohjelma { Name = "That 70's Show", AirTime = "17:00-17:30", Channel = "MTV 3", Description = "A bunch of wakky kids smoking pot and engaging in general shenanigans." });
            programs.Add(new Ohjelma { Name = "That 70's Show", AirTime = "17:00-17:30", Channel = "MTV 3", Description = "A bunch of wakky kids smoking pot and engaging in general shenanigans." });
            programs.Add(new Ohjelma { Name = "That 70's Show", AirTime = "17:00-17:30", Channel = "MTV 3", Description = "A bunch of wakky kids smoking pot and engaging in general shenanigans." });
            programs.Add(new Ohjelma { Name = "That 70's Show", AirTime = "17:00-17:30", Channel = "MTV 3", Description = "A bunch of wakky kids smoking pot and engaging in general shenanigans." });
            programs.Add(new Ohjelma { Name = "That 70's Show", AirTime = "17:00-17:30", Channel = "MTV 3", Description = "A bunch of wakky kids smoking pot and engaging in general shenanigans." });
            programs.Add(new Ohjelma { Name = "That 70's Show", AirTime = "17:00-17:30", Channel = "MTV 3", Description = "A bunch of wakky kids smoking pot and engaging in general shenanigans." });

            StreamWriter outputFile = null;
            try
            {
                outputFile = new StreamWriter(@"e:\TVFilu.txt");
                foreach (Ohjelma pograms in programs)
                {
                    outputFile.WriteLine(programs.ToString());
                }

            }
            finally
            {
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }


        }
    }
}
