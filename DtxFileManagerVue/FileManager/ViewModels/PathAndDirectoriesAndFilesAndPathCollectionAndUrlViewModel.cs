namespace Dtx.FileManager.ViewModels
{
	public class PathAndDirectoriesAndFilesAndPathCollectionAndUrlViewModel : DirectoriesAndFilesViewModel
	{
		public PathAndDirectoriesAndFilesAndPathCollectionAndUrlViewModel() : base()
		{
		}

		// **********
		public string Path { get; set; }
		// **********

		// **********
		[System.Web.Script.Serialization.ScriptIgnore]
		public string PreDefinedRootRelativePath { get; set; }
		// **********

		// **********
		public string Url
		{
			get
			{
				string url =
					System.Web.HttpContext.Current.Request.Url.Scheme +
					System.Uri.SchemeDelimiter +
					System.Web.HttpContext.Current.Request.Url.Host +
					(System.Web.HttpContext.Current.Request.Url.IsDefaultPort ? "" : ":" + System.Web.HttpContext.Current.Request.Url.Port)
					;

				if (PreDefinedRootRelativePath == "~")
				{
					url += Path;
				}
				else
				{
					url +=
						"/" +
						PreDefinedRootRelativePath.Substring(2) +
						Path
						;
				}

				return url;
			}
		}
		// **********

		// **********
		// **********
		// **********
		private System.Collections.Generic.IList<PathItemViewModel> pathCollection;
		// **********

		// **********
		public System.Collections.Generic.IList<PathItemViewModel> PathCollection
		{
			get
			{
				if (pathCollection == null)
				{
					pathCollection =
						new System.Collections.Generic.List<PathItemViewModel>();
				}

				return pathCollection;
			}
		}
		// **********
	}
}
