using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace ZombieProject
{
    public partial class Difficulty_Level : Form
    {
        SoundPlayer hoverSound = new SoundPlayer(Properties.Resources.click);
        public Difficulty_Level()
        {
            InitializeComponent();
        }

        private void EasyModeBTN_MouseEnter(object sender, EventArgs e)
        {
            EasyModeBTN.ForeColor = Color.DeepSkyBlue;
            EasyModeBTN.FlatAppearance.BorderColor = Color.PaleTurquoise;
            hoverSound.Play();
        }

        private void EasyModeBTN_MouseLeave(object sender, EventArgs e)
        {
            EasyModeBTN.ForeColor = Color.Snow;
            EasyModeBTN.FlatAppearance.BorderColor = Color.Snow;
        }

        private void NormalModeBTN_MouseEnter(object sender, EventArgs e)
        {
            NormalModeBTN.ForeColor = Color.Yellow;
            NormalModeBTN.FlatAppearance.BorderColor = Color.PaleGoldenrod;
            hoverSound.Play();
        }

        private void NormalModeBTN_MouseLeave(object sender, EventArgs e)
        {
            NormalModeBTN.ForeColor = Color.Snow;
            NormalModeBTN.FlatAppearance.BorderColor = Color.Snow;
        }

        private void HardModeBTN_MouseEnter(object sender, EventArgs e)
        {
            HardModeBTN.ForeColor = Color.Red;
            HardModeBTN.FlatAppearance.BorderColor = Color.PaleVioletRed;
            hoverSound.Play();
        }

        private void HardModeBTN_MouseLeave(object sender, EventArgs e)
        {
            HardModeBTN.ForeColor = Color.Snow;
            HardModeBTN.FlatAppearance.BorderColor = Color.Snow;
        }

        private void EasyModeBTN_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw = new StreamWriter("difficulty_Lvl.txt"))
            {
                sw.Write("");
            }
            using(StreamWriter sw = new StreamWriter("difficulty_Lvl.txt"))
            {
                sw.Write("easy");
            }
            this.Hide();
            SnakeGame sg = new SnakeGame();
            sg.ShowDialog();
            this.Show();
        }

        private void NormalModeBTN_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("difficulty_Lvl.txt"))
            {
                sw.Write("");
            }
            using (StreamWriter sw = new StreamWriter("difficulty_Lvl.txt"))
            {
                sw.Write("medium");
            }
            this.Hide();
            SnakeGame sg = new SnakeGame();
            sg.ShowDialog();
            this.Show();
        }

        private void HardModeBTN_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("difficulty_Lvl.txt"))
            {
                sw.Write("");
            }
            using (StreamWriter sw = new StreamWriter("difficulty_Lvl.txt"))
            {
                sw.Write("hard");
            }
            this.Hide();
            SnakeGame sg = new SnakeGame();
            sg.ShowDialog();
            this.Show();
        }
    }
}
