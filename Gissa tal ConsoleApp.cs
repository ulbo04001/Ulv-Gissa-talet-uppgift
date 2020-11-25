using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            int Slumptal = slump.Next(1,101);
            Console.WriteLine("Jag har valt ett slupmtal mellan 1 och 100. Gissa vilket!");
            int Gissning = 0;
            int antal = 0;
            while (Gissning != Slumptal)
            {
                Console.WriteLine("Skriv in din gissning: ");
                Gissning = int.Parse(Console.ReadLine());

                if (Gissning > Slumptal)
                {
                    Console.WriteLine("För högt gissa lägre");
                }
                else if (Gissning < Slumptal)
                {
                    Console.WriteLine("För lågt gissa högre");
                }
                else
                {
                    Console.WriteLine("Grattis, Rätt!");
                    Console.WriteLine("Du gissade " + (antal + 1) + " gånger");

                }

                antal++;
            }

        }
    }
}
