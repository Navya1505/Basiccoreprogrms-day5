using System;

namespace perfectnumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            int total = 0; int i = 1;
            for (i = 1; i < num; i++)
            {
                if (num % i == 0)
                    total += i;
            }
            if (total == num)
                Console.Write("{0} is a perfect number", num);
            else
                Console.Write("{0} is not a perfect number", num);
        }
        }
    }
