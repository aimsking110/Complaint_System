using Complaint_System.DL;
using Complaint_System.DTO;
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
   
        public Form1 VerifyUser(LoginDTO lg)
        {
            // Here we call loginDL objects method verifyUserFromDB
            UserDTO ud = _lgDL.VerifyUserFromDB(lg);
            if (ud == null)
            {
                //   return new WrongUserGUI();
            }
            if (ud.Role == "admin")
            {
                // return new AdminMainGUI(ud);
            }
            else
            {
                //
            }
            return null;
        }
    }
}
