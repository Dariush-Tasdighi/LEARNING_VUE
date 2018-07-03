namespace ViewModels.General
{
	public class JsonResultViewModel<T> : JsonResultViewModel
	{
		public JsonResultViewModel() : base()
		{
			ErrorMessages =
				new System.Collections.Generic.List<string>();

			InformationMessages =
				new System.Collections.Generic.List<string>();
		}

		// **********
		public T Data { get; set; }
		// **********
	}
}
