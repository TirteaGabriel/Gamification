namespace Gamification
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.button_play = new System.Windows.Forms.Button();
            this.button_profil = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(220, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gamification";
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_play.FlatAppearance.BorderSize = 0;
            this.button_play.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_play.Location = new System.Drawing.Point(203, 240);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(273, 58);
            this.button_play.TabIndex = 7;
            this.button_play.Text = "Joaca";
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_profil
            // 
            this.button_profil.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_profil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_profil.FlatAppearance.BorderSize = 0;
            this.button_profil.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_profil.Location = new System.Drawing.Point(203, 304);
            this.button_profil.Name = "button_profil";
            this.button_profil.Size = new System.Drawing.Size(273, 58);
            this.button_profil.TabIndex = 7;
            this.button_profil.Text = "Profil";
            this.button_profil.UseVisualStyleBackColor = false;
            this.button_profil.Click += new System.EventHandler(this.button_profil_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_exit.BackgroundImage")));
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit.Location = new System.Drawing.Point(631, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(32, 30);
            this.button_exit.TabIndex = 16;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 508);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_profil);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button_play;
        private Button button_profil;
        private Button button_exit;
    }
}