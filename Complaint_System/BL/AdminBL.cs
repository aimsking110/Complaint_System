using Complaint_System.DL;
using Complaint_System.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint_System.BL
{
    class AdminBL
    {
        private AdminDL aDL;
        public AdminBL()
        {
            aDL = new AdminDL();
        }
        public void CreateAccount(UserDTO ud)
        {
            ud.Role.ToLower();
            aDL.CreateAccountInDB(ud);
            aDL.AddCustomerInDB(ud);
        }
    }
}
