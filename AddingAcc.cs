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

namespace ZombieProject
{
    public partial class AddingAcc : Form
    {
        AccountsList AcctList;
        
        public AddingAcc()
        {
            InitializeComponent();
            AcctList = new AccountsList();
            using (StreamReader sr = new StreamReader("account.txt"))
            {
                while (sr.EndOfStream == false)
                {
                    string info = Convert.ToString(sr.ReadLine());
                    if (info != "")
                    {
                        string[] field = info.Split(',');
                        AcctList.addAccount(new Account(field[0], field[1]));
                    }

                }
            }
            using (StreamWriter clearing = new StreamWriter("account.txt"))
            {
                clearing.Write("");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            using (StreamReader sr = new StreamReader("account.txt"))
            {
                while (sr.EndOfStream == false)
                {
                    string info = Convert.ToString(sr.ReadLine());
                    if (info != "")
                    {
                        string[] field = info.Split(',');
                        AcctList.addAccount(new Account(field[0], field[1]));
                    }

                }
            }

            using (StreamWriter clearing = new StreamWriter("account.txt"))
            {
                clearing.Write("");
            }

            using (StreamWriter sw = new StreamWriter("account.txt"))
                {
                    if (UsernameTB.Text != "" && PasswordTB.Text != "")
                    {

                        for (int i = 0; i < AcctList.AccLength(); i++)
                        {
                            sw.WriteLine(AcctList.getAccount(i).getUser() + "," + AcctList.getAccount(i).getPass());
                        }
                        sw.WriteLine(UsernameTB.Text + "," + PasswordTB.Text);

                        MessageBox.Show("Account has been added.");
                    }
                    else
                    {
                        MessageBox.Show("Please fill in your account", "Error");
                    }
                    sw.Close();

                    UsernameTB.Text = "";
                    PasswordTB.Text = "";
                }
                
                    
                



            }
        }
    }
