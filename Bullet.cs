using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ZombieProject
{
    class Bullet
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;

        private int Speed = 30;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form)
        {
            bullet.Tag = "bullet";
            bullet.BackColor = Color.YellowGreen;
            if(direction == "left" || direction == "right")
            {
                bullet.Size = new Size(20, 5);
            }
            else if (direction == "up" || direction == "down")
            {
                bullet.Size = new Size(5, 20);
            }

            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;

            form.Controls.Add(bullet);

            bulletTimer.Interval = Speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                bullet.Left -= Speed;
            }

            if (direction == "right")
            {
                bullet.Left += Speed;
            }

            if (direction == "up")
            {
                bullet.Top -= Speed;
            }

            if (direction == "down")
            {
                bullet.Top += Speed;
            }

            if (bullet.Left < 0 || bullet.Left > 850 || bullet.Top < 21 || bullet.Top > 590)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }
    }
}
