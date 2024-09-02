using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    public class Department
    {
        private Institution institute;
        private string name;
        //private string NameOfType;
        

        public Institution Institute { get => institute; set => institute = value; }
        public string Name { get => name; set => name = value; }
        public string PrintData()
        {
            return $"Department Name:{Name}, Department Institute Name:{Institute.Name}, Institute Region: {Institute.Region},Institute Country:{Institute.Country}";
        }
    }
}
