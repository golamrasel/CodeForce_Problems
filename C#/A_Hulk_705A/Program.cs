namespace A_Hulk_705A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                    result += "I hate";
                else
                    result += "I love";

                if (i != n)
                    result += " that ";
            }

            result += " it";

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
