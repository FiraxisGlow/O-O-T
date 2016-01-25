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
    class Program
    {
     
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            Console.Write("Anna taajuus jota kuunnella:");
            string hz = Console.ReadLine();
            int freaquency = int.Parse(hz);
            radio.Freaquency = freaquency;
            
       
            Volyme volyme = new Volyme();
            Console.Write("Anna äänenvoimakkuus jolla kuunnella:");
            string vol = Console.ReadLine();
            int volyme = int.Parse(vol);
            Volyme.Vol = volyme;

            Console.WriteLine(hz.ToString);
        }
    }
}
