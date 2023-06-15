using System;
namespace Test
{
	public static class Sorter
	{
		private static void SortClass(Human human)
		{
            switch (human)
            {
                case Persone:
                    ConsolePrint.PrintInfo($"       Person1{human}");
                    break;
                case Student:
                    ConsolePrint.PrintInfo($"       Student1{human}");
                    break;
                case Teacher:
                    ConsolePrint.PrintInfo($"       Teacher1{human}");
                    break;
                default:
                    human = null;
                        break;
            }
        }
        public static void SortClassInfo(Human human)
        {
            SortClass(human);
        }
	}
}

