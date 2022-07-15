using Complaint_System.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Complaint_System.DL
{
    class LoginDL
    {
        private DBConnection dbCon;
        public LoginDL()
        {
            dbCon = new DBConnection();
        }
        public UserDTO VerifyUserFromDB(LoginDTO lg)
        {
            UserDTO retDTO = new UserDTO();
            try
            {
                dbCon.Con.Open();
                string queryString = "SELECT * FROM Users WHERE UserID=@UserID AND Password=@Password;";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@UserID", lg.Username);
                com.Parameters.AddWithValue("@Password", lg.Password);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    retDTO.UserID = reader["UserID"].ToString();
                    retDTO.Name = reader["Name"].ToString();
                    retDTO.Password = reader["Password"].ToString();
                    retDTO.Role = reader["Role"].ToString();
                    return retDTO;
                }
            }
            catch (SqlException ex)
            {
                return null;
             }
            finally
            {
                dbCon.Con.Close();
            }
            return null;
        }
    }
            
}

