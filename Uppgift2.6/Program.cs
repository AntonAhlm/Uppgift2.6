using System;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening med 3 ord.");
            string Mening = Console.ReadLine();

            int PunktIndexx = Mening.IndexOf(" ");
            int PunktIndex = Mening.IndexOf(" ",PunktIndexx);

            string ord1 = Mening[..PunktIndex];

            string ord2 = Mening[(PunktIndex + 1^1)..];

            string ord3 = Mening[(PunktIndex + 3)..];

            //Console.WriteLine(ord3 + ord2 + ord1 + ".");
            Console.WriteLine(ord1);
            Console.WriteLine(ord2);
            Console.WriteLine(ord3);

        }
    }
}
