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
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                String querry = "SELECT * FROM Login WHERE UserName = '" + txt_username.Text + "'AND Parola = '" + txt_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = txt_password.Text;
                    user_password = txt_password.Text;
                    Menu form2 = new Menu();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}