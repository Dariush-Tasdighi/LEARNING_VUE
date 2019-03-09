namespace ViewModels.General
{
	public class JsonResultViewModel : object
	{
		public JsonResultViewModel() : base()
		{
			ErrorMessages =
				new System.Collections.Generic.List<string>();

			HiddenMessages =
				new System.Collections.Generic.List<string>();

			InformationMessages =
				new System.Collections.Generic.List<string>();
		}

		// **********
		public bool IsSuccess { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<string> ErrorMessages { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<string> HiddenMessages { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<string> InformationMessages { get; set; }
		// **********

		protected string FixMessage(string message)
		{
			if (message == null)
			{
				return string.Empty;
			}

			message = message.Trim();

			if (message == string.Empty)
			{
				return string.Empty;
			}

			while (message.Contains("  "))
			{
				message =
					message.Replace("  ", " ");
			}

			return message;
		}

		public void AddErrorMessage(string message)
		{
			string result = FixMessage(message);

			if (result != string.Empty)
			{
				if (ErrorMessages.Contains(result) == false)
				{
					ErrorMessages.Add(message);
				}
			}
		}

		public void AddHiddenMessage(string message)
		{
			string result = FixMessage(message);

			if (result != string.Empty)
			{
				if (HiddenMessages.Contains(result) == false)
				{
					HiddenMessages.Add(message);
				}
			}
		}

		public void AddInformationMessage(string message)
		{
			string result = FixMessage(message);

			if (result != string.Empty)
			{
				if (InformationMessages.Contains(result) == false)
				{
					InformationMessages.Add(message);
				}
			}
		}

		public void ClearAllMessages()
		{
			ClearErrorMessages();
			ClearHiddenMessages();
			ClearInformationMessages();
		}

		public void ClearNotHiddenMessages()
		{
			ClearErrorMessages();
			ClearInformationMessages();
		}

		public void ClearErrorMessages()
		{
			ErrorMessages.Clear();
		}

		public void ClearHiddenMessages()
		{
			ErrorMessages.Clear();
		}

		public void ClearInformationMessages()
		{
			InformationMessages.Clear();
		}
	}
}
