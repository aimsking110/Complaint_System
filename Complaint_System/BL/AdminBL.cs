using Complaint_System.DL;
using Complaint_System.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable GetComplain()
        {
            return aDL.GetComplainFromDB();
        }

        public DataTable GetCustomer()
        {
            return aDL.GetCustomerFromDB();
        }

        public void DeleteCustomer(UserDTO udto)
        {
            aDL.DeleteCustomerFromDB(udto);
        }
    }
}
