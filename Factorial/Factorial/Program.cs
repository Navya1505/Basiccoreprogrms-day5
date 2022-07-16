using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:"); ;
            int number = Convert.ToInt32(Console.ReadLine());
            int factor;
            for (factor = 1; factor <= number; factor++)
            {
                if (number % factor == 0)
                {
                    Console.WriteLine(factor + "");
                }
                
            }
        }
    }
}  
