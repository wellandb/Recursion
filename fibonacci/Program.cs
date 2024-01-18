namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 12;
            int fib = fibonacci(n);
            Console.WriteLine($"The {n}'th number of the fibonacci sequence is: {fib}");
        }

        public static int fibonacci(int n)
        {
            
            if (n<=1)
            {
                return 0;
            }
            if (n == 2)
            {
                return 1;
            }
            return fibonacci(n-1) + fibonacci(n-2);
        }
    }
}
