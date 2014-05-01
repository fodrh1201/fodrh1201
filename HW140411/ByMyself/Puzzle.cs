using System;

namespace Next
{
	class Puzzle
	{
		static void ShowSquareMatrix(int[,] arr, int n)
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("{0} ", arr[i, j]);
				}
				Console.WriteLine();
			}
		}

		static int[] SaveLocation(int[,] arr, int n)
		{
			int[] loc = new int[2];

			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (arr[i, j] == n)
					{
						loc[0] = i;
						loc[1] = j;
					}
				}
			}

			return loc;
		}

		static int[,] ChangeMatrix(int[,] arr, int row, int column)
		{
			int[] ZeroLoc = SaveLocation(arr, 0);
			int i = ZeroLoc[0];
			int j = ZeroLoc[1];

			if (row + 1 == i && column == j)
			{
				arr[i, j] = arr[i - 1, j];
				arr[i - 1, j] = 0;
			}
			else if (row - 1 == i && column == j)
			{
				arr[i, j] = arr[i + 1, j];
				arr[i + 1, j] = 0;
			}
			else if (row == i && column + 1 == j)
			{
				arr[i, j] = arr[i, j - 1];
				arr[i, j - 1] = 0;
			}
			else if (row == i && column - 1 == j)
			{
				arr[i, j] = arr[i, j + 1];
				arr[i, j + 1] = 0;
			}
			else
				Console.WriteLine("해당하는 숫자가 0이거나 옆에 0이 없습니다. 다시 골라주세요.");

			return arr;
		}
		

		static void Main(string[] args)
		{
			int[,] arr = new int[3, 3] { {1, 2, 3}, {4, 5, 6}, {7, 8, 0} };
			int n = 0;

			while (n >= 0)
			{
				Console.WriteLine("움직이고 싶은 숫자를 골라주세요 : ");
				ShowSquareMatrix(arr, 3);
				n = Convert.ToInt32(Console.ReadLine());

				if (n < 0)
				{
					Console.WriteLine("종료!!");
					break;
				}
				else if (n >= 9)
					Console.WriteLine("해당하는 숫자가 없습니다. 숫자를 다시 골라 주세요.");
				else
				{
					int[] NumLoc = SaveLocation(arr, n);
					int row = NumLoc[0];
					int col = NumLoc[1];
		        
					ChangeMatrix(arr, row, col);
				}


			}


		}
	}
}
			
		
	


