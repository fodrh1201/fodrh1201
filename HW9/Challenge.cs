using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
	public static int total;
	public string name;
	public int id;
}

class MainApp 
{
	static void Swap(List <Student> list, int pos1, int pos2)
	{
		Student tempS = new Student();
		tempS = list.ElementAt(pos1);
		list.RemoveAt(pos1);
		list.Insert(pos1, list.ElementAt(pos2-1));
		list.RemoveAt(pos2);
		list.Insert(pos2, tempS);
	}

	static void Shuffle(List <Student> list, int n)
	{
		Random r = new Random();
		int rand = 0;

		for (int i = 0; i < n; i++)
		{
			rand = r.Next(i, list.Count);
			Swap(list, i, rand);
		}
	}

	static void Main()
	{
		string input = "";
		Student.total = 0;
		List <Student> list = new List <Student> ();

		while (true)
		{
			Console.Write("학생의 이름을 입력하세요(qqq : 종료) : ");
			input = Console.ReadLine();
			
			if (input == "qqq")
				break;

			Student s = new Student();
			s.name = input;
			list.Add(s);
			Student.total += 1;
		}
		Console.Write("몇 명 선택하시겠습니까? (1 - {0}) ", Student.total);
		int n = Convert.ToInt32(Console.ReadLine());

		Shuffle(list, n);
		
		for (int i = 0; i < n-1; i++)
		{
			Console.Write("{0}, ", list.ElementAt(i).name);
		}
		Console.WriteLine("{0} 님이 밥을 사세요. ", list.ElementAt(n-1).name);
	}
}

