﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamification
{
    public class User
    {
        public string Username { get; set; }
        public int Credit { get; set; }
        public int Admin { get; set; }

        public static User CurrentUser { get; set; } = new User();


        public User()
        {
        }
        public User(string username, int credit)
        {
            Username = username;
            Credit = credit;
        }

        public void UpdateCredit(int newCredit)
        {
            //string connectionString = "Data Source=DESKTOP-3FVN9CH;Initial Catalog=users_database;Integrated Security=True";
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3FVN9CH;Initial Catalog=users_database;Integrated Security=True");
            //SqlConnection connection = new SqlConnection(connectionString);
            // Actualizarea valorii creditului utilizatorului în baza de date
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UPDATE Login SET Credite = @Credit WHERE UserName = @Username", connection);
                command.Parameters.AddWithValue("@Credit", newCredit);
                command.Parameters.AddWithValue("@Username", Username);
                command.ExecuteNonQuery();

                // Actualizarea valorii creditului utilizatorului în obiectul CurrentUser
                CurrentUser.Credit = newCredit;
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
