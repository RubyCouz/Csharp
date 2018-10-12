using System;

namespace exo8
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string message = "Enfin !!";
			for (int num = 200; num >= 0; num -= 12)
			{
				Console.WriteLine(message);
			}
		}
	}
}

