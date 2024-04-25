using Microsoft.Data.SqlClient;
using RestourantDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClientApp
{
    public class DatabaseHelper
    {
        private const string connectionString = "workstation id=Restourant.mssql.somee.com;packet size=4096;user id=Wiles_SQLLogin_1;pwd=9tdk5ikk9r;data source=Restourant.mssql.somee.com;persist security info=False;initial catalog=Restourant;TrustServerCertificate=True"; // Підставте свій рядок підключення до бази даних

        public static bool CheckIfLoginExists(string login)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Clients WHERE Login = @Login";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static bool CheckIfPhoneNumberExists(string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Clients WHERE PhoneNukmber = @PhoneNukmber";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PhoneNukmber", phoneNumber);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static void AddClientToDatabase(Client client)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Clients (FirstName, LastName, PhoneNukmber, Email, Address, Login, Password) " +
                               "VALUES (@FirstName, @LastName, @PhoneNukmber, @Email, @Address, @Login, @Password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", client.FirstName);
                    command.Parameters.AddWithValue("@LastName", client.LastName);
                    command.Parameters.AddWithValue("@PhoneNukmber", client.PhoneNukmber);
                    command.Parameters.AddWithValue("@Email", client.Email);
                    command.Parameters.AddWithValue("@Address", client.Address);
                    command.Parameters.AddWithValue("@Login", client.Login);
                    command.Parameters.AddWithValue("@Password", client.Password);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static bool CheckCredentials(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Clients WHERE Login = @Login AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                ///////just for test pull
            }
        }
    }
}
