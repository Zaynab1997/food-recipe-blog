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
    public partial class Form_RecipeViewFull : Form
    {
        private int recipe_id;
        private int viewer_id;
        private bool is_company;
        private DataSet ds;
        private bool isRating = false, isEditingRating = false;

        public Form_RecipeViewFull(int recipe_id, int viewer_id)
        {
            this.recipe_id = recipe_id;
            this.viewer_id = viewer_id;

            InitializeComponent();

            pictureBox_recipeImage.ImageLocation = Form_Home.GetPicPath(recipe_id, Form_Home.PicFolders.Recipes);

            GetData();
            FillData();


            if ((int)ds.Tables["recipeInfo"].Rows[0]["userID"] == viewer_id || is_company)
            {
                button_rateRecipe.Visible = false;
                button_saveRecipe.Visible = false;
                // todo : we can make a button for edit visible
            }
            else
            {
                checkSaved();
                checkRated();
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
                    cmd.CommandText = @"exec GetRecipeInfo @recipe_id";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds, "recipeInfo");
                    cmd.CommandText = @"exec GetRecipeIngredients @recipe_id";
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
            textBox_authorName.Text = (string)ds.Tables["recipeInfo"].Rows[0]["userName"];
            textBox_dishType.Text = ds.Tables["recipeInfo"].Rows[0]["dishType"] == DBNull.Value ? "N/A" : (string)ds.Tables["recipeInfo"].Rows[0]["dishType"];
            textBox_dishOrigin.Text = ds.Tables["recipeInfo"].Rows[0]["dishOrigin"] == DBNull.Value ? "N/A" : (string)ds.Tables["recipeInfo"].Rows[0]["dishOrigin"];
            textBox_description.Text = ds.Tables["recipeInfo"].Rows[0]["recipe_description"] == DBNull.Value ? "N/A" : (string)ds.Tables["recipeInfo"].Rows[0]["recipe_description"];
            textBox_prepTime.Text = ds.Tables["recipeInfo"].Rows[0]["prep_time"] == DBNull.Value ? "N/A" : ((int)ds.Tables["recipeInfo"].Rows[0]["prep_time"]).ToString();
            textBox_serves.Text = ds.Tables["recipeInfo"].Rows[0]["serves"] == DBNull.Value ? "N/A" : ((int)ds.Tables["recipeInfo"].Rows[0]["serves"]).ToString();
            textBox_difficulty.Text = ds.Tables["recipeInfo"].Rows[0]["difficulty"] == DBNull.Value ? "N/A" : ((int)ds.Tables["recipeInfo"].Rows[0]["difficulty"]).ToString();
            textBox_calories.Text = ds.Tables["recipeInfo"].Rows[0]["calories"] == DBNull.Value ? "N/A" : ((double)ds.Tables["recipeInfo"].Rows[0]["calories"]).ToString();
            textBox_rating_nbRatings.Text = "rating: " + (ds.Tables["recipeInfo"].Rows[0]["average_rating"] == DBNull.Value ? "N/A" : (((double)ds.Tables["recipeInfo"].Rows[0]["average_rating"]).ToString("F2", System.Globalization.CultureInfo.InvariantCulture) + "/10 , " + (int)ds.Tables["recipeInfo"].Rows[0]["nb_ratings"]));
            textBox_postedOn.Text = ((DateTime)ds.Tables["recipeInfo"].Rows[0]["post_time"]).ToString();
            textBox_instructions.Text = (string)ds.Tables["recipeInfo"].Rows[0]["instructions"];
            is_company = (bool)ds.Tables["recipeInfo"].Rows[0]["is_company"];
            if (is_company)
            {
                textBox_isCompany.Text = "(company)";
            }
            else
            {
                textBox_isCompany.Text = "(consumer)";
            }

            dataGridView_ingredients.DataSource = ds.Tables["recipeIngredients"];
            dataGridView_ingredients.Columns["product_id"].Visible = false;
            this.PerformLayout();
            //MessageBox.Show(dataGridView_ingredients.NewRowIndex.ToString());
            //dataGridView_ingredients.Rows[dataGridView_ingredients.NewRowIndex].Visible = false;
        }

        private void GetProviders(int product_id)
        {
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Form_Home.connection;
                    SqlParameter param = new SqlParameter("@product_id", SqlDbType.Int);
                    param.Value = product_id;
                    cmd.Parameters.Add(param);
                    cmd.CommandText = @"exec GetProviders @product_id";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds, "providers");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void FillProviders()
        {
            dataGridView_providers.DataSource = ds.Tables["providers"];
            dataGridView_providers.Columns["userID"].Visible = false;
        }

        private void dataGridView_ingredients_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_ingredients.SelectedCells.Count == 0) return;
            int product_id = (int)dataGridView_ingredients.Rows[dataGridView_ingredients.SelectedCells[0].RowIndex].Cells["product_id"].Value;
            pictureBox_productImage.ImageLocation = Form_Home.GetPicPath(product_id, Form_Home.PicFolders.Products);
            GetProviders(product_id);
            FillProviders();
        }

        private void dataGridView_ingredients_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_ingredients.SelectedRows.Count == 0) return;
            int product_id = (int)dataGridView_ingredients.SelectedRows[0].Cells["product_id"].Value;
            pictureBox_productImage.ImageLocation = Form_Home.GetPicPath(product_id, Form_Home.PicFolders.Products);
            GetProviders(product_id);
            FillProviders();
        }

        private void button_saveRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Form_Home.connection;
                    SqlParameter param = new SqlParameter("@recipe_id", SqlDbType.Int);
                    param.Value = recipe_id;
                    cmd.Parameters.Add(param);
                    param = new SqlParameter("@userID", SqlDbType.Int);
                    param.Value = viewer_id;
                    cmd.Parameters.Add(param);
                    if (button_saveRecipe.Text == "Save recipe")
                    {
                        cmd.CommandText = @"select count(*) from saved_recipes where userID = @userID and recipe_id = @recipe_id";
                        int n = (int)cmd.ExecuteScalar();
                        if (n > 0) { MessageBox.Show("Recipe already saved."); button_saveRecipe.Text = "Unsave recipe"; }
                        else
                        {
                            cmd.CommandText = @"insert into saved_recipes(userID, recipe_id, save_time) values (@userID, @recipe_id, getdate());";
                            n = cmd.ExecuteNonQuery();
                            if (n == 0) MessageBox.Show("Operation failed. Please try again later.");
                            else { MessageBox.Show("Recipe saved successfully"); button_saveRecipe.Text = "Unsave recipe"; }
                        }
                    }
                    else
                    {
                        cmd.CommandText = @"select count(*) from saved_recipes where userID = @userID and recipe_id = @recipe_id";
                        int n = (int)cmd.ExecuteScalar();
                        if (n < 1) { MessageBox.Show("Recipe already unsaved."); button_saveRecipe.Text = "Save recipe"; }
                        else
                        {
                            cmd.CommandText = @"delete from saved_recipes where userID = @userID and recipe_id = @recipe_id;";
                            n = cmd.ExecuteNonQuery();
                            if (n == 0) MessageBox.Show("Operation failed. Please try again later.");
                            else { MessageBox.Show("Recipe unsaved successfully"); button_saveRecipe.Text = "Save recipe"; }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkRated()
        {
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Form_Home.connection;
                    SqlParameter param = new SqlParameter("@recipe_id", SqlDbType.Int);
                    param.Value = recipe_id;
                    cmd.Parameters.Add(param);
                    param = new SqlParameter("@userID", SqlDbType.Int);
                    param.Value = viewer_id;
                    cmd.Parameters.Add(param);
                    cmd.CommandText = @"select * from ratings where userID = @userID and recipe_id = @recipe_id";

                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
                    if(dt.Rows.Count == 0)
                    {
                        button_rateRecipe.Text = "Rate recipe";
                        numericUpDown1.Visible = false;
                    }
                    else
                    {
                        button_rateRecipe.Text = "Edit rating";
                        numericUpDown1.Enabled = false;
                        numericUpDown1.Visible = true;
                        numericUpDown1.Value = (int)dt.Rows[0]["rating"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkSaved()
        {
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Form_Home.connection;
                    SqlParameter param = new SqlParameter("@recipe_id", SqlDbType.Int);
                    param.Value = recipe_id;
                    cmd.Parameters.Add(param);
                    param = new SqlParameter("@userID", SqlDbType.Int);
                    param.Value = viewer_id;
                    cmd.Parameters.Add(param);
                    cmd.CommandText = @"select * from saved_recipes where userID = @userID and recipe_id = @recipe_id";

                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        button_saveRecipe.Text = "Save recipe";
                    }
                    else
                    {
                        button_saveRecipe.Text = "Unsave recipe";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_authorName_DoubleClick(object sender, EventArgs e)
        {
            // todo
        }

        private void button_rateRecipe_Click(object sender, EventArgs e)
        {
            if (button_rateRecipe.Text == "Edit rating")
            {
                isEditingRating = true;
                numericUpDown1.Enabled = true;
                button_rateRecipe.Text = "Validate";
            }
            else if (button_rateRecipe.Text == "Rate recipe")
            {
                isRating = true;
                numericUpDown1.Enabled = true;
                numericUpDown1.Visible = true;
                button_rateRecipe.Text = "Validate";
            }
            else
            {
                if (isRating)
                {
                    // todo
                    // code to add new rating
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = Form_Home.connection;
                            SqlParameter param = new SqlParameter("@recipe_id", SqlDbType.Int);
                            param.Value = recipe_id;
                            cmd.Parameters.Add(param);
                            param = new SqlParameter("@userID", SqlDbType.Int);
                            param.Value = viewer_id;
                            cmd.Parameters.Add(param);
                            param = new SqlParameter("@rating", SqlDbType.Int);
                            param.Value = (int)numericUpDown1.Value;
                            cmd.Parameters.Add(param);
                            cmd.CommandText = @"insert into ratings(userID, recipe_id, rating, rating_time) values(@userID, @recipe_id, @rating, getdate());";
                            int n = cmd.ExecuteNonQuery();
                            if (n == 0)
                            {
                                MessageBox.Show("Operation failed. Please try again later.");
                            }
                            else
                            {
                                MessageBox.Show("Rating added successfully");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (isEditingRating)
                {
                    // todo
                    // code to edit a rating
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = Form_Home.connection;
                            SqlParameter param = new SqlParameter("@recipe_id", SqlDbType.Int);
                            param.Value = recipe_id;
                            cmd.Parameters.Add(param);
                            param = new SqlParameter("@userID", SqlDbType.Int);
                            param.Value = viewer_id;
                            cmd.Parameters.Add(param);
                            param = new SqlParameter("@rating", SqlDbType.Int);
                            param.Value = (int)numericUpDown1.Value;
                            cmd.Parameters.Add(param);
                            cmd.CommandText = @"update ratings set rating = @rating, rating_time = getdate() where userID = @userID and recipe_id = @recipe_id;";
                            int n = cmd.ExecuteNonQuery();
                            if (n == 0)
                            {
                                MessageBox.Show("Operation failed. Please try again later.");
                            }
                            else
                            {
                                MessageBox.Show("Rating updated successfully");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                // todo : also to delete rate
                isRating = false;
                isEditingRating = false;
                GetData();
                FillData();
                checkRated();
            }
        }

    }
}
