using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Backend.Controllers;
using Backend.Models;
using System.Text;
namespace Backend.Connector
{
       public class UserDbConnector
    {
        private SqlConnection connection;

        public UserDbConnector()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "chat.database.windows.net";
            builder.UserID = "aboualy";
            builder.Password = "****";
            builder.InitialCatalog = "chat";

            try
            {
                connection = new SqlConnection(builder.ConnectionString);
                connection.Open();
            }

            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Error in PersonDbConnector(): " + e.Message);
            }
        }



        public void SaveUser(User user)
        { 
            try
            { 
                String sql = "INSERT INTO tables VALUES ('" + user.username + "','" + user.firstname + "','" + user.lastname + "');"; 
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }

            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Error in SaveUser(): " + e.Message);
            }
        }




        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            String sql = "SELECT * from tables";

            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                }
            }
            
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Error in GetUsers(): " + e.Message);
            }

            return users;
        }
        
		

            
        }
		       
    }
