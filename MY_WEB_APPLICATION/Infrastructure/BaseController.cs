namespace Infrastructure
{
	public class BaseController : System.Web.Mvc.Controller
	{
		public BaseController() : base()
		{
		}

		protected JsonNetResult JsonNet(object data)
		{
			var result =
				new JsonNetResult() { Data = data };

			return (result);
		}
	}
}
