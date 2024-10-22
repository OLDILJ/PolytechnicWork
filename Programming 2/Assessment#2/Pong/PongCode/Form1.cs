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
        bool gamestart = false;
        Graphics g;
        Controller control;
        Player1 P1;
        Player2 P2;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            P1 = new Player1(new System.Drawing.Point(10, 10), new System.Drawing.Point(100, 100), Color.Black, g);
            control = new Controller(g, ClientSize);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gamestart)
            {
                control.Run();
                P1.InputCheck();
                P1.Draw();
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
