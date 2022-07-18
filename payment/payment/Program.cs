using System;


namespace payment
{
    class Program
    {
        static void Main(string[] args)
        {
            int principle; int year; int rate;
            principle = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());
            rate = Convert.ToInt32(Console.ReadLine());
            float n = 12 * year;
            float r = rate / (12 * 100);
            float payment = (float)((principle * r) / (1 -((1 + r) ^ 2, -n)));
            Console.WriteLine("Payement  using compund interest " + payment);

        }
    }
}
