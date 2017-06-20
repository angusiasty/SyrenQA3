using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyrenQA3.Loops
{
	public class ForLoop
	{
		public static void ListPrimeNumbers(int checkUpTo)
		{
			int numberToCheck;
			int divisor;

			for (numberToCheck = 2; numberToCheck < checkUpTo; numberToCheck++)
			{
				for (divisor = 2; divisor <= Math.Sqrt(numberToCheck); divisor++)
				{
					if ((numberToCheck % divisor) == 0) break;
				}
				if (divisor > Math.Sqrt(numberToCheck))
				{
					Console.WriteLine($"{numberToCheck} is prime");
				}
			}
		}
	}
}
