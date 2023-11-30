using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieProject
{
    class Account
    {

        private string Username,Password;

        public Account(string user, string pass)
        {
            this.Username = user;
            this.Password = pass;
        }

        public string getUser()
        {
            return this.Username;
        }

        public string getPass()
        {
            return this.Password;
        }
    }
}
