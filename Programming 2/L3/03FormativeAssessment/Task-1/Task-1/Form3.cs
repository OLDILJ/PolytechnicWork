using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Task_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            checkedListBox2.CheckOnClick = true;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("Small"))
            {
                listBox1.Items.Remove("Small");
            }
            if (listBox1.Items.Contains("Large"))
            {
                listBox1.Items.Remove("Large");
            }
            listBox1.Items.Add("Small");
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("Small"))
            {
                listBox1.Items.Remove("Small");
            }
            if (listBox1.Items.Contains("Large"))
            {
                listBox1.Items.Remove("Large");
            }
            listBox1.Items.Add("Large");
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = checkedListBox2.SelectedItem.ToString();
            //Index needs debugging
            int index = checkedListBox2.Items.IndexOf(curItem);
            //
            if (index != -1)
            {
                // if item is in list already remove it
                listBox1.Items.Remove(curItem);
            }
            else
            {
                listBox1.Items.Add(curItem);
            }
            

        }
    }
}
