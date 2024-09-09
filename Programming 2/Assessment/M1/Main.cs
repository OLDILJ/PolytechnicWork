using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M1
{
    internal static class M1
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
         
        }
        public enum EPosition
        {
            LECTURER = 0,
            SENIOR_LECTURER = 1,
            PRINCIPAL_LECTURER = 2,
            ASSOCIATE_PROFESSOR = 3,
            PROFESSOR = 4
        }
        public enum ESalary
        {
            LECTURER_SALARY = 85000,
            SENIOR_LECTURER_SALARY = 100000,
            PRINCIPAL_LECTURER_SALARY = 115000,
            ASSOCIATE_PROFESSOR_SALARY = 130000,
            PROFESSOR_SALARY = 145000
        }
    }
}
