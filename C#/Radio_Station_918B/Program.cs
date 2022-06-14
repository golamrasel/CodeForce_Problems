using System;
using System.Collections.Generic;

namespace Radio_Station_918B
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new List<string>();
            var nameIp = new List<string>();
            var commandIp = new List<string>();
            var command = new List<string>();
            int n, m;

            string[] namcom = Console.ReadLine().Split(' ');
            n = int.Parse(namcom[0]);
            m = int.Parse(namcom[1]);

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                name.Add(input[0]);
                nameIp.Add(input[1]);
            }
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                command.Add(input[0]);
                commandIp.Add(input[1].Remove(input[1].Length - 1, 1));
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   if (commandIp[i] == nameIp[j])
                    {
                        Console.WriteLine($"{command[i]} {commandIp[i]}; #{name[j]}");
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
