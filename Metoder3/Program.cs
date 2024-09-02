using System.Diagnostics.Metrics;

namespace Metoder3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa ett program med en ny metod.Metoden skall ta emot två inparametrar av typen string
            //och slå ihop dom till en sträng och returnera det nya värdet.Anropa den nya metoden från
            //Main och skriv ut resultatet på skärmen. 

            string combinedStrings = CombineStrings("Hej" , "DÅ");

            Console.WriteLine(combinedStrings);

            Console.ReadLine();

        }
        static string CombineStrings(string x, string y)
        {
            return x + y;
        }

    }
}
