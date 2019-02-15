//namespace Dtx.FileManager
//{
//	public partial class BaseFileManagerController : System.Web.Mvc.Controller
//	{
//		public BaseFileManagerController() : base()
//		{
//		}

//		protected int SleepMillisecondsTimeout
//		{
//			get
//			{
//				return 1000;
//			}
//		}

//		protected virtual string PreDefinedRootRelativePath
//		{
//			get
//			{
//				return "~";
//			}
//		}

//		[System.Web.Mvc.HttpPost]
//		public virtual System.Web.Mvc.JsonResult UploadFile(string path)
//		{
//			System.Threading.Thread.Sleep(SleepMillisecondsTimeout);

//			FileManager.JsonData oJsonData =
//				FileManager.Utility.UploadFile(PreDefinedRootRelativePath, path);

//			return (oJsonData.GetJsonResult());
//		}

//		[System.Web.Mvc.HttpPost]
//		public virtual System.Web.Mvc.JsonResult DeleteDirectoriesAndFiles
//			(FileManager.ViewModels.PathAndDirectoriesAndFilesViewModel viewModel)
//		{
//			System.Threading.Thread.Sleep(SleepMillisecondsTimeout);

//			FileManager.JsonData oJsonData =
//				FileManager.Utility.DeleteDirectoriesAndFiles(PreDefinedRootRelativePath, viewModel);

//			return (oJsonData.GetJsonResult());
//		}

//		[System.Web.Mvc.HttpGet]
//		public virtual System.Web.Mvc.ActionResult Download(string path, string fileName)
//		{
//			System.Threading.Thread.Sleep(SleepMillisecondsTimeout);

//			FileManager.Utility.Download(PreDefinedRootRelativePath, path, fileName);

//			return (null);
//		}

//		[System.Web.Mvc.HttpPost]
//		public virtual System.Web.Mvc.JsonResult GetDirectoriesAndFiles(string path = "/")
//		{
//			System.Threading.Thread.Sleep(SleepMillisecondsTimeout);

//			FileManager.JsonData oJsonData =
//				FileManager.Utility.GetDirectoriesAndFiles(PreDefinedRootRelativePath, path);

//			return (oJsonData.GetJsonResult());
//		}

//		[System.Web.Mvc.HttpPost]
//		public virtual System.Web.Mvc.JsonResult Compress
//			(FileManager.ViewModels.PathAndDirectoriesAndFilesAndFileNameViewModel viewModel)
//		{
//			System.Threading.Thread.Sleep(SleepMillisecondsTimeout);

//			FileManager.JsonData oJsonData =
//				FileManager.Utility.Compress(PreDefinedRootRelativePath, viewModel);

//			return (oJsonData.GetJsonResult());
//		}

//		[System.Web.Mvc.HttpPost]
//		public virtual System.Web.Mvc.JsonResult Decompress
//			(FileManager.ViewModels.PathAndDirectoriesAndFilesViewModel viewModel)
//		{
//			System.Threading.Thread.Sleep(SleepMillisecondsTimeout);

//			FileManager.JsonData oJsonData =
//				FileManager.Utility.Decompress(PreDefinedRootRelativePath, viewModel);

//			return (oJsonData.GetJsonResult());
//		}

//		[System.Web.Mvc.HttpPost]
//		public virtual System.Web.Mvc.JsonResult CreateDirectory(string path, string directoryName)
//		{
//			System.Threading.Thread.Sleep(SleepMillisecondsTimeout);

//			FileManager.JsonData oJsonData =
//				FileManager.Utility.CreateDirectory(PreDefinedRootRelativePath, path, directoryName);

//			return (oJsonData.GetJsonResult());
//		}

//		[System.Web.Mvc.HttpPost]
//		public virtual System.Web.Mvc.JsonResult Rename(string path, string oldName, string newName)
//		{
//			System.Threading.Thread.Sleep(SleepMillisecondsTimeout);

//			FileManager.JsonData oJsonData =
//				FileManager.Utility.Rename(PreDefinedRootRelativePath, path, oldName, newName);

//			return (oJsonData.GetJsonResult());
//		}
//	}
//}
