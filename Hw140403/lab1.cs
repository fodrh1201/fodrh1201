using System;

namespace Lab01
{
	class next
	{
		static void Main(string[] args)

	{
		int i = -1;
		double sum = 0;
        double m = 0;
		
		while (m >= 0)
		{
			sum = sum + m;
			i = i + 1;
			string word = Console.ReadLine();
			m = Convert.ToInt32(word);
		}
		Console.WriteLine("avg : {0}", sum / i);
		Console.WriteLine("sum : {0}", sum);
		Console.WriteLine("count : {0}", i);
	}
}
}

