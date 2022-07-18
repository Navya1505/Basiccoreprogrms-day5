using System;

namespace squareroot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number whose square root to be found");
            Random random = new Random();
            int n = random.Next();
            double epsilon = 1e-15;
            double t = n;
            while (Math.Abs(t - n / t) > epsilon * t)
            {
                t = (n / t + t) / 2.0;
            }
            Console.WriteLine("Squarerootis :" +t);

        }
    }
}
