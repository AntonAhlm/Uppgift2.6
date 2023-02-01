using System;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening med 3 ord.");
            string Mening = Console.ReadLine();

            int PunktIndex = Mening.IndexOf(" ");
            int PunktIndex2 = Mening.IndexOf(" ",PunktIndex+1);

            string ord1 = Mening[..PunktIndex];

            string ord2 = Mening[(PunktIndex+1)..(PunktIndex2)];

            string ord3 = Mening[(PunktIndex2 + 1)..];

            Console.WriteLine(ord3 + " " + ord2 + " " + ord1 + ".");

        }
    }
}
