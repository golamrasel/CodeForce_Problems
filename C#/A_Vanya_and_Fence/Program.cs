using System;

namespace A_Vanya_and_Fence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var n = int.Parse(input[0]);
            var h = int.Parse(input[1]);
            var output = 0;
            var frdHight = Console.ReadLine().Split(' ');

            for (int i = 0; i < frdHight.Length; i++)
            {
                if (int.Parse(frdHight[i]) <= h)
                    output++;
                else
                    output += 2;
            }
            Console.WriteLine(output);
        }
    }
}
