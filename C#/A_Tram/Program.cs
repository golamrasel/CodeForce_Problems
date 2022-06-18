using System;

namespace A_Tram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStops = int.Parse(Console.ReadLine());
            int minimumCapacity = 0, arriving = 0;
            for (int i = 1; i <= numberOfStops; i++)
            {
                var interAndExit = Console.ReadLine().Split();
                int exit = int.Parse(interAndExit[0]); 
                int enter = int.Parse(interAndExit[1]);
                arriving = Math.Abs((arriving - exit) + enter);
                minimumCapacity = minimumCapacity >= arriving ? minimumCapacity : arriving;
            }
            Console.WriteLine(minimumCapacity);
        }
    }
}
