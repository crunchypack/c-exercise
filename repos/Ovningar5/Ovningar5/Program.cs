using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovningar5
{
    class Program
    {
        static void Main(string[] args)
        {
            Ovning8_12();
        }
        public static void Ovning1()
        {
            Console.WriteLine("Enter ten numbers:");
            int[] numbers = new int[10];
            string[] numberName = { "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth" };
            for(int count = 0; count < numbers.Length; count++)
            {
                Console.Write("Enter the {0} number: ", numberName[count]);
                numbers[count] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int tmp = numbers[i];
                numbers[i] = numbers[numbers.Length - i - 1];
                numbers[numbers.Length - i - 1] = tmp;
            }
            Console.WriteLine("{0,5}{1,8}", "Index", "Value");
            
            for(int count = 0; count < numbers.Length; count++)
            {
                Console.WriteLine("{0,5} {1,7:D2}", count, numbers[count]);
            }
        }
        /*Use a one-dimensional array to solve the following problem:
          Write an app that inputs five numbers, each of which is between 10 and 100, inclusive. As each
          number is read, display it only if it’s not a duplicate of a number already read. Provide for the “worst
          case,” in which all five numbers are different. Use the smallest possible array to solve this problem.
          Display the complete set of unique values input after the user inputs each new value.
       */
        public static void Ovning8_12()
        {
            int[] numbers = new int[5];          
            int number = 0;
            bool numberDup = false;
            int count = 0;

            while(count < 5)
            {
                numberDup = false;
                Console.Write("Please enter a number between 10 and 100: ");
                number = Convert.ToInt32(Console.ReadLine());
                while(number < 10 || number > 100)
                {
                    Console.Write("Number not supported. Please enter a number between 10 and 100: ");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                for(int i = 0; i< numbers.Length; i++)
                {
                    if (number == numbers[i]) numberDup = true;  
                }

                if (!numberDup) numbers[count] = number;
                Console.Write("Non duplicate numbers:");
                foreach (int num in numbers)
                {
                    if (num >= 10)
                        Console.Write(num + " ");
                }
                Console.WriteLine();
                
                count++;
            }
            Console.ReadLine();
        }
    }
}
