using System;
/**
 * Written by Simon Lobo
 * 2018-11-24
 * DT071G Programmering med C#.NET
 * Laboration 2
**/

public class Lab2
{
    public static void Main(string[] args)
    {
        // Creating objects with different constructors
        CD noct = new CD();
        CD pars = new CD("Franz Liszt", "Parcours Satanique");
        CD allEyes = new CD("2Pac", "All Eyes on Me", "Hip Hop", 1996, "Death Row Records", 27, 132.2);

        // Filling missing properties
        noct.Artist="Frederic Chopin";
        noct.Title = "Nocturnes";
        noct.Genre = "Classical";
        noct.Year = 2010;
        noct.RecordCompany = "Sony";
        noct.NrOfSongs = 19;
        noct.Duration = 105.0;

        pars.Genre = "Classical";
        pars.Year = 2000;
        pars.RecordCompany = "Lyrinx";
        pars.NrOfSongs = 7;
        pars.Duration = 65.8;

        // Writing out brief and full versions for all three objects
        Console.WriteLine();    // Including extra (empty)line before each object for readability 
        noct.PrintBrief();

        Console.WriteLine();
        pars.PrintFull();

        Console.WriteLine();
        allEyes.PrintFull();
    }
}