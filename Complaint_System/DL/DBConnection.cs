using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint_System.DL
{
    class DBConnection
    {
        private SqlConnection con;
        public DBConnection()
        {
            string path = Environment.CurrentDirectory;
           
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\umaru\Source\Repos\aimsking110\Complaint_System\Complaint_System\CLTS.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(conString);
        }

        public SqlConnection Con { get => con; set => con = value; }
    }
}
