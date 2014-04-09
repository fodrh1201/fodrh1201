using System;

namespace Next
{
	class lab3_2
	{
		static void Matrix(string[,] arr)
		{
			int sizeRow = arr.GetLength(0);
			int sizeColumn = arr.GetLength(1);

			for (int idxRow = 0; idxRow < sizeRow; idxRow++)
			{
				for (int idxColumn = 0; idxColumn < sizeColumn; idxColumn++)
				{
					Console.Write(arr[idxRow, idxColumn]);
				}
				Console.WriteLine();
			}
		}

		static void Main(string[] args)
		{
			int size = 0;

			while (size >= 0)
			{

			Console.Write("배열 크기를 입력해주세요 : ");
			string word = Console.ReadLine();
			size = Convert.ToInt32(word);
			string[,] arr = new string[size, size];

			if ((size % 2) == 0)
			{
				Console.WriteLine("배열을 다시 입력해주세요. 짝수에요!");
			}
			else
			{

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					arr[i, j] = "* ";
				}
			}

			Matrix(arr);

			int locRow = 0;
			int locCol = 0;

			while (locRow >= 0 && locCol >= 0)
			{
				Console.Write("지울 위치를 입력해 주세요 : ");
				string line = Console.ReadLine();
				string[] loc = line.Split(' ');

				locRow = Convert.ToInt32(loc[0]);
				locCol = Convert.ToInt32(loc[1]);

				if (locRow < 0 || locCol < 0)
				{
					break;
				}
				else 
				{
					for (int l = 0; l < size; l++)
					{
						for (int k = 0; k < size; k++)
						{
							if (locRow == l && locCol == k)
							{
								if (arr[l, k] == "  ")
								{
									Console.WriteLine("이미 지웠던 곳입니다!");
								}
								else 
								{
									arr[l, k] = "  ";
									arr[k, l] = "  ";
								}
							}
						}
					}
					Matrix(arr);
				}
			}
			break;
		}

	}
}
}
}
