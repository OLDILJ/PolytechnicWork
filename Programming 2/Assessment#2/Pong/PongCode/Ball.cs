using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Ball(Point speed, Point position, Color color, Graphics graphics, Size clSize)
        {
            this.speed = speed;
            this.position = position;
            this.color = color;
            this.graphics = graphics;
            this.clSize = clSize;
            brush = new SolidBrush(color);
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
                speed.X = -speed.X;
                Console.WriteLine("Horizontal Speed Flipped");
                Console.WriteLine(speed.X);
            }
            if (position.Y < 0 || position.Y > clSize.Height)
            {
                speed.Y = -speed.Y;
                Console.WriteLine("Vertical Speed Flipped");
                Console.WriteLine(speed.Y);
            }



            }
        }
    }
