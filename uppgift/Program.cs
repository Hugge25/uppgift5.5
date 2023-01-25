using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många frågor vill du ställa mig?");
            int q = int.Parse(Console.ReadLine());
            
            int[] v = new int[q];
            Random rnd = new Random();

            string[] s = {"Nej, så klart inte", "Um... Om du har tur?", "Jag tror inte din mamma hade gått med på det", "Det där är inte mitt område", "Ja, lätt", "Ja", "NEJ", "... bara stopp", "Tänker inte svara ens", "Ja, om dina föräldrar tillåter det", };

            int anfr = 0;

            for (int i = 0; i < q; i++)
            {
                anfr++;
                Console.WriteLine($"Vad är det du undrar? {anfr} av {q} frågor");
                Console.WriteLine();
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("-" + s[rnd.Next(10)]);
                Console.WriteLine();

                
            }

            


        }
    }
}