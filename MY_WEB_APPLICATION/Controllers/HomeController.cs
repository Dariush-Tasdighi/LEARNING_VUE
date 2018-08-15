using System.Linq;

namespace MY_WEB_APPLICATION.Controllers
{
	public class HomeController : Infrastructure.BaseController
	{
		public HomeController() : base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Alaki()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Index()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0100()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0200()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0300()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0400()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0500()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0550()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0575()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0583()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0600()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0650()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0700()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0800()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0850()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0900()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1000()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5000()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult GetMessage5000()
		{
			var data = "Hello, World";

			return (Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult GetMessage5010()
		{
			var data =
				new { Message = "Hello, World" };

			return (Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5100()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetMessage5100()
		{
			var data =
				new { Message = "Hello, World" };

			return (Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult GetMessage5110()
		{
			var data =
				new { Message = "Hello, World" };

			return (Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		/// <summary>
		/// Tanx Mr. Ali Ashrafi
		/// In this case GetMessage5120 accept GET and POST
		/// </summary>
		public System.Web.Mvc.JsonResult GetMessage5120()
		{
			var data =
				new { Message = "Hello, World" };

			return (Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5200()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult GetMessage5200(string name)
		{
			var data =
				new { Message = $"Welcome { name }!" };

			return (Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5300()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetMessage5300(string name)
		{
			var data =
				new { Message = $"Welcome { name }!" };

			return (Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetMessage5310(string name, string family)
		{
			var data =
				new { Message = $"Welcome { name } { family }!" };

			return (Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetMessage5320(Models.Employee employee)
		{
			var data =
				new { Message = $"Welcome { employee.Name } { employee.Family }!" };

			return (Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5350()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetMessage5350(Models.Employee employee)
		{
			var data =
				new { Message = $"Welcome { employee.Name } { employee.Family }!" };

			return (Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5400()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult DoSomething5400(string name)
		{
			System.Threading.Thread.Sleep(5000);

			ViewModels.General.JsonResultViewModel
				result = new ViewModels.General.JsonResultViewModel();

			try
			{
				// Do Something

				result.IsSuccess = true;

				result.AddErrorMessage("Error Message 1");
				result.AddErrorMessage("Error Message 2");

				result.AddInformationMessage("Information Message 1");
				result.AddInformationMessage("Information Message 2");
				result.AddInformationMessage("Information Message 3");
			}
			catch //(System.Exception ex)
			{
				// Log(ex)

				result.ClearErrorMessages();
				result.ClearInformationMessage();

				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			return (Json(data: result, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5500()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult DoSomething5500(string firstName, string lastName)
		{
			System.Threading.Thread.Sleep(5000);

			ViewModels.General.JsonResultViewModel<Models.Person>
				result = new ViewModels.General.JsonResultViewModel<Models.Person>();

			try
			{
				Models.Person person = new Models.Person()
				{
					LastName = lastName,
					FirstName = firstName,
				};

				result.Data = person;

				result.IsSuccess = true;

				result.AddErrorMessage("Error Message 1");
				result.AddErrorMessage("Error Message 2");

				result.AddInformationMessage("Information Message 1");
				result.AddInformationMessage("Information Message 2");
				result.AddInformationMessage("Information Message 3");
			}
			catch //(System.Exception ex)
			{
				// Log(ex)

				result.ClearErrorMessages();
				result.ClearInformationMessage();

				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			return (Json(data: result, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5600()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult DoSomething5600(string firstName, string lastName)
		{
			System.Threading.Thread.Sleep(5000);

			ViewModels.General.JsonResultViewModel<Models.Person>
				result = new ViewModels.General.JsonResultViewModel<Models.Person>();

			try
			{
				Models.Person person = new Models.Person()
				{
					LastName = lastName,
					FirstName = firstName,
				};

				result.Data = person;

				result.IsSuccess = true;

				result.AddErrorMessage("Error Message 1");
				result.AddErrorMessage("Error Message 2");

				result.AddInformationMessage("Information Message 1");
				result.AddInformationMessage("Information Message 2");
				result.AddInformationMessage("Information Message 3");
			}
			catch //(System.Exception ex)
			{
				// Log(ex)

				result.ClearErrorMessages();
				result.ClearInformationMessage();

				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			return (new Infrastructure.JsonNetResult
			{
				Data = result,
			});
		}


		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5700()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult DoSomething5700(Models.Person inputViewModel)
		{
			System.Threading.Thread.Sleep(5000);

			ViewModels.General.JsonResultViewModel<Models.Person>
				result = new ViewModels.General.JsonResultViewModel<Models.Person>();

			try
			{
				Models.Person person = new Models.Person()
				{
					LastName = inputViewModel.LastName,
					FirstName = inputViewModel.FirstName,
				};

				result.Data = person;

				result.IsSuccess = true;

				result.AddErrorMessage("Error Message 1");
				result.AddErrorMessage("Error Message 2");

				result.AddInformationMessage("Information Message 1");
				result.AddInformationMessage("Information Message 2");
				result.AddInformationMessage("Information Message 3");
			}
			catch //(System.Exception ex)
			{
				// Log(ex)

				result.ClearErrorMessages();
				result.ClearInformationMessage();

				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			//return (new Infrastructure.JsonNetResult
			//{
			//	Data = result,
			//});

			//return (Json(data: result, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));

			return (JsonNet(data: result));
		}

		private System.Collections.Generic.IList<Models.Person> people;

		protected System.Collections.Generic.IList<Models.Person> People
		{
			get
			{
				if (people == null)
				{
					people =
						new System.Collections.Generic.List<Models.Person>();

					for (int index = 0; index < 115; index++)
					{
						Models.Person person =
							new Models.Person()
							{
								LastName = $"Last Name { index }",
								FirstName = $"First Name { index }",
							};

						people.Add(person);
					}
				}

				return (people);
			}
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn6000()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData6000(ViewModels.General.GetData inputViewModel)
		{
			System.Threading.Thread.Sleep(2000);

			ViewModels.General.JsonResultForGridViewModel<Models.Person>
				result = new ViewModels.General.JsonResultForGridViewModel<Models.Person>();

			try
			{
				var data =
					People
					.AsQueryable();

				// Where

				int count =
					data.Count();

				data =
					data
					.OrderBy(current => current.FirstName)
					;

				var partialResult =
					data
					.Skip(inputViewModel.Skip)
					.Take(inputViewModel.Take)
					.ToList()
					;

				result.Count = count;
				result.Items = partialResult;

				result.IsSuccess = true;
			}
			catch // (System.Exception ex)
			{
				// Log(ex)

				result.Count = 0;
				result.Items = null;
				result.IsSuccess = false;

				result.ClearErrorMessages();
				result.ClearInformationMessage();

				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			return (new Infrastructure.JsonNetResult
			{
				Data = result,
			});
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn6100()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData6100(ViewModels.General.GetData inputViewModel)
		{
			System.Threading.Thread.Sleep(2000);

			ViewModels.General.JsonResultForGridViewModel<Models.Person>
				result = new ViewModels.General.JsonResultForGridViewModel<Models.Person>();

			try
			{
				var data =
					People
					.AsQueryable();

				// Where

				int count =
					data.Count();

				data =
					data
					.OrderBy(current => current.FirstName)
					;

				var partialResult =
					data
					.Skip(inputViewModel.Skip)
					.Take(inputViewModel.Take)
					.ToList()
					;

				result.Count = count;
				result.Items = partialResult;

				if (System.DateTime.Now.Millisecond % 2 == 0)
				{
					result.IsSuccess = true;

					result.InformationMessages.Add("Information (1)!");
					result.InformationMessages.Add("Information (2)!");
					result.InformationMessages.Add("Information (3)!");
				}
				else
				{
					result.IsSuccess = false;

					result.ErrorMessages.Add("Error (1)!");
					result.ErrorMessages.Add("Error (2)!");
				}
			}
			catch // (System.Exception ex)
			{
				// Log(ex)

				result.Count = 0;
				result.Items = null;
				result.IsSuccess = false;

				result.ClearErrorMessages();
				result.ClearInformationMessage();

				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			return (new Infrastructure.JsonNetResult
			{
				Data = result,
			});
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn6200()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData6200(ViewModels.Home.GetData6200InputViewModel inputViewModel)
		{
			System.Threading.Thread.Sleep(2000);

			ViewModels.General.JsonResultForGridViewModel<Models.Person>
				result = new ViewModels.General.JsonResultForGridViewModel<Models.Person>();

			try
			{
				var data =
					People
					.AsQueryable();

				if (string.IsNullOrWhiteSpace(inputViewModel.FirstName) == false)
				{
					data =
						data
						.Where(current => current.FirstName.Contains(inputViewModel.FirstName))
						;
				}

				if (string.IsNullOrWhiteSpace(inputViewModel.LastName) == false)
				{
					data =
						data
						.Where(current => current.LastName.Contains(inputViewModel.LastName))
						;
				}

				int count =
					data.Count();

				data =
					data
					.OrderBy(current => current.FirstName)
					;

				var partialResult =
					data
					.Skip(inputViewModel.Skip)
					.Take(inputViewModel.Take)
					.ToList()
					;

				result.Count = count;
				result.Items = partialResult;

				result.IsSuccess = true;

				result.InformationMessages.Add("Information (1)!");
				result.InformationMessages.Add("Information (2)!");
				result.InformationMessages.Add("Information (3)!");
			}
			catch // (System.Exception ex)
			{
				// Log(ex)

				result.Count = 0;
				result.Items = null;
				result.IsSuccess = false;

				result.ClearErrorMessages();
				result.ClearInformationMessage();

				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			return (new Infrastructure.JsonNetResult
			{
				Data = result,
			});
		}
	}
}
