using System;

namespace Next
{
	class Lab04_foreach
	{
		static void Main(string[] args)
		{
			string line;

			Console.Write("초기값, 끝값, 스텝을 입력해주세요. : ");

			line = Console.ReadLine();

			string[] words = line.Split(' ');
			int[] array = new int[words.Length];
			int count = 0;

			foreach (int a in array)
			{
				a = Convert.ToInt32(words[count]);
				count = count + 1;
			}
		}
	}
}


