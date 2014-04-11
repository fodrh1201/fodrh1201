using System;

namespace Next
{
	class Lab02_1
	{
		static void Main(string[] args)
		{
			Console.Write("행을 입력하세요 : ");
			int row = Convert.ToInt32(Console.ReadLine());

			Console.Write("열을 입력하세요 : ");
			int column = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i <= (row - 1); i++)
			{
				for (int j = 0; j <= (column - 1); j++)
				{
					Console.Write("{0}{1} ", i, j);
				}
				Console.WriteLine();
			}
		}
	}
}
