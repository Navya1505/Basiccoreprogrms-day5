using System;

namespace Coupon
{
	class Program
	{
		public static void main(string[] args)
		{


			 static int getCoupon(int n)
			{
				return (int)(Math.random() * n);
			}

		     static void collected()
			{
				int n;
				Random random = new Random();
				Console.WriteLine("Enter n");
				n = random.Next();

				bool[] isCollected = new bool[n];
				int count = 0;
				int distinct = 0;
				while (distinct < n)
				{
					int value = getCoupon(n);
					count++;
					if (!isCollected[value])
					{
						distinct++;
						isCollected[value] = true;
					}
				}
				Console.WriteLine("Count is " + count);

			}
		}
	}

}