using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_list1
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string Designation { get; set; }

        public override string ToString()
        {
            return this.Name + " " + 
                this.Age.ToString() + ", " + 
                this.Salary.ToString() + "@" + 
                this.Designation;
        }
    }

    // sorts 2 employees based on name
    class NameSorter : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name); 
            // Using built-in string comparison for 2 names
        }
    }

    // sorts 2 employees based on age
    class AgeSorter : IComparer<Employee>
    {

        public int Compare(Employee x, Employee y)
        {
            if (x.Age > y.Age)
                return 1; // x should come after y if sorted in ascending order.
            else if (x.Age < y.Age)
                return -1;// x should come before y if sorted in ascending order.
            else
                return 0;// both are equal, no swaps necessary.
        }
    }

    // sorts 2 employees based on salary
    class SalarySorter : IComparer<Employee>
    {

        public int Compare(Employee x, Employee y)
        {
            if (x.Salary > y.Salary)
                return 1; // x should come after y if sorted in ascending order.
            else if (x.Salary < y.Salary)
                return -1;// x should come before y if sorted in ascending order.
            else
                return 0;// both are equal, no swaps necessary.
        }
    }

    // sorts 2 employees based on designation
    class DesignationSorter : IComparer<Employee>
    {

        public int Compare(Employee x, Employee y)
        {
            return x.Designation.CompareTo(y.Designation);// built-in implementation for comparing 2 strings.
        }
    }
}
