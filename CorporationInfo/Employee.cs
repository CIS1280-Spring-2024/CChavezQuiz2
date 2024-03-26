using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{    
    public abstract class Employee: IPhoneBookItem // CChavez adde Public here to prevent a Compiler Error CS0060
    {
        private static int LastEmpNum = 0;
        public int EmpNum { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private List<double> hours = new List<double>();

        public List<double> Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        
        public Employee():this("","")
        {
        }

        public Employee(string firstName, string lastName, string phone = "TBD", string email = "TBD")
        {
            FirstName = firstName;
            LastName = lastName;
            EmpNum = LastEmpNum++;
            Phone = phone;
            Email = email;
        }
        public virtual string PaySummary
        {
            get { return "No pay for base class employee."; }
        }

        public abstract Decimal Pay(int start, int end);

        public override string ToString()
        {
            return EmpNum + " " + FirstName + " " + LastName;
        }

        public string Phone { get; set; }
        public string Email { get; set; }

        public string GetContactSummary()
        {
            return FirstName + " " + LastName + "\n" +
                   "Phone: " + Phone + "\n" +
                   "Email: " + Email;
        }


    }
}
