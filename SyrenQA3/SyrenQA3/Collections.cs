using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyrenQA3
{
	public class Collections
	{
		public List<int> intList { get; set; } = new List<int>
		{
			1,
			2,
			3,
			4
		};

		Dictionary<string, int> dictionary = new Dictionary<string, int>
		{
			{ "Marek" , 5 },
			{ "Tomek", 3 },
			{ "Ala", 5 }
		};

		public ArrayList arrayList { get; set; }

		public void initArrayList()
		{
			arrayList = new ArrayList();
			arrayList.Add(1);
			arrayList.Add("hello");
			arrayList.Add(new List<bool> { true, false });
		}

		public int getValueOf(string key)
		{
			if (dictionary.ContainsKey(key))
			{
				int value = dictionary[key];
				Console.WriteLine(value);
				return value;
			}
			throw new ArgumentException("Key value not found", "key");
		}
	}
}
