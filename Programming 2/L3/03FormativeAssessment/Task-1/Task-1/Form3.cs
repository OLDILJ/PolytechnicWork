using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Task_1
{
    public partial class Form3 : Form
    {
        private double CurrentValue = 0;
        public Form3()
        {
            InitializeComponent();
            checkedListBox2.CheckOnClick = true;

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("Small"))
            {
                SumTotal(-5.0);
                listBox1.Items.Remove("Small");
            }
            if (listBox1.Items.Contains("Large"))
            {
                SumTotal(-10.0);
                listBox1.Items.Remove("Large");
            }
            SumTotal(5.0);
            listBox1.Items.Add("Small");


        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("Small"))
            {
                SumTotal(-5.0);
                listBox1.Items.Remove("Small");
            }
            if (listBox1.Items.Contains("Large"))
            {
                SumTotal(-10.0);
                listBox1.Items.Remove("Large");
            }
            SumTotal(10.0);
            listBox1.Items.Add("Large");
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {


        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("TESTINPUT");
            string curItem = checkedListBox2.SelectedItem.ToString();
            //Index needs debugging
            int index = checkedListBox2.Items.IndexOf(curItem);
            //double[] ItemValue = new double[5];
            double[] ItemValue = { 0.5, 1.0, 0.75, 0.5, 1.5 };
            //ItemValue = (0.5, 1.0, 0.75, 0.5, 1.5);
            Console.WriteLine(curItem);
            //
            if (checkedListBox2.GetItemCheckState(index) == CheckState.Checked && !listBox1.Items.Contains(curItem))
            {

                listBox1.Items.Add(curItem);
                SumTotal(ItemValue[index]);

            }
            if (checkedListBox2.GetItemCheckState(index) == CheckState.Unchecked && listBox1.Items.Contains(curItem))
            {

                listBox1.Items.Remove(curItem);
                SumTotal(-ItemValue[index]);

            }
        }

        private void SumTotal(double NewValue)
        {

            CurrentValue = CurrentValue += NewValue;
            textBox1.Text = CurrentValue.ToString();
        }
    }
}
