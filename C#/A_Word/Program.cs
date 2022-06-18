using System;
using System.Linq;

namespace A_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var upperCase = string.Concat(input.Where(x => Char.IsUpper(x)));
            var lowerCase = string.Concat(input.Where(x => Char.IsLower(x)));
            var result = upperCase.Length > lowerCase.Length ? input.ToUpper() : input.ToLower();
            Console.WriteLine(result);
        }
    }
}
