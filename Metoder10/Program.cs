namespace Metoder10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string returnValue = "this is fun";
            Translate(ref returnValue);

            Console.WriteLine(returnValue);

            Console.ReadLine();

        }

        static void Translate(ref string value)
        {
            
            string[] consonants = { "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z"};

            for (int i = 0; i < consonants.Length; i++)
            {

                if (value.Contains(consonants[i]))
                {
                    value = value.Replace(consonants[i], consonants[i] + "o" +
                    consonants[i]);
                }
            }
        }

    }
}
