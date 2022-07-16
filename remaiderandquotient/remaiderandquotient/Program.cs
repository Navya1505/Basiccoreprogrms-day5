using System;

namespace remaiderandquotient
{
    class Program
    {
        static void Main(string[] args)
        {
            int divdend = 44;
            int divisor = 6;
            int quotient = divdend / divisor;
            int remainder = divdend % divisor;

            Console.WriteLine("dividend:{0} diviso:{1},dividend,divisor");
            Console.WriteLine("quotient="+quotient);
            Console.WriteLine("remainder="+remainder);
        }
    }
}
