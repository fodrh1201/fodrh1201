using System;

namespace next
{
	class Lab2
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			int x = r.Next(1,10);
            int m = 0;
			int i = 0;

			while (x != m)
			{
				Console.Write("숫자를 입력해주세요 : ");
				string word = Console.ReadLine();
				m = Convert.ToInt32(word);
				if (x > m)
				{
					Console.WriteLine("작다.");
					i = i + 1;
				}
				else if (x < m)
				{
					Console.WriteLine("크다.");
					i = i + 1;
				}
				else 
					break;
			}
			i = i + 1;
			Console.WriteLine("{0}번만에 맞았네!", i);
			Console.WriteLine(x);
		}
	}
}

			
