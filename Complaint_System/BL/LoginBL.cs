using Complaint_System.DL;
using Complaint_System.DTO;
using Complaint_System.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complaint_System.BL
{
    class LoginBL
    {
        private LoginDL _lgDL;
        public LoginBL()
        {
            _lgDL = new LoginDL();
        }

        public Form VerifyUser(LoginDTO lg)
        {

            UserDTO ud = _lgDL.VerifyUserFromDB(lg);
            if (ud == null)
            {
                return new InvalidLogin();
            }
            if (ud.Role == "Admin")
            {
                return new adminPanel();
            }

            else if (ud.Role == "Customer")
            {
                return new CustomerPanel();
            }

            return new InvalidLogin();
        }
    }
}