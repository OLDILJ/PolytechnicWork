using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Pong
{
    internal class PongGraphics
    {
        private void DrawTestEventGiver()
        {
            Graphics g;
            g = this.CreateGraphics();
            this.DrawTest(new PaintEventArgs(g, new Rectangle(20, 20, 20, 20)));
        }
        private void DrawTest(PaintEventArgs e)
        {
            //Create Black Pen with 10 px width
            Pen BlackPen = new Pen(Brushes.Black, 10);
            // Set LineJoin for corner style
            BlackPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Miter;
            // Draw the thing
            e.Graphics.DrawRectangle(BlackPen, new Rectangle(20, 20, 20, 20));
            BlackPen.Dispose();
        }


    }
}
