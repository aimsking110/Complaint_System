using Complaint_System.BL;
using Complaint_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complaint_System.GUI
{
    public partial class CustomerPanel : Form
    {
        private LoginDTO _lgDTO;
        private CustomerDTO _csDTO;
        private CustomerBL _csBL;
        private Form1 f1;
        //private UserDTO customerDTO;
        public CustomerPanel()
        {
            InitializeComponent();
            _csBL = new CustomerBL();
            _lgDTO  = new LoginDTO();
            _csDTO = new CustomerDTO();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {
            try
            {
                lb_welcome.Text += _lgDTO.Username;

               //  lb_welcome.Text += customerDTO.Name;
            }
           
            catch (SqlException ex)
            {
                MessageBox.Show("Courses not available");
            }
        }

        private void txt_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txt_complainID.Text == "" || cb_dep.Text == "" || txt_des.Text == "" || txt_status.Text == ""))
                {
                    _csDTO.ComplainID1 = txt_complainID.Text;
                    _csDTO.ComplainDescription1 = txt_des.Text;
                    _csDTO.ComplainStatus1 = txt_status.Text;
                    _csDTO.DeptName1 = cb_dep.Text;
                    
                    _csBL.RegisterComplain(_csDTO);
                    MessageBox.Show("Customer complaint has been successfuly registered");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Account has not been created due to " + ex.Message);
            }
        }
    }
}
