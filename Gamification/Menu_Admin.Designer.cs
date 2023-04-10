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
            this.button_bedges = new System.Windows.Forms.Button();
            this.button_credits = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_adminoption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_bedges
            // 
            this.button_bedges.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_bedges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bedges.FlatAppearance.BorderSize = 0;
            this.button_bedges.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_bedges.Location = new System.Drawing.Point(157, 303);
            this.button_bedges.Name = "button_bedges";
            this.button_bedges.Size = new System.Drawing.Size(273, 58);
            this.button_bedges.TabIndex = 9;
            this.button_bedges.Text = "Insignele tale";
            this.button_bedges.UseVisualStyleBackColor = false;
            // 
            // button_credits
            // 
            this.button_credits.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_credits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_credits.FlatAppearance.BorderSize = 0;
            this.button_credits.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_credits.Location = new System.Drawing.Point(157, 239);
            this.button_credits.Name = "button_credits";
            this.button_credits.Size = new System.Drawing.Size(273, 58);
            this.button_credits.TabIndex = 10;
            this.button_credits.Text = "Creditele tale";
            this.button_credits.UseVisualStyleBackColor = false;
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
            this.button_adminoption.Location = new System.Drawing.Point(157, 367);
            this.button_adminoption.Name = "button_adminoption";
            this.button_adminoption.Size = new System.Drawing.Size(273, 58);
            this.button_adminoption.TabIndex = 9;
            this.button_adminoption.Text = "Optiuni Admin";
            this.button_adminoption.UseVisualStyleBackColor = false;
            // 
            // Menu_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 511);
            this.Controls.Add(this.button_adminoption);
            this.Controls.Add(this.button_bedges);
            this.Controls.Add(this.button_credits);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.label1);
            this.Name = "Menu_Admin";
            this.Text = "Menu_Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_bedges;
        private Button button_credits;
        private Button button_play;
        private Label label1;
        private Button button_adminoption;
    }
}