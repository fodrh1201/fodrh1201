using System;

namespace Next
{
	class Lab02
	{
		static void Main(string[] args)
		{
			Random rand = new Random();
			int m = rand.Next(1,11);
			int n = 0;
			int i = 0;

			while(m != n)
			{
				Console.Write("숫자를 골라주세요.(1~10) : ");
				n = Convert.ToInt32(Console.ReadLine());
                
				if (m > n)
				{
					i = i + 1;
					Console.WriteLine("숫자가 너무 작아용.");
				}
			    else if (m < n)
				{
					i = i + 1;
					Console.WriteLine("숫자가 너무 커용.");
				}
				else 
				{
					i = i + 1;
					Console.WriteLine("정답!! {0}번만에 맞았네~~~ㅊㅋㅊㅋ", i);
				}
			}
			Console.WriteLine("babo");
		}
	}
}

