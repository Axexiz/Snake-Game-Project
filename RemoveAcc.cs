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
    public partial class RemoveAcc : Form
    {
        AccountsList AcctList;
        public RemoveAcc()
        {
            InitializeComponent();
            
            AcctList = new AccountsList();

            DGV.ColumnCount = 2;
            DGV.Columns[0].HeaderText = "Username";
            DGV.Columns[1].HeaderText = "Password";

            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToResizeRows = false;
            DGV.MultiSelect = false;

            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            using(StreamReader sr = new StreamReader("account.txt"))
            {
                while(sr.EndOfStream == false)
                {
                    string info = Convert.ToString(sr.ReadLine());
                    if(info != "")
                    {
                        string[] fields = info.Split(',');
                        AcctList.addAccount(new Account(fields[0], fields[1]));
                    }
                }
            }
            refreshDGV();
        }

        public void refreshDGV()
        {
            DGV.Rows.Clear();
            for (int i = 0; i < AcctList.AccLength(); i++)
            {
                DGV.Rows.Add();
                DGV.Rows[i].Cells[0].Value = AcctList.getAccount(i).getUser();
                DGV.Rows[i].Cells[1].Value = AcctList.getAccount(i).getPass();
            }
        }

        private void RemoveBTN_Click(object sender, EventArgs e)
        {
            int idx = DGV.CurrentRow.Index;

            AcctList.removeAcc(idx);

            using (StreamWriter clearing = new StreamWriter("account.txt"))
            {
                clearing.Write("");
            }



            using (StreamWriter sw = new StreamWriter("account.txt"))
            {
                for(int i=0; i < AcctList.AccLength(); i ++)
                {
                    sw.WriteLine(AcctList.getAccount(i).getUser() + "," + AcctList.getAccount(i).getPass());
                }
                sw.Close();
            }


            refreshDGV();

            MessageBox.Show("Account has been removed.");
        }
    }
}
