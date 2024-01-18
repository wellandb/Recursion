namespace towerOfHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            Console.WriteLine("The sequence of moves in Tower of Hanoi is:\n");
            towerOfHanoi(num, 'A', 'C', 'B');
            Console.ReadLine();
        }

        public static void towerOfHanoi(int num, char src, char dst, char temp)
        {
            if(num > 0)
            {
                towerOfHanoi(num-1, src, temp, dst);
                Console.WriteLine("Move disk {0} from tower {1} to tower {2}",
                                num, src, dst);
                towerOfHanoi(num-1, temp, dst, src);
            }
        }
    }
}
