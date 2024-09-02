using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    public class Institution
    {
        private string name;
        private string region;
        private string country;
        public string Name { get => name; set => name = value; }
        public string Region { get => region; set => region = value; }
        public string Country { get => country; set => country = value; }

        public string PrintData()
        {
            return $"Institute Name:{Name}, Institute Region:{Region}, Institute Country:{Country}";
        }
    }
}
