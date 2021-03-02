using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningRandom
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int getal1 = random.Next(1,6);
            Console.WriteLine(getal1);
            Console.WriteLine("Kies nummer: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            if (getal1 == getal2)
            {

                Console.WriteLine("Het getal is gelijk aan elkaar");

            }
            else
            {
                Console.WriteLine("fout getal");
            }


        }
    }
}
