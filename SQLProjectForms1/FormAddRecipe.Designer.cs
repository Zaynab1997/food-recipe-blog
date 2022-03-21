namespace SQLProjectForms1
{
    partial class FormAddRecipe
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox_recipe = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.button_image = new System.Windows.Forms.Button();
            this.textBox_recipe_name = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_difficulty = new System.Windows.Forms.TextBox();
            this.label_recipe_name = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_difficulty = new System.Windows.Forms.Label();
            this.label_origin = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_prep_time = new System.Windows.Forms.Label();
            this.label_serves = new System.Windows.Forms.Label();
            this.label_calories = new System.Windows.Forms.Label();
            this.textBox_prep_time = new System.Windows.Forms.TextBox();
            this.textBox_serves = new System.Windows.Forms.TextBox();
            this.textBox_calories = new System.Windows.Forms.TextBox();
            this.label_Ingredients = new System.Windows.Forms.Label();
            this.label_instructions = new System.Windows.Forms.Label();
            this.textBox_instructions = new System.Windows.Forms.TextBox();
            this.button_save_recipe = new System.Windows.Forms.Button();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.comboBox_origin = new System.Windows.Forms.ComboBox();
            this.label_author = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.textBox_productDescription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFromListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_subcategory = new System.Windows.Forms.ComboBox();
            this.comboBox_productName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_addProduct = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown_rating = new System.Windows.Forms.NumericUpDown();
            this.label_rating = new System.Windows.Forms.Label();
            this.button_profile = new System.Windows.Forms.Button();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label_amount = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rating)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_recipe
            // 
            this.pictureBox_recipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_recipe.Location = new System.Drawing.Point(36, 48);
            this.pictureBox_recipe.Name = "pictureBox_recipe";
            this.pictureBox_recipe.Size = new System.Drawing.Size(141, 125);
            this.pictureBox_recipe.TabIndex = 0;
            this.pictureBox_recipe.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(30, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(130, 24);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Add a recipe";
            // 
            // button_image
            // 
            this.button_image.Location = new System.Drawing.Point(58, 179);
            this.button_image.Name = "button_image";
            this.button_image.Size = new System.Drawing.Size(102, 73);
            this.button_image.TabIndex = 2;
            this.button_image.Text = "choose image (optional)";
            this.button_image.UseVisualStyleBackColor = true;
            this.button_image.Click += new System.EventHandler(this.button_image_Click);
            // 
            // textBox_recipe_name
            // 
            this.textBox_recipe_name.Location = new System.Drawing.Point(358, 49);
            this.textBox_recipe_name.Name = "textBox_recipe_name";
            this.textBox_recipe_name.Size = new System.Drawing.Size(214, 22);
            this.textBox_recipe_name.TabIndex = 3;
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(358, 80);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(214, 22);
            this.textBox_description.TabIndex = 4;
            // 
            // textBox_difficulty
            // 
            this.textBox_difficulty.Location = new System.Drawing.Point(358, 108);
            this.textBox_difficulty.Name = "textBox_difficulty";
            this.textBox_difficulty.Size = new System.Drawing.Size(214, 22);
            this.textBox_difficulty.TabIndex = 5;
            // 
            // label_recipe_name
            // 
            this.label_recipe_name.AutoSize = true;
            this.label_recipe_name.Location = new System.Drawing.Point(204, 52);
            this.label_recipe_name.Name = "label_recipe_name";
            this.label_recipe_name.Size = new System.Drawing.Size(93, 17);
            this.label_recipe_name.TabIndex = 7;
            this.label_recipe_name.Text = "Recipe Name";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(204, 83);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(79, 17);
            this.label_description.TabIndex = 9;
            this.label_description.Text = "Description";
            // 
            // label_difficulty
            // 
            this.label_difficulty.AutoSize = true;
            this.label_difficulty.Location = new System.Drawing.Point(204, 111);
            this.label_difficulty.Name = "label_difficulty";
            this.label_difficulty.Size = new System.Drawing.Size(61, 17);
            this.label_difficulty.TabIndex = 10;
            this.label_difficulty.Text = "Difficulty";
            // 
            // label_origin
            // 
            this.label_origin.AutoSize = true;
            this.label_origin.Location = new System.Drawing.Point(204, 139);
            this.label_origin.Name = "label_origin";
            this.label_origin.Size = new System.Drawing.Size(78, 17);
            this.label_origin.TabIndex = 12;
            this.label_origin.Text = "Dish Origin";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(204, 168);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(68, 17);
            this.label_type.TabIndex = 13;
            this.label_type.Text = "DishType";
            // 
            // label_prep_time
            // 
            this.label_prep_time.AutoSize = true;
            this.label_prep_time.Location = new System.Drawing.Point(204, 200);
            this.label_prep_time.Name = "label_prep_time";
            this.label_prep_time.Size = new System.Drawing.Size(149, 17);
            this.label_prep_time.TabIndex = 14;
            this.label_prep_time.Text = "Preperation Time(min)";
            // 
            // label_serves
            // 
            this.label_serves.AutoSize = true;
            this.label_serves.Location = new System.Drawing.Point(204, 231);
            this.label_serves.Name = "label_serves";
            this.label_serves.Size = new System.Drawing.Size(82, 17);
            this.label_serves.TabIndex = 15;
            this.label_serves.Text = "Unit Person";
            // 
            // label_calories
            // 
            this.label_calories.AutoSize = true;
            this.label_calories.Location = new System.Drawing.Point(204, 260);
            this.label_calories.Name = "label_calories";
            this.label_calories.Size = new System.Drawing.Size(96, 17);
            this.label_calories.TabIndex = 16;
            this.label_calories.Text = "Calories(Kcal)";
            // 
            // textBox_prep_time
            // 
            this.textBox_prep_time.Location = new System.Drawing.Point(358, 194);
            this.textBox_prep_time.Name = "textBox_prep_time";
            this.textBox_prep_time.Size = new System.Drawing.Size(214, 22);
            this.textBox_prep_time.TabIndex = 19;
            // 
            // textBox_serves
            // 
            this.textBox_serves.Location = new System.Drawing.Point(358, 225);
            this.textBox_serves.Name = "textBox_serves";
            this.textBox_serves.Size = new System.Drawing.Size(214, 22);
            this.textBox_serves.TabIndex = 20;
            // 
            // textBox_calories
            // 
            this.textBox_calories.Location = new System.Drawing.Point(358, 259);
            this.textBox_calories.Name = "textBox_calories";
            this.textBox_calories.Size = new System.Drawing.Size(214, 22);
            this.textBox_calories.TabIndex = 21;
            // 
            // label_Ingredients
            // 
            this.label_Ingredients.AutoSize = true;
            this.label_Ingredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ingredients.Location = new System.Drawing.Point(34, 280);
            this.label_Ingredients.Name = "label_Ingredients";
            this.label_Ingredients.Size = new System.Drawing.Size(158, 24);
            this.label_Ingredients.TabIndex = 23;
            this.label_Ingredients.Text = "Add Ingredients";
            // 
            // label_instructions
            // 
            this.label_instructions.AutoSize = true;
            this.label_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_instructions.Location = new System.Drawing.Point(17, 515);
            this.label_instructions.Name = "label_instructions";
            this.label_instructions.Size = new System.Drawing.Size(160, 24);
            this.label_instructions.TabIndex = 25;
            this.label_instructions.Text = "Add Instructions";
            // 
            // textBox_instructions
            // 
            this.textBox_instructions.Location = new System.Drawing.Point(21, 542);
            this.textBox_instructions.Multiline = true;
            this.textBox_instructions.Name = "textBox_instructions";
            this.textBox_instructions.Size = new System.Drawing.Size(874, 105);
            this.textBox_instructions.TabIndex = 26;
            // 
            // button_save_recipe
            // 
            this.button_save_recipe.Location = new System.Drawing.Point(735, 665);
            this.button_save_recipe.Name = "button_save_recipe";
            this.button_save_recipe.Size = new System.Drawing.Size(100, 23);
            this.button_save_recipe.TabIndex = 27;
            this.button_save_recipe.Text = "Save";
            this.button_save_recipe.UseVisualStyleBackColor = true;
            this.button_save_recipe.Click += new System.EventHandler(this.button_save_recipe_Click);
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(358, 164);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(214, 24);
            this.comboBox_type.TabIndex = 28;
            // 
            // comboBox_origin
            // 
            this.comboBox_origin.FormattingEnabled = true;
            this.comboBox_origin.Location = new System.Drawing.Point(358, 136);
            this.comboBox_origin.Name = "comboBox_origin";
            this.comboBox_origin.Size = new System.Drawing.Size(214, 24);
            this.comboBox_origin.TabIndex = 29;
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(204, 20);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(91, 17);
            this.label_author.TabIndex = 32;
            this.label_author.Text = "Author Name";
            this.label_author.Visible = false;
            // 
            // textBox_author
            // 
            this.textBox_author.Enabled = false;
            this.textBox_author.Location = new System.Drawing.Point(358, 17);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(214, 22);
            this.textBox_author.TabIndex = 31;
            this.textBox_author.Visible = false;
            // 
            // textBox_productDescription
            // 
            this.textBox_productDescription.Location = new System.Drawing.Point(735, 360);
            this.textBox_productDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_productDescription.Multiline = true;
            this.textBox_productDescription.Name = "textBox_productDescription";
            this.textBox_productDescription.ReadOnly = true;
            this.textBox_productDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_productDescription.Size = new System.Drawing.Size(175, 125);
            this.textBox_productDescription.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(590, 359);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 359);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(569, 126);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
            this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromListToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // removeFromListToolStripMenuItem
            // 
            this.removeFromListToolStripMenuItem.Name = "removeFromListToolStripMenuItem";
            this.removeFromListToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.removeFromListToolStripMenuItem.Text = "Remove from list";
            this.removeFromListToolStripMenuItem.Click += new System.EventHandler(this.removeFromListToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Category:";
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(127, 8);
            this.comboBox_category.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(160, 24);
            this.comboBox_category.TabIndex = 33;
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(573, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "Product name:";
            // 
            // comboBox_subcategory
            // 
            this.comboBox_subcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_subcategory.FormattingEnabled = true;
            this.comboBox_subcategory.Location = new System.Drawing.Point(412, 8);
            this.comboBox_subcategory.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_subcategory.Name = "comboBox_subcategory";
            this.comboBox_subcategory.Size = new System.Drawing.Size(160, 24);
            this.comboBox_subcategory.TabIndex = 35;
            this.comboBox_subcategory.SelectedIndexChanged += new System.EventHandler(this.comboBox_subcategory_SelectedIndexChanged);
            // 
            // comboBox_productName
            // 
            this.comboBox_productName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_productName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_productName.FormattingEnabled = true;
            this.comboBox_productName.Location = new System.Drawing.Point(706, 8);
            this.comboBox_productName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_productName.Name = "comboBox_productName";
            this.comboBox_productName.Size = new System.Drawing.Size(187, 24);
            this.comboBox_productName.TabIndex = 37;
            this.comboBox_productName.SelectedIndexChanged += new System.EventHandler(this.comboBox_productName_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(292, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Subcategory:";
            // 
            // button_addProduct
            // 
            this.button_addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addProduct.Location = new System.Drawing.Point(735, 493);
            this.button_addProduct.Margin = new System.Windows.Forms.Padding(4);
            this.button_addProduct.Name = "button_addProduct";
            this.button_addProduct.Size = new System.Drawing.Size(100, 28);
            this.button_addProduct.TabIndex = 39;
            this.button_addProduct.Text = "Add to list";
            this.button_addProduct.UseVisualStyleBackColor = true;
            this.button_addProduct.Click += new System.EventHandler(this.button_addProduct_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDown_rating
            // 
            this.numericUpDown_rating.Location = new System.Drawing.Point(697, 139);
            this.numericUpDown_rating.Name = "numericUpDown_rating";
            this.numericUpDown_rating.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_rating.TabIndex = 43;
            this.numericUpDown_rating.Visible = false;
            this.numericUpDown_rating.ValueChanged += new System.EventHandler(this.numericUpDown_rating_ValueChanged);
            this.numericUpDown_rating.Leave += new System.EventHandler(this.numericUpDown_rating_Leave);
            // 
            // label_rating
            // 
            this.label_rating.AutoSize = true;
            this.label_rating.Location = new System.Drawing.Point(626, 142);
            this.label_rating.Name = "label_rating";
            this.label_rating.Size = new System.Drawing.Size(49, 17);
            this.label_rating.TabIndex = 44;
            this.label_rating.Text = "Rating";
            this.label_rating.Visible = false;
            // 
            // button_profile
            // 
            this.button_profile.Location = new System.Drawing.Point(633, 17);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(102, 22);
            this.button_profile.TabIndex = 45;
            this.button_profile.Text = "Profile";
            this.button_profile.UseVisualStyleBackColor = true;
            this.button_profile.Visible = false;
            this.button_profile.Click += new System.EventHandler(this.button_follow_Click);
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(157, 495);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(214, 22);
            this.textBox_amount.TabIndex = 46;
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(512, 497);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(214, 22);
            this.textBox_quantity.TabIndex = 47;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Location = new System.Drawing.Point(55, 498);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(56, 17);
            this.label_amount.TabIndex = 48;
            this.label_amount.Text = "Amount";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(410, 500);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(61, 17);
            this.label_quantity.TabIndex = 49;
            this.label_quantity.Text = "Quantity";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_category);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBox_productName);
            this.panel1.Controls.Add(this.comboBox_subcategory);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(21, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 46);
            this.panel1.TabIndex = 50;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(650, 95);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(138, 21);
            this.radioButton1.TabIndex = 51;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Rate This Recipe";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "Add to Saved";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(929, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.button_profile);
            this.Controls.Add(this.label_rating);
            this.Controls.Add(this.numericUpDown_rating);
            this.Controls.Add(this.textBox_productDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_addProduct);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.comboBox_origin);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.button_save_recipe);
            this.Controls.Add(this.textBox_difficulty);
            this.Controls.Add(this.textBox_instructions);
            this.Controls.Add(this.label_difficulty);
            this.Controls.Add(this.label_instructions);
            this.Controls.Add(this.textBox_calories);
            this.Controls.Add(this.label_origin);
            this.Controls.Add(this.label_Ingredients);
            this.Controls.Add(this.textBox_serves);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.textBox_prep_time);
            this.Controls.Add(this.label_prep_time);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_serves);
            this.Controls.Add(this.label_recipe_name);
            this.Controls.Add(this.label_calories);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_recipe_name);
            this.Controls.Add(this.button_image);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.pictureBox_recipe);
            this.Name = "FormAddRecipe";
            this.Text = "FormAddRecipe";
            this.Load += new System.EventHandler(this.FormAddRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rating)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_recipe;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_image;
        private System.Windows.Forms.TextBox textBox_recipe_name;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_difficulty;
        private System.Windows.Forms.Label label_recipe_name;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_difficulty;
        private System.Windows.Forms.Label label_origin;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_prep_time;
        private System.Windows.Forms.Label label_serves;
        private System.Windows.Forms.Label label_calories;
        private System.Windows.Forms.TextBox textBox_prep_time;
        private System.Windows.Forms.TextBox textBox_serves;
        private System.Windows.Forms.TextBox textBox_calories;
        private System.Windows.Forms.Label label_Ingredients;
        private System.Windows.Forms.Label label_instructions;
        private System.Windows.Forms.TextBox textBox_instructions;
        private System.Windows.Forms.Button button_save_recipe;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.ComboBox comboBox_origin;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.TextBox textBox_productDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_subcategory;
        private System.Windows.Forms.ComboBox comboBox_productName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_addProduct;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeFromListToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDown_rating;
        private System.Windows.Forms.Label label_rating;
        private System.Windows.Forms.Button button_profile;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
    }
}