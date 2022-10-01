using E4.İnharitance_Rules.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E4.İnharitance_Rules
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student student = new Student("144", "Yavuz", "1234");
            ClassRoom classRoom = new ClassRoom();
            Teacher teacher = new Teacher("Mathematics","Selim","1234");

            classRoom.number = "1";
            classRoom.character = "A";
            student.classRoom = classRoom;
            classRoom.GetFullName();
            student.teacher.Add(teacher);
        }
    }
}
