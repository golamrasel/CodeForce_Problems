using System;
using System.Collections.Generic;

namespace A_Magnets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMagnets = int.Parse(Console.ReadLine());
            var input = new List<string>();
            var group = 1;

            for (int i = 0; i < numberOfMagnets; i++)
            {
                var a = Console.ReadLine();
                input.Add(a);
            }

            for (int i = 0; i < input.Count - 1; i++)
            {
                if(input[i] != input[i + 1])
                    group++;
            }

            Console.WriteLine(group);
        }
    }
}
