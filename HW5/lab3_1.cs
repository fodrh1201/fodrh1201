using System;

namespace Next
{
	class lab3_1
	{
		static void Main(string[] args)
		{
			Console.Write("배열 크기를 입력해주세요 : ");
			
			int n = Convert.ToInt32(Console.ReadLine());
			string[,] arr = new string[n,n];

			int row = 0;
			int column = 0;

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					arr[i, j] = "* ";
					Console.Write(arr[i, j]);
				}
				Console.WriteLine();
			}

			while (row >= 0 && column >= 0)
			{
				Console.Write("지울 위치를 입력해주세요 : ");
				string line = Console.ReadLine();
				string[] words = line.Split(' ');

	 			row = Convert.ToInt32(words[0]);
				column = Convert.ToInt32(words[1]);

				for (int l = 0; l < n; l++)
				{
					for (int k = 0; k < n; k++)
					{
						if ((row == l && column == k) || (column == l && row == k))
						{
							if (arr[l, k] == "  ")
							{
								Console.WriteLine("이미 지웠던 곳입니다!");
							}
							else
							{
								arr[l, k] = "  ";
								Console.Write(arr[l, k]);
							}
						}
						else if (row < 0 || column < 0)
							{
								break;
							}
						else
						{
							Console.Write(arr[l, k]);
						}
					}
					Console.WriteLine();
				}
			}
		}
	}
}

