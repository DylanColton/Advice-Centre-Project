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
    class AppointmentsDAL
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["AdviceCentre-2017"].ConnectionString;

        public static int AddNewAppointment(DateTime AppointmentDate, int ClientID, int StaffID, int RoomID, int AdviceID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand insertAppointment = new SqlCommand("INSERT INTO Appointments VALUES(@AppointmentDate,@ClientID,@StaffID,@AdviceID,@RoomID)", connection))
                {
                    insertAppointment.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                    insertAppointment.Parameters.AddWithValue("@ClientID", ClientID);
                    insertAppointment.Parameters.AddWithValue("@StaffID", StaffID);
                    insertAppointment.Parameters.AddWithValue("@AdviceID", AdviceID);
                    insertAppointment.Parameters.AddWithValue("@RoomID", RoomID);
                    int rows = insertAppointment.ExecuteNonQuery();
                    return rows;
                }
            }
        }

        public static int EditAppointment(int AppointmentID, DateTime AppointmentDate, int ClientID, int StaffID, int AdviceID, int RoomID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand editAppointment = new SqlCommand("UPDATE Appointments SET appointmentDate=@AppointmentDate, clientID=@ClientID, staffID=@StaffID, adviceID=@AdviceID, roomID=@RoomID" + " WHERE appointmentID=@AppointmentID", connection))
                {
                    editAppointment.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                    editAppointment.Parameters.AddWithValue("@ClientID", ClientID);
                    editAppointment.Parameters.AddWithValue("@StaffID", StaffID);
                    editAppointment.Parameters.AddWithValue("@AdviceID", AdviceID);
                    editAppointment.Parameters.AddWithValue("@RoomID", RoomID);
                    editAppointment.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                    int rows = editAppointment.ExecuteNonQuery();
                    return rows;
                }
            }
        }

        public static int DeleteAppointment(int AppointmentID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand deleteAppointment = new SqlCommand("DELETE FROM Appointments " + " WHERE AppointmentID=@AppointmentID", connection))
                {
                    deleteAppointment.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                    int rows = deleteAppointment.ExecuteNonQuery();
                    return rows;
                }
            }
        }

        public static DataSet PopulateClientIDCombobox()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                DataSet ClientDS = new DataSet();

                using (SqlCommand populatecombo = new SqlCommand("SELECT ClientID, ClientName FROM Client", connection))
                {
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = populatecombo;
                    Da.Fill(ClientDS);
                    return ClientDS;
                }
            }
        }

        public static DataTable SelectCertainClients(int ClientID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectClient = new SqlCommand("SELECT ClientID,ClientName FROM Client WHERE clientID=@ClientID", connection))
                    {
                        selectClient.Parameters.AddWithValue("@ClientID", ClientID);
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectClient);
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

        public static DataTable SelectCertainStaff(int StaffID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectStaff = new SqlCommand("SELECT StaffID,StaffName FROM Staff WHERE StaffID=@StaffID", connection))
                    {
                        selectStaff.Parameters.AddWithValue("@StaffID", StaffID);
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectStaff);
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

        public static DataTable SelectCertainAdvice(int AdviceID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectAdvice = new SqlCommand("SELECT AdviceID,AdviceName FROM Advice WHERE AdviceID=@AdviceID", connection))
                    {
                        selectAdvice.Parameters.AddWithValue("@AdviceID", AdviceID);
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectAdvice);
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

        public static DataSet PopulateStaffIDCombobox()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                DataSet StaffDS = new DataSet();

                using (SqlCommand populatecombo = new SqlCommand("SELECT StaffID, StaffName FROM Staff", connection))
                {
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = populatecombo;
                    Da.Fill(StaffDS);
                    return StaffDS;
                }
            }
        }

        public static DataSet PopulateRoomIDCombobox()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                DataSet RoomDS = new DataSet();

                using (SqlCommand populatecombo = new SqlCommand("SELECT RoomID FROM Room", connection))
                {
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = populatecombo;
                    Da.Fill(RoomDS);
                    return RoomDS;
                }
            }
        }

        public static DataSet PopulateAdviceIDCombobox()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                DataSet AdviceDS = new DataSet();

                using (SqlCommand populatecombo = new SqlCommand("SELECT AdviceID, AdviceName FROM Advice", connection))
                {
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = populatecombo;
                    Da.Fill(AdviceDS);
                    return AdviceDS;
                }
            }
        }

        public static DataTable SelectAllAppointments()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectAllAppointments = new SqlCommand("SELECT * FROM Appointments", connection))
                    {
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectAllAppointments);
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

        public static DataTable SelectAppointmentbyCriteria(DateTime AppointmentDate, int Room, int Staff)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectAppByCriteria = new SqlCommand("SELECT * FROM Appointments WHERE appointmentDate=@AppointmentDate AND staffID=@StaffID AND roomID=@RoomID", connection))
                    {
                        selectAppByCriteria.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        selectAppByCriteria.Parameters.AddWithValue("@RoomID", Room);
                        selectAppByCriteria.Parameters.AddWithValue("@StaffID", Staff);
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectAppByCriteria);
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

        public static DataTable SelectStaffAppointments(DateTime AppointmentDate, int Staff)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectAppByCriteria = new SqlCommand("SELECT AppointmentDate,StaffID FROM Appointments WHERE appointmentDate=@AppointmentDate AND staffID=@StaffID", connection))
                    {
                        selectAppByCriteria.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        selectAppByCriteria.Parameters.AddWithValue("@StaffID", Staff);
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectAppByCriteria);
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

        public static DataTable SelectAppointmentbyClient(int ClientID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectAppByCriteria = new SqlCommand("SELECT * FROM Appointments WHERE clientID=@ClientID", connection))
                    {
                        selectAppByCriteria.Parameters.AddWithValue("@ClientID", ClientID);
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectAppByCriteria);
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

        public static DataTable SelectAppointmentbyStaff(int StaffID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectAppByCriteria = new SqlCommand("SELECT * FROM Appointments WHERE staffID=@StaffID", connection))
                    {
                        selectAppByCriteria.Parameters.AddWithValue("@StaffID", StaffID);
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectAppByCriteria);
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

        public static DataTable SelectAppointmentbyDate(DateTime AppointmentDate)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectAppByCriteria = new SqlCommand("SELECT * FROM Appointments WHERE appointmentDate=@AppointmentDate", connection))
                    {
                        selectAppByCriteria.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectAppByCriteria);
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
