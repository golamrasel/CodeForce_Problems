using System;

namespace Water_Lily_1199B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double H = int.Parse(input[0]);
            double L = int.Parse(input[1]);

            double A = ((L * L - H * H) / (2 * H));
            Console.WriteLine(Math.Round(A,10));
            Console.ReadKey();
        }
    }
}
