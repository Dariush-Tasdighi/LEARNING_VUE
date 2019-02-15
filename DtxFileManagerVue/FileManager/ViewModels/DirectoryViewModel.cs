namespace Dtx.FileManager.ViewModels
{
	public class DirectoryViewModel : BaseViewModel
	{
		//public DirectoryViewModel() : base()
		//{
		//}

		public DirectoryViewModel(System.IO.DirectoryInfo directoryInfo) : base()
		{
			Name = directoryInfo.Name;

			CreationTime = directoryInfo.CreationTime;
			LastWriteTime = directoryInfo.LastWriteTime;
			LastAccessTime = directoryInfo.LastAccessTime;
		}
	}
}
