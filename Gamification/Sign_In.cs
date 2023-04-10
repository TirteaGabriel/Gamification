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
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3FVN9CH;Initial Catalog=users_database;Integrated Security=True");
        public int credits = 0;
        public int admin = 0;
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

        private void back_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (txt_username.Text == string.Empty || txt_password.Text == string.Empty || txt_name.Text == string.Empty || txt_compassword.Text == string.Empty || txt_firstname.Text == string.Empty)
            {
                MessageBox.Show("Toate campurile sunt obligatorii!");
                txt_name.Focus();
            }
            else if (txt_password.Text != txt_compassword.Text)
            {
                MessageBox.Show("Parolele nu corespund", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Clear();
                txt_compassword.Clear();
                txt_password.Focus();
            }
            else
            {
                cmd.CommandText = "insert into Login values('" + txt_username.Text + "','" + txt_name.Text + "', '" + txt_firstname.Text + "', '" + txt_password.Text + "', '" + credits + "', '" + admin + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ai creeat contul cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Login login = new Login();
                login.Show();
                this.Close();

            }
            con.Close();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_firstname.Clear();
            txt_username.Clear();
            txt_password.Clear();
            txt_compassword.Clear();
            txt_name.Focus();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbxShowPas.Checked)
            {
                txt_password.PasswordChar = '\0';
                txt_compassword.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
                txt_compassword.PasswordChar = '*';
            }
        }

        private void Sign_In_Load(object sender, EventArgs e)
        {
            this.Show();
            txt_name.Focus();
            txt_password.PasswordChar = '*';
            txt_compassword.PasswordChar = '*';
        }
    }
}
