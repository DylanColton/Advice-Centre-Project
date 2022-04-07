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
    class ClientReferralDAL
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["AdviceCentre-2017"].ConnectionString;
        
        public static int AddNewClientReferral(int ClientID, int ReferralID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand insertClientReferral = new SqlCommand("INSERT INTO ClientReferral VALUES(@ClientID,@ReferralID)", connection))
                {
                    insertClientReferral.Parameters.AddWithValue("@ClientID", ClientID);
                    insertClientReferral.Parameters.AddWithValue("@ReferralID", ReferralID);
                    int rows = insertClientReferral.ExecuteNonQuery();
                    return rows;
                }
            }
        }
        
        public static int DeleteClientReferral(int ClientID, int ReferralID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand deleteClientReferral = new SqlCommand("DELETE FROM ClientReferral " + " WHERE ClientID=@ClientID AND ReferralID=@ReferralID", connection))
                {
                    deleteClientReferral.Parameters.AddWithValue("@ClientID", ClientID);
                    deleteClientReferral.Parameters.AddWithValue("@ReferralID", ReferralID);
                    int rows = deleteClientReferral.ExecuteNonQuery();
                    return rows;
                }
            }
        }
        
        public static DataTable SelectAllClientReferrals()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectAllClients = new SqlCommand("SELECT * FROM ClientReferral", connection))
                    {
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectAllClients);
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

        public static DataTable SelectClientReferralsFromClients(int ClientID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectClientReferrals = new SqlCommand("SELECT * FROM ClientReferral WHERE clientID=@ClientID", connection))
                    {
                        selectClientReferrals.Parameters.AddWithValue("@ClientID", ClientID);
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectClientReferrals);
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

        public static DataTable SelectClientReferralsFromReferrals(int ReferralID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectClientReferrals = new SqlCommand("SELECT * FROM ClientReferral WHERE referralID=@ReferralID", connection))
                    {
                        selectClientReferrals.Parameters.AddWithValue("@ReferralID", ReferralID);
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectClientReferrals);
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
    }
}
