using System;

namespace Next
{
	class Lab03
	{
		static void Main(string[] args)
		{
			Console.Write("배열의 크기를 입력하세요 : ");
			int size = Convert.ToInt32(Console.ReadLine());

			int[,] array = new int[size,size];

			for (int i = 0; i <= size - 1; i++)
			{
				for (int j = 0; j <= size - 1; j++)
				{
					Console.Write("{0}, {1}의 값을 입력하세요 : ", i + 1, j + 1);
					array[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}

			for (int k = 0; k <= size - 1; k++)
			{
				Console.Write("| ");
				for (int l = 0; l <= size - 1; l++)
				{
					Console.Write("{0} ", array[k, l]);
				}
				Console.WriteLine("|");
			}
		}
	}
}
