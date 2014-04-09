using System;

namespace Next
{
	class Lab2
	{
		static void Main(string[] args)
		{
			Console.Write("숫자를 입력해 주세요 : ");
			int n = Convert.ToInt32(Console.ReadLine());


			for (int i = 0; i < n + 1; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("#");
				}
				for (int k = 0; k < n - i; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
			
