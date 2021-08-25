using EmployeesTeemProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesTeamConsole
{
    class ProjectUI
    {
        private readonly EmployeeRepo _employee = new EmployeeRepo();

        public void Run()
        {
            Menu();
        }

        public void Menu()
        {
            var keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("select from the following menu: \n" +
                    "1. Create employee profile\n" +
                    "2. View all employees\n" +
                    "3. Search for an individual employee\n" +
                    "4. Update an existing employee\n" +
                    "5. Delete an employee profile\n" +
                    "6. Exit");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateEmployee();
                        break;
                    case "2":
                        ViewAllEmployees();
                        break;
                    case "3":
                        SearchForEmployee();
                        break;
                    case "4":
                        UpdateExistingEmployee();
                        break;
                    case "5":
                        DeleteExistingEmployee();
                        break;
                    case "6":
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input: select from one of the menu options!");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }

        }
        private void CreateEmployee()
        {
            Employee newEmployee = new Employee();

            Console.WriteLine("Create an ID uniquely for the new employee:");
            string inputAsString = Console.ReadLine();
            int inputAsInt = int.Parse(inputAsString);
            newEmployee.EmpId = inputAsInt;

            Console.WriteLine("Enter the first name:");
            newEmployee.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the last name:");
            newEmployee.LastName = Console.ReadLine();

            Console.WriteLine("Enter the address:");
            newEmployee.Address = Console.ReadLine();

            Console.WriteLine("Enter the city:");
            newEmployee.City = Console.ReadLine();

            Console.WriteLine("enter the state:");
            newEmployee.State = Console.ReadLine();

            Console.WriteLine("enter a phone number:");
            newEmployee.PhoneNumber = Console.ReadLine();

            _employee.CreateEmployee(newEmployee);
        }
        private void ViewAllEmployees()
        {

            List<Employee> employeesList = _employee.GetEmployee();

            foreach (var employee in employeesList)
            {
                Console.WriteLine($"Employee ID: {employee.EmpId}\n" +
                    $"First Name: {employee.FirstName}\n" +
                    $"Last Name: {employee.LastName}");
               
            }
        }

        private void SearchForEmployee()
        {

        }

        private void UpdateExistingEmployee()
        {

        }

        private void DeleteExistingEmployee()
        {

        }
    }
}
