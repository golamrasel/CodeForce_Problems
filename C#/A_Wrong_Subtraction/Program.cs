using System;

namespace A_Wrong_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]); //Subtract number.
            int k = int.Parse(input[1]); //Subtractions correspondingly.

            for (int i = 1; i <= k; i++)
            {
                var lastDigit = n % 10;
                if (lastDigit != 0)
                    n -= 1;
                else
                    n = n / 10;
            }
            Console.WriteLine(n);
        }
    }
}
