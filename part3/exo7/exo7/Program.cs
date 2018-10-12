using System;

namespace exo7
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string message = "On tient le bon bout.";
			for (int num = 1; num <= 100; num += 15)
			{
				Console.WriteLine(message);
			}
		}
	}
}
