using System.Diagnostics.Metrics;
using System;

namespace Metoder4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa en metod som räknar ut hur mycket momsen blir på en viss summa. Summan skall
            //vara en inparameter av typen int.Metoden skall returnera momsvärdet
            int value = int.Parse(Console.ReadLine());
            
            float moms = Moms(value);

            Console.WriteLine(moms);
            Console.ReadLine();

        }

        static float Moms(int x)
        {
            return (float)(x * 0.25);
            
        }

    }
}
