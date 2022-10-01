using E4.İnharitance_Rules.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E4.İnharitance_Rules.Forms
{
    public partial class İnterface : Form
    {
        public İnterface()
        {
            InitializeComponent();
        }

        List<Teacher> teachers = new List<Teacher>();

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            if (teachers.Any(x => x.userName == txtUserName.Text && x.branch == txtBranh.Text))
            {
                MessageBox.Show("Bu kullanıcı zaten mevcut");
                return;
            }

            Teacher teacher = new Teacher(txtBranh.Text, txtUserName.Text, txtPassword.Text);
            teachers.Add(teacher);
        }

        private void btnListTeacher_Click(object sender, EventArgs e)
        {



            foreach (Teacher teacher in teachers)
            {
                lstTeacher.Items.Add($"Kullanıcı adı : {teacher.userName} , Branş : {teacher.branch}");
            }


        }
    }
}
