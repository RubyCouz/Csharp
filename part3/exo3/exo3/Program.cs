using System;

namespace exo3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int firstNumber = 100;
			int secondNumber = 60;
			while (firstNumber >= 10)
			{
				Console.WriteLine(firstNumber * secondNumber + ' ');
				firstNumber--;
			}
		}
	}
}
