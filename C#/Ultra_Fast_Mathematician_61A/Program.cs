namespace Ultra_Fast_Mathematician_61A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lineOne = Console.ReadLine();
            string lineTwo = Console.ReadLine();

            string output = string.Empty;

            for (int i = 0; i < lineOne.Length; i++)
            {
                if (lineOne[i] != lineTwo[i])
                {
                    output = output + "1";
                }
                else
                {
                    output = output + "0";
                }
            }

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
