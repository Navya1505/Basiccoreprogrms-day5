using System;

namespace tempconv
{
	class Program
	{
		static void Main(string[] args)
		{
			int choice;
			bool flag = true;
			float celsius, fahrenhite, result;
			Random random = new Random();
            Console.WriteLine("1.Celsius-Fahrenhite\n2.Fahrenhite -Celsius\n3.exit");
			choice = random.Next(0,3);
			switch (choice)
			{
				case 1:
					Console.WriteLine("Enter celsius");
				
					result = (celsius * 9 / 5) + 32;
					Console.WriteLine("Fahrenhite value " + result);
					break;
				case 2:
					Console.WriteLine("Enter fahrenhite");
					fahrenhite = random.Next();
					result = (fahrenhite - 32) * 5 / 9;
					Console.WriteLine("Celsius value " + result);
					break;
				default:
					flag = false;
                              Console.WriteLine("Enter valid choice");
							break;
						}
					}
			}
		}
	
