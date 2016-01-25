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
    class Volyme
    {
     
        static void Main(string[] args)
        {
            //luodaan radio
            Radio radio = new Radio();
            Console.Write("Anna taajuus jota kuunnella:");
            string hz = Console.ReadLine();
            int freaquency = int.Parse(hz);
            radio.Freaquency = freaquency;
            Console.ReadLine();


            //luodaan volyme

            Volyme volyme = new Volyme();
            Console.Write("Anna äänenvoimakkuus jolla kuunnella:");
            string vol = Console.ReadLine();
            int Volyme = int.Parse(vol);
            vol.Volyme = volyme;

            
        }
    }
}
