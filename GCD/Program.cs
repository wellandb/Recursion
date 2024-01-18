namespace GCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 99;
            int grCoDiv = GCD(x, y);
            Console.WriteLine($"GCD of {x} and {y} is: {grCoDiv}");
        }

        public static int GCD(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }
            return (GCD(y, x % y));
        }
    }
}
