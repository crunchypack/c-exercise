using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace BounceNew
{
    // Klassen Ball förlänger (exetends) Label 
    class Ball : Label
    {
        // Deklarerar variabler
        public static double gravity = 0;
        public static int collissions = 0;
        public double speedX, speedY;
        public double posX, posY;

        // Konstruerare för klassen med Image image som argument
        public Ball(Image image)
        {
            // Sätter bild 
            Image = image;
            // Genomskinnligt bakgrundsfärg, då bilden är rund och man vill få bort den fyrkantiga bakgrunden
            BackColor = Color.Transparent;
            // Storleken bredd och höjd till i pixlar
            Size = new Size(60, 60);
            // Gör bollen synlig
            Visible = true;
        }
        // Metoden MoveBall() rör bollen
        public void MoveBall()
        {
            // Hastigheten i y-led ökas med gravitationen
            speedY += gravity;
            // Positionen i x- och y-led ökas med hastigheten i x- och y-led
            posX += speedX;
            posY += speedY;
            // Platsen uppdateras
            Location = new Point((int)(posX), (int)(posY));
        }
        // Metoden BounceY får bollen att studsa uppåt
        public void BounceY()
        {
            // Sätter hastigeheten till det mottsatta och tar bort gravitation 
            speedY = -(speedY + gravity); // dont add gravity when bouncing
        }
        // Metoden BounceX får bollen att studsa i sidled
        public void BounceX()
        {
            // Hastigheten sätts till det mottsatta
            speedX = -speedX;
        }
        public double PosX
        {
            set
            {
                posX = value;
            }
            get
            {
                return posX;
            }
        }
        // Metoden Start initierar bollen till vald plats
        public void Start()
        {
            posX = Location.X;
            posY = Location.Y;
        }
        // variabeln P ger rooten av speedX^2 + speedY^2
        public double P
        {
            get
            {
                return Math.Sqrt(speedX * speedX + speedY * speedY);
            }
        }
        // Metoden isColliding returnerar true om 2 bollar colliderar
        public bool IsColliding(Ball b)
        {
            double dx = posX - b.posX;
            double dy = posY - b.posY;
            return (dx * dx + dy * dy < 60 * 60);
        }
        // Du behöver inte beskriva Collide i detalj. I synnerhet inte vad de olika räkningarna gör.
        // Metoden Collide får bollarna att reagera när collision sker
        public void Collide(Ball b)
        {
            // hämta alla coordinater
            double x1 = posX;
            double y1 = posY;
            double x2 = b.posX;
            double y2 = b.posY;
            // räkna ut vinklar i radianer
            double a = Math.Atan2(y1 - y2, x1 - x2);
            double a1 = Math.Atan2(speedY, speedX);
            double a2 = Math.Atan2(b.speedY, b.speedX);
            // Mer matte
            double p1 = P;
            double cmx1 = p1 * Math.Cos(a1 - a);
            double cmy1 = p1 * Math.Sin(a1 - a);

            double p2 = b.P;
            double cmx2 = p2 * Math.Cos(a2 - a);
            double cmy2 = p2 * Math.Sin(a2 - a);
            // Bollarnas hastigheter i olika led sätts baserat på mer matte
            speedX = Math.Cos(a) * cmx2 + Math.Cos(a + Math.PI / 2) * cmy1;
            speedY = Math.Sin(a) * cmx2 + Math.Sin(a + Math.PI / 2) * cmy1;
            b.speedX = Math.Cos(a) * cmx1 + Math.Cos(a + Math.PI / 2) * cmy2;
            b.speedY = Math.Sin(a) * cmx1 + Math.Sin(a + Math.PI / 2) * cmy2;
        }
    }
}