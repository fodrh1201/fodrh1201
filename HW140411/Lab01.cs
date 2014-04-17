using System;

namespace Next
{
	class Lab01
	{
		static void Main(string[] args)
		{
			int[] Months = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			Console.Write("월과 일을 입력해 주세요 : ");
			string line = Console.ReadLine();
			string[] date = line.Split(' ');

			int days = 0;
			int remainder = 0;
			int temp = 0;

			int month = Convert.ToInt32(date[0]);
			int day = Convert.ToInt32(date[1]);

			for (int i = 1; i < month - 1; i++)
				days = days + Months[i];

			if (month == 1)
			{
				days = day - 1;
				remainder = days % 7;
			}
			else if (month == 2)
			{
				days = day + 30;
				remainder = days % 7;
			}
			else
			{
				temp = days;
				days = temp + 30 + day;
				remainder = days % 7;
			}

			if (remainder == 0)
				Console.WriteLine("Mon");
			else if (remainder == 1)
				Console.WriteLine("Tue");
			else if (remainder == 2)
				Console.WriteLine("Wed");
			else if (remainder == 3)
				Console.WriteLine("Thu");
			else if (remainder == 4)
				Console.WriteLine("Fri");
			else if (remainder == 5)
				Console.WriteLine("Sat");
			else
				Console.WriteLine("Sun");
		}
	}
}

