using System;

namespace decimalToBinaryEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Binary 1:");
            string s = Console.ReadLine();
            Console.Write("Binary 2:");
            string s1 = Console.ReadLine();

            foreach (char b in s)
            {
                if (b < '0' || b > '9')
                {
                    Console.WriteLine("ERROR");
                    return;
                }
            }
            foreach (char b in s1)
            {
                if (b < '0' || b > '9')
                {
                    Console.WriteLine("ERROR");
                    return;
                }
            }
            int c = Convert.ToInt32(s);
            int c1 = Convert.ToInt32(s1);

            int i = 0, rem = 0;
            int[] summaray = new int[20];
            while (c != 0 || c1 != 0)
            {
                summaray[i++] = (c % 10 + c1 % 10 + rem) % 2;
                rem = (c % 10 + c1 % 10 + rem) / 2;
                c = c / 10;
                c1 = c1 / 10;
            }
            if (rem != 0)
                summaray[i++] = rem;
            --i;
            Console.WriteLine("Sum of the two binary numbers: ");
            while (i >= 0)
                Console.Write("{0}", summaray[i--]);
            Console.ReadLine();
        }
    }
}