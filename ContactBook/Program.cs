namespace ContactBook;
class Program
{
    static void Main(string[] args)
    {
        EmployeeService employeeService = new EmployeeService();

        while (true)
        {
            employeeService.AddEmployee();

            List<Employee> employees = employeeService.GetAllEmployess();

            foreach (var employee in employees)
            {
                Console.WriteLine($" {employee.Id} {employee.FirstName} {employee.LastName} {employee.Departament} ");
            }
        }

        
    }
}

