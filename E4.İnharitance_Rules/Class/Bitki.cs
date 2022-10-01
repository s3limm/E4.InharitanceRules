using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.İnharitance_Rules.Class
{
    public class Bitki : Polymorphism_Class
    {

        public override void GetBreath()
        {
            System.Windows.Forms.MessageBox.Show("Fotosentez yap.");
        }

    }
}
