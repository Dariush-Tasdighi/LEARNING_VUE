namespace Dtx.FileManager.ViewModels
{
	public class PathAndDirectoriesAndFilesAndFileNameViewModel : DirectoriesAndFilesViewModel
	{
		public PathAndDirectoriesAndFilesAndFileNameViewModel() : base()
		{
		}

		// **********
		public string Path { get; set; }
		// **********

		// **********
		public string FileName { get; set; }
		// **********
	}
}
