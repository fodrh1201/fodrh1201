using System;

namespace next
{
	class MainApp
	{
		static void Main(string[] args)
		{
			
			Console.Write("숫자를 입력해주세요 : ");

			string word = Console.ReadLine();
			int m = Convert.ToInt32(word);

			
			for(int i = 1; i <= 9; i++)
			{
				Console.WriteLine("{0}X{1} = {2}", m, i, m*i);
			}
		}
	}
}
