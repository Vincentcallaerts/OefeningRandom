using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int getal1 = random.Next(-5, 6);
            Console.WriteLine(getal1);
            Console.ReadLine();
        }
    }
}
