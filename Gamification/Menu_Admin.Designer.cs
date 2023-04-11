namespace Gamification
{
    partial class Menu_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Admin));
            this.button_play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_adminoption = new System.Windows.Forms.Button();
            this.button_profil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_play.FlatAppearance.BorderSize = 0;
            this.button_play.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_play.Location = new System.Drawing.Point(157, 175);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(273, 58);
            this.button_play.TabIndex = 12;
            this.button_play.Text = "Joaca";
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gamification";
            // 
            // button_adminoption
            // 
            this.button_adminoption.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_adminoption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_adminoption.FlatAppearance.BorderSize = 0;
            this.button_adminoption.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_adminoption.Location = new System.Drawing.Point(157, 303);
            this.button_adminoption.Name = "button_adminoption";
            this.button_adminoption.Size = new System.Drawing.Size(273, 58);
            this.button_adminoption.TabIndex = 9;
            this.button_adminoption.Text = "Leaderboard";
            this.button_adminoption.UseVisualStyleBackColor = false;
            this.button_adminoption.Click += new System.EventHandler(this.button_adminoption_Click);
            // 
            // button_profil
            // 
            this.button_profil.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_profil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_profil.FlatAppearance.BorderSize = 0;
            this.button_profil.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_profil.Location = new System.Drawing.Point(157, 239);
            this.button_profil.Name = "button_profil";
            this.button_profil.Size = new System.Drawing.Size(273, 58);
            this.button_profil.TabIndex = 13;
            this.button_profil.Text = "Profil";
            this.button_profil.UseVisualStyleBackColor = false;
            this.button_profil.Click += new System.EventHandler(this.button_profil_Click);
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(246, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 100);
            this.label2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(543, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_profil);
            this.Controls.Add(this.button_adminoption);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Admin";
            this.Load += new System.EventHandler(this.Menu_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_play;
        private Label label1;
        private Button button_adminoption;
        private Button button_profil;
        private Label label2;
        private Button button1;
    }
}