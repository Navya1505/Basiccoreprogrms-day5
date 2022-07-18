using System;

namespace binary2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter the number");
			Random random = new Random();
			int deci= random.Next();
			int[] binary = new int[40];
			int index = 0;
			int res = 0;
			while (deci > 0)
			{
				binary[index++] = deci % 2;
				deci = deci / 2;
			}
            Console.WriteLine("Binary is");
			for (int i = index - 1; i >= 0; i--)
			{
                Console.WriteLine(binary[i] + "\t");
			}
			int[] swap = swapNibbles(binary);
            Console.WriteLine("after swapping");
			for (int i = 0; i < swap.Length; i++)
                Console.WriteLine(swap[i] + "\t");
			for (int i = swap.Length - 1; i >= 0; i--)
		   res+= (swap[i] * Math.Pow(swap[i], i));
			isPower(res);
}
		public static void isPower(int res)
		{
			while (res != 1)
			{
				if (res % 2 != 0)
                    Console.WriteLine("not power of 2");
				res = res / 2;
			}
            Console.WriteLine("power of 2");
		}
		static int[] swapNibbles(int[] arr)
		{
			
			int temp, j = arr.Length - 4;
			for (int i = 0; i < 4; i++)
			{ 
				temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
				j++;
			}
			return arr;
		}
	}
}
