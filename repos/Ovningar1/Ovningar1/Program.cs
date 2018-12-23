using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovningar1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(12 * 3 / 4);
            // Console.WriteLine(3 / 4 * 12); // Funkar inte eftersom det är hela tal vi använder
            // C# läser den så här 3 / 4 = 0... 0 * 12 = 0
            // Console.WriteLine(3.0 / 4.0 * 12.0);// Nu får vi rätt svar för att vi använder decimaltal
            // C# läser den så här 3.0 / 4.0 = 0.75.. 0.75 * 12= 9
            // Console.WriteLine(11%5);
            // Console.WriteLine(123 % 5);
            // Console.WriteLine(1028 % 10);
            // Console.WriteLine(1029 % 10);
            // Console.WriteLine(1030 % 10);
            // Console.WriteLine(1031 % 10);
            // Console.WriteLine(1032 % 10);
            // Modulus 10 kan beskrivas som att få fram sista siffran av ett heltal
            Console.Write("ENTER 5 digit number: ");
            int nr = Convert.ToInt32(Console.ReadLine());
            int first = nr % 10;
            nr = nr / 10;
            int second = nr % 10;
            nr = nr / 10;
            int third = nr % 10;
            nr = nr / 10;
            int fourth = nr % 10;
            nr = nr / 10;
            int fifth = nr % 10;
            Console.WriteLine("{0}   {1}   {2}   {3}   {4}", fifth,fourth,third,second, first);
        }
    }
}
