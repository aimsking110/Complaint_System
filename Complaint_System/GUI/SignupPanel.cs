using Complaint_System.BL;
using Complaint_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complaint_System.GUI
{
    public partial class SignupPanel : Form
    {
        private UserDTO _user;
        private AdminBL aBL;

        public SignupPanel()
        {
            InitializeComponent();
            aBL = new AdminBL();
            _user = new UserDTO();
        }

        private void SignupPanel_Load(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txt_name.Text == "" || txt_name.Text == "" || txt_password.Text == "" || txt_pNumber.Text == ""))
                {
                    _user.UserID = txt_userID.Text;
                    _user.Name = txt_name.Text;
                    _user.Password = txt_password.Text;
                    _user.PhoneNumber = txt_pNumber.Text;
                    _user.Cnic = txt_cnic.Text;
                    _user.Role = txt_role.Text;
                    aBL.CreateAccount(_user);
                    MessageBox.Show("Account has been successfuly created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Account has not been created due to " + ex.Message);
            }
        }
    }
}
