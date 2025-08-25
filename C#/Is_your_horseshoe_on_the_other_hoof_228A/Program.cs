namespace Is_your_horseshoe_on_the_other_hoof_228A
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
           var dis = input.Distinct().Count();
           var output = 4 - dis;
           Console.WriteLine(output);
        }

    }
}
