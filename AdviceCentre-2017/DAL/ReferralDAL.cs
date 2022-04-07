using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace AdviceCentre_2017.DAL
{
    public class ReferralDAL
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["AdviceCentre-2017"].ConnectionString;

        public static int AddNewReferral(string ReferralName, string ReferralPhoneNo, string ReferralEmail)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand insertReferral = new SqlCommand("INSERT INTO Referral VALUES(@ReferralName, @ReferralPhoneNo, @ReferralEmail)", connection))
                {
                    insertReferral.Parameters.AddWithValue("@ReferralName", ReferralName);
                    insertReferral.Parameters.AddWithValue("@ReferralPhoneNo", ReferralPhoneNo);
                    insertReferral.Parameters.AddWithValue("@ReferralEmail", ReferralEmail);
                    int rows = insertReferral.ExecuteNonQuery();
                    return rows;
                }
            }
        }

        public static int EditReferral(int ReferralID, string ReferralName, string ReferralPhoneNo, string ReferralEmail)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand editReferral = new SqlCommand("UPDATE Referral SET referralName=@ReferralName, referralPhoneNo=@ReferralPhoneNo, referralEmail=@ReferralEmail" + " WHERE referralID=@ReferralID", connection))
                {
                    editReferral.Parameters.AddWithValue("@ReferralName", ReferralName);
                    editReferral.Parameters.AddWithValue("@ReferralPhoneNo", ReferralPhoneNo);
                    editReferral.Parameters.AddWithValue("@ReferralEmail", ReferralEmail);
                    editReferral.Parameters.AddWithValue("@ReferralID", ReferralID);
                    int rows = editReferral.ExecuteNonQuery();
                    return rows;
                }
            }
        }

        public static int DeleteReferral(int ReferralID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand deleteReferral = new SqlCommand("DELETE FROM Referral " + " WHERE ReferralID=@ReferralID", connection))
                {
                    deleteReferral.Parameters.AddWithValue("@ReferralID", ReferralID);
                    int rows = deleteReferral.ExecuteNonQuery();
                    return rows;
                }
            }
        }

        public static DataTable SelectAllReferrals()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectAllReferrals = new SqlCommand("SELECT * FROM Referral", connection))
                    {
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectAllReferrals);
                        DataTable results = new DataTable();
                        resultsReader.Fill(results);
                        return results;
                    }
                }
                catch (Exception)
                {
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static DataTable SelectReferralsByName(string ReferralName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string SearchQuery = string.Format("SELECT * FROM Referral WHERE ReferralName LIKE '{0}%'", ReferralName);
                    using (SqlCommand selectReferralsByName = new SqlCommand(SearchQuery, connection))
                    {
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectReferralsByName);
                        DataTable results = new DataTable();
                        resultsReader.Fill(results);
                        return results;
                    }
                }
                catch (Exception)
                {
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static DataTable SelectReferralsByID(int ReferralID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string SearchQuery = string.Format("SELECT * FROM Referral WHERE ReferralID LIKE '{0}%'", ReferralID);
                    using (SqlCommand selectReferralsByID = new SqlCommand(SearchQuery, connection))
                    {
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectReferralsByID);
                        DataTable results = new DataTable();
                        resultsReader.Fill(results);
                        return results;
                    }
                }
                catch (Exception)
                {
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static DataSet PopulateReferralIDCombobox()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                DataSet ReferralDS = new DataSet();

                using (SqlCommand populatecombo = new SqlCommand("SELECT ReferralID, ReferralName FROM Referral", connection))
                {
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = populatecombo;
                    Da.Fill(ReferralDS);
                    return ReferralDS;
                }
            }
        }
    }
}
