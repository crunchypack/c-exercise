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
            IPayable[] payableObjects = new IPayable[4];
            payableObjects[0] = new Invoice("GE001", "dildo", 2, 399.99M);
            payableObjects[1] = new Invoice("GE023","black giant",2,599.00M);
            payableObjects[2] = new SalariedEmployee("Simon","lobo","562-23-2341",1200M);
            payableObjects[3] = new SalariedEmployee("Jorgen", "Klopp", "322-55-9875", 900M);

            Console.WriteLine("Processed Polymorphically");


            foreach(var currentPay in payableObjects){
                Console.WriteLine("{0}\npayment due: {1:C}\n",
                    currentPay, currentPay.GetPaymentAmount());
            }


        }// end main                                                      
    } // end class
}// end namespace
