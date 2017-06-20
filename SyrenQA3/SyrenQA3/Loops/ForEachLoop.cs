using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyrenQA3.Loops
{
	public class ForEachLoop
	{
		public static void ListPrimeNumbers(int checkUpTo)
		{
			int numberToCheck;
			List<int> primeNumbers = new List<int> { 2 };

			Console.WriteLine("2 is prime");
			for (numberToCheck = 3; numberToCheck < checkUpTo; numberToCheck++)
			{
				foreach (var primeNumber in primeNumbers)
				{
					if ((numberToCheck % primeNumber) == 0) break;
					if (primeNumber > Math.Sqrt(numberToCheck))
					{
						Console.WriteLine($"{numberToCheck} is prime");
						primeNumbers.Add(numberToCheck);
						break;
					}
				}
			}
		}

		public void PrintArrayList(ArrayList List)
		{
			Console.WriteLine("ArrayList contains following elements:");
			foreach (var item in List)
			{
				Console.WriteLine($"#{List.IndexOf(item)}: {item}");
			}
		}
	}
}
