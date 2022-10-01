using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.İnharitance_Rules.Class
{
    public class Student : User
    {
        public Student(string _userName, string _passWord, string _schoolNumber) : base(_userName, _passWord)
        {
            schoolNumber = _schoolNumber;
        }
        public ClassRoom classRoom { get; set; }
        public string schoolNumber { get; set; }
        public List<Teacher> teacher { get; set; }
        public List<Lessons> lessons{ get; set; }
    }
}
