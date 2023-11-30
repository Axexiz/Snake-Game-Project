using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieProject
{
    class Ammo
    {
        public List<PictureBox> ammunition;

        public Ammo()
        {
            ammunition = new List<PictureBox>();
        }

        public void addAmmo(PictureBox p)
        {
            this.ammunition.Add(p);
        }

        public void clearAmmo()
        {
            this.ammunition.Clear();
        }
    }
}
