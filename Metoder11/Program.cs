namespace Metoder11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 0;
            Console.WriteLine($"x: {x}, y: {y}");
            Translate(ref x, out y);
            Console.WriteLine($"x: {x}, y: {y}");
            Console.ReadLine();
        }
        static void Translate(ref int x, out int y)
        {
            x = 10 + x;
            y = 20;
        }
    }
}
