using System.Data;
using System.Data.SqlClient;

namespace Gamification
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3FVN9CH;Initial Catalog=users_database;Integrated Security=True");
        User user;
        private void Login_Load(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }
        
        private void button_login_Click(object sender, EventArgs e)
        {
            conn.Open();
            string username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;
            try
            {
                String querry = "SELECT * FROM Login WHERE UserName = '" + txt_username.Text + "'AND Parola = '" + txt_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = txt_password.Text;
                    user_password = txt_password.Text;
                    int credits = GetCreditsForUser(username);
                    int admin = GetAdminForUser(username);
                    user = new User { Username = username, Credit = credits, Admin = admin };
                    AppData.CurrentUser = new User(username, credits);
                    if (admin == 1)
                    {
                        Menu_Admin form2 = new Menu_Admin();
                        form2.Show();
                        this.Hide();
                    }
                    else if (admin == 0)
                    {
                        Menu form2 = new Menu();
                        form2.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();

                    //focus username
                    txt_username.Focus();
                }
                

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        public int GetAdminForUser(string username)
        {
            string connString = @"Data Source=DESKTOP-3FVN9CH;Initial Catalog=users_database;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // Interogarea bazei de date pentru a obține valoarea de admin pentru utilizatorul specificat
                string query = "SELECT Admin FROM Login WHERE UserName = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                int admin = (int)cmd.ExecuteScalar();
                conn.Close();

                return admin;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit","Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            Sign_In signin = new Sign_In();
            signin.Show();
            this.Hide();
        }
        public int GetCreditsForUser(string username)
        {
            string connString = @"Data Source=DESKTOP-3FVN9CH;Initial Catalog=users_database;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // Interogarea bazei de date pentru a obține valoarea creditului pentru utilizatorul specificat
                string query = "SELECT Credite FROM Login WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                int credits = (int)cmd.ExecuteScalar();
                conn.Close();

                return credits;
            }
        }
        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }
    }
}