using System;

class Way
{
	static void FindWay(int i, int j, int k, int[,] arr)
	{
		if (i == 4)
		{
			if (j == 5)
			{
				if (k == 30)
				{
					arr[i,j] = 30;
					ShowWay(arr);
				}
			}
			else  if (j == 0)
			{
				if (arr[i,j] == 0)
				{	
					int[,] arr01 = (int[,]) arr.Clone();
					arr01[i,j] = k;
					FindWay(i, j+1, k+1, arr01);
				}
			}
			else
			{
				if (arr[i,j] == 0)
				{
					int[,] arr02 = (int[,]) arr.Clone();
					int[,] arr03 = (int[,]) arr.Clone();
					arr02[i,j] = k;
					arr03[i,j] = k;
					FindWay(i, j+1, k+1, arr02);
					FindWay(i-1, j, k+1, arr03);
				}
			}
		}
		else if (i == 0)
		{
			if (j == 5)
			{
				if (arr[i,j] == 0)
				{
					int[,] arr04 = (int[,]) arr.Clone();
					arr04[i,j] = k;
					FindWay(i+1, j, k+1, arr04);
				}
			}
			else
			{
				if (arr[i,j] == 0)
				{
					int[,] arr05 = (int[,]) arr.Clone();
					int[,] arr06 = (int[,]) arr.Clone();
					arr05[i,j] = k;
					arr06[i,j] = k;
					FindWay(i+1, j, k+1, arr05);
					FindWay(i, j+1, k+1, arr06);
				}
			}
		}
		else if (j == 0)
		{
			if (arr[i,j] == 0)
			{
				int[,] arr07 = (int[,]) arr.Clone();
				int[,] arr08 = (int[,]) arr.Clone();
				arr07[i,j] = k;
				arr08[i,j] = k;
				FindWay(i+1, j, k+1, arr07);
				FindWay(i, j+1, k+1, arr08);
			}
		}
		else if (j == 5)
		{
			if (arr[i,j] == 0)
			{
				int[,] arr09 = (int[,]) arr.Clone();
				int[,] arr10 = (int[,]) arr.Clone();
				arr09[i,j] = k;
				arr10[i,j] = k;
				FindWay(i+1, j, k+1, arr09);
				FindWay(i, j-1, k+1, arr10);
			}
		}
		else
		{
			if (arr[i,j] == 0)
			{
				int[,] arr11 = (int[,]) arr.Clone();
				int[,] arr12 = (int[,]) arr.Clone();
				int[,] arr13 = (int[,]) arr.Clone();
				int[,] arr14 = (int[,]) arr.Clone();
				arr11[i,j] = k;
				arr12[i,j] = k;
				arr13[i,j] = k;
				arr14[i,j] = k;
				FindWay(i+1, j, k+1, arr11);
				FindWay(i-1, j, k+1, arr12);
				FindWay(i, j+1, k+1, arr13);
				FindWay(i, j-1, k+1, arr14);
			}
		}

	}	

	static void ShowWay(int[,] arr)
	{
		for (int k = 1; k <= 30; k++)
		{
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 6; j++)
				{
					if (k == arr[i,j])
					{
						if (k == 30)
							Console.Write("{0}", 6*i+j+1);
						else
						    Console.Write("{0}->", 6*i+j+1);
					}
				}
			}
		}
		Console.WriteLine();
	}
    
	static void Main()
	{
		int[,] mat = new int[5,6];
		

		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < 6; j++)
			{
				mat[i,j] = 0;
			}
		}
		

		FindWay(0, 0, 1, mat);
	}
}













