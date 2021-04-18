using System;

namespace การบ้านครั้งที่4
{
	public class Program
	{
		static void printPascal(int n)
		{
			n++;
			for (int line = 0; line < n; line++)
			{
				for (int i = 0; i <= line; i++)
					Console.Write(binomialCoeff(line, i) + " ");
				Console.WriteLine();
			}
		}

		static int binomialCoeff(int n, int k)
		{
			int res = 1;
			if (k > n - k)
				k = n - k;
			for (int i = 0; i < k; ++i)
			{
				res *= (n - i);
				res /= (i + 1);
			}

			return res;
		}

		public static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			if (n < 0)
			{
				while (n < 0)
				{
					Console.WriteLine("Invalid Pascal's triangle row number.\n");
					n = Convert.ToInt32(Console.ReadLine());
				}
			}

			printPascal(n);
		}
	}
}