using System;

namespace String_Task_118A
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 'a' && input[i] != 'e' && input[i] != 'i' && input[i] != 'o' && input[i] != 'u' && input[i] != 'y' &&
                   input[i] != 'A' && input[i] != 'E' && input[i] != 'I' && input[i] != 'O' && input[i] != 'U' && input[i] != 'Y')
                {
                    if (input[i] >= 'A' && input[i] <= 'Z')
                        output += "." + (char)(input[i] + 32);
                    else
                        output += "." + input[i];
                }
            }
            Console.WriteLine(output);
        }
    }
}
