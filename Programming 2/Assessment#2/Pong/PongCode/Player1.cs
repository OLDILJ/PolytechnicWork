using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace PongCode
{
    internal class Player1
    {
        private const int BSize = 32;
        private System.Drawing.Point speed;
        private System.Drawing.Point position;
        private System.Drawing.Color color;
        private Graphics graphics;
        private System.Drawing.Brush brush;
        private System.Drawing.Size CSize;

        public System.Drawing.Point Position { get => position; set => position = value; }

        public Player1(System.Drawing.Point speed, System.Drawing.Point position, System.Drawing.Color color, Graphics graphics, System.Drawing.Size cSize)
        {
            this.speed = speed;
            this.position = position;
            this.color = color;
            this.graphics = graphics;
            brush = new SolidBrush(color);
            this.CSize = cSize;
        }
        public void InputCheck()
        {
            if (Keyboard.IsKeyDown(Key.W))
            {
                position.Y = position.Y - speed.Y; 
            }
            if (Keyboard.IsKeyDown(Key.S) && (position.Y < 0 || position.Y < CSize.Height - 32*4))
            {
                position.Y = position.Y + speed.Y;
            }
        }
        public void Draw()
        {
            
            Rectangle rectang = new Rectangle(position.X, position.Y, BSize, BSize * 4);
            graphics.FillRectangle(brush, rectang);
        }
    }
}
