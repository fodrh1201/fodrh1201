using System;

namespace Next
{
	class Lab1
	{
		public static void Main(string[] args)
		{
			Console.Write("행과 열을 입력하세요 : ");
			
			string line = Console.ReadLine();
			string[] words = line.Split(' ');
			int row = Convert.ToInt32(words[0]);
			int column = Convert.ToInt32(words[1]);
			int[,] arr = new int[row,column];

			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					arr[i, j] = (i + 1)*(j + 1);
				    Console.Write("{0} ", arr[i, j]);
				}
				Console.WriteLine();
			}
		}
	}
}
