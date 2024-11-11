using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongCode
{
    internal class Ball
    {
        private const int BSize = 32;
        private Point speed;
        private Point position;
        private Color color;
        private Graphics graphics;
        private Brush brush;
        private Size clSize;
        new Random rand = new Random();

        public Ball(Point speed, Point position, Color color, Graphics graphics, Size clSize)
        {
            
            this.speed = speed;
            this.position = position;
            this.color = color;
            this.graphics = graphics;
            this.clSize = clSize;
            brush = new SolidBrush(color);
        }
        public void CollisionSound(string SongLocation)
        {
            System.Media.SoundPlayer player =
            new System.Media.SoundPlayer();
            player.SoundLocation = @SongLocation;
            player.LoadAsync();
            player.Stop();
            player.Play();

        }

        public void Draw()
        {
            Rectangle rectang = new Rectangle(position.X, position.Y, BSize, BSize);
            graphics.FillEllipse(brush, rectang);
        }

        public void Move()
        {
            position.X = position.X + speed.X;
            position.Y = position.Y + speed.Y;
        }
        public void Bounce()
        {
            if (position.X < 0 || position.X > clSize.Width)
            {
                if (position.X < 0)
                {
                    //Left Wall Connect
                    Console.WriteLine("P2 Scored");
                }
                if (position.X > clSize.Width)
                {
                    //Right Wall Connect
                    Console.WriteLine("P1 Scored");
                }
                speed.X = -speed.X;
                Console.WriteLine("Point Scored");
                Console.WriteLine(speed.X);
                position.X = (clSize.Width + rand.Next(clSize.Width/10, clSize.Width/6)) / 2;
                position.Y = (clSize.Height + rand.Next(clSize.Height / 10, clSize.Height / 6)) / 2;
                CollisionSound("../../PongWin.wav");
            }
            if (position.Y < 0 || position.Y > clSize.Height - 32)
            {
                speed.Y = -speed.Y;
                Console.WriteLine("Vertical Speed Flipped");
                Console.WriteLine(speed.Y);
                CollisionSound("../../PongBounce.wav");
            }



        }
        public void PaddleCollision(Point PadPos)
        {
            Rectangle rectang = new Rectangle(PadPos.X, PadPos.Y, BSize, BSize*4);
            rectang.Offset(-5,-5);
            rectang.Inflate(15,15);
           // graphics.FillEllipse(brush,rectang);
            if (rectang.Contains(position.X,position.Y))
            {
                speed.Y = (-speed.Y);
                speed.X = (-speed.X);
                Console.WriteLine("Flip");
                CollisionSound("../../PongHit.wav");
            }

        }
        }
    }
