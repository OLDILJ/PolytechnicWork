using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Write code that allows the user to enter a number into each of five TextBoxes.
            //Provide Buttons that compute the sum and the average of the five numbers.
            //https://github.com/otago-polytechnic-bit-courses/ID511001-programming-2/blob/main-s2-24/resources/img/07/05-image.png
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
