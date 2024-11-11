using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace PongCode
{
    public partial class Form1 : Form
    {

        private Bitmap offScreenBitMap;
        private Graphics offScreenGraphics;
        bool gamestart = false;
        Graphics g;
        Controller control;
        Player1 P1;
        Player2 P2;
        int[] scores;
        string PrintScore1 = "0";
        string PrintScore2 = "0";
        Font font = new Font("Times New Roman", 12.0f);
        Brush brush = new SolidBrush(Color.DarkCyan);
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            offScreenBitMap = new Bitmap(Width, Height); // An image used as a buffer for rendering
            offScreenGraphics = Graphics.FromImage(offScreenBitMap); // Enables you to draw on the offScreenBitmap
            control = new Controller(g, ClientSize);
            P1 = new Player1(new System.Drawing.Point(10, 10), new System.Drawing.Point(100, 200), Color.Black, g, ClientSize, PrintScore1);
            P2 = new Player2(new System.Drawing.Point(10, 10), new System.Drawing.Point(700, 200), Color.Black, g, ClientSize, PrintScore2);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gamestart)
            {
                g.DrawImage(offScreenBitMap, 0, 0);
                g.Clear(BackColor);
                P1.InputCheck();
                P1.Draw();
                P2.InputCheck();
                P2.Draw();
                scores = control.SendScoreUp();
                control.Run();
                control.PadCheck(P1.Position);
                control.PadCheck(P2.Position);
                if (scores != null)
                {

                    g.DrawString(scores[0].ToString(), font, brush, 600, 10);
                    g.DrawString(scores[1].ToString(), font, brush, 200, 10);
                }
            }
            if (!gamestart)
            {
                if (Keyboard.IsKeyDown(Key.Space))
                {
                    gamestart = true;
                    Console.WriteLine("GameStart");
                }
            }
        }
    }
}
