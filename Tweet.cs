using System;

namespace TweetDemo
{
	class Tweet
	{
		private static int CURRENT_ID = 10000;
		public string From { get; }
		public string To { get; }
		public string Body { get; }
		public string Tag { get; }
		public string Id { get; }

		const int CharacterCountToShowInOneLine = 40;

		public Tweet(string from, string to, string body, string tag)
		{
			From = from;
			To = to;
			Body = body;
			Tag = tag;
			Id = CURRENT_ID++.ToString();
		}

		public Tweet(string from, string to, string body, string tag, string id)
		{
			From = from;
			To = to;
			Body = body;
			Tag = tag;
			Id = id;
		}

		public override string ToString()
		{
			string body = string.Empty;
			if (Body.Length > CharacterCountToShowInOneLine)
			{
				int numLines = (int)Math.Ceiling((double)Body.Length / CharacterCountToShowInOneLine);
				body += $"{Body.Substring(0, CharacterCountToShowInOneLine)}";
				for (int i = 1; i < numLines; ++i)
				{
					int lengthToSub = CharacterCountToShowInOneLine;
					if (Body.Length - i * CharacterCountToShowInOneLine < CharacterCountToShowInOneLine)
						lengthToSub = Body.Length - i * CharacterCountToShowInOneLine;
					body += $"\n{Body.Substring(i * CharacterCountToShowInOneLine, lengthToSub)}";
				}
			}
			else
				body = Body;

			return $"{From} => {To}\n{body}\n#{Tag}\n{{{Id}}}";
		}

		public static Tweet Parse(string line)
		{
			string from = string.Empty;
			string to = string.Empty;
			string body = string.Empty;
			string tag = string.Empty;
			string Id = string.Empty;

			var strings = line.Split('\t');
			if (strings.Length > 0)
				tag = strings[0];
			if (strings.Length > 1)
				from = strings[1];
			if (strings.Length > 2)
				to = strings[2];
			if (strings.Length > 3)
				body = strings[3];
			if (strings.Length > 4)
				Id = strings[4];
			return new Tweet(from, to, body, tag, Id);
		}
	}
}
