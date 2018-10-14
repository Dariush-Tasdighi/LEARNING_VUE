namespace Models
{
	public class Person : BaseEntity
	{
		public Person() : base()
		{
		}

		// **********
		public bool IsActive { get; set; }
		// **********

		// **********
		public int Age { get; set; }
		// **********

		// **********
		public int Salary { get; set; }
		// **********

		// **********
		public string LastName { get; set; }
		// **********

		// **********
		public string FirstName { get; set; }
		// **********
	}
}
