using Complaint_System.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint_System.DL
{
    class CustomerDL
    {
        private DBConnection dbCon;
        public CustomerDL()
        {
            dbCon = new DBConnection();
        }
        public void RegisterComplainInDB(CustomerDTO cdto)
        {
            try
            {
                dbCon.Con.Open();
                string queryString1 = "INSERT INTO  Complain VALUES (@ComplainID,  @ComplainDescription ,  @ComplainStatus,@DeptName );";
                SqlCommand com = new SqlCommand(queryString1, dbCon.Con);
                com.Parameters.AddWithValue("@ComplainID", cdto.ComplainID1);
                com.Parameters.AddWithValue("@ComplainDescription", cdto.ComplainDescription1);
                com.Parameters.AddWithValue("@ComplainStatus", cdto.ComplainStatus1);
                com.Parameters.AddWithValue("@DeptName", cdto.DeptName1);
                int rowAffected = com.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbCon.Con.Close();
            }
        }
    }
}
