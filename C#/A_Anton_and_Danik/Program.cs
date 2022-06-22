using System;

namespace A_Anton_and_Danik
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var s = Console.ReadLine();
            char[] input = s.ToCharArray();
            int anton = 0, danik = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'A')
                    anton++;
                else
                    danik++;
            }

            if (anton > danik)
                Console.WriteLine("Anton");
            else if(anton < danik)
                Console.WriteLine("Danik");
            else
                Console.WriteLine("Friendship");
        }
    }
}
