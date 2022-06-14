using System;

namespace Display_The_Number_1295A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string output = string.Empty;

            while (n > 0)
            {
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    output = "";
                    for (int i = 1; i <= input/2; i++)
                    {
                        output += "1";
                    }
                    Console.WriteLine(output);
                    n--;
                }
                else
                {
                    output = "7";
                    input -= 3;
                    for (int i = 1; i <= input/2; i++)
                    {
                        output += "1";
                    }
                    Console.WriteLine(output);
                    n--;
                }
            }
            Console.ReadKey();
        }
    }
}
