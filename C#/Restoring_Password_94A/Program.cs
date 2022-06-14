using System;

namespace Restoring_Password_94A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] digit = new string[11];
            string a = Console.ReadLine();
            string b, x;
            int output(string z)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (z == digit[i])
                    {
                        return i;
                    }
                }
                return 0;
            }

            for (int i = 0; i < 10; i++)
            {
                b = Console.ReadLine();
                digit[i] = b;
            }
            for (int i = 0; i <= 70; i = i + 10 )
            {
                x = a.Substring(i, 10);
                Console.Write(output(x));
            }
            Console.ReadKey();
        }
    }
}
