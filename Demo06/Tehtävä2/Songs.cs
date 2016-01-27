using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2
{
    class Songs  //: Song
    {

        List<Song> songs;
        public Songs()
        {
            songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }      




        public override string ToString()
        {
           
            return songs;
           
        }
    }
}
