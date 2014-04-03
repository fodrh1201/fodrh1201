using System;

namespace Next
{
	class Ex03_2
	{
		static void Main(string[] args)
		{
			int i = 0;

			while (i < 5)
			{
				int j = 1;

				while (j <= 5 - i)
				{
					Console.Write("*");
					j = j + 1;
				}
				i = i + 1;	
				Console.WriteLine();
			}
		}
	}
}
