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
    public partial class adminPanel : Form
    {
        private AdminBL _AdBL;
        private UserDTO adminDTO;
        public adminPanel()
        {
            InitializeComponent();
            _AdBL = new AdminBL();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminPanel_Load(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
          //  dataGridView3.DataSource = _AdBL.GetComplain();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = _AdBL.GetComplain();
        }
    }
}
