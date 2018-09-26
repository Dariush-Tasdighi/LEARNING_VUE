namespace ViewModels.General
{
	public class JsonResultForGridViewModel<T> : JsonResultViewModel
	{
		public JsonResultForGridViewModel() : base()
		{
		}

		// **********
		public int Count { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<T> Items { get; set; }
		// **********
	}
}
