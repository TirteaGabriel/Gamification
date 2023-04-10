namespace Gamification
{
    partial class Game1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_restart = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_endgame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_restart
            // 
            this.button_restart.Location = new System.Drawing.Point(680, 12);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(75, 23);
            this.button_restart.TabIndex = 1;
            this.button_restart.Text = "Restart";
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(655, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 304);
            this.listBox1.TabIndex = 2;
            // 
            // button_endgame
            // 
            this.button_endgame.Location = new System.Drawing.Point(680, 50);
            this.button_endgame.Name = "button_endgame";
            this.button_endgame.Size = new System.Drawing.Size(75, 23);
            this.button_endgame.TabIndex = 3;
            this.button_endgame.Text = "End Game";
            this.button_endgame.UseVisualStyleBackColor = true;
            this.button_endgame.Click += new System.EventHandler(this.button_endgame_Click);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 711);
            this.Controls.Add(this.button_endgame);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_restart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Game1";
            this.Text = "Game1";
            this.Load += new System.EventHandler(this.Game1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_restart;
        private ListBox listBox1;
        private Button button_endgame;
    }
}