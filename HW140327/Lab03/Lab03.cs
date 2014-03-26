using System;

namespace next
{
	public class Student
	{
		public string name;
		public int kor;
		public int math;
		public double avg;
		}

	class Test
	{
		static void Main(string[] args)
		{
			Student s1 = new Student();
			s1.name = "Lim";
			s1.kor = 80;
			s1.math = 90;
			s1.avg = (s1.kor + s1.math)/2;

			Student s2 = new Student();
			s2.name = "Ko";
			s2.kor = 95;
			s2.math = 97;
			s2.avg = (s2.kor + s2.math)/2;

			double tavg;
			tavg = (s1.avg + s2.avg)/2;

			Console.WriteLine("{0}의 평균은 {1}입니다.", s1.name, s1.avg);
			Console.WriteLine("{0}의 평균은 {1}입니다.", s2.name, s2.avg);
			Console.WriteLine(s2.name + "와 " + s1.name + "의 전체평균은 {0}입니다.", tavg);
		}
	}
}

