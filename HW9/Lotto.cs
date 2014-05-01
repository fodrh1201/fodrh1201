using System;
using System.Linq;
using System.Collections.Generic;

class Lotto
{
	static void Swap(List <int> list, int pos1, int pos2)
	{
		int temp = 0;
		temp = list.ElementAt(pos1);
		list.RemoveAt(pos1);
		list.Insert(pos1, list.ElementAt(pos2-1));
		list.RemoveAt(pos2);
		list.Insert(pos2, temp);
	}
	
	static void Main()
	{
		List <int> list = new List<int> ();
		Random r = new Random();

		for (int i = 1; i <= 45; i++)
		{
			list.Add(i);
		}

		for (int j = 0; j < 7; j++)
		{
			Swap(list, j, r.Next(j, list.Count));
		}

		Console.Write("당첨번호 : ");
		for (int k = 0; k < 6; k++)
			Console.Write("{0} ", list.ElementAt(k));

		Console.WriteLine();

		Console.WriteLine("보너스번호 : {0}", list.ElementAt(6));
	}
}
