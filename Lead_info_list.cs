using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieProject
{
    class Lead_info_list
    {
        public List<Leaderboard_info> boardList;

        public Lead_info_list()
        {
            boardList = new List<Leaderboard_info>();
        }

        public Leaderboard_info getLeadInfo(int i)
        {
            return this.boardList[i];
        }

        public int getLeadLength()
        {
            return this.boardList.Count();
        }

        public void addLeadInfo(Leaderboard_info i)
        {
            this.boardList.Add(i);
        }

    }
}
