﻿namespace ContactBook;

class Program
{
    static void Main(string[] args)
    {
        MenuActionService actionService = new MenuActionService();
        EmployeeService employeeService = new EmployeeService();

        actionService = Initialize(actionService);
        var mainMenu = actionService.GetMenuActionsByMenuName("Main");

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("| Baza pracowników Najlepszej Firmy |");
        Console.WriteLine("-------------------------------------");

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
                    var detailId = employeeService.EmployeeDetailSelectionView();
                    employeeService.EmployeeDetailView(detailId);
                    break;
                case 3:
                    var employeeId = employeeService.AddEmployeeView();
                    var newEmployeeId = employeeService.AddEmployee(employeeId);
                    break;
                case 4:
                    var updateId = employeeService.UpdateEmployeeSelectView();
                    employeeService.UpdateEmployee(updateId);
                    break;
                case 5:
                    var removeId = employeeService.RemoveEmployeeView();
                    employeeService.RemoveEmployee(removeId);
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa opcja");
                    break;
            }
        }
    }

    public static MenuActionService Initialize(MenuActionService actionService)
    {
        actionService.AddNewAction(1, "Wyświetl listę pracowników", "Main");
        actionService.AddNewAction(2, "Wyświetl szczegóły pracownika", "Main");
        actionService.AddNewAction(3, "Dodaj pracownika", "Main");
        actionService.AddNewAction(4, "Edytuj pracownika", "Main");
        actionService.AddNewAction(5, "Usuń pracownika", "Main");

        return actionService;
    }
}

