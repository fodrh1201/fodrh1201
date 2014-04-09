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
			int[,] array2 = new int[size,size];
			int[,] array3 = new int[size,size];

			for (int i = 0; i <= size - 1; i++)
			{   
				Console.Write("배열 1의 {0}행의 값을 입력하세요 : ", i + 1);
				string line = Console.ReadLine();
				string[] words = line.Split(' ');
				for (int j = 0; j <= size - 1; j++)
					array[i, j] = Convert.ToInt32(words[j]);
			}

			for (int k = 0; k <= size - 1; k++)
			{
				Console.Write("배열 2의 {0}행의 값을 입력하세요 : ", k + 1);
				string line2 = Console.ReadLine();
				string[] words2 = line2.Split(' ');
				for (int l = 0; l <= size - 1; l++)
					array2[k, l] = Convert.ToInt32(words2[l]);
			}

			for (int m = 0; m <= size - 1; m++)
			{
				Console.Write("| ");
				for (int n = 0; n <= size - 1; n++)
				{
					array3[m, n] = array[m, n] + array2[m, n];
					Console.Write("{0} ", array3[m, n]);
				}
				Console.Write("|");
				Console.WriteLine();
			}
		}
	}
}

                       
