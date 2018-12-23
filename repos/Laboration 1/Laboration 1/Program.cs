using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Written by Simon Lobo
 * 2018-11-14
 * Course DT071G Programmering i C#.NET
 * Laboration 1
 */


    

namespace Laboration_1
{
    class Program
    {
        ///  This is a program that calculates how long it would take you to shovel your driveway
        static void Main(string[] args)
        {
            // Declaring variables
            double width;
            double height;
            double sqmph;
            // Welcome the user
            Console.WriteLine("Välkommen till skottnings programmet \n");

            // Prompt the user to get width, height, and the users stamina
            Console.Write("Hur bred är din garage (meter): ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nHur djup är din garage (meter): ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nHur många kvadratmeter orkar du skotta per timma: ");
            sqmph = Convert.ToDouble(Console.ReadLine());

            // Make the calculations
            double area = width * height;
            // Getting the time in minutes 
            double timeMinutes = (area / sqmph) * 60;
            // Using TimeSpan.FromMinutes to get the time in hours, minutes and seconds
            TimeSpan ts = TimeSpan.FromMinutes(timeMinutes);
            Console.WriteLine("\nDet kommer att ta dig {0:%h} timma(r) {0:%m} minut(er) {0:%s} sekund(er) att skotta", ts );
        }
    }
}
