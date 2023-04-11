using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gamification
{
    public partial class Game1 : Form
    {
        private Panel[,] squares;
        private int[,] A = new int[20,20];
        Graphics g;
        string connectionString = @"Data Source=DESKTOP-3FVN9CH;Initial Catalog=users_database;Integrated Security=True";
        User user;

        public EventHandler Square_Click { get; private set; }

        public Game1()
        {
            InitializeComponent();
        }
        private void Game1_Load(object sender, EventArgs e)
        {
            InitializeSquares(20, 20);
        }
        int squareSize = 25; // dimensiunea unui patrat
        private void InitializeSquares(int rows, int cols)
        {
            squares = new Panel[rows, cols];
            
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    squares[row, col] = new Panel();
                    squares[row, col].Size = new Size(squareSize, squareSize);
                    squares[row, col].Location = new Point(col * squareSize, row * squareSize);
                    squares[row, col].BackColor = Color.White; // culoarea initiala a patratului
                    squares[row, col].BorderStyle = BorderStyle.FixedSingle;
                    squares[row, col].Click += new EventHandler(Game1_Click); // adauga evenimentul Click la fiecare patrat
                    
                    this.Controls.Add(squares[row, col]);
                }
            }
        }
        int credits = AppData.CurrentUser.Credit;
        private void Game1_Click(object sender, EventArgs e)
        {
            
            //int credits = 0;
            Panel square = (Panel)sender;
            if (square.BackColor == Color.White)
            {
                //square.BackColor = square.BackColor == Color.White ? Color.Red : Color.White; // schimba culoarea patratului
                square.BackColor = Color.Red;
                A[square.Location.Y / squareSize, square.Location.X / squareSize] = 1;

                int x = square.Location.Y / squareSize;
                int y = square.Location.X / squareSize;
                credits = GameLogic.CheckForCompletion(A, credits, x, y);
                GameLogic.RandomPlacementsInMatrix(A, x, y, ref squares);
            }
            
        }

        Login form1 = new Login();
        private void button_endgame_Click(object sender, EventArgs e)
        {
            AppData.CurrentUser.UpdateCredit(credits);
            int admin = form1.GetAdminForUser(AppData.CurrentUser.Username);
            if(admin == 1)
            {
                Menu_Admin menu = new Menu_Admin();
                menu.Show();
                this.Close();
            }
            else
            {
                Menu menu = new Menu();
                menu.Show();
                this.Close();
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
