namespace Dtx.FileManager.ViewModels
{
	public class BaseViewModel : object
	{
		public BaseViewModel() : base()
		{
		}

		// **********
		public bool IsSelected { get; set; }
		// **********

		// **********
		public string Name { get; set; }
		// **********

		// **********
		public string Message { get; set; }
		// **********

		// **********
		// **********
		// **********
		[System.Web.Script.Serialization.ScriptIgnore]
		public System.DateTime CreationTime { get; set; }
		// **********

		// **********
		public string DisplayCreationTime
		{
			get
			{
				string result =
					CreationTime.ToString("yyyy/MM/dd - HH:mm:ss");

				return result;
			}
		}
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		[System.Web.Script.Serialization.ScriptIgnore]
		public System.DateTime LastWriteTime { get; set; }
		// **********

		// **********
		public string DisplayLastWriteTime
		{
			get
			{
				string result =
					LastWriteTime.ToString("yyyy/MM/dd - HH:mm:ss");

				return result;
			}
		}
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		[System.Web.Script.Serialization.ScriptIgnore]
		public System.DateTime LastAccessTime { get; set; }
		// **********

		// **********
		public string DisplayLastAccessTime
		{
			get
			{
				string result =
					LastAccessTime.ToString("yyyy/MM/dd - HH:mm:ss");

				return result;
			}
		}
		// **********
	}
}
