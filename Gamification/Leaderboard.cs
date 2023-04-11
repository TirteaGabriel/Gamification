using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamification
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-3FVN9CH;Initial Catalog=users_database;Integrated Security=True");

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT UserName, Credite FROM Login ORDER BY Credite DESC", connection);
            SqlDataReader reader = command.ExecuteReader();

            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.Username = reader.GetString(0);
                user.Credit = reader.GetInt32(1);
                users.Add(user);
            }

            reader.Close();
            connection.Close();
            dataGridView1.DataSource = users;
        }

        Login form1 = new Login();
        private void back_menu_Click(object sender, EventArgs e)
        {
            int admin = form1.GetAdminForUser(AppData.CurrentUser.Username);
            if (admin == 0)
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else if (admin == 1)
            {
                Menu_Admin menu = new Menu_Admin();
                menu.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
