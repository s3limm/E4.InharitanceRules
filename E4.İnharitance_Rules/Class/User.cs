using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.İnharitance_Rules.Class
{
    public class User
    {


        public User(string _userName, string _passWord)
        {
            userName = _userName;
            password = _passWord;
            createdDate = DateTime.Now;
        }

        public string userName { get; set; }
        public string password { get; set; }
        public  string name { get; set; }
        public string  surName { get; set; }
        public string phoneNumber { get; set; }
        public string mail { get; set; }
        public DateTime createdDate{ get; set; }


    }
}
