namespace Dtx.FileManager.ViewModels
{
	public class CreatedFileAndDirectoriesAndFilesViewModel : DirectoriesAndFilesViewModel
	{
		public CreatedFileAndDirectoriesAndFilesViewModel() : base()
		{
		}

		// **********
		public FileViewModel CreatedFile { get; set; }
		// **********
	}
}
