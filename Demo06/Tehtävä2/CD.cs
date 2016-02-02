using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2
{
    class CD
    {
        /// <summary>
        /// Holds songs
        /// </summary>
        private List<Songs> songs = new List<Songs>();
        public string Name { get; set; }

        /// <summary>
        /// Method to add songs to a CD
        /// </summary>
        /// <param name="song"></param>
        public void AddSongs(Songs song)
        {
            songs.Add(song);
        }

        public void PrintSongs()
        {
            Console.WriteLine("Songs on disk \"{0}\":", Name);
            foreach (Songs song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }
    }
}
