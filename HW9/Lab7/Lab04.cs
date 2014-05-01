using System;
using System.Linq;
using System.Collections.Generic;

class Shuffle
{
	static void Swap(List <int> list, int pos1, int pos2)
	{
		int temp = 0;
		temp = list.ElementAt(pos1);
		list.Insert(pos1,list.ElementAt(pos2));
		list.RemoveAt(pos1+1);
		list.RemoveAt(pos2);
		list.Insert(pos2,temp);
	}

	static void Main()
	{
		List <int> list = new List <int> ();
		Random r = new Random();

		for (int i = 1; i <= 10; i++)
			list.Add(i);

		for (int i = 0; i < list.Count-1; i++)
		{
			Swap(list, i, r.Next(i+1, list.Count));
		}

		foreach (int a in list)
			Console.Write("{0} ", a);

		Console.WriteLine();
	}
}
