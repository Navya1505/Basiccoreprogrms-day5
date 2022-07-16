using System;

namespace leapyear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("enter year");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
        }
    }
}