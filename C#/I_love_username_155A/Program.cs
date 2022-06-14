using System;

namespace I_love_username_155A
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ");
            int count = 0;

            int maxValu = int.Parse(input[0]);
            int minValu = int.Parse(input[0]);

            for (int i = 0; i < length; i++)
            {
                if(int.Parse(input[i])> maxValu)
                {
                    maxValu = int.Parse(input[i]);
                    count++;
                }
                if(int.Parse(input[i]) < minValu)
                {
                    minValu = int.Parse(input[i]);
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
