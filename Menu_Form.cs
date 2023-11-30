using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ZombieProject
{
    public partial class Menu_Form : Form
    {
        SoundPlayer hoverSound = new SoundPlayer(Properties.Resources.click);
        public Menu_Form()
        {
            InitializeComponent();
            playTrack();
        }

        private void playTrack()
        {
            SoundPlayer soundtrack = new SoundPlayer(Properties.Resources.Intro_soundtrack);
            soundtrack.PlayLooping();
        }
        private void PlayBTN_MouseEnter(object sender, EventArgs e)
        {
            PlayBTN.ForeColor = Color.Yellow;
            PlayBTN.Font = new Font("UD Digi Kyokasho NK-B", 39);
            hoverSound.Play();
        }

        private void PlayBTN_MouseLeave(object sender, EventArgs e)
        {
            PlayBTN.ForeColor = Color.Snow;
            PlayBTN.Font = new Font("UD Digi Kyokasho NK-B", 36);
        }

        private void exitBTN_MouseEnter(object sender, EventArgs e)
        {
            exitBTN.ForeColor = Color.Yellow;
            exitBTN.Font = new Font("UD Digi Kyokasho NK-B", 39);
            hoverSound.Play();
        }

        private void exitBTN_MouseLeave(object sender, EventArgs e)
        {
            exitBTN.ForeColor = Color.Snow;
            exitBTN.Font = new Font("UD Digi Kyokasho NK-B", 36);
        }

        private void LeaderboardBTN_MouseEnter(object sender, EventArgs e)
        {
            LeaderboardBTN.ForeColor = Color.Yellow;
            LeaderboardBTN.Font = new Font("UD Digi Kyokasho NK-B", 39);
            hoverSound.Play();
        }

        private void LeaderboardBTN_MouseLeave(object sender, EventArgs e)
        {
            LeaderboardBTN.ForeColor = Color.Snow;
            LeaderboardBTN.Font = new Font("UD Digi Kyokasho NK-B", 36);
        }

        private void PlayBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Difficulty_Level df = new Difficulty_Level();
            df.ShowDialog();
            this.Show();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeaderboardBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leaderboard lb = new Leaderboard();
            lb.ShowDialog();
            this.Show();
        }

        private void InfoBTN_Click(object sender, EventArgs e)
        {   
            this.Hide();
            Instructions i = new Instructions();
            i.ShowDialog();
            this.Show();
        }
    }
}
