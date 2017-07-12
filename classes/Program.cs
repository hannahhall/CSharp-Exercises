using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main()
        {
            Company Target = new Company("Target", DateTime.Now);
            Employee Gary = new Employee("Gary", "Cashier", "06-14-2006");
            Employee Larry = new Employee("Larry", "Cashier", "09-03-2016");
            Employee Mo = new Employee("Mo", "Service Desk", "09-03-2013");
            Target.AddEmployee(new List<Employee>(){Gary, Larry, Mo});
            Target.ListEmployee();
        }
    }
}
