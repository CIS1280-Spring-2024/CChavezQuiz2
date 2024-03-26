using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class SalaryEmployee:Employee
    {
        public decimal Salary { get; set; }

        public SalaryEmployee()
            : this("", "", 30000.0M)
        {            
        }

        public SalaryEmployee(string firstName, string lastName, decimal salary, string phone = "TBD", string email = "TBD")
            :base(firstName,lastName, phone, email)
        {
            Salary = salary; //CChavez added this line so salary will properly be set but the constructor, as it is not set in the inherited constructor
        }

        public override string PaySummary
        {
            get
            {
                return "This employee is payed " + Salary + " per year";
            }
        }

        public override decimal Pay(int start, int end)
        {
            const int  payPeriodsPerYear = 24;
            decimal pay = Salary * (end - start) / payPeriodsPerYear;
            return pay;
        }

        public override string ToString() // cchavez added Override to this sting so ToString is properly inherited
        {
            return base.ToString() + " Salary Employee";
        }
    }
}
