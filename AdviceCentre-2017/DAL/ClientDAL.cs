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
    public class ClientDAL
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["AdviceCentre-2017"].ConnectionString;

        public static int AddNewClient(string ClientName, string ClientDescription, string ClientPhoneNo, string ClientEmail)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand insertClient =new SqlCommand("INSERT INTO Client VALUES(@ClientName,@ClientDescription,@ClientPhoneNo,@ClientEmail)", connection))
                {
                    insertClient.Parameters.AddWithValue("@ClientName", ClientName);
                    insertClient.Parameters.AddWithValue("@ClientDescription", ClientDescription);
                    insertClient.Parameters.AddWithValue("@ClientPhoneNo", ClientPhoneNo);
                    insertClient.Parameters.AddWithValue("@ClientEmail", ClientEmail);
                    int rows = insertClient.ExecuteNonQuery();
                    return rows;
                }
            }
        }

        public static int EditClient(int ClientID, string ClientName, string ClientDescription, string ClientPhoneNo, string ClientEmail)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand editClient = new SqlCommand("UPDATE Client SET clientName=@ClientName, clientDescription=@ClientDescription, clientPhoneNo=@ClientPhoneno, clientEmail=@ClientEmail" + " WHERE clientID=@ClientID", connection))
                {
                    editClient.Parameters.AddWithValue("@ClientName", ClientName);
                    editClient.Parameters.AddWithValue("@ClientDescription", ClientDescription);
                    editClient.Parameters.AddWithValue("@ClientPhoneNo", ClientPhoneNo);
                    editClient.Parameters.AddWithValue("@ClientEmail", ClientEmail);
                    editClient.Parameters.AddWithValue("@ClientID", ClientID);
                    int rows = editClient.ExecuteNonQuery();
                    return rows;
                }
            }
        }

        public static int DeleteClient(int ClientID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand deleteClient=new SqlCommand("DELETE FROM Client " + " WHERE ClientID=@ClientID", connection))
                {
                    deleteClient.Parameters.AddWithValue("@ClientID", ClientID);
                    int rows = deleteClient.ExecuteNonQuery();
                    return rows;
                }
            }
        }

        public static DataTable SelectAllClients()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectAllClients = new SqlCommand("SELECT * FROM Client", connection))
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

        public static DataTable SelectClientsByName(string ClientName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string SearchQuery = string.Format("SELECT * FROM Client WHERE ClientName LIKE '{0}%'", ClientName);
                    using (SqlCommand selectClientsByName = new SqlCommand(SearchQuery, connection))
                    {
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectClientsByName);
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

        public static DataTable SelectClientsByID(int ClientID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string SearchQuery = string.Format("SELECT * FROM Client WHERE ClientID LIKE '{0}%'", ClientID);
                    using (SqlCommand selectClientsByName = new SqlCommand(SearchQuery, connection))
                    {
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectClientsByName);
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

