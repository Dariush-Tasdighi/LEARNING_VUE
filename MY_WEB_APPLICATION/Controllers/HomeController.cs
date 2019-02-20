using System.Linq;

namespace MY_WEB_APPLICATION.Controllers
{
	public class HomeController : Infrastructure.BaseController
	{
		public HomeController() : base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Test()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Index()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0050()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0100()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0200()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0300()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0400()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0500()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0525()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0550()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0575()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0583()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0600()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0650()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0675()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0700()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0750()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0800()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0825()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0850()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0875()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0900()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0910()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0920()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0930()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0932()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0933()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0935()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0940()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0950()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0960()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn0970()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn1000()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5000()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult GetMessage5000()
		{
			var data = "Hello, World";

			return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult GetMessage5010()
		{
			var data =
				new { Message = "Hello, World" };

			return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5100()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetMessage5100()
		{
			var data =
				new { Message = "Hello, World" };

			return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult GetMessage5110()
		{
			var data =
				new { Message = "Hello, World" };

			return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		/// <summary>
		/// Tanx Mr. Ali Ashrafi
		/// In this case GetMessage5120 accept GET and POST
		/// </summary>
		public System.Web.Mvc.JsonResult GetMessage5120()
		{
			var data =
				new { Message = "Hello, World" };

			return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5200()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult GetMessage5200(string name)
		{
			var data =
				new { Message = $"Welcome { name }!" };

			return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5300()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetMessage5300(string name)
		{
			var data =
				new { Message = $"Welcome { name }!" };

			return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetMessage5310(string name, string family)
		{
			var data =
				new { Message = $"Welcome { name } { family }!" };

			return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetMessage5320(Models.Employee employee)
		{
			var data =
				new { Message = $"Welcome { employee.Name } { employee.Family }!" };

			return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5350()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetMessage5350(Models.Employee employee)
		{
			var data =
				new { Message = $"Welcome { employee.Name } { employee.Family }!" };

			return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5400()
		{
			return View();
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

				result.ClearNotHiddenMessages();

				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			return Json(data: result,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5500()
		{
			return View();
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
				result.ClearInformationMessages();

				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			return Json(data: result,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5600()
		{
			return View();
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
				result.ClearInformationMessages();

				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			return new Infrastructure.JsonNetResult
			{
				Data = result,
			};
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5700()
		{
			return View();
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
				result.ClearInformationMessages();

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

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5800()
		{
			return View();
		}

		private static System.Collections.Generic.IList<Models.Person> people;

		protected static System.Collections.Generic.IList<Models.Person> People
		{
			get
			{
				if (people == null)
				{
					System.Random random =
						new System.Random(System.Environment.TickCount);

					people =
						new System.Collections.Generic.List<Models.Person>();

					for (int index = 1; index <= 113; index++)
					{
						Models.Person person =
							new Models.Person()
							{
								LastName = $"Last Name { index }",
								FirstName = $"First Name { index }",

								Age = random.Next(20, 100),
								Salary = random.Next(1000000, 9000000),
							};

						people.Add(person);
					}
				}

				return people;
			}
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn5900()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn6000()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData6000(ViewModels.General.InputGridViewModel inputViewModel)
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

				result.ClearNotHiddenMessages();

				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			return new Infrastructure.JsonNetResult
			{
				Data = result,
			};
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn6100()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData6100(ViewModels.General.InputGridViewModel inputViewModel)
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
				result.ClearInformationMessages();

				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			return new Infrastructure.JsonNetResult
			{
				Data = result,
			};
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn6200()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData6200
			(ViewModels.Home.GetData6200InputViewModel inputViewModel)
		{
			System.Threading.Thread.Sleep(500);

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

				if (string.IsNullOrWhiteSpace(inputViewModel.sortFieldName))
				{
					data = data.OrderBy(current => current.InsertDateTime);
				}
				else
				{
					switch (inputViewModel.sortFieldName.ToUpper())
					{
						case "AGE":
						{
							if (inputViewModel.sortDirection == "0")
							{
								data = data.OrderBy(current => current.Age);
							}
							else
							{
								data = data.OrderByDescending(current => current.Age);
							}

							break;
						}

						case "SALARY":
						{
							if (inputViewModel.sortDirection == "0")
							{
								data = data.OrderBy(current => current.Salary);
							}
							else
							{
								data = data.OrderByDescending(current => current.Salary);
							}

							break;
						}

						case "FIRSTNAME":
						{
							if (inputViewModel.sortDirection == "0")
							{
								data = data.OrderBy(current => current.FirstName);
							}
							else
							{
								data = data.OrderByDescending(current => current.FirstName);
							}

							break;
						}

						case "LASTNAME":
						{
							if (inputViewModel.sortDirection == "0")
							{
								data = data.OrderBy(current => current.LastName);
							}
							else
							{
								data = data.OrderByDescending(current => current.LastName);
							}

							break;
						}
					}
				}

				var partialResult =
					data
					.Skip(inputViewModel.Skip)
					.Take(inputViewModel.Take)
					.ToList()
					;

				result.Count = count;
				result.Items = partialResult;

				result.IsSuccess = true;

				result.AddErrorMessage("Error (1)!");

				result.AddHiddenMessage("Hidden (1)!");
				result.AddHiddenMessage("Hidden (2)!");

				result.AddInformationMessage("Information (1)!");
				result.AddInformationMessage("Information (2)!");
				result.AddInformationMessage("Information (3)!");
			}
			catch (System.Exception ex)
			{
				// Log(ex)

				result.Count = 0;
				result.Items = null;
				result.IsSuccess = false;

				result.ClearNotHiddenMessages();

				result.AddHiddenMessage(ex.Message);
				result.AddErrorMessage("Unexpected Error!");
			}
			finally
			{
			}

			return new Infrastructure.JsonNetResult
			{
				Data = result,
			};
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn7000()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn7100()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn7200()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn7300()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn7400()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn7500()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn7600()
		{
			return View();
		}
	}
}
