using System;

namespace An_Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var output = 0;
            while(input > 0)
            {
                input -= 5;
                output += 1;
            }
            Console.WriteLine(output);
        }
    }
}
