using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keykeeper
{

    public  class Account
    {

        public string link,user,pass;
        public Account(String link,String user,String pass)
        {
            this.link = link;
            this.user = user;
            this.pass = pass;
        }
    }
}
