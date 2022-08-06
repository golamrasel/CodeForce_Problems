using System;
using System.Linq;

namespace A_Beautiful_Year
{
    class Program
    {
        static void Main(string[] args)
        {
			int input = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                input = input + 1;
                if (Convert.ToString(input).Distinct().Count() == 4)
                {
                    var a = Convert.ToString(input).Distinct();
                    break;
                }
            }
            Console.Write(input);
		}
    }
}
