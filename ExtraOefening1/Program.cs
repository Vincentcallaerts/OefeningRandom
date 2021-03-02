using System;


namespace ExtraOefening1
{
    class Program
    {
        static void Main(string[] args)
        {

            double lengte, gewicht,bmi;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("hoe groot ben je in meter: ");
                lengte = Convert.ToDouble(Console.ReadLine());
                Console.Write("hoe dik ben je in kg: ");
                gewicht = Convert.ToDouble(Console.ReadLine());

                bmi = (gewicht/(lengte*lengte))*100;
                Console.WriteLine(bmi);

                if (bmi <= 18.5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ondergewicht");
                    Console.ResetColor();

                }
                else if (bmi > 18.5 && bmi <= 25)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Normaal");
                    Console.ResetColor();
                }
                else if (bmi > 25 && bmi <= 30)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Overgewicht");
                    Console.ResetColor();
                }
                else if (bmi > 30 && bmi <= 40)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Zwaarlijvig");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Ernstige obesitas");
                    Console.ResetColor();
                }
            }
           
            Console.ReadLine();
        }
    }
}
