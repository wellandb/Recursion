namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fac = factorial(5);
            Console.WriteLine($"factorial of 5: {fac}");
            Console.ReadLine();
        }
        static int factorial(int n)
        {
            // Base Case
            if ( n <= 1)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }
    }
}
