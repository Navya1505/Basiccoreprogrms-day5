using System;

namespace prime_no
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 3, z, i, n;
            Console.Write("Enter the number of elements: ");
            n =int.Parse(Console.ReadLine());
            Console.Write(x + " " + y + " ");
            for (i = 2; i < n; i++)
            {
                z = x + y;
                Console.Write(z + " ");
                x = y;
                y = z;
            }
        }
    }
}
