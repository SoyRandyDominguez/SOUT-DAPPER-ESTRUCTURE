using System;
using System.Collections.Generic;
using System.Text;

namespace SOUT.Models.Records
{
    public class UsersRecord
    {

        public int UserID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }


    }
}
