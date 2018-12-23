using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CD
{
    // Declaring properites, making them private since only the class will handle them.
    private string artist;
    private string title;
    private string genre;
    private int year;
    private string recordCompany;
    private int nrOfSongs;
    private double duration;
    // Creating three different constructors
    public CD()
    {
        // Empty constructor, default values.
        Artist = "";
        Title = "";
        Genre = "";
        Year = 0;
        RecordCompany = "";
        NrOfSongs = 0;
        Duration = 0.0;
    }
    public CD(string art, string tit)
    {
        // constructor with artist and title. Other properties set to default
        Artist = art;
        Title = tit;
        Genre = "";
        Year = 0;
        RecordCompany = "";
        NrOfSongs = 0;
        Duration = 0.0;
    }
    public CD(string art, string tit, string gen, int yr, string reC, int nrS, double dur)
    {
        //Full constructor all properties set
        Artist = art;
        Title = tit;
        Genre = gen;
        Year = yr;
        RecordCompany = reC;
        NrOfSongs = nrS;
        Duration = dur;
    }
    // Manipulation of properties, GET and SET.
    public string Artist
    {
        get
        {
            return artist;
        }
        set
        {
            if (value != "") artist = value; 
            else artist = "Unknown";    // Default value if no real value is set.
        }
    }
    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            if (value != "") title = value;
            else title = "Unknown";
        }
    }
    public string Genre
    {
        get
        {
            return genre;
        }
        set
        {
            if (value != "") genre = value;
            else genre = "Generic";
        }
    }
    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            if (value >= 1860) year = value;
            else year = 1860;
        }
    }
    public string RecordCompany
    {
        get
        {
            return recordCompany;
        }
        set
        {
            if (value != "") recordCompany = value;
            else recordCompany = "Unknown";
        }
    }
    public int NrOfSongs
    {
        get
        {
            return nrOfSongs;
        }
        set
        {
            if (value >= 0) nrOfSongs = value;
            else nrOfSongs = 1;
        }
    }
    public double Duration
    {
        get
        {
            return duration;
        }
        set
        {
            if (value >= 0.5) duration = value;
            else duration = 0.5;
        }
    }
    // Methods for printing objects properties
    public void PrintBrief()
    {
        // Brief print with only Artist, title and year
        Console.WriteLine("\n{0}, {1} ({2})", Artist, Title, Year);
    }
    public void PrintFull()
    {
        // Full print with all properties
        Console.WriteLine("Artist:{0} \nTitle: {1} \nGenre:{2} \nRelease year:{3} \nRecord company: {4} \nNumber of songs: {5} \nAlbum duration: {6} minutes", Artist, Title, Genre, Year, RecordCompany, NrOfSongs, Duration);
    }

}
