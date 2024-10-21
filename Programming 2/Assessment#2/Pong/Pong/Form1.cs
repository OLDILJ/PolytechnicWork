using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer timer;
        private int clocktime;

        public Form1()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            textBox1.Text = (clocktime += 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
