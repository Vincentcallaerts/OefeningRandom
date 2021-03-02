using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefening3
{
    class Program
    {
        enum Vragen {Waar_ligt_Parijs, Wat_is_jouw_naam, Waar_woon_je}
        enum Antwoorden {Frankrijk, Mijn_naam, Mechelen}
        enum RandomOplossingen {Duitsland, Spanje, Engenland,Ken,Kenny,Niet_Vincent,Antwerpen,Dendermonde,Gent }
        enum Vraag { a,b,c,d}
        static void Main(string[] args)
        {

            char antwoord;
            Random random = new Random();
            int randomGetal1,randomGetal2,temp, score;
            score = 0;

            Console.WriteLine("antwoord aub met a b c of d in deze quiz");
            
            for (int i = 0; i < 3; i++)
            {
                
                randomGetal1 = random.Next(4);
                temp = randomGetal1;
                Console.WriteLine((Vragen)i + ": ");
                for (int j = 0; j < 4; j++)
                {
                   
                    if (randomGetal1 == j)
                    {
                       
                        Console.WriteLine($"Antwoord {(Vraag)j}: {(Antwoorden)i}");
                    }
                    else
                    {
                        randomGetal2 = random.Next(i * 3, 3 + 3*i);
                        Console.WriteLine($"Antwoord {(Vraag)j}: {(RandomOplossingen)(randomGetal2)}");
                    }
                }
                Console.Write("Wat is je antwoord: ");
                antwoord = Convert.ToChar(Console.ReadLine());
                if (temp == Convert.ToInt32(antwoord - 97))
                {
                    score += 2;

                }
                else
                {
                    score -= 1;
                }
                             
            }

            Console.WriteLine($"Wow dat was een leuke quiz je score is: {score}");
            Console.ReadLine();
        }
    }
}
