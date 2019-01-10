using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
/**
 * Modifierad av Simon Lobo
 * 2019-01-19
 * DT071G Programmering med C#.NET
 * Laboration 5
 **/
namespace BounceNew
{
    public partial class BounceNew : Form
    {
        //Deklarerar de olika variabler som krävs
        //Boolean running som används för kontrollera om applikationen är igång eller inte
        private bool running;
        // De två bollarna som ska studsa
        Ball b1;
        // Backgrundsarbetare som gör det möjligt att köra operationer på en annan tråd
        BackgroundWorker worker;
        // En delegat för en metod som tar Ball som parameter
        private delegate void MoveBallCallback(Ball b);
        // Svårighet, vind och poäng
        private bool difficulty;
        private double wind;
        private int score;
        Random random = new Random();
        // antal kast 
        private int throws;
        // sträng som kommer hålla poäng
        public string setScore;
        
        // sträng som kommer att hålla svårighet
        private string diff;
        

        public BounceNew()
        {
            InitializeComponent();
            // Ställer in gravitationen på bollarna baserat på vad som finns på vår NumericUpDown.
            // Använder cast double för att få rätt typ
            Ball.gravity = (double)gravityUpDown.Value;

            // FromFile kräver att man ställer in filerna i Projektet att Copy to Output Directory.
            // högerklicka bilderna / Properties 
            b1 = new Ball(Image.FromFile("images/ball.png"));
            score = 0;
            // Lägger till bollarna på panelen
            panel.Controls.Add(b1);
            difficulty = true;
            throws = 10;
            diff = "Easy";
            scoreLabel.Text = $"Score: {score}";
            // När spelet laddar körs denna kod, vi kallar resetBall() senare som innehåller samma kod
            b1.Location = new Point(10, 300);
            b1.speedX = (double)throwForce.Value;
            b1.speedY = -(double)throwUpForce.Value;

           
            running = false;

            if (difficulty)
            {
                wind = random.NextDouble() * 10 - 5;
            }
            else
            {
                double max = 4;
                double min = -8;
                wind = random.NextDouble() * (max - min) + min;
            }

            windLabel.Text = "Wind: " + string.Format("{0:0.0} m/s", wind);
            // Initierar bollarna till rätt positioner
            b1.Start();

        }

        // Så länge spelaren inte avslutar så kallas denna metod för att återställa bollen och hämta ny vind
        private void ResetBall()
        {
            // Måste använda Invoke för att köra på samma tråd, 
            //Invoke kommer att användas igenom koden när vi ändrar labels och liknande också
            b1.Invoke(new Action(() => b1.Location = new Point(10, 300)));
            b1.Location = new Point(10, 300);
            b1.speedX = (double)throwForce.Value;
            b1.speedY = -(double)throwUpForce.Value;

            running = false;
            if (difficulty)
            {
                wind = random.NextDouble() * 10 - 5;
            }
            else
            {
                double max = 4;
                double min = -8;
                wind = random.NextDouble() * (max - min) + min;
            }
            
            windLabel.Invoke(new Action(()=>windLabel.Text = "Wind: " + string.Format("{0:0.0} m/s", wind)));
           
            b1.Start();
        }

        // Klick på Go knappen
        private void goButton_Click(object sender, EventArgs e)
        {
            // Om applikationen är redan igång så stoppas den
            if (running == true)
            {
                // Original värden för bollarna och bool variabeln running, minus en kast 
                throws--;
                nrOfThrows.Invoke(new Action(() => nrOfThrows.Text = $"Throws: {throws}"));
                b1.Location = new Point(10, 300);
                b1.speedX = (double)throwForce.Value;
                b1.speedY = -(double)throwUpForce.Value;
                running = false;
                b1.Start();
               
                return;
            }
            // Ställ in styrkan, både mot mål och uppåt
            b1.speedX = (double)throwForce.Value;
            b1.speedY = -(double)throwUpForce.Value ;
            // Vi sätter running till true
            running = true;

            // Följande kodrader gör så att metoden RunMe körs i en separat tråd
            // så att det inte påverkar applikationens flöde.
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(RunMe); // knyt metoden RunMe till worker
            worker.RunWorkerAsync(); // starta
        }
        // Metoden RunMe hanterar vad som sker när spelet är igång
        public void RunMe(object sender, DoWorkEventArgs e)
        {
            // Så länge som running är true
            // Beroende på hastigheten och läget på bollarna så åkallar vi olika metoder
            while (running)
            {
                // Om bollen når botten så avslutas kastet och man får inga poäng
                if (b1.speedY > 0 && b1.Location.Y > panel.Size.Height - b1.Size.Height)
                {
                    throws--;
                    running = false;
                }
                // Om bollen nuddar kanten till höger endast en poäng ges
                if (b1.speedX > 0 && b1.Location.X > panel.Size.Width - b1.Size.Width)
                {
                    score++;
                    throws--;
                    running = false;
                }
                // Om bollen nuddar kanten till vänster 
                if (b1.speedX < 0 && b1.Location.X < 0)
                {
                    throws--;
                    running = false;
                }
                // Skapa en rektangel där vårt mål finns
                var rect = new Rectangle(
                    targetBox.Location.X,
                    targetBox.Location.Y,
                    targetBox.Width/2,
                    targetBox.Height/2
                    );
                // Om den träffas så får man 2 poäng
                var targetHit = rect.Contains(b1.Location.X, b1.Location.Y);
                if (targetHit)
                {
                    score += 2;
                    throws--;
                    running = false;
                }
                b1.PosX += wind;

                
                // Anropa Moveball för att få bollarna att röra på sig
                this.Invoke(new MoveBallCallback(MoveBall), b1);
                //this.Invoke(new MoveBallCallback(MoveBall), b2);
                Thread.Sleep(10);
            }
            nrOfThrows.Invoke(new Action(() => nrOfThrows.Text = $"Throws: {throws}"));
            scoreLabel.Invoke(new Action(() => scoreLabel.Text = $"Score: {score}"));
            // Lagring av poäng i sträng
            setScore = score.ToString();
            // När kasten tar slut
            if (throws == 0)
            {
                // Kalla metod som sparar poängen
                saveHighScore();
                
                // Dialog som frågar om man vill fortsätta
                var result = MessageBox.Show("No more balls \n New Game?","Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.No)
                {
                    // Vill man inte så stängs applikation ner.
                    Application.Exit();
                }
                // Radera alla items i listviewitem 
                highScoreView.Invoke(new Action(()=>highScoreView.Items.Clear()));
                // Kalla metod beroende på svårigheten som är inställd.              
                if (difficulty) easyDif();
                else hardDif();
                // Metod som fyller listviewitems med poängen
                getHighScores();

            }
            // återställ bollen
            ResetBall();

        }
        
        // Spara poäng metoden
        private void saveHighScore()
        {
            // Sökvägen ställs in till nuvarande mapp (för mig Bounce/bin/Debug/) med textfilen highscore.txt
            string path = Directory.GetCurrentDirectory() + @"\highscore.txt";
            // Två listor skapas en som ska ha nuvarande poängen
            // En som ska ha de uppdaterade
            List<string> scores = new List<string>();
            List<string> newscores = new List<string>();
            // Om textfilen inte finns 
            if (!File.Exists(path))
            {
                // Filen skapas 
                using (StreamWriter writer = File.CreateText(path))
                {
                    // Första raden ska användas för kolumner
                    writer.WriteLine("HighScore,Name,Difficulty");
                    writer.Close();
                }
                //nuvarande poängen sparas i behörig lista
                newscores.Add(setScore + "," + nameInput.Text + "," + diff);
            }
            // textfilen finns redan
            else
            {
                // Läs in filen
                using (StreamReader reader = new StreamReader(path))
                {
                    // Första raden läses bort, det är våra kolumner
                    reader.ReadLine();
                    // Så länge det finns rad att läsa
                    while (reader.Peek()>=0)
                    {
                        // Lägg till raden i behörig lista: nuvarande poängen
                        scores.Add(reader.ReadLine());
                    }
                    // Stäng läsaren
                    reader.Close();
                    // boolean som ska kontrollera att endast en gammal poäng ska försvinna.
                    bool done = true;
                    int oldscore = 0;
                    // Om det finns mer än tio sparade poäng
                    if(scores.Count >= 10)
                    {
                        // Och om det svårigheten är inte svår
                        if(diff != "Hard")
                        {
                            // Kontrollera varje rad av poäng
                            foreach (var item in scores)
                            {
                                // Om den kontrollerade poänge är inte för svårigheten Hard
                                if (item.Substring(item.Length - 4) != "Hard")
                                {
                                    try
                                    {
                                        // försök omvandla de två första karaktärerna i strängen till int
                                        oldscore = Int32.Parse(item.Substring(0, 2));
                                    }
                                    catch
                                    {
                                        // Funkar det inte så betyder det att poängen är ental så endas en karaktär omvandlas
                                        oldscore = Int32.Parse(item.Substring(0, 1));
                                    }
                                    
                                }
                                else// Är svårigheten Hard, så läggs hela raden till i den nya listan  och loopen bryts
                                {
                                    newscores.Add(item);
                                    break;
                                }
                                if (score > oldscore && done) // Vi kontrollerar om poängen på raden är mindre än det spelade poängen
                                {
                                    // Stämmer det så lägger vi till den spelade raden till den nya listan, därmed så läggs inte den gamla raden med i den nya
                                    // och blir den överskriven
                                    newscores.Add(setScore + "," + nameInput.Text + "," + diff);
                                    // vår boolean blir falsk och vi tar inte bort mer gamla poäng från listan
                                    done = false;
                                }
                                else // Om poängen på listan är högre än den spelade
                                {
                                    // Den gamla poängen läggs till den uppdaterade listan
                                    newscores.Add(item);
                                }
                            }
                        }
                        else // Om det inte finns mer än tio sparade poäng
                        {
                            // Alla gamla poäng läggs till den nya listan
                            foreach (var item in scores)
                            {
                                newscores.Add(item);
                            }
                            // Den spelade ronden läggs också till
                            newscores.Add(setScore + "," + nameInput.Text + "," + diff);
                        }
                        
                    }
                    else // Om svårigheten är Hard så sparas alla poäng till den nya listan
                    {
                        foreach(var item in scores)
                        {
                            newscores.Add(item);
                        }
                        newscores.Add(setScore + "," + nameInput.Text + "," + diff);
                    }
                    

                }
            }
            // Vi skapar en skrivare som skriver över textfilen
            using (StreamWriter writer = File.CreateText(path))
            {
                // Första raden 
                writer.WriteLine("HighScore,Name,Difficulty");
                // Vi sparar varje item som ny rad i textfilen
                foreach (var item in newscores)
                {
                    writer.WriteLine(item);
                }
                writer.Close();
            }
        }

        // Metoden MoveBall kallar metoden Ball.MoveBall() 
        // den tar Ball b som argument
        void MoveBall(Ball b)
        {
            // skickad Ball b kallar metoden
            b.MoveBall();
        }

        // När man väljer svårighetsgrad
        private void difficultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ny form öppnas 
            DifficultySelector dia = new DifficultySelector();
            dia.ShowDialog(this);
            // vi hämtar boolean för att sätta svårighetsgraden
            difficulty = dia.Difficulty;
            if (difficulty) // Är det sant så sätter vi easy, annars hard. Bollen återställs
            {
                easyDif();
                ResetBall();
                
            }
            else
            {
                hardDif();
                ResetBall();
            }
             
        }
        // Hard
        private void hardDif()
        {
            // Ställer in svårighets texten och en sträng
            difLabel.Text = "Hard";
            diff = "Hard";
            // Antal kast
            throws = 5;
            // Återställer poängen
            score = 0;
            // Uppdaterar labels
            scoreLabel.Invoke(new Action(() => scoreLabel.Text = $"Score: {score}"));
            nrOfThrows.Invoke(new Action(() => nrOfThrows.Text = $"Throws: {throws}"));
        }
        // Easy - Samma som hard med annorlunda text 
        private void easyDif()
        {
            difLabel.Text = "Easy";
            diff = "Easy";
            throws = 10;
            score = 0;
            scoreLabel.Invoke(new Action(() => scoreLabel.Text = $"Score: {score}"));
            nrOfThrows.Invoke(new Action(() => nrOfThrows.Text = $"Throws: {throws}"));
        }

        // När man ändrar värdet på NumericUpDown gravityUpDown
        private void gravityUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Sätter gravitationen till värdet
            Ball.gravity = (double)gravityUpDown.Value;
        }

        // Avsluta applikationen 
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Laddning av spelet
        private void Bounce_Load(object sender, EventArgs e)
        {
            // Läser in highscore.txt
            string path = Directory.GetCurrentDirectory() + @"\highscore.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {    
                    // Ställer in kolumner 
                    string column = sr.ReadLine();
                    string[] columns = column.Split(',');
                    highScoreView.Columns.Add(columns[0]);
                    highScoreView.Columns.Add(columns[1]);
                    highScoreView.Columns.Add(columns[2]);
                    sr.Close();
                }               
            }
            // Hämtar highscores
            getHighScores();
        }
        // Hämta High Scores
        private void getHighScores()
        {
            string path = Directory.GetCurrentDirectory() + @"\highscore.txt";
            // Läser in 
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string scores;
                    sr.ReadLine();
                    while ((scores = sr.ReadLine()) != null)
                    {
                        // För varje rad så lägger vi ut poängen i listviewitem
                        string[] highSchores = scores.Split(',');
                        ListViewItem item = new ListViewItem(highSchores[0]);
                        item.SubItems.Add(highSchores[1]);
                        item.SubItems.Add(highSchores[2]);
                        highScoreView.Invoke(new Action(()=>highScoreView.Items.Add(item)));
                    }
                    sr.Close();
                }
            }
            // Sortera listviewitems
            highScoreView.Sorting = SortOrder.Descending;
        }
    }
}
