using System;

namespace A_Nearly_Lucky_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var luckyNumber = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '4' || input[i] == '7')
                    luckyNumber += input[i];
            }
            if(luckyNumber.Length == 4 || luckyNumber.Length == 7)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
