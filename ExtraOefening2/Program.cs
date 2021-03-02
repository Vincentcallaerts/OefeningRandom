using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            int aantalSchoenen,resultaat;
            Console.Write("Hoeveel schoenen heb je gekocht: ");
            aantalSchoenen = Convert.ToInt32(Console.ReadLine());

            if (aantalSchoenen >= 10)
            {
                resultaat = (9 * 20) + (aantalSchoenen - 9) * 10;
                Console.WriteLine($"Je hebt 9 gekocht schoenen gekocht aan 20 euro en {aantalSchoenen - 9} aan 10 euro, Totaal bedrag {resultaat}");
            }
            else
            {
                resultaat = aantalSchoenen * 20;
                Console.WriteLine($"Je hebt 9 gekocht schoenen gekocht aan 20 euro en dit koste {resultaat}");
            }
            Console.ReadLine();
        }
    }
}
