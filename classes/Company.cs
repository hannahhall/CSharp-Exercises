using System;
using System.Collections.Generic;

namespace classes
{
    class Company
    {
        /*
        Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List<Employee> EmployeeList = new List<Employee>();

        // Create a method that allows external code to add an employee
        public void AddEmployee(Employee employee)
        {
            EmployeeList.Add(employee);
        }

        public void AddEmployee(List<Employee> employeeList)
        {
            EmployeeList.AddRange(employeeList);
        }

        // Create a method that allows external code to remove an employee
        public void RemoveEmployee(Employee employee)
        {
            EmployeeList.Remove(employee);
        }


        public void ListEmployee()
        {
            foreach (Employee employee in EmployeeList)
            {
                Console.WriteLine($"{employee.Name} is a {employee.JobTitle}");
            }
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company (string name, DateTime createdOn)
        {
            this.Name = name;
            this.CreatedOn = createdOn;
        }
    }
}