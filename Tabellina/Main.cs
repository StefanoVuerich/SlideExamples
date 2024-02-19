using System;

namespace Tabellina
{
	class MainClass
	{
		public static int[][] Make(int dim)
		{
			
			int[][] jagged = new int[dim][];
			for (int i = 0; i < dim; ++i)
			{
				jagged[i] = new int[i + 1];
			}
			return jagged;
			
		}
		
		public static int[][] Fill(int[][] jagged)
		{		
			for (int row = 0; row < jagged.GetLength(0); ++row)
			{
				for (int col = 0; col < jagged[row].GetLength(0); ++col)
				{
					jagged[row][col] = (row + 1) * (col + 1);
				}
			}
			return jagged;
		}
		
		public static void Print(int[][] jagged)
		{
			for (int row = 0; row < jagged.GetLength(0); ++row)
			{
				Console.WriteLine();
				for (int col = 0; col < jagged[row].GetLength(0); ++col)
				{
					Console.Write(" {0}", jagged[row][col]);
				}
					                  
			}
		}
		
		public static void Main (string[] args)
		{
			Print(Fill(Make(4)));
		}
	}
}

