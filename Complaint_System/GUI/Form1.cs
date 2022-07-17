using Complaint_System.BL;
using Complaint_System.DTO;
using Complaint_System.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complaint_System
{
    public partial class Form1 : Form
    {
        private SignupPanel _sp;
        private LoginDTO _lgDTO;
        private LoginBL _lgBL;
        private UserDTO _UDTO;
        public Form1()
        {
            InitializeComponent();
            _lgDTO = new LoginDTO();
            _lgBL = new LoginBL();
            _UDTO = new UserDTO();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(txt_Username.Text == " " || txt_password.Text == " "))
            {
                _lgDTO.Username = txt_Username.Text;
                _lgDTO.Password = txt_password.Text;
                _lgBL.VerifyUser(_lgDTO).ShowDialog();
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           _sp - new SignupPanel();
           _sp.Show();
            this.Hide();
        }
    }
}