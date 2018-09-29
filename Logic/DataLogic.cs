using alexa_challenge.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace alexa_challenge.Logic
{
    public class DataLogic
    {
        public static SqlConnection connection;
        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                string conString = ConfigurationManager.AppSettings["connectionString"];
                connection = new SqlConnection(conString);
            }
            return connection;
        }
        public static async Task SaveTransaction(UserDetails userDetails)
        {
            try
            {
                Trace.TraceInformation("About to save transaction");
                using (SqlConnection con = GetConnection())
                {
                    con.Open();
                    string cmd = $"INSERT User_Details(Name, Phone_number, Email, Device_Id) values ({userDetails.UserName},{userDetails.PhoneNumber}, {userDetails.Email}, {userDetails.DeviceId})";
                    using (SqlCommand sCmd = new SqlCommand(cmd, con))
                    {
                        sCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.TraceInformation($"An error occured while saving transaction. Message:{ex.Message} Inner Exception: {ex.InnerException}, Stack: {ex.StackTrace}");
            }
        }
       
        public static UserDetails GetUserDetails(string deviceId)
        {
            List<UserDetails> userDetails = new List<UserDetails>();
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();
                    string query =
                        $"select * from User_Details where Device_Id ='{deviceId}'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    userDetails.Add(new UserDetails()
                                    {
                                        UserName=reader["Name"]?.ToString(),
                                        PhoneNumber=reader["Phone_number"]?.ToString(),
                                        Email=reader["Email"]?.ToString(),
                                        Id=(int)reader["Id"],
                                        DeviceId=reader["Device_Id"]?.ToString()

                                    });
                                }
                                catch (Exception)
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.TraceInformation($"An error occured while getting logs. Message:{ex.Message} Inner Exception: {ex.InnerException}, Stack: {ex.StackTrace}");
            }
            return userDetails.FirstOrDefault();
        }
    }
}
