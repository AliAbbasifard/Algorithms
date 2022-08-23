using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    //1: ComparablePattern[] x = new ComparablePattern[];
    //2: Array.Sort(employees, new ComparablePattern());
    public class Employee
    {
        public int ID;
        public string EmployeeName;
        public Employee(int id, string employeename)
        {
            this.ID = id;
            this.EmployeeName = employeename;
        }
    }

    public class ComparablePattern : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            var result = x.EmployeeName[0].CompareTo(y.EmployeeName[0]);

            // for ascending return result
            return result;

            // for descending
            //return result * -1;
        }
    }
}
