using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ZombieProject
{
    class Parts
    {
        public List<PictureBox> part;

        public Parts()
        {
            part = new List<PictureBox>();
        }

        public PictureBox getPart(int i)
        {
            return this.part[i];
        }

        public void clearParts()
        {
            this.part.Clear();
        }

        public void addParts(PictureBox p)
        {
            this.part.Add(p);
        }
    }
}
