using System;

namespace flipcoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int head = 1, tail = 0;
            Random random = new Random();
            int flip = random.Next(0, 2);
            if(flip==0)
            {
                Console.WriteLine("tail");

            }
            else
            {
                Console.WriteLine("head");
            }
          
        }
    }
}
