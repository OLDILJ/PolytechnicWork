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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Institution institution in ExportedInstituteList)
            {
                textBox1.Text += ($"{ institution.Name}, { institution.Region}, {institution.Country} ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Department department in ExportedDepartmentList)
            {
                textBox3.Text += ($"{department.Name}, {department.Institute.Name}, {department.Institute.Region}, {department.Institute.Country} ");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportedInstituteList = Utils.SeedInstitutions();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportedDepartmentList = Utils.SeedDepartments();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExportedCourseList = Utils.SeedCourses();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Course course in ExportedCourseList)
            {
                textBox4.Text += ($"{course.Department.Name}, {course.Department.Institute.Name}, {course.Department.Institute.Region}, {course.Department.Institute.Country}, {course.Code}, {course.Name}, {course.Description}, " + Environment.NewLine + $"{course.Credits},"+ Environment.NewLine + $"{course.Fees} ");
            }
        }
    }
}
