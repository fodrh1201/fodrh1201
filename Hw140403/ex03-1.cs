using System;

namespace Next
{
	class Ex03_1
	{
		static void Main(string[] args)
		{
			int i = 0;

			while (i < 5)
			{
				int j = 0;
			
				while (j <= i)
				{
					Console.Write("*");
					j = j + 1;
				}
			
				Console.WriteLine();
			
				i = i + 1;
			}
		}
	}
}

