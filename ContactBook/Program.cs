using System.Diagnostics.Metrics;

namespace ContactBook;
class Program
{
    static void Main(string[] args)
    {
        EmployeeService employeeService = new EmployeeService();

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("| Baza pracowników Najlepszej Firmy |");
        Console.WriteLine("-------------------------------------");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Wyświetl wszystkich pracowników");
            Console.WriteLine("2. Dodaj pracownika");
            Console.WriteLine("3. Wyszukaj pracownika");
            Console.WriteLine("4. Usuń pracownika");
            Console.WriteLine();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var employees = employeeService.GetAllEmployees();
                    employeeService.DisplayEmployees(employees);
                    break;
                case "2":
                    var employee = employeeService.AddEmployeeView();
                    employeeService.AddEmployee(employee);
                    break;
                case "3":
                    var lastname = employeeService.SearchForEmployeesView();
                    employeeService.SearchForEmployees(lastname);
                    break;
                case "4":
                    var id = employeeService.RemoveEmployeeView();
                    employeeService.RemoveEmployee(id);
                    break;
                default:
                    Console.WriteLine("Wybierz poprawną wartość");
                    break;
            }

        }
        
    }
}

