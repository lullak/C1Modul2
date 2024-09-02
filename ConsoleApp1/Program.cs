namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float value1;
            Console.Write("Ange ett värde du vill konvertera till procent ");
            if (float.TryParse(Console.ReadLine(), out float value2))
            {
                value1 = ToPercentage(value2);

                Console.WriteLine($"Procenten är {value1:##.##}%");
            }
            else
            {
                Console.WriteLine("Försök igen");
            }

            
            

            Console.ReadKey();
        }

        static float ToPercentage(float x)
        {
            return x = x * 100;
        }
    }
}
