using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamification
{
    public partial class Menu_Admin : Form
    {
        public Menu_Admin()
        {
            InitializeComponent();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            Game1 game1 = new Game1();
            game1.Show();
            this.Close();
        }

        private void button_adminoption_Click(object sender, EventArgs e)
        {
            Leaderboard lead = new Leaderboard();
            lead.Show();
            this.Hide();
        }

        private void Menu_Admin_Load(object sender, EventArgs e)
        {

        }

        private void button_profil_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
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
