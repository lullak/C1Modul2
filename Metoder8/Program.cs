namespace Metoder8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4};

            int sumOfAddition = Sum(numbers);
            int sumOfMultiplication = Multiply(numbers);

            Console.WriteLine($"Summan av att addera är: {sumOfAddition}\nSumman av att multiplera är: {sumOfMultiplication}");
            Console.ReadLine();
        }
        static int Sum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        static int Multiply(int[] nums)
        {
            int sum = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                sum *= nums[i];
            }
            return sum;
        }
    }
}
