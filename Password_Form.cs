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
    public partial class Password_Form : Form
    {
        AccountsList accountsList;
        private bool validAcc = false;
        private string Login_username;

        public Password_Form()
        {
            InitializeComponent();
            playTrack();
            accountsList = new AccountsList();
        }

        private void playTrack()
        {
            SoundPlayer soundtrack = new SoundPlayer(Properties.Resources.Intro_soundtrack);
            soundtrack.PlayLooping();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void AddAccBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddingAcc ec = new AddingAcc();
            ec.ShowDialog();
            this.Show();
        }
        
        private void RemoveAccBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveAcc ra = new RemoveAcc();
            ra.ShowDialog();
            this.Show();
        }

        public void Login()
        {
            for (int i = 0; i < accountsList.AccLength(); i++)
            {
                accountsList.removeAcc(i);
            }

            using (StreamReader sr = new StreamReader("account.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string info = Convert.ToString(sr.ReadLine());
                    if (info != "")
                    {
                        string[] fields = info.Split(',');
                        accountsList.addAccount(new Account(fields[0], fields[1]));
                    }
                }
            }

            for (int i = 0; i < accountsList.AccLength(); i++)
            {
                if (UsernameTB.Text == accountsList.getAccount(i).getUser() && PasswordTB.Text == accountsList.getAccount(i).getPass())
                {
                    Login_username = accountsList.getAccount(i).getUser();
                    validAcc = true;
                }
            }

            using (StreamWriter clearing = new StreamWriter("currentAcc.txt"))
            {
                clearing.Write("");
            }

            using (StreamWriter sw = new StreamWriter("currentAcc.txt"))
            {
                sw.Write(Login_username);
            }

            if (validAcc == false)
            {
                MessageBox.Show("Invalid password.", "Error");
            }
            else if (validAcc == true)
            {
                this.Hide();
                Menu_Form mf = new Menu_Form();
                mf.ShowDialog();
                this.Close();
                validAcc = false;
            }

            this.UsernameTB.Text = "";
            this.PasswordTB.Text = "";
        }

        
    }
}
