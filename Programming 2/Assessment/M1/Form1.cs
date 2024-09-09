using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M1
{
    public partial class Form1 : Form
    {
        public List<Institution> ExportedInstituteList;
        public List<Department> ExportedDepartmentList;
        public List<Course> ExportedCourseList;
        public Form1()
        {
            InitializeComponent();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            ExportedInstituteList = Utils.SeedInstitutions();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ExportedDepartmentList = Utils.SeedDepartments();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ExportedCourseList = Utils.SeedCourses();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                foreach (Institution institution in ExportedInstituteList)
                {
                    textBox1.Text += ($"{institution.Name}, {institution.Region}, {institution.Country} ");
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (Department department in ExportedDepartmentList)
                {
                    textBox3.Text += ($"{department.Name}, {department.Institute.Name}, {department.Institute.Region}, {department.Institute.Country} ");
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {

                foreach (Course course in ExportedCourseList)
                {
                    textBox4.Text += ($"{course.Department.Name}, {course.Department.Institute.Name}, {course.Department.Institute.Region}, {course.Department.Institute.Country}, {course.Code}, {course.Name}, {course.Description}, " + Environment.NewLine + $"{course.Credits}," + Environment.NewLine + $"{course.Fees} ");
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
