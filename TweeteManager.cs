using System;
using System.Collections.Generic;
using System.IO;

namespace TweetDemo
{
	static class TweetManager
	{
		private static List<Tweet> TWEETS;
		private static string FILENAME;

		static TweetManager()
		{
			TWEETS = new List<Tweet>();
			FILENAME = "Assignment_02_TweetFile.txt";
			using (StreamReader reader = new StreamReader(FILENAME))
			{
				while (!reader.EndOfStream)
				{
					string line = reader.ReadLine();
					Tweet tweet = Tweet.Parse(line);
					if (tweet != null)
						TWEETS.Add(tweet);
				}
			}
		}

		public static void Initialize()
		{
			for (int i = 0; i < 5; ++i)
				TWEETS.Add(new Tweet($"From{i}", $"To{i}", $"Body{i}", $"Tag{i}"));
			for (int i = 0; i < 5; ++i)
				TWEETS.Add(new Tweet($"From{i}", $"To{i}", $"Body{i}", $"Tag{i}", $"Id{i}"));
		}

		public static void ShowAll()
		{
			foreach (var tweet in TWEETS)
			{
				Console.WriteLine(tweet);
				Console.WriteLine();
			}
		}

		public static void ShowAll(string tag)
		{
			foreach (var tweet in TWEETS)
			{
				if(tweet.Tag.ToLower() == tag.ToLower())
				{
					Console.WriteLine(tweet);
					Console.WriteLine();
				}
			}
		}
	}
}
