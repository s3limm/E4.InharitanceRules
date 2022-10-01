using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.İnharitance_Rules.Class
{
    public class ClassRoom
    {
        public string number { get; set; }
        public  string character { get; set; }

        public string GetFullName()
        {
            return $"{number}-{character}";
        }

    }
}
