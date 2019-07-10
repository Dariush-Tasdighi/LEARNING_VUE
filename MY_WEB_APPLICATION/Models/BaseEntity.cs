using System.Linq;

namespace Models
{
	public abstract class BaseEntity : object
	{
		public BaseEntity() : base()
		{
			Id = System.Guid.NewGuid();
			InsertDateTime = System.DateTime.Now;
		}

		// **********
		public System.Guid Id { get; set; }
		// **********

		// **********
		public System.DateTime InsertDateTime { get; set; }
		// **********

		public object GetPropertyValue(string propertyName)
		{
			var o1 = this.GetType();

			var o2 =
				o1.GetProperties()
				.Where(current => string.Compare(current.Name, propertyName, true) == 0)
				.FirstOrDefault();

			object value = o2.GetValue(this, null);

			return value;
		}
	}
}
