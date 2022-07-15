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
            string[] appPath = path.Split(new string[] { "bin" }, StringSplitOptions.None);
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\umaru\Documents\CL&TS.mdf;Integrated Security=True";
            Con = new SqlConnection(conString);
        }

        public SqlConnection Con { get => con; set => con = value; }
    }
}
