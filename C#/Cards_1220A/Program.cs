using System;

namespace Cards_1220A
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int z = 0, n = 0;//Zero 'z' & One 'n' Count
            string input = Console.ReadLine();

            for (int i = 0; i < length; i++)
            {
                if (input[i] == 'z')
                {
                    z = z + 1;
                }
                else if (input[i] == 'n')
                {
                    n = n + 1;
                }
            }
            while (n > 0)
            {
                Console.Write("1 ");
                n--;
            }
            while (z > 0)
            {
                Console.Write("0 ");
                z--;
            }
        }
    }
}
