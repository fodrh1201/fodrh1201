using System;

namespace Next
{
	class Lab01
	{
		static void Main(string[] args)
		{
			Console.Write("숫자를 입력하세요 : ");

			int m = Convert.ToInt32(Console.ReadLine());
			m = m + 1;

			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < (m - i - 1); j++)
				{
					Console.Write(" ");
				}
				for (int k = 0; k < (2*i - 1); k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
