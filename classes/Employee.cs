using System;

namespace classes
{
    class Employee
    {
        public string Name;
        public string JobTitle;
        public string StartDate;

        public Employee (string name, string jobTitle, string startDate)
        {
            this.Name = name;
            this.JobTitle = jobTitle;
            this.StartDate = startDate;
        }

    }
}