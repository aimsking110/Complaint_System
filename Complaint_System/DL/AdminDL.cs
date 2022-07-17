using Complaint_System.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint_System.DL
{
    class AdminDL
    {
        private DBConnection dbCon;
        public AdminDL()
        {
            dbCon = new DBConnection();
        }
        public void CreateAccountInDB(UserDTO ud)
        {
            try
            {
                dbCon.Con.Open();
                string queryString1 = "INSERT INTO  Users VALUES (@UserID,  @Name ,  @Password,@Role , @CNIC , @PhoneNumber );";
                SqlCommand com = new SqlCommand(queryString1, dbCon.Con);
                com.Parameters.AddWithValue("@UserID", ud.UserID);
                com.Parameters.AddWithValue("@Name", ud.Name);
                com.Parameters.AddWithValue("@Password", ud.Password);
                com.Parameters.AddWithValue("@CNIC", ud.Cnic);
                com.Parameters.AddWithValue("@PhoneNumber", ud.PhoneNumber);
                com.Parameters.AddWithValue("@Role", ud.Role);
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

        public void AddCustomerInDB(UserDTO ud)
        {

        }
    }
}