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
		public System.Web.Mvc.ViewResult Learn_3700()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_3800()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_3900()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_4000()
		{
			return View();
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

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_4500()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_4600()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_4700()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_4800()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_4900()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn_5000()
		{
			return View();
		}
	}
}
