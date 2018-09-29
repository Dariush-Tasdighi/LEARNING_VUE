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
	}
}
