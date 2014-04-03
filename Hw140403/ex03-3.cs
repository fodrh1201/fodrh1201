using System;

namespace Next
{
	class Ex03_3
	{
		static void Main(string[] args)
		{
			int i = 0;

			do
			{
				int j = 0;
				do
				{
					Console.Write("*");
				    j = j + 1;
				}
				while (j <= i);

				Console.WriteLine();
				i = i + 1;
			}
			while (i < 5);
		}
	}
}
