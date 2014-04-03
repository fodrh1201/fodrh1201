using System;

namespace Next
{
	class Ex03_4
	{
		static void Main(string[] args)
		{
			int i = 0;

			do
			{
				int j = 1;

				do
				{
					Console.Write("*");
					j = j + 1;
				}
				while (j <= 5 - i);

				Console.WriteLine();
				i = i + 1;
			}
			while (i < 5);
		}
	}
}

