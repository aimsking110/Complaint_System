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

namespace Complaint_System
{
    public partial class Form1 : Form
    {
        private LoginDTO _lgDTO;
        private LoginBL _lgBL;
        public Form1()
        {
            InitializeComponent();
            _lgDTO = new LoginDTO();
            _lgBL = new LoginBL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(txt_Username.Text == " " || txt_password.Text == " "))
            {
                _lgDTO.Username = txt_Username.Text;
                _lgDTO.Password = txt_password.Text;
                _lgBL.VerifyUser(_lgDTO).ShowDialog();
            }
        }
    }
}
