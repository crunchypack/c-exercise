using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Console.Write("Enter number: ");
               int number = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("The number is {0}", Even(number));
               Console.Write("Enter number to get all even number up to it: ");
               int evenStop = Convert.ToInt32(Console.ReadLine());
               EvenIm(evenStop);
            */
            SquareDraw();


        }
        private void Singular()
        {
            decimal amount;
            decimal principal = 1000;
            double rate = 0.05;

            Console.WriteLine("Year{0,20}", "Amount on deposit");

            for (int year = 1; year <= 10; ++year)
            {
                amount = principal * ((decimal)Math.Pow(1.0 + rate, year));
                Console.WriteLine("{0,4}{1,20:C}", year, amount);
            }
        }
        private static void Square()
        {
            Console.Write("Input last number: ");
            int lastNumber = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i< lastNumber; i++)
            {
                var square = (i + 1) * (i + 1);
                Console.WriteLine("{0} * {0} = {1}", i+1, square);
            }
        }
        private static void SqareIm()
        {
            Console.WriteLine("Enter number to get the square enter -1 to cancel");
            int number = Convert.ToInt32(Console.ReadLine());
            while(number != -1)
            {
                Console.WriteLine(number * number);
                Console.WriteLine("Enter number to get the square enter -1 to cancel");
                number = Convert.ToInt32(Console.ReadLine());

            }
        }
        private static void Hello()
        {
            Console.Write("How many times should we write hello?: ");
            int nrOfHello = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < nrOfHello; i++)
            {
                Console.WriteLine("Hello");
            }
        }
        private static void HelloIm()
        {
            Console.WriteLine("Hello");
            Console.Write("Write out greeting again ?(yes/no)");
            string answ = Console.ReadLine();
            while (answ == "yes" || answ == "y" || answ == "Yes" || answ == "Y") {
                Console.WriteLine("Hello");
                Console.Write("Write out greeting again ?(yes/no)");
                answ = Console.ReadLine();
            }
        }
        private static string Even(int n)
        {
            string s;

            if (n % 2 == 0)
            {
                 s = "Even";
            }
            else  s = "Uneven";
            return s;
        }
        private static void EvenIm(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }
        }
        private static void LoopNumber()
        {
            int i = 0;
            int sum = 0;
            int temp = 0;
            int big = 0;
            int n = 0;
            Console.WriteLine("Type in 5 numbers");
            while ( i < 5)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > big) big = n;

                temp = n;
                sum += n;
                i++;
            }
            double med = (double)sum / 5;
            Console.WriteLine("Largest number: {0}", big);
            Console.WriteLine("Sum of numbers: {0}", sum);
            Console.WriteLine("Average value: {0}", med);
        }
        private static void Backwards()
        {
            Console.Write("Enter any number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            int reverse = 0;

            while(number != 0)
            {
                temp = number % 10;
                reverse = reverse * 10 + temp;
                number /= 10;
            }
            Console.WriteLine(reverse);
        }
        private static void Factorial()
        {
            Console.Write("Enter any positive number ");
            int number = Convert.ToInt32(Console.ReadLine());
            int facto = 1;
            for(int i = 1; i <= number; i++)
            {
                facto = facto * i;
                if (i != number)
                    Console.Write("{0} * ", number - i + 1);
                else Console.Write(number - i + 1);
            }
            Console.Write(" = ");
            Console.WriteLine(facto);
        }
        private static void SquareDraw()
        {
            Console.Write("How big should the Sqare be?: ");
            int squareSize = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < squareSize; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < squareSize; i++)
            {
                if (i == 0 || i == squareSize - 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < squareSize; i++)
            {
                Console.Write("*");
                if (i == squareSize - 1)
                    Console.WriteLine(" ");
            }

        }
    }
}
