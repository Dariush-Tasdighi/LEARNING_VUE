namespace Models
{
	public class Person : BaseEntity
	{
		public Person() : base()
		{
		}

		// **********
		public string LastName { get; set; }
		// **********

		// **********
		public string FirstName { get; set; }
		// **********
	}
}
