using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieProject
{
    class Snake_Body
    {
        public List<PictureBox> Train;

        public Snake_Body()
        {
            Train = new List<PictureBox>();
        }

        public PictureBox bodyIndex(int i)
        {
            return this.Train[i];
        }
        public void setBody(int i, PictureBox p)
        {
            this.Train.Insert(i, p);
        }
        public void addBody(PictureBox i)
        {
            this.Train.Add(i);
        }

        public int bodyLength()
        {
            return this.Train.Count();
        }

        public void removeBody(int i)
        {
            this.Train.RemoveAt(i);
        }

        public void clearBody()
        {
            this.Train.Clear();
        }
    }
}
