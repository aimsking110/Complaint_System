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
    public partial class InvalidLogin : Form
    {
        public InvalidLogin()
        {
            InitializeComponent();
        }

        private void InvalidLogin_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 500);
        }
    }
}
