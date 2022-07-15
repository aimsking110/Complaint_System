using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint_System.DTO
{
    class UserDTO
    {
        private string _userID;
        private string _name;
        private string _password;
        private string _role;

        public string UserID { get => _userID; set => _userID = value; }
        public string Name { get => _name; set => _name = value; }
        public string Password { get => _password; set => _password = value; }
        public string Role { get => _role; set => _role = value; }

    }
}
