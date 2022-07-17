using Complaint_System.DL;
using Complaint_System.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complaint_System.BL
{
    class CustomerBL
    {
        private CustomerDL cusDL;
        public CustomerBL()
        {
            cusDL = new CustomerDL();
        }
        public void RegisterComplain(CustomerDTO ud)
        {
            cusDL.RegisterComplainInDB(ud);
                
           // aDL.AddCustomerInDB(ud);
        }
    }
}
