using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongCode
{
    internal class Controller
    {
        private Ball ball;
        public Controller(Graphics graphics, Size clSize) 
        {
            ball = new Ball(new Point(10, 10), new Point(100, 100), Color.Black, graphics, clSize);
        }
        public void Run()
        {
            ball.Move();
            ball.Draw();
            ball.Bounce();
        }
    }
}
