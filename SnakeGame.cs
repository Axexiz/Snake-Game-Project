using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Media;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ZombieProject 
{
    public partial class SnakeGame : Form 
    {
        System.Windows.Forms.Timer bulletTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer mobTimer = new System.Windows.Forms.Timer();

        SoundPlayer spit = new SoundPlayer(Properties.Resources.spit);
        SoundPlayer mobDie = new SoundPlayer(Properties.Resources.mobDeath);
        SoundPlayer collectP = new SoundPlayer(Properties.Resources.Collect_Parts);
        SoundPlayer endOfGame = new SoundPlayer(Properties.Resources.GameOver);
        SoundPlayer getItem = new SoundPlayer(Properties.Resources.obtainItem);
        SoundPlayer Boost = new SoundPlayer(Properties.Resources.SpeedBoost);

        bool goLeft, goRight, goUp, goDown,MobSlain,boostCheck;
        bool gameOver = false;
        bool intersection = false;
        string DifficulttyStatus;
        string facing = "up";
        int playerHealth = 100;
        int kills, parts;
        int gap = 0;
        int ammo = 5;
        int speedCap = 500;
        int speedBoost = 10*2;
        int speed = 10;
        int MobSpeed;
        int MobNo = 3;


        Random randomNum = new Random();

        PictureBox mob,Ammo, newBodyPart,Parts;

        List<PictureBox> MobList = new List<PictureBox>();


        Ammo ammoList = new Ammo();
        Snake_Body bodyList = new Snake_Body();
        Parts partsList = new Parts();
        public SnakeGame()
        {
            InitializeComponent();

            using(StreamReader sr = new StreamReader("difficulty_Lvl.txt"))
            {
                string info = sr.ReadLine();
                DifficulttyStatus = info;
            }
            RestartGame();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            

            if (playerHealth > 1 && playerHealth <= progressBar1.Maximum)
            {
                progressBar1.Value = playerHealth;
            }

            else if (playerHealth < 1 && playerHealth <= progressBar1.Minimum)
            {
                gameOver = true;
                SaveScore(parts);
                GameTimer.Stop();
                bulletTimer.Stop();
                mobTimer.Stop();
                endOfGame.Play();
                MessageBox.Show("Congratulations! you scored " + parts + " parts!", "Status");
            }

            if(speedCap >= 0 && speedCap <=SpeedBar.Maximum)
            {
                SpeedBar.Value = speedCap;
            }
            else
            {
                speed = 10;
            }

            if(DifficulttyStatus == "easy" || DifficulttyStatus == "medium")
            {
                if (goDown == true || goLeft == true || goUp == true || goRight == true)
                {
                    if (boostCheck == true)
                    {
                        speedCap--;
                    }
                }
            }
            else
            {
                if (boostCheck == true)
                {
                    speedCap--;
                }
            }
            
            if(DifficulttyStatus == "easy")
            {
                txtAmmo.Text = "" ;
            }
            else if(DifficulttyStatus == "medium")
            {
                txtAmmo.Text = "ammo: " + ammo;
            }
            
            txtKills.Text = "kills: " + kills;
            txtParts.Text = "parts: " + parts;
            
            if(DifficulttyStatus == "easy" || DifficulttyStatus == "medium")
            {
                if (playerHealth == 25 )
                {
                    dropHealth();
                }
            }

            if (DifficulttyStatus == "easy")
            {
                MobSpeed = 1;
            }
            else
            {
                MobSpeed = 2;
            }


            if (goLeft == true && PLayer.Left > 0)
            {
                PLayer.Location = new Point(PLayer.Location.X - speed, PLayer.Location.Y);
            }

            if (goRight == true && PLayer.Left + PLayer.Width < this.ClientSize.Width)
            {
                PLayer.Location = new Point(PLayer.Location.X + speed, PLayer.Location.Y);
            }

            if (goUp == true && PLayer.Top > 38)
            {
                PLayer.Location = new Point(PLayer.Location.X , PLayer.Location.Y - speed);
            }

            if (goDown == true && PLayer.Top + PLayer.Height < this.ClientSize.Height)
            {
                PLayer.Location = new Point(PLayer.Location.X, PLayer.Location.Y + speed);
            }
            

            

            if(goDown == true || goLeft == true || goUp == true || goRight == true)
            {
                for(int i = bodyList.bodyLength()-1 ; i > 0 ; i--)
                {
                    if(facing == "right")
                    {
                        bodyList.bodyIndex(i).Location = new Point( bodyList.bodyIndex(i - 1).Location.X - gap , bodyList.bodyIndex(i-1).Location.Y);
                    }

                    if (facing == "left")
                    {
                        bodyList.bodyIndex(i).Location = new Point(bodyList.bodyIndex(i - 1).Location.X + gap, bodyList.bodyIndex(i - 1).Location.Y);
                    }

                    if (facing == "up")
                    {
                        bodyList.bodyIndex(i).Location = new Point(bodyList.bodyIndex(i - 1).Location.X , bodyList.bodyIndex(i - 1).Location.Y + gap);
                    }

                    if (facing == "down")
                    {
                        bodyList.bodyIndex(i).Location = new Point(bodyList.bodyIndex(i - 1).Location.X, bodyList.bodyIndex(i - 1).Location.Y - gap);
                    }

                }
            }
            
            bodyList.bodyIndex(0).Location = PLayer.Location; //make the first index of the body list the head


//===========================================================================================================================================================


            foreach (Control x in this.Controls.OfType<PictureBox>())
            {   

                if ((string)x.Tag == "Ammo") //for everytime a control within this windows form detects a picturebox that has a tag
                {                                             //"ammo" in it and IF that specific ammo picture box comes into contact with the player's
                    if (PLayer.Bounds.IntersectsWith(x.Bounds))//boundary of the picture box, it will remove the control in the form as well as remove that
                    {                                          //specific ammo box entirely.
                        getItem.Play();
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                if ((string)x.Tag == "mob")
                {
                    if (x.Left > PLayer.Left)
                    {
                        x.Left -= MobSpeed;
                        ((PictureBox)x).Image = Properties.Resources.mleft;
                    }

                    if (x.Left < PLayer.Left)
                    {
                        x.Left += MobSpeed;
                        ((PictureBox)x).Image = Properties.Resources.mright;
                    }

                    if (x.Top > PLayer.Top)
                    {
                        x.Top -= MobSpeed;
                        ((PictureBox)x).Image = Properties.Resources.mup;
                    }

                    if (x.Top < PLayer.Top)
                    {
                        x.Top += MobSpeed;
                        ((PictureBox)x).Image = Properties.Resources.mdown;                
                    }

                    foreach (Control b in this.Controls.OfType<PictureBox>())
                    {
                        if ((string)b.Tag == "body" && b.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (!intersection)
                            {
                                playerHealth--;
                                intersection = true;
                            }
                            break;
                        }
                    }
                }

                if((string)x.Tag == "health")
                {
                    if(PLayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        getItem.Play();
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        if(DifficulttyStatus == "easy")
                        {
                            if (playerHealth + 30 > 100)
                            {
                                playerHealth = 100;
                            }
                            else if(playerHealth < 100)
                            {
                                playerHealth += 30;
                            }
                        }
                        else if (DifficulttyStatus == "medium")
                        {
                            if (playerHealth + 20 > 100)
                            {
                                playerHealth = 100;
                            }
                            else if (playerHealth < 100)
                            {
                                playerHealth += 20;
                            }
                        }



                    }
                }

                if((string)x.Tag == "parts")
                {
                    if (x.Bounds.IntersectsWith(PLayer.Bounds))
                    {
                        collectP.Play();
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        parts += 1;
                        newBodyPart = new PictureBox();
                        newBodyPart.Size = new Size(60, 49);
                        newBodyPart.BackColor = Color.FromArgb(214, 244, 157);
                        newBodyPart.Tag = "body";
                        newBodyPart.Location = PLayer.Location;
                        bodyList.addBody(newBodyPart);
                        Controls.Add(newBodyPart);
                        
                    }
                }




                foreach (Control j in this.Controls.OfType<PictureBox>()) //bullets and zombies are being created dynamically which means that
                {                                                           //we need another loop to link between the bullet and the zombie together
                    if ((string)j.Tag == "bullet" && (string)x.Tag == "mob")//In this loop, j is to represent the bullet while x is to represent the zombie
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))              //if the boundary of a bullet intersects the boundary of a 
                        {
                            MobSlain = true;
                            mobDie.Play();
                        }
                        if(MobSlain == true)
                        {
                            dropParts(x.Left + (x.Width/2),x.Top + (x.Height/2));
                            kills++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            MobList.Remove((PictureBox)x);
                            MakeMob();

                            MobSlain = false;
                        }

                    }

                    
                }
             
            }

            intersection = false;

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }

            if(DifficulttyStatus == "easy" || DifficulttyStatus == "medium")
            {
                if (e.KeyCode == Keys.Left)
                {
                    goLeft = true;
                    facing = "left";
                    PLayer.Image = Properties.Resources.Hleft; //This is turn the image to a desired direction 
                    PLayer.BackgroundImageLayout = ImageLayout.Center;
                }

                if (e.KeyCode == Keys.Right)
                {
                    goRight = true;
                    facing = "right";
                    PLayer.Image = Properties.Resources.Hright;
                    PLayer.BackgroundImageLayout = ImageLayout.Center;
                }

                if (e.KeyCode == Keys.Up)
                {
                    goUp = true;
                    facing = "up";
                    PLayer.Image = Properties.Resources.Hup;
                    PLayer.BackgroundImageLayout = ImageLayout.Center;
                }

                if (e.KeyCode == Keys.Down)
                {
                    goDown = true;
                    facing = "down";
                    PLayer.Image = Properties.Resources.Hdown;
                    PLayer.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else if(DifficulttyStatus == "hard")
            {
                if (e.KeyCode == Keys.Left)
                {
                    goLeft = true; 
                    goRight = false; goDown = false; goUp = false;
                    facing = "left";
                    PLayer.Image = Properties.Resources.Hleft; //This is turn the image to a desired direction 
                    PLayer.BackgroundImageLayout = ImageLayout.Center;
                }

                if (e.KeyCode == Keys.Right)
                {
                    goRight = true;
                    goLeft = false; goDown = false; goUp = false;
                    facing = "right";
                    PLayer.Image = Properties.Resources.Hright;
                    PLayer.BackgroundImageLayout = ImageLayout.Center;
                }

                if (e.KeyCode == Keys.Up)
                {
                    goUp = true;
                    goRight = false; goDown = false; goLeft = false;
                    facing = "up";
                    PLayer.Image = Properties.Resources.Hup;
                    PLayer.BackgroundImageLayout = ImageLayout.Center;
                }

                if (e.KeyCode == Keys.Down)
                {
                    goDown = true;
                    goRight = false; goLeft = false; goUp = false;
                    facing = "down";
                    PLayer.Image = Properties.Resources.Hdown;
                    PLayer.BackgroundImageLayout = ImageLayout.Center;
                }
            }

            

            if(e.KeyCode == Keys.Space && speedCap > 1)
            {
                Boost.Play();
                speed = speedBoost;
                boostCheck = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(DifficulttyStatus == "easy" || DifficulttyStatus == "medium")
            {
                if (e.KeyCode == Keys.Left)
                {
                    goLeft = false;
                }

                if (e.KeyCode == Keys.Right)
                {
                    goRight = false;

                }

                if (e.KeyCode == Keys.Up)
                {
                    goUp = false;
                }

                if (e.KeyCode == Keys.Down)
                {
                    goDown = false;
                }

                if(e.KeyCode == Keys.Space)
                {
                    speed = 10;
                    boostCheck = false;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Space && speedCap > 1)
                {
                    speed = 10;
                    boostCheck = false;
                }
            }
            
            if(DifficulttyStatus == "easy")
            {
                if (e.KeyCode == Keys.C && ammo > 0 && gameOver == false)
                {
                    ShootBullet(facing);
                }
            }
            else if (DifficulttyStatus == "medium")
            {
                if (e.KeyCode == Keys.C && ammo > 0 && gameOver == false)
                {
                    ammo--;
                    ShootBullet(facing);

                    if (ammo < 1)
                    {
                        DropAmmo();
                    }
                }
            }
            

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }

            if(e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }

        private void SnakeGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(gameOver == false)
            {
                e.Cancel = true;
            }
        }

        public void SaveScore(int parts)
        {

            Lead_info_list Lboard = new Lead_info_list();


            if(DifficulttyStatus == "easy")
            {
                using (StreamReader sr = new StreamReader("scores_Ez.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string info = Convert.ToString(sr.ReadLine());
                        if (info != "")
                        {
                            string[] fields = info.Split(',');
                            int currentScore = Convert.ToInt32(fields[1]);
                            Lboard.addLeadInfo(new Leaderboard_info(fields[0], currentScore));
                        }
                    }
                }

                using (StreamReader sr = new StreamReader("currentAcc.txt"))
                {
                    string username = sr.ReadLine();
                    Lboard.addLeadInfo(new Leaderboard_info(username, parts));
                }


                Lboard.boardList = Lboard.boardList.OrderByDescending(o => o.getScore()).Take(5).ToList();


                using (StreamWriter sw = new StreamWriter("scores_Ez.txt"))
                {
                    for (int i = 0; i < Lboard.getLeadLength(); i++)
                    {
                        sw.WriteLine(Lboard.getLeadInfo(i).getUser() + "," + Lboard.getLeadInfo(i).getScore());
                    }
                }
            }


            else if(DifficulttyStatus == "medium")
            {
                using(StreamReader sr = new StreamReader("scores_Med.txt"))
                {
                    while(!sr.EndOfStream)
                    {
                            string info = Convert.ToString(sr.ReadLine());
                            if(info != "")
                            {
                                string[] fields = info.Split(',');
                                int currentScore = Convert.ToInt32(fields[1]);
                                Lboard.addLeadInfo(new Leaderboard_info(fields[0], currentScore));
                            } 
                    }
                }
            
                using(StreamReader sr = new StreamReader("currentAcc.txt"))
                {
                    string username = sr.ReadLine();
                    Lboard.addLeadInfo(new Leaderboard_info(username, parts));
                }

            
                Lboard.boardList = Lboard.boardList.OrderByDescending(o => o.getScore()).Take(5).ToList();
            

                using (StreamWriter sw = new StreamWriter("scores_Med.txt"))
                {
                    for(int i=0;i<Lboard.getLeadLength();i++)
                    {
                        sw.WriteLine(Lboard.getLeadInfo(i).getUser() + "," + Lboard.getLeadInfo(i).getScore());
                    }
                }
            }


            else
            {
                using (StreamReader sr = new StreamReader("scores_Hard.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string info = Convert.ToString(sr.ReadLine());
                        if (info != "")
                        {
                            string[] fields = info.Split(',');
                            int currentScore = Convert.ToInt32(fields[1]);
                            Lboard.addLeadInfo(new Leaderboard_info(fields[0], currentScore));
                        }
                    }
                }

                using (StreamReader sr = new StreamReader("currentAcc.txt"))
                {
                    string username = sr.ReadLine();
                    Lboard.addLeadInfo(new Leaderboard_info(username, parts));
                }


                Lboard.boardList = Lboard.boardList.OrderByDescending(o => o.getScore()).Take(5).ToList();


                using (StreamWriter sw = new StreamWriter("scores_Hard.txt"))
                {
                    for (int i = 0; i < Lboard.getLeadLength(); i++)
                    {
                        sw.WriteLine(Lboard.getLeadInfo(i).getUser() + "," + Lboard.getLeadInfo(i).getScore());
                    }
                }
            }

        }

        private void ShootBullet(String direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = PLayer.Left + (PLayer.Width / 2);
            shootBullet.bulletTop = PLayer.Top + (PLayer.Height / 2);
            shootBullet.MakeBullet(this);
            spit.Play();
        }


        private void MakeHead()
        {
            PLayer.Image = Properties.Resources.Hup;
            PLayer.Location = new Point(379, 263);
            PLayer.SizeMode = PictureBoxSizeMode.CenterImage;
            bodyList.addBody(PLayer);
            this.Controls.Add(PLayer);
            PLayer.BringToFront();
        }

        private void MakeMob()
        {
            mob = new PictureBox();
            mob.Tag = "mob";
            mob.Image = Properties.Resources.mdown;
            mob.Size = new Size(70, 70);
            mob.BackColor = Color.Transparent;
            mob.Left = randomNum.Next(-30, 900);
            mob.Top = randomNum.Next(-20, 700);
            mob.SizeMode = PictureBoxSizeMode.StretchImage;
            MobList.Add(mob);
            this.Controls.Add(mob);
            mob.BringToFront();

        }

        private void DropAmmo()
        {
            Ammo = new PictureBox();
            Ammo.Tag = "Ammo";
            Ammo.Image = Properties.Resources.Chest_ammo;
            Ammo.Size = new Size(60, 50); 
            Ammo.SizeMode = PictureBoxSizeMode.StretchImage;
            Ammo.Left = randomNum.Next(10, this.ClientSize.Width - Ammo.Width);
            Ammo.Top = randomNum.Next(40, this.ClientSize.Height - Ammo.Height);
            this.Controls.Add(Ammo);
            ammoList.addAmmo(Ammo);
           
            Ammo.BringToFront();
            PLayer.BringToFront();
        }

        private void dropHealth()
        {
            PictureBox health = new PictureBox();
            health.Tag = "health";
            health.Image = Properties.Resources.health;
            health.Size = new Size(25,25);
            health.SizeMode = PictureBoxSizeMode.StretchImage;
            health.BackColor = Color.Transparent;
            health.Left = randomNum.Next(10, this.ClientSize.Width - health.Width - 10);
            health.Top = randomNum.Next(40, this.ClientSize.Height - health.Height - 10);
            this.Controls.Add(health);

            health.BringToFront();
        }
        
        private void dropParts(int x,int y)
        {
            Parts = new PictureBox();
            Parts.Tag = "parts";
            Parts.Image = Properties.Resources.parts;
            Parts.Size = new Size(30, 40);
            Parts.SizeMode = PictureBoxSizeMode.StretchImage;
            Parts.BackColor = Color.Transparent;
            Parts.Left = x;
            Parts.Top = y;
            this.Controls.Add(Parts);

            partsList.addParts(Parts);
            Parts.BringToFront();
        }

        private void ClearAllPictureBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && (string)c.Tag == "health")
                {
                    this.Controls.Remove(c);
                    ((PictureBox)c).Dispose();
                }

                if (c is PictureBox && (string)c.Tag == "Ammo")
                {
                    this.Controls.Remove(c);
                    ((PictureBox)c).Dispose();
                }
            }
        }

        private void RestartGame()
        {
            PLayer.Image = Properties.Resources.Hup;
            foreach (PictureBox i in MobList) //search up all the locations of all the zombies that were added to the list
            {                                   //and remove all of them
                this.Controls.Remove(i);
            }

            MobList.Clear();

            foreach (PictureBox i in bodyList.Train)
            {
                this.Controls.Remove(i);
            }

            bodyList.clearBody();

             
            foreach(PictureBox i in partsList.part)
            {
                this.Controls.Remove(i);
            }

            partsList.clearParts();

            foreach (PictureBox i in ammoList.ammunition)
            {
                this.Controls.Remove(i);
            }

            ammoList.clearAmmo();

            ClearAllPictureBoxes();

            for (int i = 0; i < MobNo; i++)
            {
                MakeMob();
            }

            goUp = false;
            goLeft = false;
            goRight = false;
            goDown = false;
            gameOver = false;
            intersection = false;
            playerHealth = 100;
            kills = 0;
            ammo = 10;
            speedCap = 100;
            parts = 0;

            if (DifficulttyStatus == "hard")
            {
                bulletTimer.Interval = 1500;
                bulletTimer.Tick += (sender, e) => ShootBullet(facing);
                bulletTimer.Start();

                mobTimer.Interval = 20000;
                mobTimer.Tick += (sender, e) => MakeMob();
                mobTimer.Start();
            }


            MakeHead();

            GameTimer.Start();

        }

    }
}
