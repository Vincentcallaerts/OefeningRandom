using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                Random random = new Random();
                int getal1, getal2;
                getal1 = random.Next(1, 7);
                System.Threading.Thread.Sleep(100);
                getal2 = random.Next(1, 7);
                Console.WriteLine(getal1);
                Console.WriteLine(getal2);
                if (getal1 == getal2)
                {
                    Console.WriteLine("je wint");
                }
                else
                {
                    Console.WriteLine("je verliest");
                }
                Console.WriteLine();
            }
            

            Console.ReadLine();

        }
    }
}
