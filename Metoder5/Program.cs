using System.Diagnostics.Metrics;
using System;

namespace Metoder5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa ett program där användaren får en fråga om att mata in sin ålder. Skapa en metod som
            //tar emot det inmatade värdet och kontrollerar om användaren är myndig dvs över 18 år.
            //Metoden returnerar sant eller falskt.Anropa metoden och skriv ut på skärmen om
            //användaren är myndig eller ej.
            Console.Write("Ange din ålder: ");
            int age = int.Parse(Console.ReadLine());
            bool ageLimit = UserOverTheAge(age);
            if (ageLimit)
                Console.WriteLine("Du är myndig");
            else
                Console.WriteLine("Du är inte myndig");

            Console.ReadLine();

        }

        public static bool UserOverTheAge(int x)
        {
            if (x < 18) 
            {
                return false;
            }
            else 
            {
                return true;
            }
            
        }
       
    }
}
