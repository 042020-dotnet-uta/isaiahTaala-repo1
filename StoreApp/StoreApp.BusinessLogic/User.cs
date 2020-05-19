using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp.BusinessLogic
{
    public class User
    {
        private string _email;

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                var newEmail = value.ToLower();
                _email = newEmail;
            }
        }
        public string Password { get; set; }
    }
}
