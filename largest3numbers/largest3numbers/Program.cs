using System;

namespace largest3numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnum, secondnum, thirdnum;
            Console.WriteLine("enter first number:");
            firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number:");
            secondnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number:");
            thirdnum = Convert.ToInt32(Console.ReadLine());
            if (firstnum > secondnum)
            {

                if (firstnum > thirdnum)
                {
                    Console.WriteLine("largest number" + firstnum);
                }
                else
                {
                    Console.WriteLine("largest number" + secondnum);
                }
            }
            else
            {
                if (secondnum > thirdnum)
                {
                    Console.WriteLine("largest number" + secondnum);
                }
                else
                {
                    Console.WriteLine("largest number" + thirdnum);
                }
            }
        }      
    }

}
