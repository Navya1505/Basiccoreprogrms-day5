using System;

namespace evenorodd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("odd Number");
            }
        }
    }
}
