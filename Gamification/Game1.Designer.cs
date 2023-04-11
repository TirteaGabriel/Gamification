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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1));
            this.button_endgame = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_endgame
            // 
            this.button_endgame.Location = new System.Drawing.Point(788, 524);
            this.button_endgame.Name = "button_endgame";
            this.button_endgame.Size = new System.Drawing.Size(75, 23);
            this.button_endgame.TabIndex = 3;
            this.button_endgame.Text = "End Game";
            this.button_endgame.UseVisualStyleBackColor = true;
            this.button_endgame.Click += new System.EventHandler(this.button_endgame_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_exit.BackgroundImage")));
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit.Location = new System.Drawing.Point(831, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(32, 30);
            this.button_exit.TabIndex = 10;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 711);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_endgame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game1";
            this.Load += new System.EventHandler(this.Game1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button button_endgame;
        private Button button_exit;
    }
}