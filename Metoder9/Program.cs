namespace Metoder9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in en bokstav för att kontrollera om det är en vokal eller konstant: ");
            char word = char.Parse(Console.ReadLine());

            bool isAVokal = IsAVokal(word);
            if (isAVokal)
                Console.WriteLine("Bokstaven är en vokal.");
            else
                Console.WriteLine("Bokstaven är en konstant.");

            Console.ReadKey();
        }
        static bool IsAVokal(char x)
        {
            if (x == 'a' || x == 'o' || x == 'u' || x == 'e' || x == 'i' || x == 'y' || x == 'ä' || x == 'å' || x == 'ö')
                return true;
            else 
                return false;
        }
    }
}
