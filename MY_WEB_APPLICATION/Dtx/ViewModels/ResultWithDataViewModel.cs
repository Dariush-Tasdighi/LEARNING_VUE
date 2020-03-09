namespace Dtx.ViewModels
{
	public class ResultWithDataViewModel<T> : ResultViewModel
	{
		public ResultWithDataViewModel() : base()
		{
		}

		// **********
		public T Data { get; set; }
		// **********
	}
}
