using System;

namespace calender
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;
            Console.WriteLine("enter day");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter month");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter year");
            year = Convert.ToInt32(Console.ReadLine());
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d = (day + x + (31 * m) / 12) % 7;
            Console.WriteLine("Day " + d);

            ;
        }
    }
}
