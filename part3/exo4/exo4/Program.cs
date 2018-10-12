using System;

namespace exo4
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			decimal number = 1;
			while (number <= 10)
			{
				Console.WriteLine(number);
				number = number += number / 2;
			}
		}
	}
}
