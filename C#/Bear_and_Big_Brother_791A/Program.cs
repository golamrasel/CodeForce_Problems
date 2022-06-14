using System;

namespace Bear_and_Big_Brother_791A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] length = Console.ReadLine().Split(' ');
            int a = int.Parse(length[0]);
            int b = int.Parse(length[1]);
            int x = 0;

            while (a <= b)
            {
                a = a * 3;
                b = b * 2;
                x = x + 1;
            }
            Console.WriteLine(x);
        }
    }
}
