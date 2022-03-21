namespace SQLProjectForms1
{
    partial class Form_RecipeViewFull
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
            this.textBox_recipeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_recipeImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_authorName = new System.Windows.Forms.TextBox();
            this.textBox_postedOn = new System.Windows.Forms.TextBox();
            this.textBox_rating_nbRatings = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dishType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_dishOrigin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_isCompany = new System.Windows.Forms.TextBox();
            this.dataGridView_ingredients = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_instructions = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_saveRecipe = new System.Windows.Forms.Button();
            this.button_rateRecipe = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_prepTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_serves = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_difficulty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_calories = new System.Windows.Forms.TextBox();
            this.pictureBox_productImage = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_providers = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recipeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ingredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_productImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_providers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_recipeName
            // 
            this.textBox_recipeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_recipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_recipeName.Location = new System.Drawing.Point(343, 12);
            this.textBox_recipeName.Multiline = true;
            this.textBox_recipeName.Name = "textBox_recipeName";
            this.textBox_recipeName.ReadOnly = true;
            this.textBox_recipeName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_recipeName.Size = new System.Drawing.Size(360, 20);
            this.textBox_recipeName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipe name:";
            // 
            // pictureBox_recipeImage
            // 
            this.pictureBox_recipeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_recipeImage.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_recipeImage.Name = "pictureBox_recipeImage";
            this.pictureBox_recipeImage.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_recipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_recipeImage.TabIndex = 2;
            this.pictureBox_recipeImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author:";
            // 
            // textBox_authorName
            // 
            this.textBox_authorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_authorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_authorName.Location = new System.Drawing.Point(343, 40);
            this.textBox_authorName.Multiline = true;
            this.textBox_authorName.Name = "textBox_authorName";
            this.textBox_authorName.ReadOnly = true;
            this.textBox_authorName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_authorName.Size = new System.Drawing.Size(360, 20);
            this.textBox_authorName.TabIndex = 3;
            this.textBox_authorName.DoubleClick += new System.EventHandler(this.textBox_authorName_DoubleClick);
            // 
            // textBox_postedOn
            // 
            this.textBox_postedOn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_postedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_postedOn.Location = new System.Drawing.Point(12, 218);
            this.textBox_postedOn.Name = "textBox_postedOn";
            this.textBox_postedOn.ReadOnly = true;
            this.textBox_postedOn.Size = new System.Drawing.Size(200, 15);
            this.textBox_postedOn.TabIndex = 5;
            this.textBox_postedOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_rating_nbRatings
            // 
            this.textBox_rating_nbRatings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_rating_nbRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_rating_nbRatings.Location = new System.Drawing.Point(12, 239);
            this.textBox_rating_nbRatings.Name = "textBox_rating_nbRatings";
            this.textBox_rating_nbRatings.ReadOnly = true;
            this.textBox_rating_nbRatings.Size = new System.Drawing.Size(200, 15);
            this.textBox_rating_nbRatings.TabIndex = 6;
            this.textBox_rating_nbRatings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dish type:";
            // 
            // textBox_dishType
            // 
            this.textBox_dishType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_dishType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dishType.Location = new System.Drawing.Point(343, 95);
            this.textBox_dishType.Multiline = true;
            this.textBox_dishType.Name = "textBox_dishType";
            this.textBox_dishType.ReadOnly = true;
            this.textBox_dishType.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_dishType.Size = new System.Drawing.Size(360, 20);
            this.textBox_dishType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dish Origin:";
            // 
            // textBox_dishOrigin
            // 
            this.textBox_dishOrigin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_dishOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dishOrigin.Location = new System.Drawing.Point(343, 123);
            this.textBox_dishOrigin.Multiline = true;
            this.textBox_dishOrigin.Name = "textBox_dishOrigin";
            this.textBox_dishOrigin.ReadOnly = true;
            this.textBox_dishOrigin.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_dishOrigin.Size = new System.Drawing.Size(360, 20);
            this.textBox_dishOrigin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description:";
            // 
            // textBox_description
            // 
            this.textBox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_description.Location = new System.Drawing.Point(343, 171);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.ReadOnly = true;
            this.textBox_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_description.Size = new System.Drawing.Size(605, 83);
            this.textBox_description.TabIndex = 11;
            // 
            // textBox_isCompany
            // 
            this.textBox_isCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_isCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_isCompany.Location = new System.Drawing.Point(218, 63);
            this.textBox_isCompany.Name = "textBox_isCompany";
            this.textBox_isCompany.ReadOnly = true;
            this.textBox_isCompany.Size = new System.Drawing.Size(119, 15);
            this.textBox_isCompany.TabIndex = 13;
            // 
            // dataGridView_ingredients
            // 
            this.dataGridView_ingredients.AllowUserToAddRows = false;
            this.dataGridView_ingredients.AllowUserToDeleteRows = false;
            this.dataGridView_ingredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ingredients.Location = new System.Drawing.Point(12, 298);
            this.dataGridView_ingredients.MultiSelect = false;
            this.dataGridView_ingredients.Name = "dataGridView_ingredients";
            this.dataGridView_ingredients.ReadOnly = true;
            this.dataGridView_ingredients.Size = new System.Drawing.Size(381, 172);
            this.dataGridView_ingredients.TabIndex = 14;
            this.dataGridView_ingredients.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ingredients_CellEnter);
            this.dataGridView_ingredients.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ingredients_RowEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ingredients:";
            // 
            // textBox_instructions
            // 
            this.textBox_instructions.BackColor = System.Drawing.Color.White;
            this.textBox_instructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_instructions.Location = new System.Drawing.Point(12, 506);
            this.textBox_instructions.Multiline = true;
            this.textBox_instructions.Name = "textBox_instructions";
            this.textBox_instructions.ReadOnly = true;
            this.textBox_instructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_instructions.Size = new System.Drawing.Size(936, 160);
            this.textBox_instructions.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Instructions:";
            // 
            // button_saveRecipe
            // 
            this.button_saveRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_saveRecipe.Location = new System.Drawing.Point(222, 194);
            this.button_saveRecipe.Name = "button_saveRecipe";
            this.button_saveRecipe.Size = new System.Drawing.Size(98, 23);
            this.button_saveRecipe.TabIndex = 18;
            this.button_saveRecipe.Text = "Save recipe";
            this.button_saveRecipe.UseVisualStyleBackColor = true;
            this.button_saveRecipe.Click += new System.EventHandler(this.button_saveRecipe_Click);
            // 
            // button_rateRecipe
            // 
            this.button_rateRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rateRecipe.Location = new System.Drawing.Point(222, 223);
            this.button_rateRecipe.Name = "button_rateRecipe";
            this.button_rateRecipe.Size = new System.Drawing.Size(98, 23);
            this.button_rateRecipe.TabIndex = 19;
            this.button_rateRecipe.Text = "Rate recipe";
            this.button_rateRecipe.UseVisualStyleBackColor = true;
            this.button_rateRecipe.Click += new System.EventHandler(this.button_rateRecipe_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(709, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Time:";
            // 
            // textBox_prepTime
            // 
            this.textBox_prepTime.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_prepTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_prepTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_prepTime.Location = new System.Drawing.Point(804, 12);
            this.textBox_prepTime.Multiline = true;
            this.textBox_prepTime.Name = "textBox_prepTime";
            this.textBox_prepTime.ReadOnly = true;
            this.textBox_prepTime.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_prepTime.Size = new System.Drawing.Size(144, 20);
            this.textBox_prepTime.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(709, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Serves:";
            // 
            // textBox_serves
            // 
            this.textBox_serves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_serves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_serves.Location = new System.Drawing.Point(804, 38);
            this.textBox_serves.Multiline = true;
            this.textBox_serves.Name = "textBox_serves";
            this.textBox_serves.ReadOnly = true;
            this.textBox_serves.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_serves.Size = new System.Drawing.Size(144, 20);
            this.textBox_serves.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(709, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Difficulty:";
            // 
            // textBox_difficulty
            // 
            this.textBox_difficulty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_difficulty.Location = new System.Drawing.Point(804, 64);
            this.textBox_difficulty.Multiline = true;
            this.textBox_difficulty.Name = "textBox_difficulty";
            this.textBox_difficulty.ReadOnly = true;
            this.textBox_difficulty.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_difficulty.Size = new System.Drawing.Size(144, 20);
            this.textBox_difficulty.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(709, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Calories:";
            // 
            // textBox_calories
            // 
            this.textBox_calories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_calories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_calories.Location = new System.Drawing.Point(804, 90);
            this.textBox_calories.Multiline = true;
            this.textBox_calories.Name = "textBox_calories";
            this.textBox_calories.ReadOnly = true;
            this.textBox_calories.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_calories.Size = new System.Drawing.Size(144, 20);
            this.textBox_calories.TabIndex = 26;
            // 
            // pictureBox_productImage
            // 
            this.pictureBox_productImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_productImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_productImage.Name = "pictureBox_productImage";
            this.pictureBox_productImage.Size = new System.Drawing.Size(166, 166);
            this.pictureBox_productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_productImage.TabIndex = 28;
            this.pictureBox_productImage.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(392, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Selected product:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_providers);
            this.panel1.Controls.Add(this.pictureBox_productImage);
            this.panel1.Location = new System.Drawing.Point(396, 298);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 172);
            this.panel1.TabIndex = 30;
            // 
            // dataGridView_providers
            // 
            this.dataGridView_providers.AllowUserToAddRows = false;
            this.dataGridView_providers.AllowUserToDeleteRows = false;
            this.dataGridView_providers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_providers.Location = new System.Drawing.Point(175, 3);
            this.dataGridView_providers.MultiSelect = false;
            this.dataGridView_providers.Name = "dataGridView_providers";
            this.dataGridView_providers.ReadOnly = true;
            this.dataGridView_providers.Size = new System.Drawing.Size(374, 166);
            this.dataGridView_providers.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(567, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Providers:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(238, 252);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 33;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(340, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(225, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "Double click on author name to view profile";
            this.label14.Visible = false;
            // 
            // Form_RecipeViewFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 678);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_calories);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_difficulty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_serves);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_prepTime);
            this.Controls.Add(this.button_rateRecipe);
            this.Controls.Add(this.button_saveRecipe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_instructions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_ingredients);
            this.Controls.Add(this.textBox_isCompany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_dishOrigin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_dishType);
            this.Controls.Add(this.textBox_rating_nbRatings);
            this.Controls.Add(this.textBox_postedOn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_authorName);
            this.Controls.Add(this.pictureBox_recipeImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_recipeName);
            this.Name = "Form_RecipeViewFull";
            this.Text = "Form_RecipeViewFull";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recipeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ingredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_productImage)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_providers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_recipeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_recipeImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_authorName;
        private System.Windows.Forms.TextBox textBox_postedOn;
        private System.Windows.Forms.TextBox textBox_rating_nbRatings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_dishType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_dishOrigin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_isCompany;
        private System.Windows.Forms.DataGridView dataGridView_ingredients;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_instructions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_saveRecipe;
        private System.Windows.Forms.Button button_rateRecipe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_prepTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_serves;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_difficulty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_calories;
        private System.Windows.Forms.PictureBox pictureBox_productImage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_providers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label14;
    }
}