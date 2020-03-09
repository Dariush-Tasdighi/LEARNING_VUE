namespace Dtx.Text
{
	public static class Utility
	{
		static Utility()
		{
		}

		public static string Fix(string text)
		{
			if (string.IsNullOrWhiteSpace(text))
			{
				return string.Empty;
			}

			text = text.Trim();

			while (text.Contains("  "))
			{
				text = text.Replace("  ", " ");
			}

			return text;
		}
	}
}
