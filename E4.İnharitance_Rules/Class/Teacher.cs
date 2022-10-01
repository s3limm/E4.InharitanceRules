using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.İnharitance_Rules.Class
{
    public class Teacher : User
    {
        public Teacher(string _branch ,string _userName,string _password): base(_userName,_password) 
        {
            branch = _branch;
        }
        public  string branch { get; set; }
    }
}
