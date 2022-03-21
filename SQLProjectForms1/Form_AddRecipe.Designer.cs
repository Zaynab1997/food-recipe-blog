namespace SQLProjectForms1
{
    partial class Form_AddRecipe
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
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox_recipeImage = new System.Windows.Forms.PictureBox();
            this.button_recipeImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_recipeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.checkBox_time = new System.Windows.Forms.CheckBox();
            this.numericUpDown_time = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_serves = new System.Windows.Forms.NumericUpDown();
            this.checkBox_serves = new System.Windows.Forms.CheckBox();
            this.numericUpDown_calories = new System.Windows.Forms.NumericUpDown();
            this.checkBox_calories = new System.Windows.Forms.CheckBox();
            this.numericUpDown_difficulty = new System.Windows.Forms.NumericUpDown();
            this.checkBox_difficulty = new System.Windows.Forms.CheckBox();
            this.checkBox_dishType = new System.Windows.Forms.CheckBox();
            this.comboBox_dishType = new System.Windows.Forms.ComboBox();
            this.comboBox_dishOrigin = new System.Windows.Forms.ComboBox();
            this.checkBox_dishOrigin = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFromListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_subcategory = new System.Windows.Forms.ComboBox();
            this.comboBox_productName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_addProduct = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_productDescription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox_amount = new System.Windows.Forms.CheckBox();
            this.numericUpDown_amount = new System.Windows.Forms.NumericUpDown();
            this.comboBox_quantity = new System.Windows.Forms.ComboBox();
            this.checkBox_comment = new System.Windows.Forms.CheckBox();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.button_createRecipe = new System.Windows.Forms.Button();
            this.textBox_instructions = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recipeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_serves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_calories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_difficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(11, 9);
            this.label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(101, 18);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Add a recipe";
            // 
            // pictureBox_recipeImage
            // 
            this.pictureBox_recipeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_recipeImage.Location = new System.Drawing.Point(12, 30);
            this.pictureBox_recipeImage.Name = "pictureBox_recipeImage";
            this.pictureBox_recipeImage.Size = new System.Drawing.Size(120, 120);
            this.pictureBox_recipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_recipeImage.TabIndex = 37;
            this.pictureBox_recipeImage.TabStop = false;
            // 
            // button_recipeImage
            // 
            this.button_recipeImage.Location = new System.Drawing.Point(12, 156);
            this.button_recipeImage.Name = "button_recipeImage";
            this.button_recipeImage.Size = new System.Drawing.Size(120, 44);
            this.button_recipeImage.TabIndex = 36;
            this.button_recipeImage.Text = "Choose Image (optional)";
            this.button_recipeImage.UseVisualStyleBackColor = true;
            this.button_recipeImage.Click += new System.EventHandler(this.button_recipeImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Recipe name:";
            // 
            // textBox_recipeName
            // 
            this.textBox_recipeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_recipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_recipeName.Location = new System.Drawing.Point(263, 30);
            this.textBox_recipeName.Multiline = true;
            this.textBox_recipeName.Name = "textBox_recipeName";
            this.textBox_recipeName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_recipeName.Size = new System.Drawing.Size(360, 20);
            this.textBox_recipeName.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Description:";
            // 
            // textBox_description
            // 
            this.textBox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_description.Location = new System.Drawing.Point(263, 56);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_description.Size = new System.Drawing.Size(360, 67);
            this.textBox_description.TabIndex = 40;
            // 
            // checkBox_time
            // 
            this.checkBox_time.AutoSize = true;
            this.checkBox_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_time.Location = new System.Drawing.Point(155, 139);
            this.checkBox_time.Name = "checkBox_time";
            this.checkBox_time.Size = new System.Drawing.Size(62, 20);
            this.checkBox_time.TabIndex = 42;
            this.checkBox_time.Text = "Time";
            this.checkBox_time.UseVisualStyleBackColor = true;
            this.checkBox_time.CheckedChanged += new System.EventHandler(this.checkBox_time_CheckedChanged);
            // 
            // numericUpDown_time
            // 
            this.numericUpDown_time.Enabled = false;
            this.numericUpDown_time.Location = new System.Drawing.Point(263, 139);
            this.numericUpDown_time.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown_time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_time.Name = "numericUpDown_time";
            this.numericUpDown_time.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_time.TabIndex = 43;
            this.numericUpDown_time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_serves
            // 
            this.numericUpDown_serves.Enabled = false;
            this.numericUpDown_serves.Location = new System.Drawing.Point(263, 165);
            this.numericUpDown_serves.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_serves.Name = "numericUpDown_serves";
            this.numericUpDown_serves.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_serves.TabIndex = 45;
            this.numericUpDown_serves.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_serves
            // 
            this.checkBox_serves.AutoSize = true;
            this.checkBox_serves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_serves.Location = new System.Drawing.Point(155, 165);
            this.checkBox_serves.Name = "checkBox_serves";
            this.checkBox_serves.Size = new System.Drawing.Size(76, 20);
            this.checkBox_serves.TabIndex = 44;
            this.checkBox_serves.Text = "Serves";
            this.checkBox_serves.UseVisualStyleBackColor = true;
            this.checkBox_serves.CheckedChanged += new System.EventHandler(this.checkBox_serves_CheckedChanged);
            // 
            // numericUpDown_calories
            // 
            this.numericUpDown_calories.Enabled = false;
            this.numericUpDown_calories.Location = new System.Drawing.Point(524, 139);
            this.numericUpDown_calories.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_calories.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_calories.Name = "numericUpDown_calories";
            this.numericUpDown_calories.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_calories.TabIndex = 47;
            this.numericUpDown_calories.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_calories
            // 
            this.checkBox_calories.AutoSize = true;
            this.checkBox_calories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_calories.Location = new System.Drawing.Point(416, 139);
            this.checkBox_calories.Name = "checkBox_calories";
            this.checkBox_calories.Size = new System.Drawing.Size(85, 20);
            this.checkBox_calories.TabIndex = 46;
            this.checkBox_calories.Text = "Calories";
            this.checkBox_calories.UseVisualStyleBackColor = true;
            this.checkBox_calories.CheckedChanged += new System.EventHandler(this.checkBox_calories_CheckedChanged);
            // 
            // numericUpDown_difficulty
            // 
            this.numericUpDown_difficulty.Enabled = false;
            this.numericUpDown_difficulty.Location = new System.Drawing.Point(524, 165);
            this.numericUpDown_difficulty.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_difficulty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_difficulty.Name = "numericUpDown_difficulty";
            this.numericUpDown_difficulty.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_difficulty.TabIndex = 49;
            this.numericUpDown_difficulty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_difficulty
            // 
            this.checkBox_difficulty.AutoSize = true;
            this.checkBox_difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_difficulty.Location = new System.Drawing.Point(416, 165);
            this.checkBox_difficulty.Name = "checkBox_difficulty";
            this.checkBox_difficulty.Size = new System.Drawing.Size(86, 20);
            this.checkBox_difficulty.TabIndex = 48;
            this.checkBox_difficulty.Text = "Difficulty";
            this.checkBox_difficulty.UseVisualStyleBackColor = true;
            this.checkBox_difficulty.CheckedChanged += new System.EventHandler(this.checkBox_difficulty_CheckedChanged);
            // 
            // checkBox_dishType
            // 
            this.checkBox_dishType.AutoSize = true;
            this.checkBox_dishType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_dishType.Location = new System.Drawing.Point(155, 205);
            this.checkBox_dishType.Name = "checkBox_dishType";
            this.checkBox_dishType.Size = new System.Drawing.Size(92, 20);
            this.checkBox_dishType.TabIndex = 50;
            this.checkBox_dishType.Text = "Dish type";
            this.checkBox_dishType.UseVisualStyleBackColor = true;
            this.checkBox_dishType.CheckedChanged += new System.EventHandler(this.checkBox_dishType_CheckedChanged);
            // 
            // comboBox_dishType
            // 
            this.comboBox_dishType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_dishType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_dishType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dishType.Enabled = false;
            this.comboBox_dishType.FormattingEnabled = true;
            this.comboBox_dishType.Location = new System.Drawing.Point(263, 205);
            this.comboBox_dishType.Name = "comboBox_dishType";
            this.comboBox_dishType.Size = new System.Drawing.Size(121, 21);
            this.comboBox_dishType.TabIndex = 51;
            // 
            // comboBox_dishOrigin
            // 
            this.comboBox_dishOrigin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_dishOrigin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_dishOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dishOrigin.Enabled = false;
            this.comboBox_dishOrigin.FormattingEnabled = true;
            this.comboBox_dishOrigin.Location = new System.Drawing.Point(524, 203);
            this.comboBox_dishOrigin.Name = "comboBox_dishOrigin";
            this.comboBox_dishOrigin.Size = new System.Drawing.Size(121, 21);
            this.comboBox_dishOrigin.TabIndex = 53;
            // 
            // checkBox_dishOrigin
            // 
            this.checkBox_dishOrigin.AutoSize = true;
            this.checkBox_dishOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_dishOrigin.Location = new System.Drawing.Point(416, 203);
            this.checkBox_dishOrigin.Name = "checkBox_dishOrigin";
            this.checkBox_dishOrigin.Size = new System.Drawing.Size(101, 20);
            this.checkBox_dishOrigin.TabIndex = 52;
            this.checkBox_dishOrigin.Text = "Dish origin";
            this.checkBox_dishOrigin.UseVisualStyleBackColor = true;
            this.checkBox_dishOrigin.CheckedChanged += new System.EventHandler(this.checkBox_dishOrigin_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(12, 452);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "Right click to delete product.";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(413, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(315, 21);
            this.label12.TabIndex = 60;
            this.label12.Text = "Showing top results. For more, change product name.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(427, 102);
            this.dataGridView1.TabIndex = 57;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromListToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 26);
            // 
            // removeFromListToolStripMenuItem
            // 
            this.removeFromListToolStripMenuItem.Name = "removeFromListToolStripMenuItem";
            this.removeFromListToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removeFromListToolStripMenuItem.Text = "Remove from list";
            this.removeFromListToolStripMenuItem.Click += new System.EventHandler(this.removeFromListToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.comboBox_category);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.comboBox_subcategory);
            this.panel3.Controls.Add(this.comboBox_productName);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(12, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(716, 32);
            this.panel3.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Category:";
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(89, 3);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(121, 21);
            this.comboBox_category.TabIndex = 16;
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(449, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Ingredient name:";
            // 
            // comboBox_subcategory
            // 
            this.comboBox_subcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_subcategory.FormattingEnabled = true;
            this.comboBox_subcategory.Location = new System.Drawing.Point(322, 3);
            this.comboBox_subcategory.Name = "comboBox_subcategory";
            this.comboBox_subcategory.Size = new System.Drawing.Size(121, 21);
            this.comboBox_subcategory.TabIndex = 18;
            this.comboBox_subcategory.SelectedIndexChanged += new System.EventHandler(this.comboBox_subcategory_SelectedIndexChanged);
            // 
            // comboBox_productName
            // 
            this.comboBox_productName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_productName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_productName.FormattingEnabled = true;
            this.comboBox_productName.Location = new System.Drawing.Point(572, 3);
            this.comboBox_productName.Name = "comboBox_productName";
            this.comboBox_productName.Size = new System.Drawing.Size(141, 21);
            this.comboBox_productName.TabIndex = 20;
            this.comboBox_productName.SelectedIndexChanged += new System.EventHandler(this.comboBox_productName_SelectedIndexChanged);
            this.comboBox_productName.TextChanged += new System.EventHandler(this.comboBox_productName_TextChanged);
            this.comboBox_productName.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_productName_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(216, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Subcategory:";
            // 
            // button_addProduct
            // 
            this.button_addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addProduct.Location = new System.Drawing.Point(700, 365);
            this.button_addProduct.Name = "button_addProduct";
            this.button_addProduct.Size = new System.Drawing.Size(40, 54);
            this.button_addProduct.TabIndex = 55;
            this.button_addProduct.Text = "Add to list";
            this.button_addProduct.UseVisualStyleBackColor = true;
            this.button_addProduct.Click += new System.EventHandler(this.button_addProduct_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_productDescription
            // 
            this.textBox_productDescription.Location = new System.Drawing.Point(562, 347);
            this.textBox_productDescription.Multiline = true;
            this.textBox_productDescription.Name = "textBox_productDescription";
            this.textBox_productDescription.ReadOnly = true;
            this.textBox_productDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_productDescription.Size = new System.Drawing.Size(132, 102);
            this.textBox_productDescription.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(454, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox_amount
            // 
            this.checkBox_amount.AutoSize = true;
            this.checkBox_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_amount.Location = new System.Drawing.Point(12, 321);
            this.checkBox_amount.Name = "checkBox_amount";
            this.checkBox_amount.Size = new System.Drawing.Size(78, 20);
            this.checkBox_amount.TabIndex = 62;
            this.checkBox_amount.Text = "Amount";
            this.checkBox_amount.UseVisualStyleBackColor = true;
            this.checkBox_amount.CheckedChanged += new System.EventHandler(this.checkBox_amount_CheckedChanged);
            // 
            // numericUpDown_amount
            // 
            this.numericUpDown_amount.Enabled = false;
            this.numericUpDown_amount.Location = new System.Drawing.Point(96, 321);
            this.numericUpDown_amount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_amount.Name = "numericUpDown_amount";
            this.numericUpDown_amount.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown_amount.TabIndex = 63;
            this.numericUpDown_amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_quantity
            // 
            this.comboBox_quantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_quantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_quantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_quantity.Enabled = false;
            this.comboBox_quantity.FormattingEnabled = true;
            this.comboBox_quantity.Location = new System.Drawing.Point(191, 320);
            this.comboBox_quantity.Name = "comboBox_quantity";
            this.comboBox_quantity.Size = new System.Drawing.Size(83, 21);
            this.comboBox_quantity.TabIndex = 64;
            // 
            // checkBox_comment
            // 
            this.checkBox_comment.AutoSize = true;
            this.checkBox_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_comment.Location = new System.Drawing.Point(377, 320);
            this.checkBox_comment.Name = "checkBox_comment";
            this.checkBox_comment.Size = new System.Drawing.Size(91, 20);
            this.checkBox_comment.TabIndex = 65;
            this.checkBox_comment.Text = "Comment";
            this.checkBox_comment.UseVisualStyleBackColor = true;
            this.checkBox_comment.CheckedChanged += new System.EventHandler(this.checkBox_comment_CheckedChanged);
            // 
            // textBox_comment
            // 
            this.textBox_comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_comment.Enabled = false;
            this.textBox_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_comment.Location = new System.Drawing.Point(474, 321);
            this.textBox_comment.Multiline = true;
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_comment.Size = new System.Drawing.Size(266, 20);
            this.textBox_comment.TabIndex = 66;
            // 
            // button_createRecipe
            // 
            this.button_createRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_createRecipe.Location = new System.Drawing.Point(644, 455);
            this.button_createRecipe.Name = "button_createRecipe";
            this.button_createRecipe.Size = new System.Drawing.Size(96, 48);
            this.button_createRecipe.TabIndex = 67;
            this.button_createRecipe.Text = "Create recipe";
            this.button_createRecipe.UseVisualStyleBackColor = true;
            this.button_createRecipe.Click += new System.EventHandler(this.button_createRecipe_Click);
            // 
            // textBox_instructions
            // 
            this.textBox_instructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_instructions.Location = new System.Drawing.Point(12, 506);
            this.textBox_instructions.Multiline = true;
            this.textBox_instructions.Name = "textBox_instructions";
            this.textBox_instructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_instructions.Size = new System.Drawing.Size(728, 94);
            this.textBox_instructions.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Instructions:";
            // 
            // Form_AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_instructions);
            this.Controls.Add(this.button_createRecipe);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.checkBox_comment);
            this.Controls.Add(this.comboBox_quantity);
            this.Controls.Add(this.numericUpDown_amount);
            this.Controls.Add(this.checkBox_amount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button_addProduct);
            this.Controls.Add(this.textBox_productDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_dishOrigin);
            this.Controls.Add(this.checkBox_dishOrigin);
            this.Controls.Add(this.comboBox_dishType);
            this.Controls.Add(this.checkBox_dishType);
            this.Controls.Add(this.numericUpDown_difficulty);
            this.Controls.Add(this.checkBox_difficulty);
            this.Controls.Add(this.numericUpDown_calories);
            this.Controls.Add(this.checkBox_calories);
            this.Controls.Add(this.numericUpDown_serves);
            this.Controls.Add(this.checkBox_serves);
            this.Controls.Add(this.numericUpDown_time);
            this.Controls.Add(this.checkBox_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_recipeName);
            this.Controls.Add(this.pictureBox_recipeImage);
            this.Controls.Add(this.button_recipeImage);
            this.Controls.Add(this.label_title);
            this.Name = "Form_AddRecipe";
            this.Text = "Form_AddRecipe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recipeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_serves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_calories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_difficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox pictureBox_recipeImage;
        private System.Windows.Forms.Button button_recipeImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_recipeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.CheckBox checkBox_time;
        private System.Windows.Forms.NumericUpDown numericUpDown_time;
        private System.Windows.Forms.NumericUpDown numericUpDown_serves;
        private System.Windows.Forms.CheckBox checkBox_serves;
        private System.Windows.Forms.NumericUpDown numericUpDown_calories;
        private System.Windows.Forms.CheckBox checkBox_calories;
        private System.Windows.Forms.NumericUpDown numericUpDown_difficulty;
        private System.Windows.Forms.CheckBox checkBox_difficulty;
        private System.Windows.Forms.CheckBox checkBox_dishType;
        private System.Windows.Forms.ComboBox comboBox_dishType;
        private System.Windows.Forms.ComboBox comboBox_dishOrigin;
        private System.Windows.Forms.CheckBox checkBox_dishOrigin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeFromListToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_subcategory;
        private System.Windows.Forms.ComboBox comboBox_productName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_addProduct;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_productDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox_amount;
        private System.Windows.Forms.NumericUpDown numericUpDown_amount;
        private System.Windows.Forms.ComboBox comboBox_quantity;
        private System.Windows.Forms.CheckBox checkBox_comment;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.Button button_createRecipe;
        private System.Windows.Forms.TextBox textBox_instructions;
        private System.Windows.Forms.Label label2;
    }
}