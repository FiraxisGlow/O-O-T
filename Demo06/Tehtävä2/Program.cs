using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2
{
    class Program
    {
        static void Main(string[] args)
        
            {
                // collection for the CD's.

                List<CD> collection = new List<CD>();

                // making initializing disks.

                CD disk1 = new CD { Name = "Muumeilua" };
                CD disk2 = new CD { Name = "Nyt koodataan" };

                // making and initializing some songs.
     
                Songs song1 = new Songs { Name = "Nyt Koodataan", Artist = "Ohjelmoijat", Lenght = "2:45" };
                Songs song2 = new Songs { Name = "Nyt Koodataan", Artist = "Ohjelmoijat", Lenght = "2:45" };
                Songs song3 = new Songs { Name = "Nyt Koodataan", Artist = "Ohjelmoijat", Lenght = "2:45" };
                Songs song4 = new Songs { Name = "Nyt Koodataan", Artist = "Ohjelmoijat", Lenght = "2:45" };
                Songs song5 = new Songs { Name = "Nyt Koodataan", Artist = "Ohjelmoijat", Lenght = "2:45" };
                Songs song6 = new Songs { Name = "Nyt Koodataan", Artist = "Ohjelmoijat", Lenght = "2:45" };
                Songs song7 = new Songs { Name = "Nyt Koodataan", Artist = "Ohjelmoijat", Lenght = "2:45" };
                Songs song8 = new Songs { Name = "Nyt Koodataan", Artist = "Ohjelmoijat", Lenght = "2:45" };
                Songs song9 = new Songs { Name = "Nyt Koodataan", Artist = "Ohjelmoijat", Lenght = "2:45" };
                Songs song10 = new Songs { Name = "Nyt Koodataan", Artist = "Ohjelmoijat", Lenght = "2:45" };
                Songs song11 = new Songs { Name = "Nyt Koodataan", Artist = "Ohjelmoijat", Lenght = "2:45" };
                Songs song12 = new Songs();

                
            
            
            
                // moving songs to disks.
                disk1.AddSongs(song1);
                disk1.AddSongs(song3);
                disk1.AddSongs(song6);
                disk1.AddSongs(song8);
                disk1.AddSongs(song9);
                disk1.AddSongs(song10);





                disk2.AddSongs(song2);
                disk2.AddSongs(song4);
                disk2.AddSongs(song5);
                disk2.AddSongs(song7);
                disk2.AddSongs(song9);
                disk2.AddSongs(song10);
                disk2.AddSongs(song11);
                disk2.AddSongs(song12);

                // moving disks to collections.
                collection.Add(disk1);
                collection.Add(disk2);

                // printing collection data.
                foreach (CD cd in collection)
                {
                    cd.PrintSongs();
                }
            }
        }
    }

