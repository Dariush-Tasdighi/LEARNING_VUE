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

		public void AddErrorMessage(string message)
		{
			ErrorMessages.Add(message);
		}

		public void AddHiddenMessage(string message)
		{
			ErrorMessages.Add(message);
		}

		public void AddInformationMessage(string message)
		{
			InformationMessages.Add(message);
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
