namespace SQLProjectForms1
{
    partial class Form_Home
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
            this.button_login_u = new System.Windows.Forms.Button();
            this.button_login_c = new System.Windows.Forms.Button();
            this.panel_home = new System.Windows.Forms.Panel();
            this.button_signup = new System.Windows.Forms.Button();
            this.panel_signin = new System.Windows.Forms.Panel();
            this.button_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dowloadImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.putImagesInDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeViewformtestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_signup_u = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_signup_u_done = new System.Windows.Forms.Button();
            this.textBox_email_signup_u = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_password_signup_u = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_userName_signup_u = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_signup_c = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.checkBox_onlineShopping = new System.Windows.Forms.CheckBox();
            this.checkBox_delivery = new System.Windows.Forms.CheckBox();
            this.pictureBox_logo_signup_c = new System.Windows.Forms.PictureBox();
            this.button_logo = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_homepage_signup_c = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_phone_signup_c = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_fax_signup_c = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_address_signup_c = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_cities = new System.Windows.Forms.ComboBox();
            this.comboBox_provinces = new System.Windows.Forms.ComboBox();
            this.comboBox_countries = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_signup_c_done = new System.Windows.Forms.Button();
            this.textBox_email_signup_c = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_password_signup_c = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_userName_signup_c = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel_signup_home = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button_signup_u = new System.Windows.Forms.Button();
            this.button_signup_c = new System.Windows.Forms.Button();
            this.panel_home.SuspendLayout();
            this.panel_signin.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_signup_u.SuspendLayout();
            this.panel_signup_c.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo_signup_c)).BeginInit();
            this.panel_signup_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_login_u
            // 
            this.button_login_u.Location = new System.Drawing.Point(345, 150);
            this.button_login_u.Margin = new System.Windows.Forms.Padding(4);
            this.button_login_u.Name = "button_login_u";
            this.button_login_u.Size = new System.Drawing.Size(165, 54);
            this.button_login_u.TabIndex = 0;
            this.button_login_u.Text = "User";
            this.button_login_u.UseVisualStyleBackColor = true;
            this.button_login_u.Click += new System.EventHandler(this.button_login_u_Click);
            // 
            // button_login_c
            // 
            this.button_login_c.Location = new System.Drawing.Point(345, 241);
            this.button_login_c.Margin = new System.Windows.Forms.Padding(4);
            this.button_login_c.Name = "button_login_c";
            this.button_login_c.Size = new System.Drawing.Size(165, 54);
            this.button_login_c.TabIndex = 1;
            this.button_login_c.Text = "Company";
            this.button_login_c.UseVisualStyleBackColor = true;
            this.button_login_c.Click += new System.EventHandler(this.button_login_c_Click);
            // 
            // panel_home
            // 
            this.panel_home.Controls.Add(this.button_login_u);
            this.panel_home.Controls.Add(this.button_signup);
            this.panel_home.Controls.Add(this.button_login_c);
            this.panel_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_home.Location = new System.Drawing.Point(0, 0);
            this.panel_home.Margin = new System.Windows.Forms.Padding(4);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(865, 500);
            this.panel_home.TabIndex = 3;
            // 
            // button_signup
            // 
            this.button_signup.Location = new System.Drawing.Point(345, 324);
            this.button_signup.Margin = new System.Windows.Forms.Padding(4);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(165, 54);
            this.button_signup.TabIndex = 2;
            this.button_signup.Text = "Sign Up";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // panel_signin
            // 
            this.panel_signin.Controls.Add(this.button_login);
            this.panel_signin.Controls.Add(this.label2);
            this.panel_signin.Controls.Add(this.label1);
            this.panel_signin.Controls.Add(this.textBox_password);
            this.panel_signin.Controls.Add(this.textBox_userName);
            this.panel_signin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_signin.Location = new System.Drawing.Point(0, 0);
            this.panel_signin.Margin = new System.Windows.Forms.Padding(4);
            this.panel_signin.Name = "panel_signin";
            this.panel_signin.Size = new System.Drawing.Size(865, 500);
            this.panel_signin.TabIndex = 3;
            this.panel_signin.Visible = false;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(372, 303);
            this.button_login.Margin = new System.Windows.Forms.Padding(4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(104, 52);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(372, 225);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_password.MaxLength = 25;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(220, 22);
            this.textBox_password.TabIndex = 1;
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(372, 153);
            this.textBox_userName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_userName.MaxLength = 50;
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(220, 22);
            this.textBox_userName.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.testingFormToolStripMenuItem,
            this.dowloadImagesToolStripMenuItem,
            this.putImagesInDatabaseToolStripMenuItem,
            this.recipeViewformtestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(865, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // testingFormToolStripMenuItem
            // 
            this.testingFormToolStripMenuItem.Name = "testingFormToolStripMenuItem";
            this.testingFormToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.testingFormToolStripMenuItem.Text = "Testing Form";
            this.testingFormToolStripMenuItem.Click += new System.EventHandler(this.testingFormToolStripMenuItem_Click);
            // 
            // dowloadImagesToolStripMenuItem
            // 
            this.dowloadImagesToolStripMenuItem.Enabled = false;
            this.dowloadImagesToolStripMenuItem.Name = "dowloadImagesToolStripMenuItem";
            this.dowloadImagesToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.dowloadImagesToolStripMenuItem.Text = "Dowload images";
            this.dowloadImagesToolStripMenuItem.Click += new System.EventHandler(this.dowloadImagesToolStripMenuItem_Click);
            // 
            // putImagesInDatabaseToolStripMenuItem
            // 
            this.putImagesInDatabaseToolStripMenuItem.Enabled = false;
            this.putImagesInDatabaseToolStripMenuItem.Name = "putImagesInDatabaseToolStripMenuItem";
            this.putImagesInDatabaseToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.putImagesInDatabaseToolStripMenuItem.Text = "Put images in database";
            this.putImagesInDatabaseToolStripMenuItem.Click += new System.EventHandler(this.putImagesInDatabaseToolStripMenuItem_Click);
            // 
            // recipeViewformtestToolStripMenuItem
            // 
            this.recipeViewformtestToolStripMenuItem.Name = "recipeViewformtestToolStripMenuItem";
            this.recipeViewformtestToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.recipeViewformtestToolStripMenuItem.Text = "RecipeView_form_test";
            this.recipeViewformtestToolStripMenuItem.Click += new System.EventHandler(this.recipeViewformtestToolStripMenuItem_Click);
            // 
            // panel_signup_u
            // 
            this.panel_signup_u.Controls.Add(this.label7);
            this.panel_signup_u.Controls.Add(this.label6);
            this.panel_signup_u.Controls.Add(this.button_signup_u_done);
            this.panel_signup_u.Controls.Add(this.textBox_email_signup_u);
            this.panel_signup_u.Controls.Add(this.label5);
            this.panel_signup_u.Controls.Add(this.textBox_password_signup_u);
            this.panel_signup_u.Controls.Add(this.label4);
            this.panel_signup_u.Controls.Add(this.textBox_userName_signup_u);
            this.panel_signup_u.Controls.Add(this.label3);
            this.panel_signup_u.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_signup_u.Location = new System.Drawing.Point(0, 0);
            this.panel_signup_u.Margin = new System.Windows.Forms.Padding(4);
            this.panel_signup_u.Name = "panel_signup_u";
            this.panel_signup_u.Size = new System.Drawing.Size(865, 500);
            this.panel_signup_u.TabIndex = 2;
            this.panel_signup_u.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(565, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(565, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "*";
            // 
            // button_signup_u_done
            // 
            this.button_signup_u_done.Location = new System.Drawing.Point(355, 322);
            this.button_signup_u_done.Margin = new System.Windows.Forms.Padding(4);
            this.button_signup_u_done.Name = "button_signup_u_done";
            this.button_signup_u_done.Size = new System.Drawing.Size(159, 50);
            this.button_signup_u_done.TabIndex = 6;
            this.button_signup_u_done.Text = "Sign Up";
            this.button_signup_u_done.UseVisualStyleBackColor = true;
            this.button_signup_u_done.Click += new System.EventHandler(this.button_signup_u_done_Click);
            // 
            // textBox_email_signup_u
            // 
            this.textBox_email_signup_u.Location = new System.Drawing.Point(325, 228);
            this.textBox_email_signup_u.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_email_signup_u.MaxLength = 50;
            this.textBox_email_signup_u.Name = "textBox_email_signup_u";
            this.textBox_email_signup_u.Size = new System.Drawing.Size(235, 22);
            this.textBox_email_signup_u.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // textBox_password_signup_u
            // 
            this.textBox_password_signup_u.Location = new System.Drawing.Point(325, 185);
            this.textBox_password_signup_u.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_password_signup_u.MaxLength = 25;
            this.textBox_password_signup_u.Name = "textBox_password_signup_u";
            this.textBox_password_signup_u.PasswordChar = '*';
            this.textBox_password_signup_u.Size = new System.Drawing.Size(235, 22);
            this.textBox_password_signup_u.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // textBox_userName_signup_u
            // 
            this.textBox_userName_signup_u.Location = new System.Drawing.Point(325, 139);
            this.textBox_userName_signup_u.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_userName_signup_u.MaxLength = 50;
            this.textBox_userName_signup_u.Name = "textBox_userName_signup_u";
            this.textBox_userName_signup_u.Size = new System.Drawing.Size(235, 22);
            this.textBox_userName_signup_u.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name";
            // 
            // panel_signup_c
            // 
            this.panel_signup_c.Controls.Add(this.label21);
            this.panel_signup_c.Controls.Add(this.checkBox_onlineShopping);
            this.panel_signup_c.Controls.Add(this.checkBox_delivery);
            this.panel_signup_c.Controls.Add(this.pictureBox_logo_signup_c);
            this.panel_signup_c.Controls.Add(this.button_logo);
            this.panel_signup_c.Controls.Add(this.label20);
            this.panel_signup_c.Controls.Add(this.textBox_homepage_signup_c);
            this.panel_signup_c.Controls.Add(this.label19);
            this.panel_signup_c.Controls.Add(this.textBox_phone_signup_c);
            this.panel_signup_c.Controls.Add(this.label18);
            this.panel_signup_c.Controls.Add(this.textBox_fax_signup_c);
            this.panel_signup_c.Controls.Add(this.label17);
            this.panel_signup_c.Controls.Add(this.textBox_address_signup_c);
            this.panel_signup_c.Controls.Add(this.label16);
            this.panel_signup_c.Controls.Add(this.label15);
            this.panel_signup_c.Controls.Add(this.label14);
            this.panel_signup_c.Controls.Add(this.comboBox_cities);
            this.panel_signup_c.Controls.Add(this.comboBox_provinces);
            this.panel_signup_c.Controls.Add(this.comboBox_countries);
            this.panel_signup_c.Controls.Add(this.label9);
            this.panel_signup_c.Controls.Add(this.label10);
            this.panel_signup_c.Controls.Add(this.button_signup_c_done);
            this.panel_signup_c.Controls.Add(this.textBox_email_signup_c);
            this.panel_signup_c.Controls.Add(this.label11);
            this.panel_signup_c.Controls.Add(this.textBox_password_signup_c);
            this.panel_signup_c.Controls.Add(this.label12);
            this.panel_signup_c.Controls.Add(this.textBox_userName_signup_c);
            this.panel_signup_c.Controls.Add(this.label13);
            this.panel_signup_c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_signup_c.Location = new System.Drawing.Point(0, 0);
            this.panel_signup_c.Margin = new System.Windows.Forms.Padding(4);
            this.panel_signup_c.Name = "panel_signup_c";
            this.panel_signup_c.Size = new System.Drawing.Size(865, 500);
            this.panel_signup_c.TabIndex = 2;
            this.panel_signup_c.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(460, 151);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(356, 17);
            this.label21.TabIndex = 38;
            this.label21.Text = "(A Phone number or a Home Page should be provided)";
            // 
            // checkBox_onlineShopping
            // 
            this.checkBox_onlineShopping.AutoSize = true;
            this.checkBox_onlineShopping.Location = new System.Drawing.Point(89, 417);
            this.checkBox_onlineShopping.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_onlineShopping.Name = "checkBox_onlineShopping";
            this.checkBox_onlineShopping.Size = new System.Drawing.Size(135, 21);
            this.checkBox_onlineShopping.TabIndex = 37;
            this.checkBox_onlineShopping.Text = "Online Shopping";
            this.checkBox_onlineShopping.UseVisualStyleBackColor = true;
            // 
            // checkBox_delivery
            // 
            this.checkBox_delivery.AutoSize = true;
            this.checkBox_delivery.Location = new System.Drawing.Point(89, 389);
            this.checkBox_delivery.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_delivery.Name = "checkBox_delivery";
            this.checkBox_delivery.Size = new System.Drawing.Size(81, 21);
            this.checkBox_delivery.TabIndex = 36;
            this.checkBox_delivery.Text = "Delivery";
            this.checkBox_delivery.UseVisualStyleBackColor = true;
            // 
            // pictureBox_logo_signup_c
            // 
            this.pictureBox_logo_signup_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_logo_signup_c.Location = new System.Drawing.Point(384, 262);
            this.pictureBox_logo_signup_c.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_logo_signup_c.Name = "pictureBox_logo_signup_c";
            this.pictureBox_logo_signup_c.Size = new System.Drawing.Size(159, 147);
            this.pictureBox_logo_signup_c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo_signup_c.TabIndex = 35;
            this.pictureBox_logo_signup_c.TabStop = false;
            // 
            // button_logo
            // 
            this.button_logo.Location = new System.Drawing.Point(408, 417);
            this.button_logo.Margin = new System.Windows.Forms.Padding(4);
            this.button_logo.Name = "button_logo";
            this.button_logo.Size = new System.Drawing.Size(112, 54);
            this.button_logo.TabIndex = 34;
            this.button_logo.Text = "Choose Logo (optional)";
            this.button_logo.UseVisualStyleBackColor = true;
            this.button_logo.Click += new System.EventHandler(this.button_logo_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(460, 228);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 17);
            this.label20.TabIndex = 31;
            this.label20.Text = "Home Page";
            // 
            // textBox_homepage_signup_c
            // 
            this.textBox_homepage_signup_c.Location = new System.Drawing.Point(569, 223);
            this.textBox_homepage_signup_c.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_homepage_signup_c.Name = "textBox_homepage_signup_c";
            this.textBox_homepage_signup_c.Size = new System.Drawing.Size(237, 22);
            this.textBox_homepage_signup_c.TabIndex = 30;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(460, 185);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 17);
            this.label19.TabIndex = 29;
            this.label19.Text = "Phone";
            // 
            // textBox_phone_signup_c
            // 
            this.textBox_phone_signup_c.Location = new System.Drawing.Point(569, 180);
            this.textBox_phone_signup_c.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_phone_signup_c.Name = "textBox_phone_signup_c";
            this.textBox_phone_signup_c.Size = new System.Drawing.Size(237, 22);
            this.textBox_phone_signup_c.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(460, 110);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 17);
            this.label18.TabIndex = 27;
            this.label18.Text = "Fax";
            // 
            // textBox_fax_signup_c
            // 
            this.textBox_fax_signup_c.Location = new System.Drawing.Point(569, 105);
            this.textBox_fax_signup_c.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_fax_signup_c.Name = "textBox_fax_signup_c";
            this.textBox_fax_signup_c.Size = new System.Drawing.Size(237, 22);
            this.textBox_fax_signup_c.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(460, 64);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 17);
            this.label17.TabIndex = 25;
            this.label17.Text = "Address";
            // 
            // textBox_address_signup_c
            // 
            this.textBox_address_signup_c.Location = new System.Drawing.Point(569, 59);
            this.textBox_address_signup_c.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_address_signup_c.Name = "textBox_address_signup_c";
            this.textBox_address_signup_c.Size = new System.Drawing.Size(237, 22);
            this.textBox_address_signup_c.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 331);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 17);
            this.label16.TabIndex = 23;
            this.label16.Text = "City";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 287);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Province";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 242);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Country";
            // 
            // comboBox_cities
            // 
            this.comboBox_cities.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_cities.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cities.Enabled = false;
            this.comboBox_cities.FormattingEnabled = true;
            this.comboBox_cities.Location = new System.Drawing.Point(89, 327);
            this.comboBox_cities.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_cities.Name = "comboBox_cities";
            this.comboBox_cities.Size = new System.Drawing.Size(160, 24);
            this.comboBox_cities.TabIndex = 20;
            // 
            // comboBox_provinces
            // 
            this.comboBox_provinces.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_provinces.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_provinces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_provinces.Enabled = false;
            this.comboBox_provinces.FormattingEnabled = true;
            this.comboBox_provinces.Location = new System.Drawing.Point(89, 283);
            this.comboBox_provinces.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_provinces.Name = "comboBox_provinces";
            this.comboBox_provinces.Size = new System.Drawing.Size(160, 24);
            this.comboBox_provinces.TabIndex = 19;
            this.comboBox_provinces.SelectedIndexChanged += new System.EventHandler(this.comboBox_provinces_SelectedIndexChanged);
            // 
            // comboBox_countries
            // 
            this.comboBox_countries.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_countries.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_countries.DisplayMember = "country_id";
            this.comboBox_countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_countries.FormattingEnabled = true;
            this.comboBox_countries.Location = new System.Drawing.Point(89, 239);
            this.comboBox_countries.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_countries.Name = "comboBox_countries";
            this.comboBox_countries.Size = new System.Drawing.Size(160, 24);
            this.comboBox_countries.TabIndex = 18;
            this.comboBox_countries.ValueMember = "country_id";
            this.comboBox_countries.SelectedIndexChanged += new System.EventHandler(this.comboBox_countries_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(347, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(347, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "*";
            // 
            // button_signup_c_done
            // 
            this.button_signup_c_done.Location = new System.Drawing.Point(649, 295);
            this.button_signup_c_done.Margin = new System.Windows.Forms.Padding(4);
            this.button_signup_c_done.Name = "button_signup_c_done";
            this.button_signup_c_done.Size = new System.Drawing.Size(159, 50);
            this.button_signup_c_done.TabIndex = 15;
            this.button_signup_c_done.Text = "Sign Up";
            this.button_signup_c_done.UseVisualStyleBackColor = true;
            this.button_signup_c_done.Click += new System.EventHandler(this.button_signup_c_done_Click);
            // 
            // textBox_email_signup_c
            // 
            this.textBox_email_signup_c.Location = new System.Drawing.Point(107, 148);
            this.textBox_email_signup_c.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_email_signup_c.MaxLength = 50;
            this.textBox_email_signup_c.Name = "textBox_email_signup_c";
            this.textBox_email_signup_c.Size = new System.Drawing.Size(235, 22);
            this.textBox_email_signup_c.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 151);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Email";
            // 
            // textBox_password_signup_c
            // 
            this.textBox_password_signup_c.Location = new System.Drawing.Point(107, 105);
            this.textBox_password_signup_c.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_password_signup_c.MaxLength = 25;
            this.textBox_password_signup_c.Name = "textBox_password_signup_c";
            this.textBox_password_signup_c.PasswordChar = '*';
            this.textBox_password_signup_c.Size = new System.Drawing.Size(235, 22);
            this.textBox_password_signup_c.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 108);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Password";
            // 
            // textBox_userName_signup_c
            // 
            this.textBox_userName_signup_c.Location = new System.Drawing.Point(107, 59);
            this.textBox_userName_signup_c.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_userName_signup_c.MaxLength = 50;
            this.textBox_userName_signup_c.Name = "textBox_userName_signup_c";
            this.textBox_userName_signup_c.Size = new System.Drawing.Size(235, 22);
            this.textBox_userName_signup_c.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Company Name";
            // 
            // panel_signup_home
            // 
            this.panel_signup_home.Controls.Add(this.label8);
            this.panel_signup_home.Controls.Add(this.button_signup_u);
            this.panel_signup_home.Controls.Add(this.button_signup_c);
            this.panel_signup_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_signup_home.Location = new System.Drawing.Point(0, 0);
            this.panel_signup_home.Margin = new System.Windows.Forms.Padding(4);
            this.panel_signup_home.Name = "panel_signup_home";
            this.panel_signup_home.Size = new System.Drawing.Size(865, 500);
            this.panel_signup_home.TabIndex = 9;
            this.panel_signup_home.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(355, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Sign up as :";
            // 
            // button_signup_u
            // 
            this.button_signup_u.Location = new System.Drawing.Point(352, 212);
            this.button_signup_u.Margin = new System.Windows.Forms.Padding(4);
            this.button_signup_u.Name = "button_signup_u";
            this.button_signup_u.Size = new System.Drawing.Size(165, 64);
            this.button_signup_u.TabIndex = 0;
            this.button_signup_u.Text = "User";
            this.button_signup_u.UseVisualStyleBackColor = true;
            this.button_signup_u.Click += new System.EventHandler(this.button_signup_u_Click);
            // 
            // button_signup_c
            // 
            this.button_signup_c.Location = new System.Drawing.Point(352, 283);
            this.button_signup_c.Margin = new System.Windows.Forms.Padding(4);
            this.button_signup_c.Name = "button_signup_c";
            this.button_signup_c.Size = new System.Drawing.Size(165, 64);
            this.button_signup_c.TabIndex = 1;
            this.button_signup_c.Text = "Company";
            this.button_signup_c.UseVisualStyleBackColor = true;
            this.button_signup_c.Click += new System.EventHandler(this.button_signup_c_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 500);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_signup_c);
            this.Controls.Add(this.panel_home);
            this.Controls.Add(this.panel_signin);
            this.Controls.Add(this.panel_signup_home);
            this.Controls.Add(this.panel_signup_u);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_Home";
            this.Text = "Form1";
            this.panel_home.ResumeLayout(false);
            this.panel_signin.ResumeLayout(false);
            this.panel_signin.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_signup_u.ResumeLayout(false);
            this.panel_signup_u.PerformLayout();
            this.panel_signup_c.ResumeLayout(false);
            this.panel_signup_c.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo_signup_c)).EndInit();
            this.panel_signup_home.ResumeLayout(false);
            this.panel_signup_home.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login_u;
        private System.Windows.Forms.Button button_login_c;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Panel panel_signin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testingFormToolStripMenuItem;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.Button button_signup_c;
        private System.Windows.Forms.Button button_signup_u;
        private System.Windows.Forms.Panel panel_signup_u;
        private System.Windows.Forms.Panel panel_signup_c;
        private System.Windows.Forms.TextBox textBox_userName_signup_u;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_password_signup_u;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_email_signup_u;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_signup_u_done;
        private System.Windows.Forms.Panel panel_signup_home;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_signup_c_done;
        private System.Windows.Forms.TextBox textBox_email_signup_c;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_password_signup_c;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_userName_signup_c;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox_cities;
        private System.Windows.Forms.ComboBox comboBox_provinces;
        private System.Windows.Forms.ComboBox comboBox_countries;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_homepage_signup_c;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_phone_signup_c;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_fax_signup_c;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_address_signup_c;
        private System.Windows.Forms.PictureBox pictureBox_logo_signup_c;
        private System.Windows.Forms.Button button_logo;
        private System.Windows.Forms.CheckBox checkBox_onlineShopping;
        private System.Windows.Forms.CheckBox checkBox_delivery;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ToolStripMenuItem dowloadImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipeViewformtestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem putImagesInDatabaseToolStripMenuItem;
    }
}

