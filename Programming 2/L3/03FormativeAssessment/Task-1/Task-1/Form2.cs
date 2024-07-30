using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form2 : Form
    {
        int FirstNum = 0;
        int LastNum = 0;
        int NumSum = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToInt32(textBox1.Text);
            LastNum = Convert.ToInt32(textBox2.Text);
            NumSum = FirstNum + LastNum;
            textBox3.Text = NumSum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToInt32(textBox1.Text);
            LastNum = Convert.ToInt32(textBox2.Text);
            NumSum = FirstNum - LastNum;
            textBox3.Text = NumSum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToInt32(textBox1.Text);
            LastNum = Convert.ToInt32(textBox2.Text);
            NumSum = FirstNum * LastNum;
            textBox3.Text = NumSum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToInt32(textBox1.Text);
            LastNum = Convert.ToInt32(textBox2.Text);
            NumSum = FirstNum / LastNum;
            textBox3.Text = NumSum.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToInt32(textBox1.Text);
            LastNum = Convert.ToInt32(textBox2.Text);
            NumSum = FirstNum % LastNum;
            textBox3.Text = NumSum.ToString();

        }
    }
}
