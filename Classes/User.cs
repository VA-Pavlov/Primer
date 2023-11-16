using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer.Classes
{
    internal class User
    {
        public string firstName;
        public string lastName;
        public string password;
        public string numberPhone;
        public string email;


        public User(string firstName, string email, string password)
        {
            this.firstName = firstName;
            this.email = email;
            this.password = password;
        }

       
    }
}
