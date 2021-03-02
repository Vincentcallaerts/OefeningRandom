using System;


namespace Oefening4
{
    class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();
            int getal1,getal2;
            //1 = blad 2 = steen 3 = schaar
            Console.Write("Wat kies je:\n1:blad\n2:blad\n3:schaar");
            getal1 = Convert.ToInt32(Console.ReadLine());
            getal2 = random.Next(1, 4);
            Console.WriteLine(getal1);

            if (getal1 == 1)
            {

                if (getal2 == 2)
                {
                    Console.WriteLine("je verliest");
                }
                if (getal2 == 3)
                {
                    Console.WriteLine("je wint");
                }
                else
                {
                    Console.WriteLine("gelijk");
                }

            }
            else if (getal1 == 2)
            {

                if (getal2 == 1)
                {
                    Console.WriteLine("je verliest");
                }
                if (getal2 == 3)
                {
                    Console.WriteLine("je wint");
                }
                else
                {
                    Console.WriteLine("gelijk");
                }

            }
            else if (getal1 == 3)
            {

                if (getal2 == 2)
                {
                    Console.WriteLine("je verliest");
                }
                if (getal2 == 1)
                {
                    Console.WriteLine("je wint");
                }
                else
                {
                    Console.WriteLine("gelijk");
                }

            }

            Console.ReadLine();

        }
    }
}
