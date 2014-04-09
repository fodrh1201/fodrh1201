using System;

public class Lab04
{
	public static int[] ReadInts(string msg)
	{
		int[] arr;


		Console.Write("{0}", msg);
		string r = Console.ReadLine();
		string[] words = r.Split(' ');
		arr = new int[words.Length];

		for (int i = 0; i < words.Length; i++)
		{
			arr[i] = Convert.ToInt32(words[i]);
		}

		return arr;
	}

	static void Main(string[] args)
	{
		int[] arr = ReadInts("Input test numbers : ");
		foreach (int i in arr)
			Console.WriteLine(i);
	}
}

