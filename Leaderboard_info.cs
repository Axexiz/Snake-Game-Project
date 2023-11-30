using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieProject
{
    class Leaderboard_info
    {
        private string username;
        private int score;

        public Leaderboard_info(string username , int parts)
        {
            this.username = username;
            this.score = parts;
        }

        public string getUser()
        {
            return this.username;
        }

        public int getScore()
        {
            return this.score;
        }
    }
}
