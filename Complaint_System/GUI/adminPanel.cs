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
    }
}
