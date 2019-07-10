using System.Linq;

namespace MY_WEB_APPLICATION.Controllers
{
	public class LearningDtxGridVueController : System.Web.Mvc.Controller
	{
		#region Static Member(s)
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
								IsActive = index % 2 == 0,

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
		#endregion /Static Member(s)

		public LearningDtxGridVueController() : base()
		{
		}

		public System.Web.Mvc.ViewResult Index()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_0100()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_0200()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_0250()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_0300()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_0400()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_0500()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_0600()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_0700()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_0800()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_0900()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_1000()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_1100()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_1200()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_1300()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_1400()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_1500()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_1600()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_1700()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_1800()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_1900()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_2000()
		{
			return View();
		}

		public System.Web.Mvc.ViewResult Learn_5000()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData
			(ViewModels.LearningDtxGridVue.InputGetDataViewModel inputViewModel)
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

				if (string.IsNullOrWhiteSpace(inputViewModel.SortFieldName))
				{
					data =
						data
						.OrderByDescending(current => current.InsertDateTime);
				}
				else
				{
					switch (inputViewModel.SortFieldName.ToUpper())
					{
						case "ISACTIVE":
						{
							if (inputViewModel.SortDirection == "0")
							{
								data =
									data
									.OrderBy(current => current.IsActive);
							}
							else
							{
								data =
									data
									.OrderByDescending(current => current.IsActive);
							}

							break;
						}

						case "AGE":
						{
							if (inputViewModel.SortDirection == "0")
							{
								data =
									data
									.OrderBy(current => current.Age);
							}
							else
							{
								data =
									data
									.OrderByDescending(current => current.Age);
							}

							break;
						}

						case "SALARY":
						{
							if (inputViewModel.SortDirection == "0")
							{
								data =
									data
									.OrderBy(current => current.Salary);
							}
							else
							{
								data =
									data
									.OrderByDescending(current => current.Salary);
							}

							break;
						}

						case "FIRSTNAME":
						{
							if (inputViewModel.SortDirection == "0")
							{
								data =
									data
									.OrderBy(current => current.FirstName);
							}
							else
							{
								data =
									data
									.OrderByDescending(current => current.FirstName);
							}

							break;
						}

						case "LASTNAME":
						{
							if (inputViewModel.SortDirection == "0")
							{
								data =
									data
									.OrderBy(current => current.LastName);
							}
							else
							{
								data =
									data
									.OrderByDescending(current => current.LastName);
							}

							break;
						}

						default:
						{
							data =
								data
								.OrderBy(current => current.InsertDateTime);

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

				//result.AddErrorMessage("Error (1)!");

				//result.AddHiddenMessage("Hidden (1)!");
				//result.AddHiddenMessage("Hidden (2)!");

				//result.AddInformationMessage("Information (1)!");
				//result.AddInformationMessage("Information (2)!");
				//result.AddInformationMessage("Information (3)!");
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
	}
}
