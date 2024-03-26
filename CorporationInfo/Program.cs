using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee hourEmp = new HourlyEmployee("Bill", "Gates", 15.0M, 
                "111-1111", "gatesb@aserver.net");
            hourEmp.Hours.Add(80.0);
            hourEmp.Hours.Add(90.0);
            hourEmp.Hours.Add(70.0);

            DisplayEmployeeInfo(hourEmp,0,3);

            SalaryEmployee salaryEmp = new SalaryEmployee("Alan", "Turing", 40000.0M,
                "222-2222","turinga@aserver.net");
            salaryEmp.Hours.Add(80.0);
            salaryEmp.Hours.Add(80.0);
            salaryEmp.Hours.Add(80.0);

            Console.WriteLine("SalaryEmp.PaySummary: " + salaryEmp.PaySummary + "\n");

            DisplayEmployeeInfo(salaryEmp, 0, 3);

            Department dep = new Department("Sales Department",salaryEmp,"The start of all problems", 
                "333-3333","sales@aserver.net","www.amazon.com");

            PhoneBook pb = new PhoneBook();
            pb.PhoneBookEntries.Add(hourEmp);
            pb.PhoneBookEntries.Add(salaryEmp);
            pb.PhoneBookEntries.Add(dep);

            Console.WriteLine(pb.GetPhoneBook());
            Console.WriteLine("Press any key to continue."); //CChavez Added for debugging so I can see the console before it closes
            Console.ReadLine(); //CChavez Added for debugging so I can see the console before it closes
        }

        private static void DisplayEmployeeInfo(Employee emp, int PayStart, int PayEnd)
        {
            Console.WriteLine(emp.ToString());
            Console.WriteLine(emp.PaySummary);
            Console.WriteLine("Pay for periods "+ PayStart+ "-" +PayEnd+": "
                + emp.Pay(PayStart, PayEnd).ToString("c"));
            Console.WriteLine();
        }



    }
}
