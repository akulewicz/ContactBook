﻿using System;
using ConsoleTables;

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

        public int GenerateUserId()
        {
            int id = Employees.Count() + 1;

            while (true)
            {
                var employee = GetEmployeeById(id);

                if (employee.Id == id)
                {
                    id++;
                }
                break;
            }
            return id;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            Employee employeeToFind = new Employee();
            foreach (var employee in GetAllEmployees())
            {
                if (employee.Id == employeeId)
                {
                    employeeToFind = employee;
                }
            }
            return employeeToFind;
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

        public int EmployeeDetailSelectionView()
        {
            Console.WriteLine("Podaj id pracownika: ");
            string idFromInput = Console.ReadLine();
            int.TryParse(idFromInput, out int id);
            return id;
        }

        public void EmployeeDetailView(int employeeId)
        {
            var employee = GetEmployeeById(employeeId);

            var table = new ConsoleTable("Id", "Imię", "Nazwisko", "Dział", "Email", "Telefon", "Opis");
            table.AddRow(employee.Id, employee.FirstName, employee.LastName, employee.Departament, employee.Email, employee.PhoneNumber, employee.Description);
            table.Write();
            Console.WriteLine();
        }

        public Employee AddEmployeeView()
        {
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
            Console.WriteLine("Opis: ");
            string description = Console.ReadLine();

            int id = GenerateUserId();

            Employee employee = new Employee() { Id = id, FirstName = firstName, LastName = lastName, Departament = departament, Email = email, PhoneNumber = phoneNumber, Description = description };

            return employee;
        }

        public int AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            return employee.Id;
        }

        public int UpdateEmployeeSelectView()
        {
            Console.WriteLine("Podaj id pracownika: ");
            string idFromInput = Console.ReadLine();
            int.TryParse(idFromInput, out int id);
            return id;
        }

        public void UpdateEmployee(int id)
        {
            var employee = GetEmployeeById(id);

            Console.WriteLine($"Podaj nowe dane pracownika {employee.FirstName} {employee.LastName}:");
            Console.WriteLine();

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
            Console.WriteLine("Opis: ");
            string description = Console.ReadLine();

            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.Departament = departament;
            employee.Email = email;
            employee.PhoneNumber = phoneNumber;
            employee.Description = description;
        }

        public int RemoveEmployeeView()
        {
            Console.WriteLine("Podaj id pracownika, którego chcesz usunąć: ");
            string idFromInput = Console.ReadLine();
            int.TryParse(idFromInput, out int id);
            return id;
        }

        public void RemoveEmployee(int id)
        {
            var employee = GetEmployeeById(id);
            Employees.Remove(employee);
        }
    }
}

