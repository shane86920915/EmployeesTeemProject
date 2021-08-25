using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesTeemProject
{
    public class EmployeeRepo
    {
        private readonly List<Employee> _employee = new List<Employee>();

        public void CreateEmployee(Employee employee)
        {
            _employee.Add(employee);
        }

        public List<Employee> GetEmployee()
        {
            return _employee;
        }

        public bool UpdateEmployee(int originalId, Employee newEmployee)
        {
            Employee oldEmployee = GetEmpoyeeById(originalId);
            if (oldEmployee.EmpId == originalId)
            {
                oldEmployee.EmpId = newEmployee.EmpId;
                oldEmployee.FirstName = newEmployee.FirstName;
                oldEmployee.LastName = newEmployee.LastName;
                oldEmployee.Address = newEmployee.Address;
                oldEmployee.City = newEmployee.City;
                oldEmployee.State = newEmployee.State;
                oldEmployee.PhoneNumber = newEmployee.PhoneNumber;
                return true;
            }
            return false;
        }

        public bool DeleteEmployee(int id)
        {
            Employee employee = GetEmpoyeeById(id);

            if (employee == null)
            {
                return false ;
            }
            int initialCount = _employee.Count;
            _employee.Remove(employee);
            if (initialCount > _employee.Count)
            {
                return true;
            }
            else
            {

            return false;
            }
        }

        public Employee GetEmpoyeeById(int id)
        {
            foreach (Employee employee in _employee)
            {
                if (employee.EmpId == id)
                {
                    return employee;
                }
            }
                    Console.WriteLine($"There is no employee with the ID of {id}.\n" +
                        $"Please select a valid ID!");
                    return null;
        }       
    }
}
