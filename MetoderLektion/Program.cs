namespace MetoderLektion
{
    internal class Program
    {
        // I en console applikation är Main metoden det första som körs.
        static void Main(string[] args)
        {
            Console.Write("Mata in första talet: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Mata in andra talet: ");
            int number2 = int.Parse(Console.ReadLine());

            int sum = SumNumbers(number1, number2);
            int[] arrayNumbers = GetNumberArray(number1, number2);

            Console.WriteLine(sum);
            PrintNumbers(arrayNumbers);
            Console.ReadLine();
        }
        static int SumNumbers(int number1, int number2)
        {
            number1++;
            return number1 + number2;
        }

        static int[] GetNumberArray(int number1, int number2)
        {
            int[] numberArray = new int[2];
            numberArray[0] = number1;
            numberArray[1] = number2;
            return numberArray;
        }

        static void PrintNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

    }
}
