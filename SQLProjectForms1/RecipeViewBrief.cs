using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Data;

namespace SQLProjectForms1
{
    class RecipeViewBrief : Panel
    {
        //private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox textBox_postedOn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_dishOrigin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_dishType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_authorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_recipeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_rating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_recipeImage;
        private System.Windows.Forms.Button button_viewRecipe;
        private System.Windows.Forms.TextBox textBox_nbMatchedProducts;
        private System.Windows.Forms.Label label_nbMatchedProducts;
        private System.Windows.Forms.Button button_editRecipe;


        public int recipe_id;

        public RecipeViewBrief()
        {
            this.button_viewRecipe = new System.Windows.Forms.Button();
            this.textBox_postedOn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_dishType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_authorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_recipeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_rating = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_dishOrigin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox_recipeImage = new System.Windows.Forms.PictureBox();
            this.textBox_nbMatchedProducts = new System.Windows.Forms.TextBox();
            this.label_nbMatchedProducts = new System.Windows.Forms.Label();
            this.button_editRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recipeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // this
            // 
            this.AutoSize = false;
            this.Controls.Add(this.button_editRecipe);
            this.Controls.Add(this.textBox_dishOrigin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_viewRecipe);
            this.Controls.Add(this.textBox_postedOn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_dishType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_authorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_recipeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_rating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_recipeImage);
            this.Controls.Add(this.textBox_nbMatchedProducts);
            this.Controls.Add(this.label_nbMatchedProducts);

            /*
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "panel1";
            */
            this.Size = new System.Drawing.Size(913, 191);
            /*
            this.TabIndex = 0;
            */

            // 
            // button_viewRecipe
            // 
            this.button_viewRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button_viewRecipe.Location = new System.Drawing.Point(12, 138);
            this.button_viewRecipe.Name = "button_viewRecipe";
            this.button_viewRecipe.Size = new System.Drawing.Size(120, 22);
            this.button_viewRecipe.TabIndex = 13;
            this.button_viewRecipe.Text = "View Recipe";
            this.button_viewRecipe.UseVisualStyleBackColor = true;
            this.button_viewRecipe.Click += new System.EventHandler(this.button_viewRecipe_Click);
            // 
            // textBox_postedOn
            // 
            this.textBox_postedOn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_postedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_postedOn.Location = new System.Drawing.Point(523, 15);
            this.textBox_postedOn.Name = "textBox_postedOn";
            this.textBox_postedOn.ReadOnly = true;
            this.textBox_postedOn.Size = new System.Drawing.Size(161, 19);
            this.textBox_postedOn.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(411, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Posted on:";
            // 
            // textBox_description
            // 
            this.textBox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_description.Location = new System.Drawing.Point(279, 125);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.ReadOnly = true;
            this.textBox_description.Size = new System.Drawing.Size(631, 63);
            this.textBox_description.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(138, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description:";
            // 
            // textBox_dishType
            // 
            this.textBox_dishType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_dishType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_dishType.Location = new System.Drawing.Point(279, 78);
            this.textBox_dishType.Name = "textBox_dishType";
            this.textBox_dishType.ReadOnly = true;
            this.textBox_dishType.Size = new System.Drawing.Size(631, 19);
            this.textBox_dishType.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(138, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dish Type:";
            // 
            // textBox_dishOrigin
            // 
            this.textBox_dishOrigin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_dishOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_dishOrigin.Location = new System.Drawing.Point(279, 100);
            this.textBox_dishOrigin.Name = "textBox_dishOrigin";
            this.textBox_dishOrigin.ReadOnly = true;
            this.textBox_dishOrigin.Size = new System.Drawing.Size(631, 19);
            this.textBox_dishOrigin.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(138, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dish Origin:";
            // 
            // textBox_authorName
            // 
            this.textBox_authorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_authorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_authorName.Location = new System.Drawing.Point(279, 56);
            this.textBox_authorName.Name = "textBox_authorName";
            this.textBox_authorName.ReadOnly = true;
            this.textBox_authorName.Size = new System.Drawing.Size(631, 19);
            this.textBox_authorName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(138, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author Name:";
            // 
            // textBox_recipeName
            // 
            this.textBox_recipeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_recipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_recipeName.Location = new System.Drawing.Point(279, 34);
            this.textBox_recipeName.Name = "textBox_recipeName";
            this.textBox_recipeName.ReadOnly = true;
            this.textBox_recipeName.Size = new System.Drawing.Size(631, 19);
            this.textBox_recipeName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(138, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recipe Name:";
            // 
            // textBox_rating
            // 
            this.textBox_rating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_rating.Location = new System.Drawing.Point(279, 12);
            this.textBox_rating.Name = "textBox_rating";
            this.textBox_rating.ReadOnly = true;
            this.textBox_rating.Size = new System.Drawing.Size(126, 19);
            this.textBox_rating.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(138, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rating:";
            // 
            // pictureBox_recipeImage
            // 
            this.pictureBox_recipeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_recipeImage.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_recipeImage.Name = "pictureBox_recipeImage";
            this.pictureBox_recipeImage.Size = new System.Drawing.Size(120, 120);
            this.pictureBox_recipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_recipeImage.TabIndex = 0;
            this.pictureBox_recipeImage.TabStop = false;
            // 
            // textBox_nbMatchedProducts
            // 
            this.textBox_nbMatchedProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_nbMatchedProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_nbMatchedProducts.Location = new System.Drawing.Point(785, 15);
            this.textBox_nbMatchedProducts.Name = "textBox_nbMatchedProducts";
            this.textBox_nbMatchedProducts.ReadOnly = true;
            this.textBox_nbMatchedProducts.Size = new System.Drawing.Size(59, 19);
            this.textBox_nbMatchedProducts.TabIndex = 17;
            // 
            // label_nbMatchedProducts
            // 
            this.label_nbMatchedProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label_nbMatchedProducts.Location = new System.Drawing.Point(690, 6);
            this.label_nbMatchedProducts.Name = "label_nbMatchedProducts";
            this.label_nbMatchedProducts.Size = new System.Drawing.Size(89, 28);
            this.label_nbMatchedProducts.TabIndex = 16;
            this.label_nbMatchedProducts.Text = "# of matched products:";
            // 
            // button_editRecipe
            // 
            this.button_editRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button_editRecipe.Location = new System.Drawing.Point(12, 166);
            this.button_editRecipe.Name = "button_editRecipe";
            this.button_editRecipe.Size = new System.Drawing.Size(120, 22);
            this.button_editRecipe.TabIndex = 18;
            this.button_editRecipe.Text = "Edit Recipe";
            this.button_editRecipe.UseVisualStyleBackColor = true;
            this.button_editRecipe.Visible = false;
            this.button_editRecipe.Click += new System.EventHandler(this.button_editRecipe_Click);


            // 
            // also this
            // 
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recipeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public void FillData(bool allowEdit, int recipe_id, string recipe_image, double rating, DateTime postedOn, string recipe_name, string author_name, string dishType, string dishOrigin, string description, int? nbMatchedProducts = null)
        {

            this.recipe_id = recipe_id;

            this.button_editRecipe.Visible = allowEdit;
            this.pictureBox_recipeImage.ImageLocation = recipe_image;
            this.textBox_rating.Text = rating == 0f ? "N/A" : rating.ToString("N");
            this.textBox_postedOn.Text = postedOn.ToLocalTime().ToString();
            this.textBox_recipeName.Text = recipe_name;
            this.textBox_authorName.Text = author_name;
            this.textBox_dishType.Text = dishType;
            this.textBox_dishOrigin.Text = dishOrigin;
            this.textBox_description.Text = description;
            if (nbMatchedProducts == null)
            {
                this.label_nbMatchedProducts.Visible = false;
                this.textBox_nbMatchedProducts.Visible = false;
            }
            else
            {
                this.label_nbMatchedProducts.Visible = true;
                this.textBox_nbMatchedProducts.Visible = true;
                this.textBox_nbMatchedProducts.Text = nbMatchedProducts.ToString();
            }
        }

        private void button_viewRecipe_Click(object sender, EventArgs e)
        {
            // todo
            /*
            this.FindForm().Visible = false;
            using(a new form to show the recipe)

            */
            ViewFullRecipe(this);
        }

        private void button_editRecipe_Click(object sender, EventArgs e)
        {
            // todo
            /*
            this.FindForm().Visible = false;
            using(a new form to show the recipe)

            */
            EditRecipe(this);
        }

        public delegate void _ViewFullRecipe(RecipeViewBrief sender);
        public _ViewFullRecipe ViewFullRecipe;

        public delegate void _EditRecipe(RecipeViewBrief sender);
        public _EditRecipe EditRecipe;
    }
}
