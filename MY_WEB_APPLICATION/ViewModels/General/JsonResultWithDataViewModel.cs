namespace ViewModels.General
{
	public class JsonResultViewModel<T> : JsonResultViewModel
	{
		public JsonResultViewModel() : base()
		{
		}

		// **********
		public T Data { get; set; }
		// **********
	}
}
