namespace Metoder7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "king", "ming", "hästens", "birthday", "sgfewrgergergeg" };
            string longestWord = HittaLangstaOrdet(words);

            Console.WriteLine($"Längsta ordet är: {longestWord}");
            Console.ReadLine();
        }
        static string HittaLangstaOrdet(string[] x)
        {
            string longestWord = "";
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i].Length > longestWord.Length)
                    longestWord = x[i];
            }
            return longestWord;
        }
    }
}
