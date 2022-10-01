using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.İnharitance_Rules.Class
{
    public class Student : User
    {
        public Student(string _userName,string _passWord,string _schoolNumber) : base(_userName,_passWord)
        {
            schoolNumber = _schoolNumber;
        }
        public string schoolNumber { get; set; }
    }
}
