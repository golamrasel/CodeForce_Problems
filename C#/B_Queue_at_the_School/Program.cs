using System;

namespace B_Queue_at_the_School
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int t = int.Parse(input[1]);

            string boyAndGirls = Console.ReadLine();
            char[] chars = boyAndGirls.ToCharArray();

            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < boyAndGirls.Length - 1; j++)
                {
                    if (chars[j] == 'B' && chars[j + 1] == 'G')
                    {
                        chars[j] = 'G';
                        chars[j + 1] = 'B';
                        j++;
                    }
                }
            }
            string result = new string(chars);
            Console.WriteLine(result);
        }
    }
}
