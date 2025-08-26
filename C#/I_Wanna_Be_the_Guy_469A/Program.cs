using System;
using System.Linq;

namespace I_Wanna_Be_the_Guy_469A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var xLevels = Console.ReadLine().Split().Skip(1).Select(int.Parse);
            var yLevels = Console.ReadLine().Split().Skip(1).Select(int.Parse);

            var allLevels = xLevels.Concat(yLevels).Distinct();

            Console.WriteLine(allLevels.Count() == n ? "I become the guy." : "Oh, my keyboard!");
        }
    }
}
