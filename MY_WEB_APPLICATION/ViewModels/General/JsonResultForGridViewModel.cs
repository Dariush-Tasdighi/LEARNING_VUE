namespace ViewModels.General
{
	public class JsonResultForGridViewModel<T> : JsonResultViewModel
	{
		public JsonResultForGridViewModel() : base()
		{
			ErrorMessages =
				new System.Collections.Generic.List<string>();

			InformationMessages =
				new System.Collections.Generic.List<string>();
		}

		// **********
		public int Count { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<T> Items { get; set; }
		// **********
	}
}
