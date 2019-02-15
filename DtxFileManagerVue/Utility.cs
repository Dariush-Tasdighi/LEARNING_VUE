namespace Dtx.FileManager
{
	public static class Utility
	{
		static Utility()
		{
		}

		public const string VERSION = "3.0.0";

		internal static string FixPath(string path)
		{
			if (path == null)
			{
				path = "/";
			}

			path = path.Trim();

			if (path == string.Empty)
			{
				path = "/";
			}

			while (path.Contains("//"))
			{
				path =
					path.Replace("//", "/");
			}

			if (path != "/")
			{
				if (path.EndsWith("/") == false)
				{
					path =
						string.Format("{0}/", path);
				}

				if (path.StartsWith("/") == false)
				{
					path =
						string.Format("/{0}", path);
				}
			}

			return path;
		}

		/// <summary>
		/// Add the tag (<identity impersonate="true"/>) in your web.config file.
		/// </summary>
		internal static void SetFullControlForEveryOne(string path)
		{
			try
			{
				System.Security.AccessControl.DirectorySecurity
					directorySecurity = System.IO.Directory.GetAccessControl(path);

				// Using this instead of the "Everyone"
				// string means we work on non-English systems.
				System.Security.Principal.SecurityIdentifier everyone =
					new System.Security.Principal.SecurityIdentifier
						(System.Security.Principal.WellKnownSidType.WorldSid, null);

				System.Security.AccessControl.FileSystemAccessRule fileSystemAccessRule =
					new System.Security.AccessControl.FileSystemAccessRule
						(identity: everyone,
						fileSystemRights: System.Security.AccessControl.FileSystemRights.FullControl |
						System.Security.AccessControl.FileSystemRights.Synchronize,
						inheritanceFlags: System.Security.AccessControl.InheritanceFlags.ContainerInherit |
						System.Security.AccessControl.InheritanceFlags.ObjectInherit,
						propagationFlags: System.Security.AccessControl.PropagationFlags.None,
						type: System.Security.AccessControl.AccessControlType.Allow);

				directorySecurity.AddAccessRule(fileSystemAccessRule);

				System.IO.Directory.SetAccessControl
					(path: path, directorySecurity: directorySecurity);
			}
			catch (System.Exception ex)
			{
				string errorMessage = ex.Message;
			}
		}

		private static void InitializeZipFile(Ionic.Zip.ZipFile zipFile)
		{
			zipFile.AlternateEncoding = zipFile.AlternateEncoding;
			zipFile.AlternateEncodingUsage = Ionic.Zip.ZipOption.Default; // Default: [Default]

			zipFile.Strategy = Ionic.Zlib.CompressionStrategy.Default; // Default: [Default]
			zipFile.UseZip64WhenSaving = Ionic.Zip.Zip64Option.Default; // Default: [Default]
			zipFile.CompressionMethod = Ionic.Zip.CompressionMethod.Deflate; // Default: [Deflate]
			zipFile.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression; // Default: [Default]

			zipFile.CodecBufferSize = 0; // Default: [0]
			zipFile.BufferSize = 32768; // Default: [32768]
			zipFile.MaxOutputSegmentSize = 0; // Default: [0]
			zipFile.ParallelDeflateMaxBufferPairs = 16; // Default: [16]
			zipFile.ParallelDeflateThreshold = 524288; // Default: [524288]

			zipFile.Comment = null; // Default: [null]
			zipFile.FullScan = false; // Default: [false]
			zipFile.TempFileFolder = null; // Default: [null]
			zipFile.CaseSensitiveRetrieval = false; // Default: [false]
			zipFile.FlattenFoldersOnExtract = false; // Default: [false]
			zipFile.SortEntriesBeforeSaving = false; // Default: [false]

			zipFile.EmitTimesInUnixFormatWhenSaving = false; // Default: [false]
			zipFile.EmitTimesInWindowsFormatWhenSaving = true; // Default: [true]

			zipFile.Password = null; // Default: [null]
			zipFile.Encryption = Ionic.Zip.EncryptionAlgorithm.None; // Default: [None]

			zipFile.ZipErrorAction = Ionic.Zip.ZipErrorAction.Skip; // Default: [Throw]
			zipFile.ExtractExistingFile = Ionic.Zip.ExtractExistingFileAction.OverwriteSilently; // Default: [Throw]
		}

		public static JsonData UploadFile(string preDefinedRootRelativePath, string path)
		{
			JsonData jsonData = null;

			var varFiles =
				System.Web.HttpContext.Current.Request.Files;

			// **************************************************
			if (varFiles.Count == 0)
			{
				string strErrorMessage =
					"You did not specify file for uploading!";

				jsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return jsonData;
			}
			// **************************************************

			// **************************************************
			var varFile = varFiles[0];

			if (string.IsNullOrWhiteSpace(varFile.FileName))
			{
				string strErrorMessage =
					"You did not specify file for uploading!";

				jsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return jsonData;
			}
			// **************************************************

			// **************************************************
			if (varFile.ContentLength == 0)
			{
				string strErrorMessage =
					"The file does not uploaded successfully!";

				jsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return jsonData;
			}
			// **************************************************

			// **************************************************
			path = FixPath(path);

			string strFileName =
				System.IO.Path.GetFileName(varFile.FileName);

			string strPreDefinedRootRelativePath =
				FixPreDefinedRootRelativePath(preDefinedRootRelativePath);

			string strRootRelativePath =
				string.Format("{0}{1}",
				strPreDefinedRootRelativePath, path);

			string strPath =
				System.Web.HttpContext.Current.Server.MapPath(strRootRelativePath);

			string strRootRelativePathName =
				string.Format("{0}{1}",
				strRootRelativePath, strFileName);

			string strPathName =
				System.Web.HttpContext.Current.Server.MapPath(strRootRelativePathName);
			// **************************************************

			// **************************************************
			if (System.IO.File.Exists(strPathName))
			{
				string strErrorMessage =
					"There is a file with this name!";

				jsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return jsonData;
			}
			// **************************************************

			// **************************************************
			if (System.IO.Directory.Exists(strPathName))
			{
				string strErrorMessage =
					"There is a directory with this name!";

				jsonData =
					new JsonData()
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return (jsonData);
			}
			// **************************************************

			// **************************************************
			try
			{
				varFile.SaveAs(strPathName);

				System.IO.FileInfo fileInfo =
					new System.IO.FileInfo(strPathName);

				ViewModels.FileViewModel fileViewModel = new ViewModels.FileViewModel(fileInfo);

				string strInformationMessage =
					string.Format("The file [{0}] uploaded successfully.", strFileName);

				jsonData =
					new JsonData
					{
						Data = fileViewModel,
						MessageText = strInformationMessage,
						State = ViewModels.JsonResultStates.Success,
					};

				return (jsonData);
			}
			catch (System.Exception ex)
			{
				string strErrorMessage = ex.Message;

				jsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return jsonData;
			}
			// **************************************************
		}

		public static JsonData GetDirectoriesAndFiles(string preDefinedRootRelativePath, string path)
		{
			JsonData jsonData = null;

			path = FixPath(path);

			preDefinedRootRelativePath =
				FixPreDefinedRootRelativePath(preDefinedRootRelativePath);

			string strRootRelativePath =
				string.Format("{0}{1}",
				preDefinedRootRelativePath, path);

			string strPath =
				System.Web.HttpContext.Current.Server.MapPath(strRootRelativePath);

			// **************************************************
			while (strPath.Contains("\\\\"))
			{
				strPath =
					strPath.Replace("\\\\", "\\");
			}

			string strRootPath =
				System.Web.HttpContext.Current.Server.MapPath("~");

			// Note: Never Write Below Code!
			//strRootPath =
			//	strRootPath.Substring(0, strRootPath.Length - 1);

			string[] strParts =
				strPath.Split('\\');

			string strTempPath = strParts[0];

			for (int intIndex = 1; intIndex <= strParts.Length - 1; intIndex++)
			{
				if (strParts[intIndex] == string.Empty)
				{
					break;
				}

				if (strTempPath.StartsWith(strRootPath, System.StringComparison.InvariantCultureIgnoreCase))
				{
					SetFullControlForEveryOne(path: strTempPath);
				}

				strTempPath += "\\" + strParts[intIndex];

				if (System.IO.Directory.Exists(strTempPath) == false)
				{
					System.IO.Directory.CreateDirectory(strTempPath);
				}
			}
			// **************************************************

			// **************************************************
			ViewModels.PathAndDirectoriesAndFilesAndPathCollectionAndUrlViewModel oReturnViewModel =
				new ViewModels.PathAndDirectoriesAndFilesAndPathCollectionAndUrlViewModel
				{
					Path = path,
					PreDefinedRootRelativePath = preDefinedRootRelativePath,
				};
			// **************************************************

			// **************************************************
			ViewModels.PathItemViewModel pathItemViewModel = null;

			string[] pathCollection = path.Split('/');

			string fullPath = string.Empty;

			for (int index = 0; index <= pathCollection.Length - 2; index++)
			{
				string strCurrentPath =
					pathCollection[index];

				fullPath =
					string.Format("{0}{1}/",
					fullPath, strCurrentPath);

				if (strCurrentPath == string.Empty)
				{
					// TODO
					//strCurrentPath =
					//	Resources.Captions.Root;
				}

				pathItemViewModel =
					new ViewModels.PathItemViewModel
					{
						Path = fullPath,
						Name = strCurrentPath,
					};

				oReturnViewModel.PathCollection.Add(pathItemViewModel);
			}
			// **************************************************

			System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(strPath);

			foreach (System.IO.DirectoryInfo currentDirectoryInfo in directoryInfo.GetDirectories())
			{
				ViewModels.DirectoryViewModel directoryViewModel =
					new ViewModels.DirectoryViewModel(currentDirectoryInfo);

				oReturnViewModel.Directories.Add(directoryViewModel);
			}

			foreach (System.IO.FileInfo currentFileInfo in directoryInfo.GetFiles())
			{
				ViewModels.FileViewModel fileViewModel =
					new ViewModels.FileViewModel(currentFileInfo);

				oReturnViewModel.Files.Add(fileViewModel);
			}

			jsonData =
				new JsonData
				{
					Data = oReturnViewModel,
					State = ViewModels.JsonResultStates.Success,
				};

			return jsonData;
		}

		public static void Download
			(string preDefinedRootRelativePath, string path, string fileName)
		{
			// **************************************************
			path = FixPath(path);

			preDefinedRootRelativePath =
				FixPreDefinedRootRelativePath(preDefinedRootRelativePath);

			string rootRelativePathName =
				string.Format("{0}{1}{2}",
				preDefinedRootRelativePath, path, fileName);

			string pathName =
				System.Web.HttpContext.Current.Server.MapPath(rootRelativePathName);

			if (System.IO.File.Exists(pathName) == false)
			{
				return;
			}
			// **************************************************

			System.IO.Stream stream = null;

			try
			{
				// Open the file
				stream =
					new System.IO.FileStream
						(path: pathName,
						mode: System.IO.FileMode.Open,
						share: System.IO.FileShare.Read,
						access: System.IO.FileAccess.Read);

				// **************************************************
				System.Web.HttpContext.Current.Response.Buffer = false;

				// Setting the unknown [ContentType]
				// will display the saving dialog for the user
				System.Web.HttpContext.Current.Response.ContentType = "application/octet-stream";

				// With setting the file name,
				// in the saving dialog, user will see
				// the [strFileName] name instead of [download]!
				System.Web.HttpContext.Current.Response
					.AddHeader("Content-Disposition", "attachment; filename=" + fileName);

				long lngFileLength = stream.Length;

				// Notify user (client) the total file length
				System.Web.HttpContext.Current.Response
					.AddHeader("Content-Length", lngFileLength.ToString());
				// **************************************************

				// Total bytes that should be read
				long lngDataToRead = lngFileLength;

				if (lngDataToRead == 0)
				{
					System.Web.HttpContext.Current.Response.Flush();

					return;
				}

				// Read the bytes of file
				while (lngDataToRead > 0)
				{
					// The below code is just for testing! So we commented it!
					//System.Threading.Thread.Sleep(1000);

					// Verify that the client is connected or not?
					if (System.Web.HttpContext.Current.Response.IsClientConnected)
					{
						// 8KB
						int intBufferSize = 8 * 1024;

						// Create buffer for reading [intBufferSize] bytes from file
						byte[] bytBuffers =
							new System.Byte[intBufferSize];

						// Read the data and put it in the buffer.
						int intTheBytesThatReallyHasBeenReadFromTheStream =
							stream.Read(buffer: bytBuffers, offset: 0, count: intBufferSize);

						// Write the data from buffer to the current output stream.
						System.Web.HttpContext.Current.Response.OutputStream.Write
							(buffer: bytBuffers, offset: 0,
							count: intTheBytesThatReallyHasBeenReadFromTheStream);

						// Flush (Send) the data to output
						// (Don't buffer in server's RAM!)
						System.Web.HttpContext.Current.Response.Flush();

						lngDataToRead =
							lngDataToRead - intTheBytesThatReallyHasBeenReadFromTheStream;
					}
					else
					{
						// Prevent infinite loop if user disconnected!
						lngDataToRead = -1;
					}
				}
			}
			catch
			{
			}
			finally
			{
				if (stream != null)
				{
					//Close the file.
					stream.Close();
					stream.Dispose();
					stream = null;
				}

				System.Web.HttpContext.Current.Response.Close();
			}
		}

		public static JsonData Compress
			(string preDefinedRootRelativePath,
			ViewModels.PathAndDirectoriesAndFilesAndFileNameViewModel viewModel)
		{
			JsonData jsonData = null;

			// **************************************************
			if (string.IsNullOrWhiteSpace(viewModel.FileName))
			{
				string errorMessage =
					"You did not specify file name!";

				jsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = errorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return jsonData;
			}

			viewModel.FileName = viewModel.FileName.Trim();
			// **************************************************

			viewModel.Path =
				FixPath(viewModel.Path);

			string strPreDefinedRootRelativePath =
				FixPreDefinedRootRelativePath(preDefinedRootRelativePath);

			string strRootRelativePath =
				string.Format("{0}{1}",
				strPreDefinedRootRelativePath, viewModel.Path);

			string strPath =
				System.Web.HttpContext.Current.Server.MapPath(strRootRelativePath);

			string strRootRelativeCompressPath =
				string.Format("{0}{1}",
				strRootRelativePath, viewModel.FileName);

			string strCompressPathName =
				System.Web.HttpContext.Current.Server.MapPath(strRootRelativeCompressPath);

			if (System.IO.File.Exists(strCompressPathName))
			{
				string strErrorMessage =
					"There is a file with this name!";

				jsonData =
					new JsonData()
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return jsonData;
			}

			if (System.IO.Directory.Exists(strCompressPathName))
			{
				string strErrorMessage =
					"There is a directory with this name!";

				jsonData =
					new JsonData()
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return jsonData;
			}

			ViewModels.CreatedFileAndDirectoriesAndFilesViewModel
				returnViewModel = new ViewModels.CreatedFileAndDirectoriesAndFilesViewModel();

			Ionic.Zip.ZipFile zipFile = null;

			try
			{
				zipFile =
					new Ionic.Zip.ZipFile(strCompressPathName);

				InitializeZipFile(zipFile);

				foreach (ViewModels.FileViewModel currentFileViewModel in viewModel.Files)
				{
					string strCurrentPathName =
						string.Format("{0}\\{1}",
						strPath, currentFileViewModel.Name);

					if (System.IO.File.Exists(strCurrentPathName))
					{
						try
						{
							zipFile.AddFile
								(fileName: strCurrentPathName,
								directoryPathInArchive: string.Empty);

							zipFile.Save();
						}
						catch (System.Exception ex)
						{
							System.IO.FileInfo oFileInfoThatHasError =
								new System.IO.FileInfo(strCurrentPathName);

							ViewModels.FileViewModel fileThatHasError =
								new ViewModels.FileViewModel(oFileInfoThatHasError)
								{
									Message = ex.Message
								};

							returnViewModel.Files.Add(fileThatHasError);
						}
					}
				}

				foreach (ViewModels.DirectoryViewModel currentirectoryViewModel in viewModel.Directories)
				{
					string strCurrentPath =
						string.Format("{0}\\{1}",
						strPath, currentirectoryViewModel.Name);

					if (System.IO.Directory.Exists(strCurrentPath))
					{
						try
						{
							zipFile.AddDirectory
								(directoryName: strCurrentPath,
								directoryPathInArchive: currentirectoryViewModel.Name);

							zipFile.Save();
						}
						catch (System.Exception ex)
						{
							System.IO.DirectoryInfo oDirectoryInfoThatHasError =
								new System.IO.DirectoryInfo(strCurrentPath);

							ViewModels.DirectoryViewModel oDirectoryThatHasError =
								new ViewModels.DirectoryViewModel(oDirectoryInfoThatHasError)
								{
									Message = ex.Message
								};

							returnViewModel.Directories.Add(oDirectoryThatHasError);
						}
					}
				}

				System.IO.FileInfo oFileInfo =
					new System.IO.FileInfo(strCompressPathName);

				ViewModels.FileViewModel oFile =
					new ViewModels.FileViewModel(oFileInfo);

				returnViewModel.CreatedFile = oFile;

				string strInformationMessage =
					string.Format("The compressed file [{0}] created successfully.",
					viewModel.FileName);

				jsonData =
					new JsonData
					{
						Data = returnViewModel,
						MessageText = strInformationMessage,
						State = ViewModels.JsonResultStates.Success,
					};

				return jsonData;
			}
			catch
			{
				string strErrorMessage =
					"Unexpected Error on Creating Compressed File!";

				jsonData =
					new JsonData
					{
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return jsonData;
			}
			finally
			{
				if (zipFile != null)
				{
					zipFile.Dispose();
					zipFile = null;
				}
			}
		}

		public static JsonData Decompress
			(string preDefinedRootRelativePath,
			ViewModels.PathAndDirectoriesAndFilesViewModel viewModel)
		{
			JsonData oJsonData = null;

			viewModel.Path =
				FixPath(viewModel.Path);

			string strPreDefinedRootRelativePath =
				FixPreDefinedRootRelativePath(preDefinedRootRelativePath);

			string strRootRelativePath =
				string.Format("{0}{1}",
				strPreDefinedRootRelativePath, viewModel.Path);

			string strPath =
				System.Web.HttpContext.Current.Server.MapPath(strRootRelativePath);

			Ionic.Zip.ZipFile oZipFile = null;

			try
			{
				foreach (ViewModels.FileViewModel currentFileViewModel in viewModel.Files)
				{
					string strCurrentPathName =
						string.Format("{0}\\{1}",
						strPath, currentFileViewModel.Name);

					if (System.IO.File.Exists(strCurrentPathName) == false)
					{
						continue;
					}

					oZipFile =
						new Ionic.Zip.ZipFile(strCurrentPathName);

					InitializeZipFile(oZipFile);

					try
					{
						oZipFile.ExtractAll
							(strPath, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
					}
					catch
					{
					}
				}

				oJsonData =
					GetDirectoriesAndFiles(preDefinedRootRelativePath, viewModel.Path);

				return oJsonData;
			}
			catch
			{
				string strErrorMessage =
					"Unexpected Error on Decompressing File(s)!";

				oJsonData =
					new JsonData
					{
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return oJsonData;
			}
			finally
			{
				if (oZipFile != null)
				{
					oZipFile.Dispose();
					oZipFile = null;
				}
			}
		}

		public static JsonData CreateDirectory
			(string preDefinedRootRelativePath, string path, string directoryName)
		{
			JsonData oJsonData = null;

			if (string.IsNullOrWhiteSpace(path))
			{
				string strErrorMessage =
					"The path does not specify!";

				oJsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return oJsonData;
			}

			if (string.IsNullOrWhiteSpace(directoryName))
			{
				string strErrorMessage =
					"You did not specify directory name!";

				oJsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return oJsonData;
			}

			directoryName = directoryName.Trim();

			path = FixPath(path);

			string strPreDefinedRootRelativePath =
				FixPreDefinedRootRelativePath(preDefinedRootRelativePath);

			string strRootRelativePath =
				string.Format("{0}{1}{2}",
				strPreDefinedRootRelativePath, path, directoryName);

			string strPath =
				System.Web.HttpContext.Current.Server.MapPath(strRootRelativePath);

			if (System.IO.File.Exists(strPath))
			{
				string strErrorMessage =
					"There is a file with this name!";

				oJsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return oJsonData;
			}

			if (System.IO.Directory.Exists(strPath))
			{
				string strErrorMessage =
					"This directory is already exist!";

				oJsonData =
					new JsonData()
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return oJsonData;
			}

			try
			{
				System.IO.DirectoryInfo oDirectoryInfo =
					System.IO.Directory.CreateDirectory(strPath);

				ViewModels.DirectoryViewModel directoryViewModel =
					new ViewModels.DirectoryViewModel(oDirectoryInfo);

				string strInformationMessage =
					"The directory created successfully.";

				oJsonData =
					new JsonData
					{
						DisplayMessage = true,
						Data = directoryViewModel,
						MessageText = strInformationMessage,
						State = ViewModels.JsonResultStates.Success,
					};

				return oJsonData;
			}
			catch
			{
				string strErrorMessage =
					"Unexpected error when creating directory!";

				oJsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return oJsonData;
			}
			finally
			{
			}
		}

		public static JsonData Rename
			(string preDefinedRootRelativePath, string path, string oldName, string newName)
		{
			JsonData oJsonData = null;

			// **************************************************
			if (string.IsNullOrWhiteSpace(oldName))
			{
				string strErrorMessage =
					"You did not specify old name!";

				oJsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return oJsonData;
			}

			oldName = oldName.Trim();
			// **************************************************

			// **************************************************
			if (string.IsNullOrWhiteSpace(newName))
			{
				string strErrorMessage =
					"You did not specify new name!";

				oJsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return oJsonData;
			}

			newName = newName.Trim();
			// **************************************************

			// **************************************************
			if (string.Compare(oldName, newName, ignoreCase: true) == 0)
			{
				string strErrorMessage =
					"The old name and new name are the same!";

				oJsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return oJsonData;
			}
			// **************************************************

			path = FixPath(path);

			string strPreDefinedRootRelativePath =
				Utility
				.FixPreDefinedRootRelativePath(preDefinedRootRelativePath);

			string strOldRootRelativePath =
				string.Format("{0}{1}{2}",
				strPreDefinedRootRelativePath, path, oldName);

			string strOldPath =
				System.Web.HttpContext.Current.Server.MapPath(strOldRootRelativePath);

			string strNewRootRelativePath =
				string.Format("{0}{1}{2}",
				strPreDefinedRootRelativePath, path, newName);

			string strNewPath =
				System.Web.HttpContext.Current.Server.MapPath(strNewRootRelativePath);

			if (System.IO.File.Exists(strNewPath))
			{
				string strErrorMessage =
					"There is a file with this name!";

				oJsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return oJsonData;
			}

			if (System.IO.Directory.Exists(strNewPath))
			{
				string strErrorMessage =
					"There is a directory with this name!";

				oJsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return oJsonData;
			}

			try
			{
				string strInformationMessage = string.Empty;

				if (System.IO.File.Exists(strOldPath))
				{
					System.IO.File.Move(strOldPath, strNewPath);

					strInformationMessage =
						string.Format("The file renamed from [{0}] to [{1}] successfully.",
						oldName, newName);
				}
				else
				{
					if (System.IO.Directory.Exists(strOldPath))
					{
						System.IO.Directory.Move(strOldPath, strNewPath);

						strInformationMessage =
							string.Format("The directory renamed from [{0}] to [{1}] successfully.",
							oldName, newName);
					}
					else
					{
						string strErrorMessage =
							string.Format("There is no directory of file with [{0}] name!",
							oldName);

						oJsonData =
							new JsonData
							{
								DisplayMessage = true,
								MessageText = strErrorMessage,
								State = ViewModels.JsonResultStates.Error,
							};

						return oJsonData;
					}
				}

				oJsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strInformationMessage,
						State = ViewModels.JsonResultStates.Success,
					};

				return oJsonData;
			}
			catch (System.Exception ex)
			{
				string strErrorMessage = ex.Message;

				if (ex.Message.Contains("Access to the path") &&
					ex.Message.Contains("is denied."))
				{
					strErrorMessage =
						string.Format("Access to the [{0}] is denied.", oldName);
				}

				oJsonData =
					new JsonData
					{
						DisplayMessage = true,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};

				return oJsonData;
			}
			finally
			{
			}
		}

		public static string FixPreDefinedRootRelativePath(string preDefinedRootRelativePath)
		{
			while (preDefinedRootRelativePath.Contains("//"))
			{
				preDefinedRootRelativePath =
					preDefinedRootRelativePath.Replace("//", "/");
			}

			if (preDefinedRootRelativePath.EndsWith("/"))
			{
				preDefinedRootRelativePath =
					preDefinedRootRelativePath.Substring
					(0, preDefinedRootRelativePath.Length - 1);
			}

			return (preDefinedRootRelativePath);
		}

		public static JsonData DeleteDirectoriesAndFiles
			(string preDefinedRootRelativePath, ViewModels.PathAndDirectoriesAndFilesViewModel viewModel)
		{
			JsonData oJsonData = null;

			viewModel.Path = FixPath(viewModel.Path);

			preDefinedRootRelativePath =
				FixPreDefinedRootRelativePath(preDefinedRootRelativePath);

			string strRootRelativePath =
				string.Format("{0}{1}",
				preDefinedRootRelativePath, viewModel.Path);

			string strPath =
				System.Web.HttpContext.Current.Server.MapPath(strRootRelativePath);

			if (System.IO.Directory.Exists(strPath) == false)
			{
				oJsonData =
					new JsonData
					{
						State = ViewModels.JsonResultStates.Error,
						MessageText = "The current path is not valid!",
					};

				return oJsonData;
			}

			ViewModels.DirectoriesAndFilesViewModel
				oReturnViewModel = new ViewModels.DirectoriesAndFilesViewModel();

			bool blnHasError = false;

			foreach (ViewModels.FileViewModel oFile in viewModel.Files)
			{
				string strCurrentPathName =
					string.Format("{0}{1}", strPath, oFile.Name);

				if (System.IO.File.Exists(strCurrentPathName))
				{
					try
					{
						System.IO.File.Delete(strCurrentPathName);
					}
					catch (System.Exception ex)
					{
						blnHasError = true;

						System.IO.FileInfo oFileInfoThatHasError =
							new System.IO.FileInfo(strCurrentPathName);

						ViewModels.FileViewModel oFileThatHasError =
							new ViewModels.FileViewModel(oFileInfoThatHasError);

						if (ex.Message.Contains("it is being used by another process"))
						{
							oFileThatHasError.Message =
								"It is being used by another process.";
						}
						else
						{
							oFileThatHasError.Message = ex.Message;
						}

						oReturnViewModel.Files.Add(oFileThatHasError);
					}
				}
			}

			foreach (ViewModels.DirectoryViewModel oDirectory in viewModel.Directories)
			{
				string strCurrentPath =
					string.Format("{0}{1}", strPath, oDirectory.Name);

				if (System.IO.Directory.Exists(strCurrentPath))
				{
					try
					{
						System.IO.Directory.Delete(strCurrentPath, recursive: true);
					}
					catch (System.Exception ex)
					{
						blnHasError = true;

						System.IO.DirectoryInfo oDirectoryInfoThatHasError =
							new System.IO.DirectoryInfo(strCurrentPath);

						ViewModels.DirectoryViewModel oDirectoryThatHasError =
							new ViewModels.DirectoryViewModel(oDirectoryInfoThatHasError);

						if (ex.Message.Contains("it is being used by another process"))
						{
							oDirectoryThatHasError.Message =
								"It is being used by another process.";
						}
						else
						{
							oDirectoryThatHasError.Message = ex.Message;
						}

						oReturnViewModel.Directories.Add(oDirectoryThatHasError);
					}
				}
			}

			if (blnHasError)
			{
				string strErrorMessage =
					"Some selected directories and/or files does not deleted!";

				oJsonData =
					new JsonData
					{
						DisplayMessage = true,
						Data = oReturnViewModel,
						MessageText = strErrorMessage,
						State = ViewModels.JsonResultStates.Error,
					};
			}
			else
			{
				string strInformationMessage =
					"All selected directories and/or files deleted successfully.";

				oJsonData =
					new JsonData
					{
						DisplayMessage = true,
						Data = oReturnViewModel,
						MessageText = strInformationMessage,
						State = ViewModels.JsonResultStates.Success,
					};
			}

			return oJsonData;
		}
	}
}
