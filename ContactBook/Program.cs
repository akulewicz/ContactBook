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
            Console.WriteLine();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var employees = employeeService.GetAllEmployess();
                    employeeService.DisplayEmployess(employees);
                    break;
                case "2":
                    employeeService.AddEmployee();
                    break;
                case "3":
                    var lastname = employeeService.SearchForEmployessView();
                    employeeService.SearchForEmployees(lastname);
                    break;
                default:
                    Console.WriteLine("Wybierz poprawną wartość");
                    break;
            }

        }
        
    }
}

