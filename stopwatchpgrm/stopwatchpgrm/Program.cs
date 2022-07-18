using System;
using System.Linq;


namespace stopwatchpgrm
{

	class Program
	{
		static void Main(string[] args)
		{
		}
		public class StopWatch
		{
			public long startTimer = 0;
			public long stopTimer = 0;
			public long elapsed;

			public void findTime()
			{

				Random random = new Random();
				Console.WriteLine("Press 1 to start timer");
				int n1 = random.Next();
				if (n1 == 1)
					start();
				Console.WriteLine("Press '2' to Stop Time: ");
				int n2 = random.Next();
				if (n1 == 2)
					stop();
				elapsed = getElapsedTime();
				Console.WriteLine("Total Time Elapsed(in millisec) is:" + elapsed);
			}
			//to start timer
			public void start()
			{
				startTimer = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Start Time is: " + startTimer);
			}

			// to stop timer
			public void stop()
			{
				stopTimer = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Stop Time is: " + stopTimer);
			}

			public long getElapsedTime()
			{
				elapsed = stopTimer - startTimer;
                Console.WriteLine("elapsed");
				return elapsed;
			}
		}
	}

}
