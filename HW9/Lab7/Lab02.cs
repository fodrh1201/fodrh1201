using System;
using System.Linq;
using System.Collections.Generic;

class Lab02
{
	static void Main()
	{
		Console.Write("리스트를 입력해주세요 : ");
		string input = Console.ReadLine();
		int[] intinput = input.Split(' ').Select( x => int.Parse(x) ).ToArray();

		List <int> list = new List <int> ();

		for (int i = 0; i < intinput.Length; i++)
		{
			list.Add(intinput[i]);
		}

		int num = 0;

		while (num != -999)
		{	
			Console.Write("숫자를 입력해 주세요 : ");
			num = Convert.ToInt32(Console.ReadLine());
	
			if (list.IndexOf(num) == -1)
			{
				foreach (int a in list)
					Console.Write("{0} ", a);
				Console.WriteLine();
			}
			else
			{
				list.Remove(num);
				foreach (int a in list)
					Console.Write("{0} ", a);
				Console.WriteLine();
			}
		}

		Console.WriteLine("종료!!");
	}
}
