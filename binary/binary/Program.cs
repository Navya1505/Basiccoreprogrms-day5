using System;

namespace binary
{
    class Program
    {
		static void Main(string[] args)
        {

			
			static int decimalToBinary(int N)
			{

				// To store the binary number
				int B_Number = 0;
				int cnt = 0;
				while (N != 0)
				{
					int rem = N % 2;
					int c = (int)Math.Pow(10, cnt);
					B_Number += rem * c;
					N /= 2;

					cnt++;
				}

				return B_Number;
			}

			static void Main()
			{
				int N = 17;
				Console.Write(decimalToBinary(N));
			}
		}
	}
		}

		

	


