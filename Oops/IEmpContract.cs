using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oops;

namespace Oops
{
    public interface IEmpContract
    {
        int WorkHourClause();
        string SickLeaveClause();
    }
    public class kpmgEmployee  : IEmpContract
    {
        public int EmpId { get; set; }
        public  string Name { get; set; }

        public string  Designation{ get; set; }

        public string SickLeaveClause()
        {
            return "Employee is allowed to take atmost 5 sick leave per days";
        }

        public int WorkHourClause()
        {
            return 8;
        }
    }
    public class DellEmployee : IEmpContract
    {
        public int EmpId { get; set; }
        public string Name { get; set; }

        public string Designation { get; set; }

        public string SickLeaveClause()
        {
            return "Employee is allowed to take atmost 4 leave per days";
        }

        public int WorkHourClause()
        {
            return 6;
        }
    }
}

class Myclass :ParentClass, IContract1,IContract2
{

}

internal  interface IContract2
{

}
 internal interface IContract1
{

}
 internal class ParentClass
{

}
