using System;

namespace NEXT
{
	class Lab02
	{
		static void Main(string[] args)
		{
			Console.Write("이름? ");
			string x = Console.ReadLine();
			
			Console.Write("밑변? ");
			string y = Console.ReadLine();

			Console.Write("높이? ");
			string z = Console.ReadLine();

			int a = Convert.ToInt32(y);
			int b = Convert.ToInt32(z);

			Console.WriteLine(x + "의 넓이 = {0}", (a * b)/2);
		}
	}
}

