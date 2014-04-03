using System;

namespace Next
{
	class Ex04
	{
		static void Main(string[] args)
		{
			Console.Write("반복횟수를 입력하세요 : ");

			int count = Convert.ToInt32(Console.ReadLine());

			while (count <= 0)
			{
				Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
				Console.WriteLine();
				Console.Write("반복횟수를 입력하세요 : ");
				count = Convert.ToInt32(Console.ReadLine());
			}

			for (int i = 0; i < count; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();

			}
		}
	}
}

