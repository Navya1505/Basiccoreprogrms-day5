using System;

namespace fibnoseries
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 1, z, i, n;
            Console.WriteLine("enter number:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + "" + y + "");
            for (i = 2; i < n; i++)
            {
                z = x + y;
                Console.WriteLine(z + "");
                x = y;
                y = z;
            }
        }
    }
}