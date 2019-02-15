using System.Linq;

namespace FileManager
{
	public class ViewEngine : System.Web.Mvc.RazorViewEngine
	{
		public ViewEngine() : base()
		{
			string[] strNewPartialViewLocationFormats = { "~/Views/Shared/PartialViews/FileManager/{0}.cshtml" };

			PartialViewLocationFormats =
				PartialViewLocationFormats.Union(strNewPartialViewLocationFormats).ToArray();
		}
	}
}

//protected void Application_Start()
//{
//	System.Web.Mvc.AreaRegistration.RegisterAllAreas();

//	RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);

//	System.Web.Mvc.ViewEngines.Engines.Add(new FileManager.ViewEngine());
//}
