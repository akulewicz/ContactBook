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


        public List<Employee> GetAllEmployees()
        {
            return Employees;
        }


        public void DisplayEmployeeDetails(Employee employee)
        {
            Console.WriteLine($"{employee.Id,4} | {employee.FirstName,-12} | {employee.LastName,-12} | {employee.Departament,-30} | {employee.PhoneNumber,-12} | {employee.Email,-20}");
        }


        public void DisplayEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                DisplayEmployeeDetails(employee);
            }
            Console.WriteLine();
        }

        public Employee AddEmployeeView()
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

            Int32.TryParse(idFromInput, out int id);

            var employee = new Employee(id, firstName, lastName, departament, phoneNumber, email);

            return employee;
        }


        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }


        public string SearchForEmployeesView()
        {
            Console.WriteLine("Podaj nazwisko pracownika: ");
            string lastName = Console.ReadLine();
            return lastName;
        }


        public void SearchForEmployees(string lastname)
        {
            foreach (var employee in Employees)
            {
                if (employee.LastName == lastname)
                {
                    DisplayEmployeeDetails(employee);
                }
            }
        }

        public int RemoveEmployeeView()
        {
            Console.WriteLine("Podaj id pracownika, którego chcesz usunąć:");
            string idFromInput = Console.ReadLine();
            Int32.TryParse(idFromInput, out int id);
            return id;
        }


        public void RemoveEmployee(int id)
        {
            Employee employeeToRemove = new Employee(1, "", "", "", "", ""); 
            foreach(var employee in Employees)
            {
                if(employee.Id == id)
                {
                    employeeToRemove = employee;
                }
            }
            Employees.Remove(employeeToRemove);
        }
    }
}

