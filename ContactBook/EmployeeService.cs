using System;
using ConsoleTables;

namespace ContactBook
{
	public class EmployeeService
	{
		public EmployeeService()
		{
			employees = new List<Employee>();
		}

		List<Employee> employees;

		public List<Employee> GetAllEmployees()
		{
			return employees;
		}

		public void DisplayEmployees(List<Employee> employees)
		{
            var table = new ConsoleTable("Id", "Imię", "Nazwisko", "Dział", "Email", "Telefon");

            foreach (var employee in employees)
            {
                table.AddRow(employee.Id, employee.FirstName, employee.LastName, employee.Departament, employee.Email, employee.PhoneNumber);
            }

            table.Write();
            Console.WriteLine();
        }

		public Employee AddEmployeeView()
		{
			Console.WriteLine("Id: ");
			string idFromInput = Console.ReadLine();
			Console.WriteLine("Imię: ");
			string firstName = Console.ReadLine();
			Console.WriteLine("Nazwisko: ");
			string lastName = Console.ReadLine();
			Console.WriteLine("Wydział: ");
			string departament = Console.ReadLine();
			Console.WriteLine("Email: ");
			string email = Console.ReadLine();
			Console.WriteLine("Telefon: ");
			string phoneNumber = Console.ReadLine();

			Int32.TryParse(idFromInput, out int id);

			Employee employee = new Employee() { Id = id, FirstName = firstName, LastName = lastName, Departament = departament, Email = email, PhoneNumber = phoneNumber };

			return employee;
		}

		public void AddEmployee(Employee employee)
		{
			employees.Add(employee);
		}
	}
}

