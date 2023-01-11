using System;
using System.Linq;

namespace B_Drinks_200B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), decimal.Parse);
            decimal output = input.Sum() / input.Length;
            Console.WriteLine(output);
        }
    }
}
