using System;
using System.Linq;
using System.Collections.Generic;

class Lab03
{
	static void Main()
	{
		List<int> list = new List<int> (new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
		
		Console.Write("바꿀 위치를 입력하세요 : ");
	 	string[] input = Console.ReadLine().Split(' ');
		int[] intInput = input.Select(x => int.Parse(x)).ToArray();

		int temp1 = 0;
		int temp2 = 0;

		temp1 = list.ElementAt(intInput[0]);
		temp2 = list.ElementAt(intInput[1]);
		list.RemoveAt(intInput[0]);
		list.Insert(intInput[0], temp2);
		list.RemoveAt(intInput[1]);
		list.Insert(intInput[1], temp1);


		foreach (int a in list)
			Console.Write("{0} ", a);

		Console.WriteLine();
	}
}


