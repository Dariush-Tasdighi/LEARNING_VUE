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
		/// <summary>
		/// Zero Based
		/// </summary>
		public int PageIndex { get; set; }
		// **********

		// **********
		public string SortFieldName { get; set; }
		// **********

		// **********
		public string SortDirection { get; set; }
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
