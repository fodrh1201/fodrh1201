using System;

namespace Next
{
	class Lab04
	{
		static void Main(string[] args)
		{
			string line;

			Console.Write("초기값, 끝값, 스텝을 입력하세용. : ");
			line = Console.ReadLine();
			string[] words = line.Split(' ');
			int[] array = new int[words.Length];
			int sum = 0;

			Console.Write("숫자 :");

			for (int i = 0; i < words.Length; i++)
				array[i] = Convert.ToInt32(words[i]);

			
			for (int init = array[0]; init < array[1]; init = init + array[2])
			{
				sum = sum + init;
				
				Console.Write(" {0}", init);
			}

			Console.WriteLine(" ");
			Console.WriteLine("합계 : {0}", sum);
		}

	}
}

