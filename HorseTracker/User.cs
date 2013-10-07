using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTracker
{
    public class User
    {
        private string id;
        private string username;
        private string fullname;
        private string password;
        private string email;
        private string dob;

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Id
        {
          get { return id; }
          set { id = value; }
        }

        public override string ToString()
        {
            return "userid=" + id + "&username=" + username + "&password=" +
                password + "&fullname=" + fullname + "&email=" + email + "&dob=" + dob;
        }

        public User(string id, string username, string password, string fullname, string email, string dob)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.fullname = fullname;
            this.email = email;
            this.dob = dob;
        }

        
    }
}
