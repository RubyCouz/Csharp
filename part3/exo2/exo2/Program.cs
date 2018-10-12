using System;

namespace exo2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int firstNumber = 0;
			int secondNumber = 80;
			while (firstNumber < 20) {
				Console.WriteLine(firstNumber * secondNumber + ' ');
				                  firstNumber++;
			}
        }
    }
}
