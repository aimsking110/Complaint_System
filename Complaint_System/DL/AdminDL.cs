using Complaint_System.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint_System.DL
{
    class AdminDL
    {
        private DBConnection dbCon;
        private CustomerDTO cDTO;
        public AdminDL()
        {
            dbCon = new DBConnection();
            cDTO = new CustomerDTO();
        }
        public void CreateAccountInDB(UserDTO ud)
        {
            try
            {
                dbCon.Con.Open();
                string queryString1 = "INSERT INTO  Users VALUES (@UserID,  @Name ,  @Password,@Role , @CNIC , @PhoneNumber ); INSERT INTO  Customer VALUES (@UserID,  @Name ,  @Password,@Role , @CNIC , @PhoneNumber );";
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

 

        public DataTable GetComplainFromDB()
        {
            DataTable dt = new DataTable();
            try
            {
                dbCon.Con.Open();
                string queryString1 = "Select * FROM Complain ;";
                SqlCommand com = new SqlCommand(queryString1, dbCon.Con);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;
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

        public DataTable GetCustomerFromDB()
        {
            DataTable dt = new DataTable();
            try
            {
                dbCon.Con.Open();
                string queryString1 = "Select * FROM Customer ;";
                SqlCommand com = new SqlCommand(queryString1, dbCon.Con);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;
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


        public void DeleteCustomerFromDB(UserDTO udto)
        {
            try
            {
                dbCon.Con.Open();
                string querystring = "Delete From Customer WHERE UserID=@UserID, Name= @Name , Password= @Password,Role = @Role ,CNIC= @CNIC ,PhoneNumber= @PhoneNumber";
                SqlCommand com = new SqlCommand(querystring, dbCon.Con);
                com.Parameters.AddWithValue("@UserID", udto.UserID);
                com.Parameters.AddWithValue("@Name", udto.Name);
                com.Parameters.AddWithValue("@Password", udto.Password);
                com.Parameters.AddWithValue("Role", udto.Role);
                com.Parameters.AddWithValue("CNIC", udto.Cnic);
                com.Parameters.AddWithValue("PhoneNumber", udto.PhoneNumber);
                int rowAffected = com.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw ex;

            }
        }
    }
}