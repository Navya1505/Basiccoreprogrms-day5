using System;

namespace swapofnums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("\n enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("\n After Swapping");
        Console.WriteLine("\n firstnumber:" +num1);
            Console.WriteLine("\n secondnumber:" +num2);
        }

    }
}
