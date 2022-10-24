using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_While01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q1
			int N = 1;
			int sum = 1;

			while (sum + N + 1 < 105)
			{
				N++;
				sum += N;
			}
			Console.WriteLine(N);


			//Q2
			int i = 1;
			while (i <= 300)
			{
				if (300 % i == 0)
				{
					Console.WriteLine(i);
				}
				i++;
			}	
		}
	}
}
