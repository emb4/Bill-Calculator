using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_9
{

    public class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

        // four-parameter constructor 
        public SalariedEmployee(string firstName, string Lastname,
        string socialSecurityNumber, decimal weeklySalary)
        : base(firstName, lastName, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }

    // property That gets and sets 
    public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if (value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"(nameof(WeeklySalary) must be >=0");
                }


firstName, string lastName,
decimal weeklySaIary) 
social Securi tyNumber) 
// validate salary 
salaried employee's salary 


weeklySaIary value;
// calculate earnings; override abstract method Earnings in Employee 
public override decimal Earnings() WeeklySalary; 
// return string representation of SalariedEmpIayee object 
public override string TOString()
salari ed empl oyee: {base. Tostring()} 
S"weekly salary; 
{Weekl , 
}
