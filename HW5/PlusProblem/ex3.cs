using System;

namespace Next
{
	class ex3
	{
		public static void Doubleprint(int x)
		{
			int n = 2 * x;
			Console.WriteLine(n);
		}

		static void Main(string[] args)
		{
			int x = 10;
			int y = 20;
			Doubleprint(x);
			Doubleprint(y);
			Doubleprint(30);

			Console.WriteLine("Main x : {0}", x);
		}
	}
}
