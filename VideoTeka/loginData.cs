using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTeka
{
    internal class loginData
    {
        int id;
        string username;
        string email;
        string password;

        public loginData(int a, string b, string c, string d) { 
            this.id = a;
            this.username = b;
            this.email = c;
            this.password = d;
        }

        public int Id
        {
            get { return id; }
        }
        public string Password {
            get { return password; }
        }
        public string Username
        {
            get { return username; }
        }
        public string Email
        {
            get { return email; }
        }

    }
}
