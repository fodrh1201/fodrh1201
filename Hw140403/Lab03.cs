using System;

namespace Next
{
	class Lab03
	{
		static void Main(string[] args)
	{
		
        int number;

		Console.Write("숫자를 입력하세요. : ");
		number = Convert.ToInt32(Console.ReadLine());
		

		if (number < 10)
		{
			for (int i = 1; i <= 9; i++)
				Console.WriteLine("{0} X {1} = {2}", number, i, number*i);
		}
		else if (number <= 20)
		{
			for (int i = 1; i <= number; i++)
				Console.WriteLine("{0} X {1} = {2}", number, i, number*i);
		}
		else 
			Console.WriteLine("범위를 벗어났습니다.");
	}
}
}
