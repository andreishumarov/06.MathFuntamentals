using System;

namespace decimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (!IsDigitsOnly(input))
            {
                Console.WriteLine("Стринга не е число");
                return;
            }
            int number = int.Parse(input);
            int[] result = new int[32];
            int i = 0;
            for (i = 0; number > 0; i++)
            {
                result[i] = number % 2;
                number = number / 2;
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
        static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
