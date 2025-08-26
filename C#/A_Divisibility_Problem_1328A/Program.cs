namespace A_Divisibility_Problem_1328A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                if (a % b == 0)
                    Console.WriteLine("0");
                else
                    Console.WriteLine(b - (a % b));
            }
            Console.ReadLine();
        }
    }
}
