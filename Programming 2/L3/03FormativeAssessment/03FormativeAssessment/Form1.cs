using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03FormativeAssessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "Here is my new text";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            int LabelClicks = Convert.ToInt16(label1.Text);
            LabelClicks = LabelClicks + 1;
            label1.Text = Convert.ToString(LabelClicks);
        }
    }
}
