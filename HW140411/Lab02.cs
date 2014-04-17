using System;

namespace Next
{
	class Lab02
	{
		static void PrintNum(int m, int n)
		{
			int[,] arr = new int[m, n]; 
			
			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					arr[i, j] = (m * j) + (i + 1);
					Console.Write("{0} ", arr[i, j]);
				}
				Console.WriteLine();
			}
		}

		static void Main(string[] args)
		{
			Console.Write("입 력 : ");
			string line = Console.ReadLine();
			string[] Nums = line.Split(' ');
			int m = Convert.ToInt32(Nums[0]);
			int n = Convert.ToInt32(Nums[1]);

			Console.WriteLine("출 력 : ");
			PrintNum(m, n);
		}
	}
}
			
			
