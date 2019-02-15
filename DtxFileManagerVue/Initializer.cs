namespace FileManager
{
	public class Initializer : object
	{
		public Initializer() : base()
		{
		}

		// **********
		protected virtual string AreaName
		{
			get
			{
				object areaName =
					System.Web.HttpContext.Current.Request.RequestContext.RouteData.DataTokens["area"];

				if (areaName == null)
				{
					return null;
				}
				else
				{
					return areaName.ToString();
				}
			}
		}
		// **********

		// **********
		protected virtual string ControllerName
		{
			get
			{
				object controllerName =
					System.Web.HttpContext.Current.Request.RequestContext.RouteData.Values["controller"];

				if (controllerName == null)
				{
					return null;
				}
				else
				{
					return controllerName.ToString();
				}
			}
		}
		// **********

		// **********
		public string Path
		{
			get
			{
				string result = string.Empty;

				if (string.IsNullOrWhiteSpace(AreaName) == false)
				{
					result =
						string.Format("/{0}", AreaName);
				}

				if (string.IsNullOrWhiteSpace(ControllerName) == false)
				{
					result =
						string.Format("{0}/{1}", result, ControllerName);
				}

				return result;
			}
		}
		// **********
	}
}
