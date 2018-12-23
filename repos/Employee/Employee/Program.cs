using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program // Payroll system test using Polymorphism
    {
        static void Main(string[] args)
        {
            SalariedEmployee salaried = new SalariedEmployee
                 ("John", "Smith", "111-11-1111", 800.00M);
            HourlyEmployee hourly =new HourlyEmployee
                ("Karen", "Price","222-22-2222", 16.75M, 40.0M);
            CommissionEmployee commission =new CommissionEmployee
                ("Sue", "Jones","333-33-3333", 10000.00M, 0.06M);
            BasePlusCommissionEmployee basePlus = new BasePlusCommissionEmployee
                ("Bob", "Lewis", "444-44-4444", 10000.00M,0.04M,300.00M);

            Console.WriteLine("Employes processed individually:\n");
            Console.WriteLine("{0}\nearned: {1:C}\n",
                salaried, salaried.Earnings());
            Console.WriteLine("{0}\nearned: {1:C}\n",
                hourly, hourly.Earnings());
            Console.WriteLine("{0}\nearned: {1:C}\n",
                commission, commission.Earnings());
            Console.WriteLine("{0}\nearned: {1:C}\n",
                basePlus, basePlus.Earnings());

            Employee[] employees = new Employee[4];
            employees[0] = salaried;
            employees[1] = hourly;
            employees[2] = commission;
            employees[3] = basePlus;

            Console.WriteLine("Employees processed polymoprhically:\n");

            foreach(Employee currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee);
                if(currentEmployee is BasePlusCommissionEmployee)
                {
                    //downcast Employee reference to 
                    // BasePlusCo... referense
                    BasePlusCommissionEmployee employee=
                    (BasePlusCommissionEmployee)currentEmployee;
                    employee.BaseSalary *= 1.10M;
                    Console.WriteLine("new base salary with 10% increase is: {0:C}",
                        employee.BaseSalary);
                }// end if
                Console.WriteLine("earned {0:C}\n", currentEmployee.Earnings());
            }// end foreach
            // get typ name of each object in employees array
            for (int j = 0; j < employees.Length; j++)
                Console.WriteLine("Employee {0} is a {1}", j,
                employees[j].GetType());
        }// end main
    } // end class
}// end namespace
