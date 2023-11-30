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
    public partial class Leaderboard : Form
    {
        Lead_info_list leadList_Ez;
        Lead_info_list leadList_Med;
        Lead_info_list leadList_Hard;
        public Leaderboard()
        {
            InitializeComponent();

            leadList_Ez = new Lead_info_list();
            leadList_Med = new Lead_info_list();
            leadList_Hard = new Lead_info_list();

//==================================================================================================================================================

            ScoreboardDGV_Ez.ColumnCount = 2;
            ScoreboardDGV_Ez.Columns[0].HeaderText = "Name";
            ScoreboardDGV_Ez.Columns[1].HeaderText = "Score";


            ScoreboardDGV_Ez.AllowUserToAddRows = false;
            ScoreboardDGV_Ez.AllowUserToResizeRows = false;
            ScoreboardDGV_Ez.MultiSelect = false;

            ScoreboardDGV_Ez.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ScoreboardDGV_Ez.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

//==================================================================================================================================================
            ScoreboardDGV_Med.ColumnCount = 2;
            ScoreboardDGV_Med.Columns[0].HeaderText = "Name";
            ScoreboardDGV_Med.Columns[1].HeaderText = "Score";


            ScoreboardDGV_Med.AllowUserToAddRows = false;
            ScoreboardDGV_Med.AllowUserToResizeRows = false;
            ScoreboardDGV_Med.MultiSelect = false;

            ScoreboardDGV_Med.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ScoreboardDGV_Med.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

//==================================================================================================================================================

            ScoreboardDGV_Hard.ColumnCount = 2;
            ScoreboardDGV_Hard.Columns[0].HeaderText = "Name";
            ScoreboardDGV_Hard.Columns[1].HeaderText = "Score";


            ScoreboardDGV_Hard.AllowUserToAddRows = false;
            ScoreboardDGV_Hard.AllowUserToResizeRows = false;
            ScoreboardDGV_Hard.MultiSelect = false;

            ScoreboardDGV_Hard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ScoreboardDGV_Hard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

//==================================================================================================================================================

            using (StreamReader sr = new StreamReader("scores_Ez.txt"))
            {
                while(!sr.EndOfStream)
                {
                    string info = sr.ReadLine();
                    if(info != "")
                    {
                        string[] fields = info.Split(',');
                        leadList_Ez.addLeadInfo(new Leaderboard_info( fields[0] , Convert.ToInt32(fields[1]) ));
                    }
                }
            }

            using (StreamReader sr = new StreamReader("scores_Med.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string info = sr.ReadLine();
                    if (info != "")
                    {
                        string[] fields = info.Split(',');
                        leadList_Med.addLeadInfo(new Leaderboard_info(fields[0], Convert.ToInt32(fields[1])));
                    }
                }
            }

            using (StreamReader sr = new StreamReader("scores_Hard.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string info = sr.ReadLine();
                    if (info != "")
                    {
                        string[] fields = info.Split(',');
                        leadList_Hard.addLeadInfo(new Leaderboard_info(fields[0], Convert.ToInt32(fields[1])));
                    }
                }
            }

            refreshDGV_Ez();
            refreshDGV_Med();
            refreshDGV_Hard();
        }

        public void refreshDGV_Ez()
        {
            ScoreboardDGV_Ez.Rows.Clear();
            for (int i = 0; i < leadList_Ez.getLeadLength(); i++)
            {
                ScoreboardDGV_Ez.Rows.Add();
                ScoreboardDGV_Ez.Rows[i].Cells[0].Value = leadList_Ez.getLeadInfo(i).getUser();
                ScoreboardDGV_Ez.Rows[i].Cells[1].Value = leadList_Ez.getLeadInfo(i).getScore();
            }
        }

        public void refreshDGV_Med()
        {
            ScoreboardDGV_Med.Rows.Clear();
            for (int i = 0; i < leadList_Med.getLeadLength(); i++)
            {
                ScoreboardDGV_Med.Rows.Add();
                ScoreboardDGV_Med.Rows[i].Cells[0].Value = leadList_Med.getLeadInfo(i).getUser();
                ScoreboardDGV_Med.Rows[i].Cells[1].Value = leadList_Med.getLeadInfo(i).getScore();
            }
        }

        public void refreshDGV_Hard()
        {
            ScoreboardDGV_Hard.Rows.Clear();
            for (int i = 0; i < leadList_Hard.getLeadLength(); i++)
            {
                ScoreboardDGV_Hard.Rows.Add();
                ScoreboardDGV_Hard.Rows[i].Cells[0].Value = leadList_Hard.getLeadInfo(i).getUser();
                ScoreboardDGV_Hard.Rows[i].Cells[1].Value = leadList_Hard.getLeadInfo(i).getScore();
            }
        }
    }
}
