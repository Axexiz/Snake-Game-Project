using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieProject
{
    class AccountsList
    {
        List<Account> accList;

        public AccountsList()
        {
            accList = new List<Account>();
        }

        public Account getAccount(int i)
        {
            return this.accList[i];
        }

        public void addAccount(Account i)
        {
            this.accList.Add(i);
        }

        public void removeAcc(int i)
        {
            this.accList.RemoveAt(i);
        }

        public int AccLength()
        {
            return this.accList.Count();
        }

        public void AccClear()
        {
            accList.Clear();
        }
    }
}
