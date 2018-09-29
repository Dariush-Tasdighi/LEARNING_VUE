namespace ViewModels.General
{
	public class InputGridViewModel : object
	{
		public InputGridViewModel() : base()
		{
		}

		// **********
		public int PageSize { get; set; }
		// **********

		// **********
		public int PageIndex { get; set; }
		// **********

		// **********
		public string sortFieldName { get; set; }
		// **********

		// **********
		public string sortDirection { get; set; }
		// **********

		// **********
		public int Skip
		{
			get
			{
				int result =
					PageIndex * PageSize;

				return result;
			}
		}
		// **********

		// **********
		public int Take
		{
			get
			{
				return PageSize;
			}
		}
		// **********
	}
}
