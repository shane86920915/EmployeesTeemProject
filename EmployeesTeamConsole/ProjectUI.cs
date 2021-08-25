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
        private readonly Employee _employee = new Employee();

        public void Run()
        {

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
                    "6. Exit" );

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

            }

        }
        private void CreateEmployee()
            {

            }
        private void ViewAllEmployees()
        {

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
