﻿/*
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
    class Program
    {
        static void Main(string[] args)
        {
          
            Jynkky2 jynkky1 = new Jynkky2();
            Console.Write("Syötä jynkky lehtiesi määrä hyllyssä. ");
            string magazine = Console.ReadLine();
            int mag = int.Parse(magazine);
            jynkky1.Magazine = mag;
            

            Jynkky jynkky2 = new Jynkky();
            Console.Write("Syötä jynkky videoidesi määrä hyllyssä.");
            string video = Console.ReadLine();
            int vid = int.Parse(video);
            jynkky2.Video = vid;
            

            Viina viina = new Viina();
            Console.Write("Kuinka monta litraa hyllyssäsi on viinaa?");
            string C2H3OH = Console.ReadLine();
            int alko = int.Parse(C2H3OH);
            viina.Volyme = alko;
           

            Sarjakuva sarjakuva = new Sarjakuva();
            Console.Write("Kuinka monta sarjakuvaa hyllyssäsi on?");
            string comics = Console.ReadLine();
            int comic = int.Parse(comics);
            sarjakuva.Comic = comic;
            

            Console.WriteLine(video.ToString());
            Console.WriteLine(magazine.ToString());
            Console.WriteLine(comic.ToString());
            Console.WriteLine(alko.ToString());
            Console.ReadLine();
        }
    }
}
