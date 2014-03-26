using System;

namespace next
{
	public class Circle
	{
		public int x;
		public int y;
		public int r;

	}

	class CircleTest
	{
		static void Main(string[] args)
		{
			Circle c1, c2;
			string tempstr;

			c1 = new Circle();
			c2 = new Circle();

			Console.WriteLine("원충돌 테스트");
			Console.Write("circle1 X? ");
			tempstr = Console.ReadLine();
			c1.x = Convert.ToInt32(tempstr);

			Console.Write("circle1 Y? ");
			tempstr = Console.ReadLine();
			c1.y = Convert.ToInt32(tempstr);

			Console.Write("circle1 R? ");
			tempstr = Console.ReadLine();
			c1.r = Convert.ToInt32(tempstr);

			Console.Write("circle2 X? ");
			tempstr = Console.ReadLine();
			c2.x = Convert.ToInt32(tempstr);

			Console.Write("circle2 Y? ");
			tempstr = Console.ReadLine();
			c2.y = Convert.ToInt32(tempstr);

			Console.Write("circle2 R? ");
			tempstr = Console.ReadLine();
			c2.r = Convert.ToInt32(tempstr);

			double d =
				Math.Sqrt(Square(c1.x - c2.x) + Square(c1.y - c2.y));
			if (Abs(c1.r - c2.r) <= d && d <= (c1.r + c2.r))
				Console.WriteLine("두 원은충돌합니다.");
			else
				Console.WriteLine("두 원은 충돌하지 않습니다.");
		}
		static int Square(int n)
		{
			return n*n;
		}
		static int Abs(int n)
		{
			//int result;
			if (n >= 0)
				return n;
			else
				return -n;
		}
	}
}
