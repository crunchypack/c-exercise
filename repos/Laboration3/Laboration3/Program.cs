using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Written by Simon Lobo
 * 2018-12-13
 * Course DT071G Programmering i C#.NET
 * Laboration 3
 */

class Program
{
    static void Main(string[] args)
    {   
        // Gravitations konstanten
        const double GRAVITY = 9.81;
        // Programmet ger användaren val av svårighetsgrad och ger antal kast baserat på input
        Console.WriteLine("Välj svårighetsgrad.\n1. Enkel\n2. Normal\n3. Svår");
        int difficulty = Convert.ToInt32(Console.ReadLine());
        // Variabler initieras för att de kommer att ändra beroende på användar input
        // antal kast man får, och min- och max-vind
        int nrOfThrows = 0;
        double minW = -1;
        double maxW = 1;
        
        // Lämplig utskrift och antal kast sätts med en switch 
        // intervall för vindhastighet ändras beroende på svårighet
        switch (difficulty)
        {
            case 1:
                Console.WriteLine("Du har valt enkel. Du får tio kast");
                nrOfThrows = 10;
                minW = -1;
                maxW = 1;
                break;
            case 2:
                Console.WriteLine("Du har valt normal. Du får åtta kast");
                nrOfThrows = 8;
                minW = -3;
                maxW = 3;
                break;
            case 3:
                Console.WriteLine("Du har valt svår. Du får fem kast");
                nrOfThrows = 5;
                minW = -5;
                maxW = 5;
                break;
            default:
                Console.WriteLine("Du har inte valt rätt. Du får tio kast");
                nrOfThrows = 10;
                minW = -1;
                maxW = 1;
                break;
        }
        // En array ska lagra de olika avstånden från apan man har kastat
        double[] throws = new double[nrOfThrows];

        // Slumpmässig nummergenererare för vindhastigheten
        Random rand = new Random();

        // Avståndet till apan i meter
        int monkeyLocation = 100;

        // Poäng räknare
        int points = 0;

        // Vi kan använda nrOfThrows men det funkar lika bra att använda array-längden.
        // Varje kast sker i en loop
        for(int count = 0; count < throws.Length; count++)
        {
            // Vindstyrkan ändras i början av varje loop/kast
            double w = rand.NextDouble() * (maxW - minW) + minW;
            // Avståndet, vindhastigheten och grativationskraften skrivs i början av varje kast
            Console.WriteLine("Avståndet till apan är {0} meter ifrån dig och vindhastigheten är {1:F}m/s (Negativ är motvind, kräver mer exempelvis högre styrka) \nTänk på att gravitationskraften är {2}m/s2", monkeyLocation, w*-1,GRAVITY);
            Console.Write("Hur mycket styrka ska du använda i kastet? (m/s): ");
            // användaren skriver in utgångshastigheten som lagras i en double
            double v = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ange vinkeln på ditt kast i grader: ");
            // Användaren skriver in vinkeln i grader som sedan omvandlas till radianer, Math.PI används för att få konstanten Pi
            double a = Convert.ToDouble(Console.ReadLine()) * Math.PI / 180;
            // Resultat lagras med hjälp av formeln från laborations uppgiften
            // Math.Sin och Math.Cos används för att få sin och cos respektive
            double result = 2 * v * v * Math.Cos(a) * Math.Sin(a) / GRAVITY - w * v * Math.Sin(a) / GRAVITY;
            // Vi lagrar avståndet mellan apan och vart bananen landade. Det skrivs sedan ut.
            // Math.Abs används för att få absolut värde ( inga negativa tal ) 
            double hitOrMiss = monkeyLocation - result;
            Console.WriteLine("Din kast landande {0} meter från apan", Math.Abs(hitOrMiss));
            // Avståndet sparas i en array
            throws[count] = hitOrMiss;

            if (hitOrMiss >= -1 && hitOrMiss <= 1)
            {
                // Om kastet var inom en meter av apan så visas en grön text
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Du träffade apan!");
                
                // poäng läggs till
                points++;
                // text färgen på konsolen återställs
                Console.ResetColor();
            }
            else
            {
                // Om kastet är för lång ifrån apan så visas en röd text 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du har missat apan!");
                Console.ResetColor();
               
            }
            // Apan förflyttas 10 meter närmare
            monkeyLocation -= 10;
            
        }
        // Om man har fått minst 5 poäng så vinner man en kram, annars äts man upp
        // Färgen på texten ändras baserat på om man vinner eller inte
        if (points >= 5)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Du får en stor apkram!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Apan åt upp dig");
            Console.ResetColor();

        }
        // Rubriker skrivs ut för en tabell som visar resultat på de olika kasten
        Console.WriteLine("{0,17} {1,25}", "Avstånd till apan", "Antal meter från apan");
        // Alla kast lagrades i en array som nu vi loopar igenom
        for(int loop = 0; loop < throws.Length; loop++)
        {
            // En sträng deklarareras för att lagra resultatet tillsammans med text
            string t;
            if(throws[loop] < 0)
            {
                // Om resultatet av kastet är negativt så har man kastat "för långt" 
                // bananen har landat bakom apan 
                // Math.Abs används för att få absolut värde ( få bort negativa tecknet ) 
                t = Math.Abs(throws[loop]).ToString("F");
                // Denna text läggs till i strängen, man kan skippa detta och lägga till direkt i utskriften efter.
                t = t + " meter bakom apan";
            }
            else if (throws[loop] > 0)
            {
                // Är resultatet positiv så har man inte kastat lång nog
                // bananen har landat framför apan
                t = throws[loop].ToString("F");
                t = t + " meter framför apan";
            }
            else
            {
                // I den väldigt osannolika händelsen att man träffar exakt på apan så skrivs detta ut
                t = "mitt i prick";
            }
            if(throws[loop]>= -1 && throws[loop]<= 1)
            {
                // Har man träffat apan så blir utskriften i grönt
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0,17} {1,25}", (monkeyLocation + throws.Length * 10) - (loop * 10) + " meter", t);
                Console.ResetColor();
            }
            else
            {
                // Har man missat så blir utskriften i rött
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0,17} {1,25}", (monkeyLocation + throws.Length * 10) - (loop * 10) + " meter", t);
                Console.ResetColor();
            }
            

        }

        
    }
}
