namespace SQLProjectForms1
{
    partial class Form_User1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_followed = new System.Windows.Forms.Label();
            this.label_ratings = new System.Windows.Forms.Label();
            this.label_followers = new System.Windows.Forms.Label();
            this.label_log_out = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_profile = new System.Windows.Forms.Label();
            this.button_timeline = new System.Windows.Forms.Button();
            this.button_profile = new System.Windows.Forms.Button();
            this.button_searchRecipe = new System.Windows.Forms.Button();
            this.label_options = new System.Windows.Forms.Label();
            this.button_myRecipes = new System.Windows.Forms.Button();
            this.button_ratedRecipes = new System.Windows.Forms.Button();
            this.button_savedRecipes = new System.Windows.Forms.Button();
            this.button_addRecipe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label_followed);
            this.panel1.Controls.Add(this.label_ratings);
            this.panel1.Controls.Add(this.label_followers);
            this.panel1.Controls.Add(this.label_log_out);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label_profile);
            this.panel1.Location = new System.Drawing.Point(274, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 308);
            this.panel1.TabIndex = 13;
            // 
            // label_followed
            // 
            this.label_followed.AutoSize = true;
            this.label_followed.Location = new System.Drawing.Point(35, 208);
            this.label_followed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_followed.Name = "label_followed";
            this.label_followed.Size = new System.Drawing.Size(49, 13);
            this.label_followed.TabIndex = 12;
            this.label_followed.Text = "Followed";
            this.label_followed.Click += new System.EventHandler(this.label_followed_Click);
            this.label_followed.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_followed.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // label_ratings
            // 
            this.label_ratings.AutoSize = true;
            this.label_ratings.Location = new System.Drawing.Point(35, 229);
            this.label_ratings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ratings.Name = "label_ratings";
            this.label_ratings.Size = new System.Drawing.Size(64, 13);
            this.label_ratings.TabIndex = 11;
            this.label_ratings.Text = "View Rating";
            this.label_ratings.Visible = false;
            this.label_ratings.Click += new System.EventHandler(this.label_ratings_Click);
            this.label_ratings.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_ratings.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // label_followers
            // 
            this.label_followers.AutoSize = true;
            this.label_followers.Location = new System.Drawing.Point(35, 187);
            this.label_followers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_followers.Name = "label_followers";
            this.label_followers.Size = new System.Drawing.Size(51, 13);
            this.label_followers.TabIndex = 10;
            this.label_followers.Text = "Followers";
            this.label_followers.Click += new System.EventHandler(this.label_followers_Click);
            this.label_followers.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_followers.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // label_log_out
            // 
            this.label_log_out.AutoSize = true;
            this.label_log_out.Location = new System.Drawing.Point(40, 254);
            this.label_log_out.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_log_out.Name = "label_log_out";
            this.label_log_out.Size = new System.Drawing.Size(45, 13);
            this.label_log_out.TabIndex = 9;
            this.label_log_out.Text = "Log Out";
            this.label_log_out.Click += new System.EventHandler(this.label_log_out_Click);
            this.label_log_out.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_log_out.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(26, 123);
            this.label_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(63, 13);
            this.label_username.TabIndex = 8;
            this.label_username.Text = "UserName: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(18, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 101);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label_profile
            // 
            this.label_profile.AutoSize = true;
            this.label_profile.Location = new System.Drawing.Point(35, 161);
            this.label_profile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_profile.Name = "label_profile";
            this.label_profile.Size = new System.Drawing.Size(57, 13);
            this.label_profile.TabIndex = 7;
            this.label_profile.Text = "Edit Profile";
            this.label_profile.Click += new System.EventHandler(this.label_profile_Click);
            this.label_profile.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_profile.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // button_timeline
            // 
            this.button_timeline.Location = new System.Drawing.Point(127, 67);
            this.button_timeline.Margin = new System.Windows.Forms.Padding(2);
            this.button_timeline.Name = "button_timeline";
            this.button_timeline.Size = new System.Drawing.Size(109, 54);
            this.button_timeline.TabIndex = 0;
            this.button_timeline.Text = "Time Line";
            this.button_timeline.UseVisualStyleBackColor = true;
            this.button_timeline.Click += new System.EventHandler(this.button_timeline_Click);
            // 
            // button_profile
            // 
            this.button_profile.Location = new System.Drawing.Point(183, 23);
            this.button_profile.Margin = new System.Windows.Forms.Padding(2);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(62, 28);
            this.button_profile.TabIndex = 4;
            this.button_profile.Text = "Profile";
            this.button_profile.UseVisualStyleBackColor = true;
            this.button_profile.Click += new System.EventHandler(this.button_profile_Click);
            // 
            // button_searchRecipe
            // 
            this.button_searchRecipe.Location = new System.Drawing.Point(14, 67);
            this.button_searchRecipe.Margin = new System.Windows.Forms.Padding(2);
            this.button_searchRecipe.Name = "button_searchRecipe";
            this.button_searchRecipe.Size = new System.Drawing.Size(109, 54);
            this.button_searchRecipe.TabIndex = 1;
            this.button_searchRecipe.Text = "Search Recipe";
            this.button_searchRecipe.UseVisualStyleBackColor = true;
            this.button_searchRecipe.Click += new System.EventHandler(this.button_searchRecipes_Click);
            // 
            // label_options
            // 
            this.label_options.AutoSize = true;
            this.label_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_options.Location = new System.Drawing.Point(16, 7);
            this.label_options.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_options.Name = "label_options";
            this.label_options.Size = new System.Drawing.Size(67, 18);
            this.label_options.TabIndex = 35;
            this.label_options.Text = "Options";
            // 
            // button_myRecipes
            // 
            this.button_myRecipes.Location = new System.Drawing.Point(14, 125);
            this.button_myRecipes.Name = "button_myRecipes";
            this.button_myRecipes.Size = new System.Drawing.Size(109, 54);
            this.button_myRecipes.TabIndex = 3;
            this.button_myRecipes.Text = "My Recipes";
            this.button_myRecipes.UseVisualStyleBackColor = true;
            this.button_myRecipes.Click += new System.EventHandler(this.button_myRecipes_Click);
            // 
            // button_ratedRecipes
            // 
            this.button_ratedRecipes.Location = new System.Drawing.Point(127, 125);
            this.button_ratedRecipes.Margin = new System.Windows.Forms.Padding(2);
            this.button_ratedRecipes.Name = "button_ratedRecipes";
            this.button_ratedRecipes.Size = new System.Drawing.Size(109, 54);
            this.button_ratedRecipes.TabIndex = 36;
            this.button_ratedRecipes.Text = "Rated recipes";
            this.button_ratedRecipes.UseVisualStyleBackColor = true;
            this.button_ratedRecipes.Click += new System.EventHandler(this.button_ratedRecipes_Click);
            // 
            // button_savedRecipes
            // 
            this.button_savedRecipes.Location = new System.Drawing.Point(127, 183);
            this.button_savedRecipes.Margin = new System.Windows.Forms.Padding(2);
            this.button_savedRecipes.Name = "button_savedRecipes";
            this.button_savedRecipes.Size = new System.Drawing.Size(109, 54);
            this.button_savedRecipes.TabIndex = 37;
            this.button_savedRecipes.Text = "Saved recipes";
            this.button_savedRecipes.UseVisualStyleBackColor = true;
            this.button_savedRecipes.Click += new System.EventHandler(this.button_savedRecipes_Click);
            // 
            // button_addRecipe
            // 
            this.button_addRecipe.Location = new System.Drawing.Point(14, 183);
            this.button_addRecipe.Name = "button_addRecipe";
            this.button_addRecipe.Size = new System.Drawing.Size(109, 54);
            this.button_addRecipe.TabIndex = 38;
            this.button_addRecipe.Text = "Add recipe";
            this.button_addRecipe.UseVisualStyleBackColor = true;
            this.button_addRecipe.Click += new System.EventHandler(this.button_addRecipe_Click);
            // 
            // Form_User1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 269);
            this.Controls.Add(this.button_addRecipe);
            this.Controls.Add(this.button_savedRecipes);
            this.Controls.Add(this.button_ratedRecipes);
            this.Controls.Add(this.button_myRecipes);
            this.Controls.Add(this.label_options);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_timeline);
            this.Controls.Add(this.button_profile);
            this.Controls.Add(this.button_searchRecipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_User1";
            this.Text = "Form_User1";
            this.Load += new System.EventHandler(this.Form_User1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_followers;
        private System.Windows.Forms.Label label_log_out;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_profile;
        private System.Windows.Forms.Button button_timeline;
        private System.Windows.Forms.Button button_profile;
        private System.Windows.Forms.Button button_searchRecipe;
        private System.Windows.Forms.Label label_options;
        private System.Windows.Forms.Label label_ratings;
        private System.Windows.Forms.Label label_followed;
        private System.Windows.Forms.Button button_myRecipes;
        private System.Windows.Forms.Button button_ratedRecipes;
        private System.Windows.Forms.Button button_savedRecipes;
        private System.Windows.Forms.Button button_addRecipe;
    }
}