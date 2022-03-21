using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLProjectForms1
{
    public partial class Form_AddRecipe : Form
    {

        private int? userID;
        private int? recipe_id;
        private AddRecipeOptions option;
        private DataSet ds;

        public enum AddRecipeOptions
        {
            AddNewRecipe = 0, EditRecipe =1
        };

        public Form_AddRecipe(AddRecipeOptions option, int? userID = null, int? recipe_id = null)
        {
            this.userID = userID;
            this.recipe_id = recipe_id;
            this.option = option;
            InitializeComponent();

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                DataTable dt = new DataTable();
                adapter.SelectCommand = new SqlCommand("select * from food_type order by name asc", Form_Home.connection);
                adapter.Fill(dt);
                comboBox_dishType.DataSource = dt;
                comboBox_dishType.ValueMember = "food_type_id";
                comboBox_dishType.DisplayMember = "name";
                adapter.SelectCommand = new SqlCommand("select * from food_origin order by name asc", Form_Home.connection);
                dt = new DataTable();
                adapter.Fill(dt);
                comboBox_dishOrigin.DataSource = dt;
                comboBox_dishOrigin.ValueMember = "food_origin_id";
                comboBox_dishOrigin.DisplayMember = "name";
                adapter.SelectCommand = new SqlCommand("select * from categories order by category_name asc", Form_Home.connection);
                dt = new DataTable();
                adapter.Fill(dt);
                comboBox_category.DisplayMember = "category_name";
                comboBox_category.ValueMember = "category_id";
                comboBox_category.DataSource = dt;
                adapter.SelectCommand = new SqlCommand("select * from quantities order by quantity_name asc", Form_Home.connection);
                dt = new DataTable();
                adapter.Fill(dt);
                comboBox_quantity.DisplayMember = "quantity_name";
                comboBox_quantity.ValueMember = "quantity_id";
                comboBox_quantity.DataSource = dt;
                foreach (DataColumn item in ((DataTable)(comboBox_productName.DataSource)).Columns)
                {
                    dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);

                }
                foreach (DataColumn item in ((DataTable)(comboBox_quantity.DataSource)).Columns)
                {
                    dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                }
                dataGridView1.Columns.Add("product_amount", "product_amount");
                dataGridView1.Columns.Add("product_comment", "product_comment");
                dataGridView1.Columns["product_id"].Visible = false;
                dataGridView1.Columns["product_description"].Visible = false;
                dataGridView1.Columns["subcategory_id"].Visible = false;
                dataGridView1.Columns["is_generic"].Visible = false;
                dataGridView1.Columns["quantity_id"].Visible = false;
                dataGridView1.Columns["quantity_abbreviation"].Visible = false;
            
            }
            if (option == AddRecipeOptions.EditRecipe)
            {
                this.Text = "Edit recipe";
                button_createRecipe.Text = "Save";
                GetData();
                FillData();
            }
            else
            {
                this.Text = "Add recipe";
            }
        }

        private void GetData()
        {
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    ds = new DataSet();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Form_Home.connection;
                    SqlParameter param = new SqlParameter("@recipe_id", SqlDbType.Int);
                    param.Value = this.recipe_id;
                    cmd.Parameters.Add(param);
                    cmd.CommandText = @"exec GetRecipeInfo_editRecipe @recipe_id";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds, "recipeInfo");
                    cmd.CommandText = @"exec GetRecipeIngredients_editRecipe @recipe_id";
                    adapter.Fill(ds, "recipeIngredients");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void FillData()
        {
            textBox_recipeName.Text = (string)ds.Tables["recipeInfo"].Rows[0]["recipe_name"];
            textBox_description.Text = (string)ds.Tables["recipeInfo"].Rows[0]["recipe_description"];
            textBox_instructions.Text = (string)ds.Tables["recipeInfo"].Rows[0]["instructions"];

            if (ds.Tables["recipeInfo"].Rows[0]["food_type_id"] != DBNull.Value)
            {
                comboBox_dishType.SelectedValue = ds.Tables["recipeInfo"].Rows[0]["food_type_id"];
                checkBox_dishType.Checked = true;
            }
            if (ds.Tables["recipeInfo"].Rows[0]["food_origin_id"] != DBNull.Value)
            {
                comboBox_dishOrigin.SelectedValue = ds.Tables["recipeInfo"].Rows[0]["food_origin_id"];
                checkBox_dishOrigin.Checked = true;
            }
            if (ds.Tables["recipeInfo"].Rows[0]["prep_time"] != DBNull.Value)
            {
                numericUpDown_time.Value = (int)ds.Tables["recipeInfo"].Rows[0]["prep_time"];
                checkBox_time.Checked = true;
            }
            if (ds.Tables["recipeInfo"].Rows[0]["serves"] != DBNull.Value)
            {
                numericUpDown_serves.Value = (int)ds.Tables["recipeInfo"].Rows[0]["serves"];
                checkBox_serves.Checked = true;
            }
            if (ds.Tables["recipeInfo"].Rows[0]["difficulty"] != DBNull.Value)
            {
                numericUpDown_difficulty.Value = (int)ds.Tables["recipeInfo"].Rows[0]["difficulty"];
                checkBox_difficulty.Checked = true;
            }
            if (ds.Tables["recipeInfo"].Rows[0]["calories"] != DBNull.Value)
            {
                numericUpDown_calories.Value = (int)((double)ds.Tables["recipeInfo"].Rows[0]["calories"]);
                checkBox_calories.Checked = true;
            }

            foreach (DataRow item in ds.Tables["recipeIngredients"].Rows)
            {
                var n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["product_id"].Value = item["product_id"];
                dataGridView1.Rows[n].Cells["product_name"].Value = item["product_name"];
                dataGridView1.Rows[n].Cells["product_amount"].Value = item["product_amount"];
                dataGridView1.Rows[n].Cells["quantity_id"].Value = item["quantity_id"];
                dataGridView1.Rows[n].Cells["quantity_name"].Value = item["quantity_name"];
                dataGridView1.Rows[n].Cells["product_comment"].Value = item["product_comment"];
            }

            string picPath = Form_Home.GetPicPath((int)recipe_id, Form_Home.PicFolders.Recipes);
            if (picPath != null)
            {
                pictureBox_recipeImage.ImageLocation = picPath;
                button_recipeImage.Text = "Remove Image";
            }
            this.PerformLayout();
            //MessageBox.Show(dataGridView_ingredients.NewRowIndex.ToString());
            //dataGridView_ingredients.Rows[dataGridView_ingredients.NewRowIndex].Visible = false;
        }



        private void button_recipeImage_Click(object sender, EventArgs e)
        {
            if (button_recipeImage.Text == "Remove Image")
            {
                pictureBox_recipeImage.ImageLocation = null;
                button_recipeImage.Text = "Choose Image (optional)";
                return;
            }
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Title = "Open Image";
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                //openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_recipeImage.ImageLocation = openFileDialog1.FileName;
                    button_recipeImage.Text = "Remove Logo";
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Form_Home.connection;
                cmd.Parameters.Add(new SqlParameter("@param1", (int)comboBox_subcategory.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@param2", comboBox_productName.Text.Trim()));
                cmd.CommandText = "select top 20 * from products where subcategory_id = @param1 and product_name like @param2 + '%' order by product_name asc;";
                DataTable tb = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(tb);
                comboBox_productName.DisplayMember = "product_name";
                comboBox_productName.ValueMember = "product_id";
                comboBox_productName.DataSource = tb;
            }
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Form_Home.connection;
                cmd.Parameters.Add(new SqlParameter("@param1", comboBox_category.SelectedValue));
                cmd.CommandText = "select * from subcategories where category_id = @param1 order by subcategory_name asc;";
                DataTable tb = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(tb);
                comboBox_subcategory.DisplayMember = "subcategory_name";
                comboBox_subcategory.ValueMember = "subcategory_id";
                comboBox_subcategory.DataSource = tb;
            }
        }

        private void comboBox_subcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_productName.Text = "";
            timer1_Tick(null, null);
        }

        private void comboBox_productName_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.ImageLocation = Form_Home.GetPicPath((int)comboBox_productName.SelectedValue, Form_Home.PicFolders.Products);
            textBox_productDescription.Text = (string)((DataTable)comboBox_productName.DataSource).Rows[comboBox_productName.SelectedIndex]["product_description"];
        }

        private void comboBox_productName_Validating(object sender, CancelEventArgs e)
        {
            foreach (DataRowView item in comboBox_productName.Items)
            {
                if (item["product_name"].ToString() == comboBox_productName.Text) return;
            }
            e.Cancel = true;
            MessageBox.Show("Please select an item from the list.");
            comboBox_subcategory_SelectedIndexChanged(null, null);
        }

        private void comboBox_productName_TextChanged(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }
        }

        private void button_addProduct_Click(object sender, EventArgs e)
        {
            DataRow drow = ((DataRowView)comboBox_productName.SelectedItem).Row;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.IsNewRow) continue;
                if ((int)item.Cells["product_id"].Value == (int)drow["product_id"])
                {
                    MessageBox.Show("This product is already listed.");
                    return;
                }
            }
            var n = dataGridView1.Rows.Add();

            //DataGridViewRow ro = (DataGridViewRow)dataGridView1.Rows[n].Clone();
            foreach (DataColumn item in ((DataTable)(comboBox_productName.DataSource)).Columns)
            {
                dataGridView1.Rows[n].Cells[item.ColumnName].Value = drow[item.ColumnName];
            }
            drow = ((DataRowView)comboBox_quantity.SelectedItem).Row;
            if (checkBox_amount.Checked) 
            foreach (DataColumn item in ((DataTable)(comboBox_quantity.DataSource)).Columns)
            {
                dataGridView1.Rows[n].Cells[item.ColumnName].Value = drow[item.ColumnName];
            }
            if (checkBox_amount.Checked) dataGridView1.Rows[n].Cells["product_amount"].Value = numericUpDown_amount.Value;
            if(checkBox_comment.Checked) dataGridView1.Rows[n].Cells["product_comment"].Value = textBox_comment.Text;
            //dataGridView1.Rows.Add(ro);
        }

        private void removeFromListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView x = (DataGridView)contextMenuStrip1.SourceControl;
            foreach (DataGridViewRow item in x.SelectedRows)
            {
                x.Rows.Remove(item);
            }
            foreach (DataGridViewCell item in x.SelectedCells)
            {
                x.Rows.Remove(item.OwningRow);
            }
        }

        private void checkBox_time_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_time.Enabled = checkBox_time.Checked;
        }

        private void checkBox_serves_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_serves.Enabled = checkBox_serves.Checked;
        }

        private void checkBox_calories_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_calories.Enabled = checkBox_calories.Checked;
        }

        private void checkBox_difficulty_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_difficulty.Enabled = checkBox_difficulty.Checked;
        }

        private void checkBox_dishType_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_dishType.Enabled = checkBox_dishType.Checked;
        }

        private void checkBox_dishOrigin_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_dishOrigin.Enabled = checkBox_dishOrigin.Checked;
        }

        private void checkBox_amount_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_amount.Enabled = checkBox_amount.Checked;
            comboBox_quantity.Enabled = checkBox_amount.Checked;
        }

        private void checkBox_comment_CheckedChanged(object sender, EventArgs e)
        {
            textBox_comment.Enabled = checkBox_comment.Checked;
        }

        private void button_createRecipe_Click(object sender, EventArgs e)
        {
            // todo : if edit recipe....
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Form_Home.connection;
                cmd.CommandText = 
    @"exec " + (option == AddRecipeOptions.AddNewRecipe ? "AddRecipe " : "EditRecipe ") 
    + @"@recipe_id output,
    @recipe_name, "
    + (option == AddRecipeOptions.AddNewRecipe ? "@userID, " : "@recipe_id_in, ")
    + @"@recipe_description,
    @instructions,

    @food_origin_id,
    @food_type_id,
    @prep_time,
    @serves,
    @difficulty,
    @calories,
    @recipeProductsList
";
                SqlParameter[] param = new SqlParameter[12];
                param[11] = new SqlParameter("@recipe_id", SqlDbType.Int);
                param[11].Direction = ParameterDirection.Output;
                param[0] = new SqlParameter("@recipe_name", SqlDbType.VarChar, 50);
                param[0].Value = textBox_recipeName.Text.Trim();
                if (option == AddRecipeOptions.AddNewRecipe)
                {
                    param[1] = new SqlParameter("@userID", SqlDbType.Int);
                    param[1].Value = this.userID;
                }
                else
                {
                    param[1] = new SqlParameter("@recipe_id_in", SqlDbType.Int);
                    param[1].Value = this.recipe_id;
                }
                param[2] = new SqlParameter("@recipe_description", SqlDbType.VarChar, 100);
                param[2].Value = textBox_description.Text.Trim();
                param[3] = new SqlParameter("@instructions", SqlDbType.Text);
                param[3].Value = textBox_instructions.Text.Trim();
                param[4] = new SqlParameter("@food_origin_id", SqlDbType.Int);
                param[4].Value = checkBox_dishOrigin.Checked ? comboBox_dishOrigin.SelectedValue : DBNull.Value;
                param[5] = new SqlParameter("@food_type_id", SqlDbType.Int);
                param[5].Value = checkBox_dishType.Checked ? comboBox_dishType.SelectedValue : DBNull.Value;
                param[6] = new SqlParameter("@prep_time", SqlDbType.Int);
                param[6].Value = checkBox_time.Checked ? (object)numericUpDown_time.Value : DBNull.Value;
                param[7] = new SqlParameter("@serves", SqlDbType.Int);
                param[7].Value = checkBox_serves.Checked ? (object)numericUpDown_serves.Value : DBNull.Value;
                param[8] = new SqlParameter("@difficulty", SqlDbType.Int);
                param[8].Value = checkBox_difficulty.Checked ? (object)numericUpDown_difficulty.Value : DBNull.Value;
                param[9] = new SqlParameter("@calories", SqlDbType.Float);
                param[9].Value = checkBox_calories.Checked ? (object)numericUpDown_calories.Value : DBNull.Value;
                param[10] = new SqlParameter("@recipeProductsList", SqlDbType.Structured);

                DataTable dt = new DataTable("RecipeProductsList");
                dt.Columns.Add("product_id");
                dt.Columns.Add("product_amount");
                dt.Columns.Add("product_quantity");
                dt.Columns.Add("product_comment");

                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    dt.Rows.Add(item.Cells["product_id"].Value, item.Cells["product_amount"].Value, item.Cells["quantity_id"].Value, item.Cells["product_comment"].Value);
                }

                param[10].Value = dt;
                param[10].TypeName = "RecipeProductsList";

                cmd.Parameters.AddRange(param);
                int n = cmd.ExecuteNonQuery();
                //MessageBox.Show(n.ToString() + "\n" + param[11].Value.ToString());
                if (n > 0)
                {
                    MessageBox.Show("Recipe created successfully.");
                    if (pictureBox_recipeImage.ImageLocation != null)
                    {
                        string newpath = Form_Home.CreatePicPath((int)param[11].Value, Form_Home.PicFolders.Recipes, pictureBox_recipeImage.ImageLocation);
                        System.IO.File.Copy(pictureBox_recipeImage.ImageLocation, newpath, true);
                    }
                    else
                    {
                        string olPath = Form_Home.GetPicPath((int)param[11].Value, Form_Home.PicFolders.Recipes);
                        if (olPath != null)
                        {
                            System.IO.File.Delete(olPath);
                        }
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operation failed. Please try again later and check the fields.");
                }

            }
        }
    }
}
