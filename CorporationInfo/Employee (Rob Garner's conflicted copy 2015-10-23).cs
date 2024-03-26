using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Employee
    {
        private static int LastEmpNum = 0;

        public int EmpNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string GetPaySummary()
        {
            return "No pay for base class employee.";
        }

        public override string ToString()
        {
            return EmpNum+" "+FirstName+" "+LastName;
        }
    }
}
