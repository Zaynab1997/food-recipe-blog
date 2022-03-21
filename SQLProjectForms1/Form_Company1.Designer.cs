namespace SQLProjectForms1
{
    partial class Form_Company1
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
            this.button_MyRecipes = new System.Windows.Forms.Button();
            this.button_add_recipe = new System.Windows.Forms.Button();
            this.button_profile = new System.Windows.Forms.Button();
            this.button_my_products = new System.Windows.Forms.Button();
            this.button_add_product = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_followers = new System.Windows.Forms.Label();
            this.label_log_out = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_profile = new System.Windows.Forms.Label();
            this.label_options = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_MyRecipes
            // 
            this.button_MyRecipes.Location = new System.Drawing.Point(17, 86);
            this.button_MyRecipes.Name = "button_MyRecipes";
            this.button_MyRecipes.Size = new System.Drawing.Size(109, 49);
            this.button_MyRecipes.TabIndex = 1;
            this.button_MyRecipes.Text = "My Recipes";
            this.button_MyRecipes.UseVisualStyleBackColor = true;
            this.button_MyRecipes.Click += new System.EventHandler(this.button_MyRecipes_Click);
            // 
            // button_add_recipe
            // 
            this.button_add_recipe.Location = new System.Drawing.Point(17, 29);
            this.button_add_recipe.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_recipe.Name = "button_add_recipe";
            this.button_add_recipe.Size = new System.Drawing.Size(109, 54);
            this.button_add_recipe.TabIndex = 0;
            this.button_add_recipe.Text = "Add Recipe";
            this.button_add_recipe.UseVisualStyleBackColor = true;
            this.button_add_recipe.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_profile
            // 
            this.button_profile.Location = new System.Drawing.Point(207, 19);
            this.button_profile.Margin = new System.Windows.Forms.Padding(2);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(62, 28);
            this.button_profile.TabIndex = 5;
            this.button_profile.Text = "Profile";
            this.button_profile.UseVisualStyleBackColor = true;
            this.button_profile.Click += new System.EventHandler(this.button_profile_Click);
            this.button_profile.MouseEnter += new System.EventHandler(this.button_profile_MouseEnter);
            // 
            // button_my_products
            // 
            this.button_my_products.Location = new System.Drawing.Point(17, 192);
            this.button_my_products.Margin = new System.Windows.Forms.Padding(2);
            this.button_my_products.Name = "button_my_products";
            this.button_my_products.Size = new System.Drawing.Size(109, 54);
            this.button_my_products.TabIndex = 3;
            this.button_my_products.Text = "My Products";
            this.button_my_products.UseVisualStyleBackColor = true;
            this.button_my_products.Click += new System.EventHandler(this.button_view_products_Click);
            // 
            // button_add_product
            // 
            this.button_add_product.Location = new System.Drawing.Point(17, 138);
            this.button_add_product.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_product.Name = "button_add_product";
            this.button_add_product.Size = new System.Drawing.Size(109, 50);
            this.button_add_product.TabIndex = 2;
            this.button_add_product.Text = "Add Product";
            this.button_add_product.UseVisualStyleBackColor = true;
            this.button_add_product.Click += new System.EventHandler(this.button_add_product_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label_followers);
            this.panel1.Controls.Add(this.label_log_out);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label_profile);
            this.panel1.Location = new System.Drawing.Point(308, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 314);
            this.panel1.TabIndex = 7;
            // 
            // label_followers
            // 
            this.label_followers.AutoSize = true;
            this.label_followers.Location = new System.Drawing.Point(38, 197);
            this.label_followers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_followers.Name = "label_followers";
            this.label_followers.Size = new System.Drawing.Size(51, 13);
            this.label_followers.TabIndex = 7;
            this.label_followers.Text = "Followers";
            this.label_followers.Click += new System.EventHandler(this.label_followers_Click);
            this.label_followers.MouseEnter += new System.EventHandler(this.label_followed_MouseEnter);
            this.label_followers.MouseLeave += new System.EventHandler(this.label_followed_MouseLeave);
            // 
            // label_log_out
            // 
            this.label_log_out.AutoSize = true;
            this.label_log_out.Location = new System.Drawing.Point(40, 226);
            this.label_log_out.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_log_out.Name = "label_log_out";
            this.label_log_out.Size = new System.Drawing.Size(45, 13);
            this.label_log_out.TabIndex = 8;
            this.label_log_out.Text = "Log Out";
            this.label_log_out.Click += new System.EventHandler(this.label_log_out_Click);
            this.label_log_out.MouseEnter += new System.EventHandler(this.label_log_out_MouseEnter);
            this.label_log_out.MouseLeave += new System.EventHandler(this.label_log_out_MouseLeave);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(22, 123);
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
            this.label_profile.TabIndex = 6;
            this.label_profile.Text = "Edit Profile";
            this.label_profile.Click += new System.EventHandler(this.label_profile_Click);
            this.label_profile.MouseEnter += new System.EventHandler(this.label_profile_MouseEnter);
            this.label_profile.MouseLeave += new System.EventHandler(this.label_profile_MouseLeave);
            // 
            // label_options
            // 
            this.label_options.AutoSize = true;
            this.label_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_options.Location = new System.Drawing.Point(24, 7);
            this.label_options.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_options.Name = "label_options";
            this.label_options.Size = new System.Drawing.Size(67, 18);
            this.label_options.TabIndex = 36;
            this.label_options.Text = "Options";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 251);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search Recipes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form_Company1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_options);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_add_product);
            this.Controls.Add(this.button_my_products);
            this.Controls.Add(this.button_profile);
            this.Controls.Add(this.button_add_recipe);
            this.Controls.Add(this.button_MyRecipes);
            this.MaximizeBox = false;
            this.Name = "Form_Company1";
            this.Text = "Form_Company1";
            this.Load += new System.EventHandler(this.Form_Company1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_MyRecipes;
        private System.Windows.Forms.Button button_add_recipe;
        private System.Windows.Forms.Button button_profile;
        private System.Windows.Forms.Button button_my_products;
        private System.Windows.Forms.Button button_add_product;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_followers;
        private System.Windows.Forms.Label label_log_out;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_profile;
        private System.Windows.Forms.Label label_options;
        private System.Windows.Forms.Button button1;
    }
}