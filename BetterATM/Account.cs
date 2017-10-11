using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterATM
{
    class Account
    {
        string userName;
        double balance;
        string password;

        Account(string userName, double balance, string password)
        {
            this.userName = userName;
            this.balance = balance;
            this.password = password;
        }

        public bool checkPassword(string password)
        {
            if(this.password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        IList<Account>  new IList
            {

            }
        Account Tommy = new Account("tkolo", 0, "stuff");

    }
}
