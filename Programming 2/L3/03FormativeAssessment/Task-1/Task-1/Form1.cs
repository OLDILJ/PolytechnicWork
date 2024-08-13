using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[5];
        double average = 0;
        int sum = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numbers[0] = Convert.ToInt32(textBox1.Text);
            average = Convert.ToDouble(numbers.Average());
            sum = numbers.Sum();
            SumBox.Text = sum.ToString();
            AverageBox.Text = average.ToString();

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            numbers[1] = Convert.ToInt32(textBox2.Text);
            average = Convert.ToDouble(numbers.Average());
            sum = numbers.Sum();
            SumBox.Text = sum.ToString();
            AverageBox.Text = average.ToString();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            numbers[2] = Convert.ToInt32(textBox3.Text);
            average = Convert.ToDouble(numbers.Average());
            sum = numbers.Sum();
            SumBox.Text = sum.ToString();
            AverageBox.Text = average.ToString();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            numbers[3] = Convert.ToInt32(textBox4.Text);
            average = Convert.ToDouble(numbers.Average());
            sum = numbers.Sum();
            SumBox.Text = sum.ToString();
            AverageBox.Text = average.ToString();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            numbers[4] = Convert.ToInt32(textBox5.Text);
            average = Convert.ToDouble(numbers.Average());
            sum = numbers.Sum();
            SumBox.Text = sum.ToString();
            AverageBox.Text = average.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}
