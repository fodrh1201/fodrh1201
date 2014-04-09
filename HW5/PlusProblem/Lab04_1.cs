using System;

namespace Next
{
	public class Next
	{
		public static int[] ReadInts(string msg)
		{
			Console.Write("{0}", msg);

			int[] arr;
			string line = Console.ReadLine();
			string[] words = line.Split(' ');
			arr = new int[words.Length];

			for (int i = 0; i < words.Length; i++)
			{
				arr[i] = Convert.ToInt32(words[i]);
			}
			return arr;
		}
	}
	class Test
	{
		static void Main(string[] args)
		{
			int[] arr = Next.ReadInts("input test numbers : ");
			
			foreach (int i in arr)
			{
				Console.WriteLine(i);
			}
		}
	}
}


