using System;

namespace A_Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            char[] reverseArray = s.ToCharArray();

            Array.Reverse(reverseArray);
            var output = new string(reverseArray);

            if (output == t)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
