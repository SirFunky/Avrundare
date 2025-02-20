using System;

namespace Avrundare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal med sex (9) antal decimaler.:");
            string nr = Console.ReadLine();
            double decimalnr = Convert.ToDouble (nr); // här gör vi så att vi kan läsa decimaltalen i texten. 

            Console.WriteLine("Hur många decimaler ska talet ha?:");
            nr = Console.ReadLine();
            int paces = Convert.ToInt32 (nr); //här lägger vi in hur många decimaler som ska vissas på skärmen

            var avrundatnr = Math.Round(decimalnr, paces); //här rundar vi av talet till antal decimaler vi har bestämt innan.
            Console.WriteLine("Avrundat: {0}", avrundatnr);

            Console.Read();
        }
    }
}
