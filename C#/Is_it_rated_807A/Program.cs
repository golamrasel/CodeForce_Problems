using System;

namespace Is_it_rated_807A
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] a = new int[length];
            int[] b = new int[length];
            int x = 0;

            for (int i = 0; i < length; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                a[i] = int.Parse(input[0]);
                b[i] = int.Parse(input[1]);
            }

            for (int i = 0; i < length; i++)
            {
                if (a[i] != b[i])
                {
                    x = 1;
                    Console.WriteLine("rated");
                    break;
                }

            }

            if (x != 1)
            {
                for (int i = 1; i < length; i++)
                {
                    if (a[i] > a[i - 1])
                    {
                        x = 2;
                        Console.WriteLine("unrated");
                        break;
                    }
                }
            }

            if (x == 0)
                Console.WriteLine("maybe");
        }
    }
}
