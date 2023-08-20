namespace ContactBook;

class Program
{
    static void Main(string[] args)
    {
        MenuActionService actionService = new MenuActionService();
        EmployeeService employeeService = new EmployeeService();

        actionService = Initialize(actionService);
        var mainMenu = actionService.GetMenuActionsByMenuName("Main");

        Console.WriteLine("Baza pracowników");

        while (true)
        {
            foreach (var item in mainMenu)
            {
                Console.WriteLine($"{item.Id} | {item.Name}");
            }

            string option = Console.ReadLine();

            Int32.TryParse(option, out int choice);

            switch (choice)
            {
                case 1:
                    var employees = employeeService.GetAllEmployees();
                    employeeService.DisplayEmployees(employees);
                    break;
                case 2:
                    Console.WriteLine("Wyświetl szczegóły wybranego pracownika");
                    break;
                case 3:
                    Console.WriteLine("Dodaj pracownika");
                    var employee = employeeService.AddEmployeeView();
                    employeeService.AddEmployee(employee);
                    break;
                default:
                    Console.WriteLine("Usuń pracownika");
                    break;
            }
        }
    }

    public static MenuActionService Initialize(MenuActionService actionService)
    {
        actionService.AddNewAction(1, "Wyświetl listę pracowników", "Main");
        actionService.AddNewAction(2, "Wyświetl szczegóły pracownika", "Main");
        actionService.AddNewAction(3, "Dodaj pracownika", "Main");
        actionService.AddNewAction(4, "Usuń pracownika", "Main");

        return actionService;
    }
}

