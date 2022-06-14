using System;
using System.Collections.Generic;

namespace University_Classes_847G
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<string>();
            int group = int.Parse(Console.ReadLine());
            for (int i = 0; i < group; i++)
            {
                string classes = Console.ReadLine();
                a.Add(classes);
            }
            int m = 0;
            for (int i = 0; i < 7; i++)
            {
                int zs = 0;
                for (int j = 0; j < group; j++)
                {
                    if (a[j][i] == '1')
                        zs++;
                }
                if (zs > m)
                    m = zs;
            }
            Console.WriteLine(m);
            Console.ReadKey();

        }
    }
}
