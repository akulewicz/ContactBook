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


		public void DisplayEmployeeDetails(Employee employee)
		{
			Console.WriteLine($"{employee.Id,4} | {employee.FirstName,-12} | {employee.LastName,-12} | {employee.Departament,-30} | {employee.PhoneNumber,-12} | {employee.Email,-20}");
		}


		public void DisplayEmployess(List<Employee> employees)
		{
			foreach (var employee in employees)
			{
				DisplayEmployeeDetails(employee);
			}
			Console.WriteLine();
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


		public string SearchForEmployessView()
		{
            Console.WriteLine("Podaj nazwisko pracownika: ");
            string lastName = Console.ReadLine();
			return lastName;
        }

		public void SearchForEmployees(string lastname)
		{
			var employees = GetAllEmployess();

			foreach (var employee in employees)
			{
				if (employee.LastName == lastname)
				{
					DisplayEmployeeDetails(employee);
                }
				
			}

		}
    }
}

