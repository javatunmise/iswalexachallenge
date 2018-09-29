using alexa_challenge.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace alexa_challenge.Logic
{
    public class TransactionProcessor
    {
        public static List<UserBankAccount> GetBalance(string phoneNumber)
        {
            List<UserBankAccount> userBankDetails = new List<UserBankAccount>();
            try
            {
                using (SqlConnection con = DataLogic.GetConnection())
                {
                    con.Open();
                    string query =
                        $"select * from User_Accounts where Phone_number ='{phoneNumber}'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    userBankDetails.Add(new UserBankAccount()
                                    {
                                        AccountName = reader["Account_Name"]?.ToString(),
                                        PhoneNumber = reader["Phone_number"]?.ToString(),
                                        AccountNumber = reader["Account_Number"]?.ToString(),
                                        AccountBalance = (decimal)reader["Id"]
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
            return userBankDetails;
        }
    }
}
