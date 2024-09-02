using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    public class Course
    {
        private Department department;
        private string code;
        private string name;
        private string description;
        private int credits;
        private double fees;
        //private string NameOfType;


        public Department Department { get => department; set => department = value; }
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Credits { get => credits; set => credits = value; }
        public double Fees { get => fees; set => fees = value; }
        public string PrintData()
        {
            return $"Course Code: {Code}, Course Name: {Name}, Course Description: {Description}, Course Credits: {Credits}, Course Fees: {Fees}, Course Department Name:{Department.Name}, Course Department Institute Name:{Department.Institute.Name}, Course Institute Region: {Department.Institute.Region}, Course Institute Country:{Department.Institute.Country}";
        }
    }
}
