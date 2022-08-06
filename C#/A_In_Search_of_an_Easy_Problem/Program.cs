using System;
using System.Linq;

namespace A_In_Search_of_an_Easy_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n = Console.ReadLine();
            //var i = Console.ReadLine().Split(' ').Select(int.Parse).Sum();

            //if (i > 0)
            //    Console.WriteLine("HARD");
            //else
            //    Console.WriteLine("EASY");

            Console.ReadLine();
            Console.WriteLine(Console.ReadLine().Split(' ').Any(x => x == "1") ? "HARD" : "EASY");
        }
    }
}
