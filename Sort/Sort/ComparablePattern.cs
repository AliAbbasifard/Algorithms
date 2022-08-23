using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    //1: ComparablePattern[] x = new ComparablePattern[];
    //2: Array.Sort(x);
    public class ComparablePattern : IComparable<ComparablePattern>
    {
        public int ID;
        public string EmployeeName;
        public ComparablePattern(int id, string employeename)
        {
            this.ID = id;
            this.EmployeeName = employeename;
        }

        public int CompareTo(ComparablePattern other)
        {
            var t = this;
            return this.EmployeeName[0].CompareTo(other.EmployeeName[0]);
        }
    }
}
