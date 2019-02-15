namespace Dtx.FileManager
{
	public class JsonData : object
	{
		public JsonData() : base()
		{
		}

		public object Data { get; set; }

		public string MessageText { get; set; }

		public string MessageTitle { get; set; }

		public bool DisplayMessage { get; set; }

		public ViewModels.JsonResultStates State { get; set; }

		public System.Web.Mvc.JsonResult GetJsonResult()
		{
			//if (DisplayMessage)
			//{
			//	if (string.IsNullOrWhiteSpace(MessageTitle))
			//	{
			//		switch (State)
			//		{
			//			case Enums.JsonResultStates.Error:
			//			{
			//				MessageTitle = Resources.Captions.ErrorState;

			//				break;
			//			}

			//			case Enums.JsonResultStates.Success:
			//			{
			//				MessageTitle = Resources.Captions.SuccessState;

			//				break;
			//			}

			//			case Enums.JsonResultStates.Warning:
			//			{
			//				MessageTitle = Resources.Captions.WarningState;

			//				break;
			//			}
			//		}
			//	}
			//}

			System.Web.Mvc.JsonResult jsonResult = new System.Web.Mvc.JsonResult
			{
				Data = this,
				RecursionLimit = null,
				MaxJsonLength = int.MaxValue,
				ContentEncoding = System.Text.Encoding.UTF8,
				JsonRequestBehavior = System.Web.Mvc.JsonRequestBehavior.AllowGet
			};

			return jsonResult;
		}
	}
}
