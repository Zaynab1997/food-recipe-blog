namespace SQLProjectForms1
{
    partial class FormAddProduct
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
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.comboBox_quantity_unit = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_quantity_per_unit = new System.Windows.Forms.TextBox();
            this.label_category = new System.Windows.Forms.Label();
            this.textBox_units_in_stock = new System.Windows.Forms.TextBox();
            this.label_quantity_unit = new System.Windows.Forms.Label();
            this.textBox_unit_price = new System.Windows.Forms.TextBox();
            this.label_unit_price = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_units_in_stock = new System.Windows.Forms.Label();
            this.label_product_name = new System.Windows.Forms.Label();
            this.label_quantity_per_unit = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.button_image = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox_product = new System.Windows.Forms.PictureBox();
            this.comboBox_main_category = new System.Windows.Forms.ComboBox();
            this.label_main_category = new System.Windows.Forms.Label();
            this.comboBox_product_name = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox_new_prod = new System.Windows.Forms.CheckBox();
            this.button_companies = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(334, 75);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(214, 24);
            this.comboBox_category.TabIndex = 49;
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            // 
            // comboBox_quantity_unit
            // 
            this.comboBox_quantity_unit.FormattingEnabled = true;
            this.comboBox_quantity_unit.Location = new System.Drawing.Point(334, 172);
            this.comboBox_quantity_unit.Name = "comboBox_quantity_unit";
            this.comboBox_quantity_unit.Size = new System.Drawing.Size(214, 24);
            this.comboBox_quantity_unit.TabIndex = 48;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(575, 272);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 47;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_quantity_per_unit
            // 
            this.textBox_quantity_per_unit.Location = new System.Drawing.Point(334, 271);
            this.textBox_quantity_per_unit.Name = "textBox_quantity_per_unit";
            this.textBox_quantity_per_unit.Size = new System.Drawing.Size(214, 22);
            this.textBox_quantity_per_unit.TabIndex = 46;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Location = new System.Drawing.Point(180, 78);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(88, 17);
            this.label_category.TabIndex = 39;
            this.label_category.Text = "Subcategory";
            // 
            // textBox_units_in_stock
            // 
            this.textBox_units_in_stock.Location = new System.Drawing.Point(334, 237);
            this.textBox_units_in_stock.Name = "textBox_units_in_stock";
            this.textBox_units_in_stock.Size = new System.Drawing.Size(214, 22);
            this.textBox_units_in_stock.TabIndex = 45;
            // 
            // label_quantity_unit
            // 
            this.label_quantity_unit.AutoSize = true;
            this.label_quantity_unit.Location = new System.Drawing.Point(180, 176);
            this.label_quantity_unit.Name = "label_quantity_unit";
            this.label_quantity_unit.Size = new System.Drawing.Size(90, 17);
            this.label_quantity_unit.TabIndex = 40;
            this.label_quantity_unit.Text = "Quantity Unit";
            // 
            // textBox_unit_price
            // 
            this.textBox_unit_price.Location = new System.Drawing.Point(334, 206);
            this.textBox_unit_price.Name = "textBox_unit_price";
            this.textBox_unit_price.Size = new System.Drawing.Size(214, 22);
            this.textBox_unit_price.TabIndex = 44;
            // 
            // label_unit_price
            // 
            this.label_unit_price.AutoSize = true;
            this.label_unit_price.Location = new System.Drawing.Point(180, 212);
            this.label_unit_price.Name = "label_unit_price";
            this.label_unit_price.Size = new System.Drawing.Size(69, 17);
            this.label_unit_price.TabIndex = 41;
            this.label_unit_price.Text = "Unit Price";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(180, 143);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(79, 17);
            this.label_description.TabIndex = 38;
            this.label_description.Text = "Description";
            // 
            // label_units_in_stock
            // 
            this.label_units_in_stock.AutoSize = true;
            this.label_units_in_stock.Location = new System.Drawing.Point(180, 243);
            this.label_units_in_stock.Name = "label_units_in_stock";
            this.label_units_in_stock.Size = new System.Drawing.Size(94, 17);
            this.label_units_in_stock.TabIndex = 42;
            this.label_units_in_stock.Text = "Units in Stock";
            // 
            // label_product_name
            // 
            this.label_product_name.AutoSize = true;
            this.label_product_name.Location = new System.Drawing.Point(180, 110);
            this.label_product_name.Name = "label_product_name";
            this.label_product_name.Size = new System.Drawing.Size(98, 17);
            this.label_product_name.TabIndex = 37;
            this.label_product_name.Text = "Product Name";
            // 
            // label_quantity_per_unit
            // 
            this.label_quantity_per_unit.AutoSize = true;
            this.label_quantity_per_unit.Location = new System.Drawing.Point(180, 272);
            this.label_quantity_per_unit.Name = "label_quantity_per_unit";
            this.label_quantity_per_unit.Size = new System.Drawing.Size(115, 17);
            this.label_quantity_per_unit.TabIndex = 43;
            this.label_quantity_per_unit.Text = "Quantity per Unit";
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(334, 140);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(214, 22);
            this.textBox_description.TabIndex = 36;
            // 
            // button_image
            // 
            this.button_image.Location = new System.Drawing.Point(34, 190);
            this.button_image.Name = "button_image";
            this.button_image.Size = new System.Drawing.Size(102, 73);
            this.button_image.TabIndex = 34;
            this.button_image.Text = "choose image (optional)";
            this.button_image.UseVisualStyleBackColor = true;
            this.button_image.Click += new System.EventHandler(this.button_image_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(6, 14);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(142, 24);
            this.label_title.TabIndex = 33;
            this.label_title.Text = "Add a product";
            // 
            // pictureBox_product
            // 
            this.pictureBox_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_product.Location = new System.Drawing.Point(12, 53);
            this.pictureBox_product.Name = "pictureBox_product";
            this.pictureBox_product.Size = new System.Drawing.Size(141, 125);
            this.pictureBox_product.TabIndex = 32;
            this.pictureBox_product.TabStop = false;
            // 
            // comboBox_main_category
            // 
            this.comboBox_main_category.FormattingEnabled = true;
            this.comboBox_main_category.Location = new System.Drawing.Point(334, 45);
            this.comboBox_main_category.Name = "comboBox_main_category";
            this.comboBox_main_category.Size = new System.Drawing.Size(214, 24);
            this.comboBox_main_category.TabIndex = 52;
            this.comboBox_main_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_main_category_SelectedIndexChanged);
            // 
            // label_main_category
            // 
            this.label_main_category.AutoSize = true;
            this.label_main_category.Location = new System.Drawing.Point(180, 48);
            this.label_main_category.Name = "label_main_category";
            this.label_main_category.Size = new System.Drawing.Size(65, 17);
            this.label_main_category.TabIndex = 51;
            this.label_main_category.Text = "Category";
            // 
            // comboBox_product_name
            // 
            this.comboBox_product_name.FormattingEnabled = true;
            this.comboBox_product_name.Location = new System.Drawing.Point(334, 107);
            this.comboBox_product_name.Name = "comboBox_product_name";
            this.comboBox_product_name.Size = new System.Drawing.Size(214, 24);
            this.comboBox_product_name.TabIndex = 53;
            this.comboBox_product_name.SelectedIndexChanged += new System.EventHandler(this.comboBox_product_name_SelectedIndexChanged);
            this.comboBox_product_name.TextUpdate += new System.EventHandler(this.comboBox_product_name_TextUpdate);
            this.comboBox_product_name.Enter += new System.EventHandler(this.comboBox_product_name_Enter);
            this.comboBox_product_name.Leave += new System.EventHandler(this.comboBox_product_name_Leave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox_new_prod
            // 
            this.checkBox_new_prod.AutoSize = true;
            this.checkBox_new_prod.Location = new System.Drawing.Point(555, 109);
            this.checkBox_new_prod.Name = "checkBox_new_prod";
            this.checkBox_new_prod.Size = new System.Drawing.Size(113, 21);
            this.checkBox_new_prod.TabIndex = 54;
            this.checkBox_new_prod.Text = "New_product";
            this.checkBox_new_prod.UseVisualStyleBackColor = true;
            // 
            // button_companies
            // 
            this.button_companies.Location = new System.Drawing.Point(183, 12);
            this.button_companies.Name = "button_companies";
            this.button_companies.Size = new System.Drawing.Size(123, 23);
            this.button_companies.TabIndex = 55;
            this.button_companies.Text = "Show Providers";
            this.button_companies.UseVisualStyleBackColor = true;
            this.button_companies.Visible = false;
            this.button_companies.Click += new System.EventHandler(this.button_companies_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(403, 12);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 56;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(678, 314);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_companies);
            this.Controls.Add(this.checkBox_new_prod);
            this.Controls.Add(this.comboBox_product_name);
            this.Controls.Add(this.comboBox_main_category);
            this.Controls.Add(this.label_main_category);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.comboBox_quantity_unit);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_quantity_per_unit);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.textBox_units_in_stock);
            this.Controls.Add(this.label_quantity_unit);
            this.Controls.Add(this.textBox_unit_price);
            this.Controls.Add(this.label_unit_price);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_units_in_stock);
            this.Controls.Add(this.label_product_name);
            this.Controls.Add(this.label_quantity_per_unit);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.button_image);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.pictureBox_product);
            this.Name = "FormAddProduct";
            this.Text = "FormAddRecipe";
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.ComboBox comboBox_quantity_unit;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_quantity_per_unit;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.TextBox textBox_units_in_stock;
        private System.Windows.Forms.Label label_quantity_unit;
        private System.Windows.Forms.TextBox textBox_unit_price;
        private System.Windows.Forms.Label label_unit_price;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_units_in_stock;
        private System.Windows.Forms.Label label_product_name;
        private System.Windows.Forms.Label label_quantity_per_unit;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Button button_image;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox pictureBox_product;
        private System.Windows.Forms.ComboBox comboBox_main_category;
        private System.Windows.Forms.Label label_main_category;
        private System.Windows.Forms.ComboBox comboBox_product_name;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox_new_prod;
        private System.Windows.Forms.Button button_companies;
        private System.Windows.Forms.Button button_edit;
    }
}