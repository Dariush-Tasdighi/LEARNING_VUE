namespace Dtx.FileManager.ViewModels
{
	public class FileViewModel : BaseViewModel
	{
		//public FileViewModel() : base()
		//{
		//}

		public FileViewModel(System.IO.FileInfo fileInfo) : base()
		{
			Name = fileInfo.Name;
			Length = fileInfo.Length;

			CreationTime = fileInfo.CreationTime;
			LastWriteTime = fileInfo.LastWriteTime;
			LastAccessTime = fileInfo.LastAccessTime;
		}

		// **********
		public long Length { get; set; }
		// **********
	}
}
