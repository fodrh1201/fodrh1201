using System;

public class NumPuzzle
{
	public string name;
	private int[,] mData;
	private int mSize;
	private int xZero, yZero;

	public void Init(int size)
	{
		mSize = size;
		mData = new int[size,size];
		for (int i = 0; i < size; i++)
			for (int j = 0; j < size; j++)
				mData[i,j] = i * size + j + 1;
		mData[size-1,size-1] = 0;
		xZero = yZero = size - 1;
	}

	public string FindMove()
	{
		ZeroLocation();
		string ret = "";
		for (int i = 0; i < mSize; i++)
		{
			for (int j = 0; j < mSize; j++)
			{
				if ((Math.Abs(i - xZero) == 1 && (j - yZero == 0)) ||
						((i - xZero == 0) && (Math.Abs(j - yZero) == 1)))
				{
					ret = ret + Convert.ToString(mData[i,j]) + " ";
				}
			}
		}
		return ret;
	}

	public bool Move(int num)
	{
		int row = 0;
		int	col = 0;
	
		for (int i = 0; i < mSize; i++)
			for (int j = 0; j < mSize; j++)
			{
				if (mData[i,j] == num)
				{
					row = i;
					col = j;
				}
			}

		if (IsMove(row, col))
		{
			Swap(ref mData[row,col], ref mData[xZero,yZero]);
			return true;
		}
		else
			return false;
	}
		

	public void ZeroLocation()
	{
		for (int i = 0; i < mSize; i++)
		{
			for (int j = 0; j < mSize; j++)
			{
				if (mData[i,j] == 0)
				{
					xZero = i;
					yZero = j;
					return;
				}
			}
		}
	}

	private bool IsMove(int row, int col)
	{
		ZeroLocation();
		if (!IsValid(row, col))
			return false;
		 
		if ((Math.Abs(row - xZero) == 1 && (col - yZero == 0)) ||
				((row - xZero == 0) && (Math.Abs(col - yZero) == 1)))
		{
			return true;
		}
		else
			return false;

	}

	private bool IsValid(int row, int col)
	{
		return ( 0 <= row && 0 <= col && row < mSize && col < mSize);
	}

	private void Swap(ref int a, ref int b)
	{
		int temp = 0;
		temp = a;
		a = b;
		b = temp;
	}

	public void PrintData()
	{
		for (int i = 0; i < mSize; i++)
		{
			for (int j = 0; j < mSize; j++)
			{
				if (mData[i,j] / 10 == 0)
				{
					Console.Write(" {0} ", mData[i,j]);
				}
				else
					Console.Write("{0} ", mData[i,j]);
			}
			Console.WriteLine();
		}
	}
					



}

class test
{
	static void Main(string[] args)
	{
		NumPuzzle np = new NumPuzzle();
		Console.Write("크기를 입력해 주세요: ");
		int size = Convert.ToInt32(Console.ReadLine());
		np.Init(size);

		while (true)
		{
			np.PrintData();
			Console.Write("어떤것을 움직이고 싶으세요? {0}(움직일 수 없는 수를 입력하면 종료됩니다.) : ", np.FindMove());
			int num = Convert.ToInt32(Console.ReadLine());
			
			if (!np.Move(num))
				break;
		}
		Console.WriteLine("종료!!");
	}

	static void Fail(string msg)
	{
		Console.WriteLine(msg);
		Environment.Exit(1);
	}

}

