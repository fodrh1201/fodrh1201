using System;

namespace Next
{
	class Postfix
	{
		static string[] CalPostfix(string[] arr)
		{			
			string[] NextArr = new string[arr.Length - 2];
			int temp = 0;

			if (arr.Length < 2)
			{
				return arr;
			}
			else
			{
				switch (arr[2])
				{
					case "+":
						temp = Convert.ToInt32(arr[0]) + Convert.ToInt32(arr[1]);
						NextArr[0] = temp.ToString();

						for (int i = 1; i < arr.Length - 2; i++)
						{
							NextArr[i] = arr[i + 2];
						}
						return NextArr;
						

					case "-":
						temp = Convert.ToInt32(arr[0]) - Convert.ToInt32(arr[1]);
						NextArr[0] = temp.ToString();

						for (int i = 1; i < arr.Length - 2; i++)
						{
							NextArr[i] = arr[i + 2];
						}
						return NextArr;
						

					case "*":
						temp = Convert.ToInt32(arr[0]) * Convert.ToInt32(arr[1]);
						NextArr[0] = temp.ToString();

						for (int i = 1; i < arr.Length - 2; i++)
						{
							NextArr[i] = arr[i + 2];
						}
						return NextArr;

						
					case "/":
						temp = Convert.ToInt32(arr[0]) / Convert.ToInt32(arr[1]);
						NextArr[0] = temp.ToString();

						for (int i = 1; i < arr.Length - 2; i++)
						{
							NextArr[i] = arr[i + 2];
						}
						return NextArr;

					default:
						Console.WriteLine("에러!");
					    string[] error = new string[1] { "X" };
						return error;
				}
			}
		}



		static void Main(string[] args)
		{
			Console.Write("후위 식을 입력해 주세요 : ");
			string line = Console.ReadLine();
			string[] formula = line.Split(' ');


			while (formula.Length > 1)
			{
				formula = CalPostfix(formula);
			}

			Console.WriteLine(formula[0]);
		}
	}
}
		

















		
