using System;
using System.Collections;
using System.Linq;

namespace The_Smallest_String_Concatenation_632C
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            var arrayList = new ArrayList();

            while(length > 0)
            {
                arrayList.Add(Console.ReadLine());
                length--;
            }
            for (int i = 0; i < arrayList.Count; i++)
            {

            }
            var strings = new string[] { "ab","abc" };
            string longest = strings.OrderByDescending(s => s.Length).First();
            Console.WriteLine(longest);
            Console.ReadKey();
        }
    }
}
