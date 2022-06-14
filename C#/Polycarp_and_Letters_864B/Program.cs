using System;

namespace Polycarp_and_Letters_864B
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX_CHAR = 256;
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] count = new int[MAX_CHAR];
            int output = 0;

            for (int i = 0; i < MAX_CHAR; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    char x = input[i];
                    ++count[x];
                    if (count[x] == 1 && x != ' ')
                    {
                        ++output;
                    }
                }
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
