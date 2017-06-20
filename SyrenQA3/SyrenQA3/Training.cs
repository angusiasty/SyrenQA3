using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyrenQA3
{
	public class Training
	{
		private List<int> mylist;
		private Random rnd = new Random();

		public List<int> FillMyList(int maxNumber)
		{
			mylist = new List<int> { rnd.Next(10, 20) };
			bool wasElementOnList;

			for (int currentNumber = 1; currentNumber <= maxNumber; currentNumber++)
			{
				wasElementOnList = false;
				foreach (int element in mylist)
				{
					if (currentNumber == element)
					{
						wasElementOnList = true;
						Console.WriteLine("{0} - this was random number", currentNumber);
						break;

					}
					continue;
				}
				if (!wasElementOnList)
				{
					mylist.Add(currentNumber);
					Console.WriteLine(currentNumber);
				}
			}

			return mylist;
		}
	}
}
