using System;

namespace Next
{
	class Ex02
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 5; i++)
			{
				for (int j = 0; j <= 5 - i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
