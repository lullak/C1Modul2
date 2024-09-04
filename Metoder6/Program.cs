namespace Metoder6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxValue = KontrolleraMaxVarde(-123, -243, 0);
            Console.WriteLine(maxValue);
            Console.ReadLine();
        }
        
        static int MaxVarde2(int value1, int value2)
        {
            // En if else, som retunerar största värdet i Maxvärde2 metoden.
            if (value1 > value2) 
            return value1;
            else 
            return value2; 
        }
        static int MaxVarde3(int value1, int value2, int value3)
        {
            // Samma sak här men det finns fler värden att kontrollera, så att den endast skickar med det största
            if (value1 > value2 && value1 > value3)
                return value1;
            else if (value2 > value3 && value2 > value3)
                return value2;
            else
                return value3;
        }
        static int KontrolleraMaxVarde(int value1, int value2, int value3)
        {
            //kontrollerar om någon av värdena är noll, och i det fallet kallar på MaxVärde 2 metoden, kör även en if else så att den
            // inte kallar MaxVarde2 med en parameter som innehåller 0. Annars kallar den på MaxVarde3 metoden.
            if (value1 == 0 || value2 == 0 || value3 == 0)
                if (value1 == 0)
                    return MaxVarde2(value2, value3);
                else if (value2 == 0)
                    return MaxVarde2(value1, value3);
                else
                    return MaxVarde2(value1, value2);
            else
            return MaxVarde3(value1, value2, value3);
        }
    }
}
