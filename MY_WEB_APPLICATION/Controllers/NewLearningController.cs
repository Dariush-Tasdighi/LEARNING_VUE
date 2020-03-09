namespace MY_WEB_APPLICATION.Controllers
{
	public class NewLearningController : System.Web.Mvc.Controller
	{
		public NewLearningController() : base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_0100()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_0200()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_0300()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_0400()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_0500()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_0600()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_0700()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_0800()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_0900()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_1000()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_1100()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_1200()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_1300()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_1400()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_1500()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_1600()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_1700()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_1800()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_1900()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_2000()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_2100()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_2200()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_2300()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_2400()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_2500()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_2600()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_2700()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_2800()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_2900()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_3000()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_3100()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_3200()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_3300()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_3400()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public void DoSomething1()
		{
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult DoSomething2()
		{
			return null;
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult DoSomething3()
		{
			return null;
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult DoSomething4()
		{
			throw new System.Exception("Some Error Message!");
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_3500()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult DoSomething2_1()
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			string message = "Hello, World!";

			return Json(data: message,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult DoSomething2_2()
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			ViewModels.MessageViewModel viewModel =
				new ViewModels.MessageViewModel
				{
					Message = "Hello, World!",
				};

			return Json(data: viewModel,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult DoSomething2_3()
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			var data =
				new { Message = "Hello, World" };

			return Json(data: data,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		/// <summary>
		/// Test With PostMan!
		/// </summary>
		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult DoSomething2_4()
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			var data =
				new { Message = "Hello, World" };

			return Json(data: data,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_3600()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult DoSomething3_1(string name)
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			var data =
				new { Message = $"GET RESULT: Hello, { name }" };

			return Json(data: data,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult DoSomething3_2(string name)
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			var data =
				new { Message = $"POST RESULT: Hello, { name }" };

			return Json(data: data,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_3700()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult DoSomething4_1(string firstName, string lastName)
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			var data =
				new { Message = $"GET RESULT: Hello, { firstName } { lastName }" };

			return Json(data: data,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult DoSomething4_2(string firstName, string lastName)
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			var data =
				new { Message = $"POST RESULT: Hello, { firstName } { lastName }" };

			return Json(data: data,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_3800()
		{
			return View();
		}

		/// <summary>
		/// Note: Using Model and ViewModel is better than partial fields!
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult DoSomething5_1(ViewModels.PersonViewModel viewModel)
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			var data =
				new { Message = $"GET RESULT: Hello, { viewModel.FirstName } { viewModel.LastName }" };

			return Json(data: data,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		/// <summary>
		/// Note: Using Model and ViewModel is better than partial fields!
		/// </summary>
		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult DoSomething5_2(ViewModels.PersonViewModel viewModel)
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			var data =
				new { Message = $"POST RESULT: Hello, { viewModel.FirstName } { viewModel.LastName }" };

			return Json(data: data,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_3900()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult DoSomething6_1(ViewModels.PersonViewModel viewModel)
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			var data =
				new { Message = $"GET RESULT: Hello, { viewModel.FirstName } { viewModel.LastName }" };

			return Json(data: data,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult DoSomething6_2(ViewModels.PersonViewModel viewModel)
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			var data =
				new { Message = $"POST RESULT: Hello, { viewModel.FirstName } { viewModel.LastName }" };

			return Json(data: data,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_4000()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult DoSomething7_1(ViewModels.PersonViewModel viewModel)
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			var data =
				new { Message = $"POST RESULT: Hello, { viewModel.FirstName } { viewModel.LastName }" };

			return Json(data: data,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_4100()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_4200()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_4300()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_4400()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult DoSomething8_1(ViewModels.PersonViewModel viewModel)
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			var data =
				new { Message = $"POST RESULT: Hello, { viewModel.FirstName } { viewModel.LastName }" };

			return Json(data: data,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_4500()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetPersonDetails_1(ViewModels.PersonViewModel viewModel)
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			var data =
				new { CellPhoneNumber = $"09121087461", EmailAddress = "DariushT@GMail.com", };

			return Json(data: data,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_4600()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetPersonDetails_2(ViewModels.PersonViewModel viewModel)
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			Dtx.ViewModels.ResultWithDataViewModel<ViewModels.NewLearning.GetPersonDetailsViewModel>
				result = new Dtx.ViewModels.ResultWithDataViewModel<ViewModels.NewLearning.GetPersonDetailsViewModel>();

			try
			{
				// Do Something!

				ViewModels.NewLearning.GetPersonDetailsViewModel resultViewModel =
					new ViewModels.NewLearning.GetPersonDetailsViewModel
					{
						CellPhoneNumber = $"09121087461",
						EmailAddress = "DariushT@GMail.com",
					};

				result.Succeeded = true;
				result.Data = resultViewModel;

				result.AddErrorMessage("Error Message 1");

				result.AddHiddenMessage("Hidden Message 1");
				result.AddHiddenMessage("Hidden Message 2");

				result.AddInformationMessage("Information Message 1");
				result.AddInformationMessage("Information Message 2");
				result.AddInformationMessage("Information Message 3");
			}
			catch //(System.Exception ex)
			{
				// Log(ex)

				result.ClearNonHiddenMessages();

				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			return Json(data: result,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_4700()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetPersonDetails_3(ViewModels.PersonViewModel viewModel)
		{
			// ایجاد یک لختی تصنعی
			System.Threading.Thread.Sleep(millisecondsTimeout: 5000);

			Dtx.ViewModels.ResultWithDataViewModel<ViewModels.NewLearning.GetPersonDetailsViewModel>
				result = new Dtx.ViewModels.ResultWithDataViewModel<ViewModels.NewLearning.GetPersonDetailsViewModel>();

			try
			{
				// Do Something!

				ViewModels.NewLearning.GetPersonDetailsViewModel
					resultViewModel = new ViewModels.NewLearning.GetPersonDetailsViewModel
					{
						CellPhoneNumber = $"09121087461",
						EmailAddress = "DariushT@GMail.com",
					};

				result.Succeeded = true;
				result.Data = resultViewModel;

				result.AddErrorMessage("Error Message 1");

				result.AddHiddenMessage("Hidden Message 1");
				result.AddHiddenMessage("Hidden Message 2");

				result.AddInformationMessage("Information Message 1");
				result.AddInformationMessage("Information Message 2");
				result.AddInformationMessage("Information Message 3");
			}
			catch //(System.Exception ex)
			{
				// Log(ex)

				result.ClearNonHiddenMessages();

				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			//return Json(data: result,
			//	behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);

			return new Infrastructure.JsonNetResult { Data = result };
		}
	}
}

