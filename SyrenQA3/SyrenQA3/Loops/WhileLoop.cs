using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyrenQA3.Loops
{
	public class WhileLoop
	{
		public static void CountTo(int numberToCountTo)
		{
			int currentNumber = 1;

			while (currentNumber <= numberToCountTo)
			{
				Console.WriteLine(currentNumber);
				currentNumber++;
			}
		}

		public static void PrintStringXTimes(string stringToPrint, int times)
		{
			int loop = 0;
			do
			{
				Console.WriteLine(stringToPrint);
				loop++;
			} while (loop > times);
		}
	}
}
