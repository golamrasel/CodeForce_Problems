using System;

namespace A_Calculating_Function_486A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = long.Parse(Console.ReadLine());
            long outout = 0;

            if (input % 2 == 0)
                outout = input / 2;
            else
                outout = -(input / 2 + 1);

            Console.WriteLine(outout);
        }
    }
}
