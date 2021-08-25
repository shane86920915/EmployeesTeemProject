using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesTeemProject
{
    public class Employee

    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }

        public Employee()
        {

        }

        public Employee(int empId, string firstName, string lastName, string address, string city, string state, string phoneNumber)
        {
            EmpId = empId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            PhoneNumber = phoneNumber;
        }
    }
}
