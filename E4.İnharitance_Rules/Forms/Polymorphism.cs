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

namespace E4.İnharitance_Rules.Forms
{
    public partial class Polymorphism : Form
    {
        public Polymorphism()
        {
            InitializeComponent();
        }

        private void btnİnsan_Click(object sender, EventArgs e)
        {
            İnsan insan = new İnsan();
            insan.GetBreath();
        }

        private void btnHayvan_Click(object sender, EventArgs e)
        {
            Hayvan hayvan = new Hayvan();
            hayvan.GetBreath();
        }

        private void btnBitki_Click(object sender, EventArgs e)
        {
            Bitki bitki = new Bitki();
            bitki.GetBreath();
        }
    }
}
