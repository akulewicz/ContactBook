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
            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);
            var mainMenu = actionService.GetMenuActionsByMenyName("Main");

            foreach (var item in mainMenu)
            {
                Console.WriteLine($"{item.Id}. {item.Name} ");
            }

            
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
                case "5":
                    return;
                default:
                    Console.WriteLine("Wybierz poprawną wartość");
                    break;
            }

        }
        
    }

    public static MenuActionService Initialize(MenuActionService actionService)
    {
        actionService.AddNewAction(1, "Wyświetl wszystkich pracowników", "Main");
        actionService.AddNewAction(2, "Dodaj pracownika", "Main");
        actionService.AddNewAction(3, "Wyszukaj pracownika", "Main");
        actionService.AddNewAction(4, "Usuń pracownik", "Main");
        actionService.AddNewAction(5, "Wyjście", "Main");

        return actionService;
    }
}

