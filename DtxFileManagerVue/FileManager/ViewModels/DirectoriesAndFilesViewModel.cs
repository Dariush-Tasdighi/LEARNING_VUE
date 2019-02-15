namespace Dtx.FileManager.ViewModels
{
	public class DirectoriesAndFilesViewModel : object
	{
		public DirectoriesAndFilesViewModel() : base()
		{
		}

		// **********
		// **********
		// **********
		private System.Collections.Generic.IList<FileViewModel> files;
		// **********

		// **********
		public System.Collections.Generic.IList<FileViewModel> Files
		{
			get
			{
				if (files == null)
				{
					files =
						new System.Collections.Generic.List<FileViewModel>();
				}

				return files;
			}
		}
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		private System.Collections.Generic.IList<DirectoryViewModel> directories;
		// **********

		// **********
		public System.Collections.Generic.IList<DirectoryViewModel> Directories
		{
			get
			{
				if (directories == null)
				{
					directories =
						new System.Collections.Generic.List<DirectoryViewModel>();
				}

				return directories;
			}
		}
		// **********
		// **********
		// **********
	}
}
