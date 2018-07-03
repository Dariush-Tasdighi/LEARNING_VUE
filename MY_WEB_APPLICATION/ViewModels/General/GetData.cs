namespace ViewModels.General
{
	public class GetData : object
	{
		public GetData() : base()
		{
		}

		// **********
		public int PageSize { get; set; }
		// **********

		// **********
		public int PageIndex { get; set; }
		// **********

		// **********
		public int Skip
		{
			get
			{
				int result =
					PageIndex * PageSize;

				return (result);
			}
		}
		// **********

		// **********
		public int Take
		{
			get
			{
				return (PageSize);
			}
		}
		// **********
	}
}
