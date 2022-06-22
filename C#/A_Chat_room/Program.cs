using System;

namespace A_Chat_room
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var chars = input.ToCharArray();
            var a = "hello";
            int x = 0, y = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if(chars[i] == a[x])
                {
                    x++;
                    y++;
                    if (y == 5)
                        break;
                }
            }
            if(y == 5)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
