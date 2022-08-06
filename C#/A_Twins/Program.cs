using System;
using System.Linq;

namespace A_Twins
{
    class Program
    {
        static void Main(string[] args)
        {
			string n = Console.ReadLine();
			int[] a = Console.ReadLine().Split().Select(e => int.Parse(e)).OrderBy(e => -e).ToArray();

			int suma = 0;
			int sumb = 0;
			int i = 0;
			for (;i < a.Length - 1; i++)
			{
				suma += a[i];
				sumb = 0;
				for (int j = i + 1; j < a.Length; j++)
					sumb += a[j];

				if (suma > sumb)
					break;
			}

			Console.WriteLine(i + 1);
		}
    }
}
