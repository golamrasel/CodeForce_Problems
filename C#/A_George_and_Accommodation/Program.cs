using System;

namespace A_George_and_Accommodation
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var output = 0;
            for (int i = 0; i < n; i++)
            {
                var liveAndCapacity = Console.ReadLine().Split(' ');
                var live = int.Parse(liveAndCapacity[0]);
                var capacity = int.Parse(liveAndCapacity[1]);
                var emptySpace = capacity - live;
                if (emptySpace >= 2)
                    output++;
            }
            Console.WriteLine(output);
        }
    }
}
