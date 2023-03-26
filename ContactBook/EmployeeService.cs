using System;
namespace ContactBook
{
	public class EmployeeService
	{
		public EmployeeService()
		{
			Employees = new List<Employee>();
		}

		public List<Employee> Employees { get; set; }

		public List<Employee> GetAllEmployess()
		{
			return Employees;
		}

		public int AddEmployee()
		{
			Console.WriteLine("Id pracownika: ");
			string idFromInput = Console.ReadLine();
			Console.WriteLine("Imię: ");
			string firstName = Console.ReadLine();
			Console.WriteLine("Nazwisko: ");
			string lastName = Console.ReadLine();
			Console.WriteLine("Dział: ");
			string departament = Console.ReadLine();
			Console.WriteLine("Numer telefonu: ");
			string phoneNumber = Console.ReadLine();
			Console.WriteLine("E-mail: ");
			string email = Console.ReadLine();

			int id;

			Int32.TryParse(idFromInput, out id);

			Employee employee = new Employee() {
				Id = id,
				FirstName = firstName,
				LastName = lastName,
				Departament = departament,
				PhoneNumber = phoneNumber,
				Email = email
			};

			Employees.Add(employee);

			return id;
			
		}
	}
}

