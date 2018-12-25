using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class HourlyEmployee: Employee
    {
        private decimal wage; // Wage per hour
        private decimal hours; // hours worked for the week

        public HourlyEmployee(string first, string last, string ssn,
            decimal hourlyWage, decimal hoursWorked)
            : base(first, last, ssn)
        {
            Wage = hourlyWage;
            Hours = hoursWorked;
        }
        public decimal Wage
        {
            get { return wage; }
            set
            {
                if (value >= 0) wage = value;
                else throw new ArgumentOutOfRangeException("Wage", value, "Wage must be >= 0");

            }
        }
        public decimal Hours
        {
            get { return hours; }
            set
            {
                if (value >= 0 && value <=168) hours = value;
                else throw new ArgumentOutOfRangeException("Hours", value, "Hours must be >= 0 and <= 168");
            }
        }
        public override decimal GetPaymentAmount()
        {
            if (Hours <= 40) return Wage * Hours;
            else return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
        }
        public override string ToString()
        {
            return string.Format("hourly employee:{0}\n{1}: {2:C}; {3}: {4:F2}",
                base.ToString(), "hourly salary", Wage, "hours worked", Hours);
        }
    }
}
