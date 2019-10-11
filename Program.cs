// Group Information:
// Michael Magtibay 301029090
// Wook Song 301047817
// Thuan An Tran 300986225

using System;

namespace TweetDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			//TweetManager.Initialize();
			Console.WriteLine("=============================================");
			Console.WriteLine("Testing TweetManager.ShowAll()");
			Console.WriteLine("=============================================\n");
			TweetManager.ShowAll();
			Console.WriteLine("=============================================");
			Console.WriteLine("Testing TweetManager.ShowAll(\"weTHENortH\")");
			Console.WriteLine("=============================================\n");
			TweetManager.ShowAll("weTHENortH");
		}
	}
}
