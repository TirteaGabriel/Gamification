using System;
using System.Collections;
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
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
            
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3FVN9CH;Initial Catalog=users_database;Integrated Security=True");

        private void Profil_Load(object sender, EventArgs e)
        {
            conn.Open();
            string username = AppData.CurrentUser.Username;
            label_username.Text = username;

            string nume = "SELECT Nume FROM Login WHERE UserName = @Username";
            SqlCommand cmd = new SqlCommand(nume, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            string numeResult = cmd.ExecuteScalar().ToString();
            label_nume.Text = numeResult;

            string prenume = "SELECT Prenume FROM Login WHERE UserName = @Username";
            SqlCommand cmdprenume = new SqlCommand(prenume, conn);
            cmdprenume.Parameters.AddWithValue("@Username", username);
            string prenumeResult = cmdprenume.ExecuteScalar().ToString();
            label_prenume.Text = prenumeResult;

            int credits = AppData.CurrentUser.Credit;
            label_credits.Text = credits.ToString();
            if (credits < 1000)
                label_rang.Text = "Incepator";
            else if (credits >= 1000 && credits < 5000)
                label_rang.Text = "Invatacel";
            else if (credits >= 5000 && credits < 10000)
                label_rang.Text = "Intermediar";
            else if (credits >= 10000 && credits < 50000)
                label_rang.Text = "Bun";
            else if (credits >= 50000 && credits < 100000)
                label_rang.Text = "Foarte bun";
            else if (credits >= 100000)
                label_rang.Text = "Legendar";
            conn.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
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
            else if(admin == 1)
            {
                Menu_Admin menu = new Menu_Admin();
                menu.Show();
                this.Hide();
            }
        }
    }
}
