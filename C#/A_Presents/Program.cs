using System;
using System.Linq;

namespace A_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] output = new int[n];

            for (int i = 0; i < n; i++)
            {
                output[p[i] - 1] = i + 1;
            }
            string s = string.Join(" ", output);
            Console.WriteLine(s);
        }
    }
}
