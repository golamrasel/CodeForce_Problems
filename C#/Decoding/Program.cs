using System;

namespace Decoding_746B
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string nextText = "";
            int i = 0;

            while(length != 0)
            {
                if (length % 2 == 0)
                    nextText = input[i] + nextText;
                else
                    nextText = nextText + input[i];
                length--;
                i++;
            }
            Console.WriteLine(nextText);
            Console.ReadKey();
           
        }
    }
}
