using System;
namespace ContactBook
{
	public class Employee
	{
		public Employee(int id, string firstName, string lastName, string departament, string phoneNumber, string email)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Departament = departament;
			PhoneNumber = phoneNumber;
			Email = email;
        }

		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Departament { get; set; }

		public string PhoneNumber { get; set; }

		public string Email { get; set; }
	}
}

