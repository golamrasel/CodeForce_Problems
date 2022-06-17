using System;

namespace A_Soldier_and_Bananas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            int k, n, w,numberOfBananas = 0, costOfBananas = 0, borrowMoney = 0, output = 0; ;
            input = Console.ReadLine().Split(' ');
            k = int.Parse(input[0]); // Cost of first banana.
            n = int.Parse(input[1]); // Has Dollars
            w = int.Parse(input[2]); // Want to bananas.

            for (int i = 1; i <= w; i++)
            {
                numberOfBananas += i;
            }
            costOfBananas = k * numberOfBananas;
            borrowMoney = costOfBananas - n;
            output = borrowMoney > 0 ? borrowMoney : output;
            Console.WriteLine(output);
        }
    }
}
