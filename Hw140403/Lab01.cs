using System;

namespace Next
{
	class Lab01
	{
		static void Main(string[] args)
		{
			double sum = 0;
			double m = 0;
			int i = 0;

			while (m >= 0)
			{
				Console.Write("숫자를 입력하세요 : ");
				m = Convert.ToDouble(Console.ReadLine());
				if (m >= 0)
				{
				i = i + 1;
				sum = sum + m;
				}
			    else break;
			}
			Console.WriteLine("횟수 : {0}", i);
			Console.WriteLine("합계 : {0}", sum);
			Console.WriteLine("평균 : {0}", sum / i);
		}
	}
}
