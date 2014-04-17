using System;

	public class NumPuzzle
 	{
		public string name;
		private int[,] mData;
		private int mSize;

		public void Init(int size)
		{
			mSize = size;
			mData = new int[mSize,mSize];
			for (int i = 0; i < mSize; i++)
			{
				for (int j = 0; j < mSize; j++)
				{
					mData[i, j] = (mSize * i) + (j + 1);
				//	mData[mSize - 1, mSize - 1] = 0;
				}
			}
		}

		public string FindMove()
		{
			//code here
			string ret = "";
			return ret;
		}

		private bool isMove(int row, int col)
		{
			int[] coor = new int[2];
			for (int i = 0; i < mSize; i++)
			{
				for (int j = 0; j < mSize; j++)
				{
					if (mData[i,j] == 0)
					{
						coor[0] = i;
						coor[1] = j;
					}
				}
			}
			if (Math.Abs(row - coor[0]) == 1 && Math.Abs(col - coor[1]) == 1)
				return true;
			else
				return false;
		}
					
	}

	class Test
	{
		static void Fail(string msg)
		{
			Console.WriteLine(msg);
			Environment.Exit(1);
		}

		static void Main()
		{
			NumPuzzle np = new NumPuzzle();

			np.Init(3); // 1 2 3 4 5 6 7 8 0
			
			
			//Test1

			string av = np.FindMove();
			if (av != "6 8")
			{
				Console.WriteLine("Test1 Fail!!");
				Environment.Exit(1);
			}

			Console.WriteLine("Test1 Success!");
		}
	}



