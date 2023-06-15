using System;
namespace Test
{
	public static class ConsolePrint
	{	
		private static void Print(string message, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(message);
			Console.ResetColor();
		}
		public static void PrintInfo(string message)
		{
			Print(message, ConsoleColor.DarkRed);
		}
	}
}

