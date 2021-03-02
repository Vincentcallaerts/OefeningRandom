using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();
            double randomGetal = random.NextDouble() * 360;
            Console.WriteLine(randomGetal);
            Console.ReadLine();

            if (randomGetal >= 0 && randomGetal <= 90)
            {
                Console.WriteLine("eerste kwadrant");
            }
            else if (randomGetal >= 90 && randomGetal <= 180)
            {
                Console.WriteLine("tweede kwadrant");
            }
            else if (randomGetal >= 180 && randomGetal <= 270)
            {
                Console.WriteLine("derde kwadrant");
            }
            else
            {
                Console.WriteLine("vierde kwadrant");
            }

        }
    }
}
