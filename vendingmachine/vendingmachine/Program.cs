using System;

namespace vendingmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int total = 0;
          int[] notes={1000, 500, 100, 50, 10, 5, 2, 1 };
            int money;
            int rem;
            Console.WriteLine("enter amount:");
            Random random = new Random();
            money = random.Next();

            if (money >= notes[i])
            {
                int calNotes = money / notes[i];
                rem = money % notes[i];
                money = rem;
                total += calNotes;
                Console.WriteLine(notes[i] + " Notes ---> " + calNotes);
            }
        }
    }
}
