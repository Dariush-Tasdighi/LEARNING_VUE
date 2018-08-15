namespace Infrastructure
{
	/// <summary>
	/// A <see cref="JsonResult"/> implementation that uses JSON.NET to
	/// perform the serialization.
	/// </summary>
	public class JsonNetResult : System.Web.Mvc.JsonResult
	{
		//public object Data { get; set; }
		//public string ContentType { get; set; }
		//public Encoding ContentEncoding { get; set; }
		//public JsonRequestBehavior JsonRequestBehavior { get; set; }

		public Newtonsoft.Json.Formatting Formatting { get; set; }
		public Newtonsoft.Json.JsonSerializerSettings SerializerSettings { get; set; }

		public JsonNetResult() : base()
		{
			Formatting =
				Newtonsoft.Json.Formatting.None;

			SerializerSettings =
				new Newtonsoft.Json.JsonSerializerSettings();

			SerializerSettings.ContractResolver =
				new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();

			JsonRequestBehavior =
				System.Web.Mvc.JsonRequestBehavior.AllowGet;
		}

		public override void ExecuteResult(System.Web.Mvc.ControllerContext context)
		{
			if (context == null)
			{
				throw (new System.ArgumentNullException("context"));
			}

			//if ((JsonRequestBehavior == System.Web.Mvc.JsonRequestBehavior.DenyGet) &&
			//		(string.Equals(context.HttpContext.Request.HttpMethod, "GET", System.StringComparison.OrdinalIgnoreCase)))
			//{
			//	throw (new System.InvalidOperationException
			//		("This request has been blocked because sensitive information could be disclosed to third party web sites when this is used in a GET request. To allow GET requests, set JsonRequestBehavior to AllowGet."));
			//}

			System.Web.HttpResponseBase
				response = context.HttpContext.Response;

			if (string.IsNullOrWhiteSpace(ContentType) == false)
			{
				response.ContentType = ContentType;
			}
			else
			{
				response.ContentType = "application/json";
			}

			if (ContentEncoding != null)
			{
				response.ContentEncoding = ContentEncoding;
			}

			if (Data != null)
			{
				var writer =
					new Newtonsoft.Json.JsonTextWriter(response.Output) { Formatting = Formatting };

				var serializer =
					Newtonsoft.Json.JsonSerializer.Create(SerializerSettings);

				serializer.Serialize(writer, Data);

				writer.Flush();
			}
		}
	}
}
