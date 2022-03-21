using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLProjectForms1
{
    public partial class Form_RecipesBriefView : Form
    {

        public string userName;
        public int? userID = null;

        private int pageNb;
        private int n = 10; // nb of recipes per page
        private DataSet brief_timeline_dataset;
        private RecipeViewBrief[] timeline_array;
        private Form_Home.RecipesBriefViewOptions options;
        private Form_Home.RecipesBriefViewOptions.Options opt;

        // todo : for adding "back" feature...
        public Form_RecipesBriefView(Form_Home.RecipesBriefViewOptions options)
        {
            this.options = options;
            if (options.opt != Form_Home.RecipesBriefViewOptions.Options.SearchRecipes)
            {
            this.userID = options.userID;
            }
            this.userName = options.userName;
            this.pageNb = options.pageNb;
            this.opt = options.opt;
            InitializeComponent();
            switch (opt)
            {
                case Form_Home.RecipesBriefViewOptions.Options.TimeLine:
                    this.Text = "Timeline of \"" + this.userName + "\"";
                    break;
                case Form_Home.RecipesBriefViewOptions.Options.MyRecipes:
                    this.Text = "Recipes of \"" + this.userName + "\"";
                    break;
                case Form_Home.RecipesBriefViewOptions.Options.SearchRecipes:
                    this.Text = "Search results";
                    break;
                case Form_Home.RecipesBriefViewOptions.Options.RatedRecipes:
                    this.Text = "Rated recipes of \"" + this.userName + "\"";
                    break;
                case Form_Home.RecipesBriefViewOptions.Options.SavedRecipes:
                    this.Text = "Saved recipes of \"" + this.userName + "\"";
                    break;
                default:
                    break;
            }
        }

        private void Form_MyRecipes_Load(object sender, EventArgs e)
        {
            timeline_array = new RecipeViewBrief[n];
            for (int i = 0; i < n; i++)
            {
                timeline_array[i] = new RecipeViewBrief();
                timeline_array[i].Visible = false;
                timeline_array[i].ViewFullRecipe = this.ViewFullRecipe;
                timeline_array[i].EditRecipe = this.EditRecipe;
                flowLayoutPanel1.Controls.Add(timeline_array[i]);
            }
            updatePage();
        }

        private void getData()
        {
            brief_timeline_dataset = new DataSet();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Form_Home.connection;

                cmd.CommandText = @"exec FilterSearch 
    @viewType,
	@starting_row,
	@ending_row,
	@userID,
	@recipeName,
	@dishTypeID,
	@dishOriginID,
	@prepTime_min,
	@prepTime_max,
	@serves_min,
	@serves_max,
	@calories_min,
	@calories_max,
	@difficulty_min,
	@difficulty_max,
	@rating_min,
	@rating_max,
	@nbRatings_min,
	@nbRatings_max,
	@orderBy,
	@order,
	@productID_1,
	@productID_2,
	@productID_3,
	@productID_4,
	@productID_5,
	@productID_6
";
                SqlParameter[] param = new SqlParameter[27];
                param[26] = new SqlParameter("@viewType", SqlDbType.Int);
                param[26].Value = options.opt == Form_Home.RecipesBriefViewOptions.Options.SearchRecipes ? 0 : (int)options.opt;
                param[0] = new SqlParameter("@starting_row", SqlDbType.Int);
                param[0].Value = pageNb * n + 1;
                param[1] = new SqlParameter("@ending_row", SqlDbType.Int);
                param[1].Value = (pageNb + 1) * n;
                param[2] = new SqlParameter("@userID", SqlDbType.Int);
                param[2].Value = (object)options.userID ?? DBNull.Value;
                param[3] = new SqlParameter("@recipeName", SqlDbType.VarChar, 50);
                param[3].Value = (object)options.recipeName ?? DBNull.Value;
                param[4] = new SqlParameter("@dishTypeID", SqlDbType.Int);
                param[4].Value = (object)options.dishTypeID ?? DBNull.Value;
                param[5] = new SqlParameter("@dishOriginID", SqlDbType.Int);
                param[5].Value = (object)options.dishOriginID ?? DBNull.Value;
                param[6] = new SqlParameter("@prepTime_min", SqlDbType.Int);
                param[6].Value = (object)options.prepTime_min ?? DBNull.Value;
                param[7] = new SqlParameter("@prepTime_max", SqlDbType.Int);
                param[7].Value = (object)options.prepTime_max ?? DBNull.Value;
                param[8] = new SqlParameter("@serves_min", SqlDbType.Int);
                param[8].Value = (object)options.serves_min ?? DBNull.Value;
                param[9] = new SqlParameter("@serves_max", SqlDbType.Int);
                param[9].Value = (object)options.serves_max ?? DBNull.Value;
                param[10] = new SqlParameter("@calories_min", SqlDbType.Int);
                param[10].Value = (object)options.calories_min ?? DBNull.Value;
                param[11] = new SqlParameter("@calories_max", SqlDbType.Int);
                param[11].Value = (object)options.calories_max ?? DBNull.Value;
                param[12] = new SqlParameter("@difficulty_min", SqlDbType.Int);
                param[12].Value = (object)options.difficulty_min ?? DBNull.Value;
                param[13] = new SqlParameter("@difficulty_max", SqlDbType.Int);
                param[13].Value = (object)options.difficulty_max ?? DBNull.Value;
                param[14] = new SqlParameter("@rating_min", SqlDbType.Int);
                param[14].Value = (object)options.rating_min ?? DBNull.Value;
                param[15] = new SqlParameter("@rating_max", SqlDbType.Int);
                param[15].Value = (object)options.rating_max ?? DBNull.Value;
                param[16] = new SqlParameter("@nbRatings_min", SqlDbType.Int);
                param[16].Value = (object)options.nbRatings_min ?? DBNull.Value;
                param[17] = new SqlParameter("@nbRatings_max", SqlDbType.Int);
                param[17].Value = (object)options.nbRatings_max ?? DBNull.Value;
                param[18] = new SqlParameter("@orderBy", SqlDbType.Int);
                param[18].Value = (object)options.orderBy;
                param[19] = new SqlParameter("@order", SqlDbType.Int);
                param[19].Value = (object)options.order;
                param[20] = new SqlParameter("@productID_1", SqlDbType.Int);
                param[20].Value = (object)options.productID_1 ?? DBNull.Value;
                param[21] = new SqlParameter("@productID_2", SqlDbType.Int);
                param[21].Value = (object)options.productID_2 ?? DBNull.Value;
                param[22] = new SqlParameter("@productID_3", SqlDbType.Int);
                param[22].Value = (object)options.productID_3 ?? DBNull.Value;
                param[23] = new SqlParameter("@productID_4", SqlDbType.Int);
                param[23].Value = (object)options.productID_4 ?? DBNull.Value;
                param[24] = new SqlParameter("@productID_5", SqlDbType.Int);
                param[24].Value = (object)options.productID_5 ?? DBNull.Value;
                param[25] = new SqlParameter("@productID_6", SqlDbType.Int);
                param[25].Value = (object)options.productID_6 ?? DBNull.Value;

                cmd.Parameters.AddRange(param);
                adapter.SelectCommand = cmd;
                adapter.Fill(brief_timeline_dataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillData()
        {
            DataRow row;
            for (int i = 0; i < n; i++)
            {
                if (i < brief_timeline_dataset.Tables[0].Rows.Count)
                {
                    row = brief_timeline_dataset.Tables[0].Rows[i];
                    timeline_array[i].Visible = true;
                    timeline_array[i].FillData((int)row["userID"] == this.userID, (int)row["recipe_id"], Form_Home.GetPicPath((int)row["recipe_id"], Form_Home.PicFolders.Recipes), row["average_rating"] == DBNull.Value ? 0f : (double)row["average_rating"], (DateTime)row["post_time"], (string)row["recipe_name"], (string)row["userName"], row["dishType"] == DBNull.Value ? "N/A" : (string)row["dishType"], row["dishOrigin"] == DBNull.Value ? "N/A" : (string)row["dishOrigin"], (string)row["recipe_description"], row.Table.Columns.Contains("nbMatchedProducts") ? (int?)row["nbMatchedProducts"] : null);
                }
                else
                {
                    timeline_array[i].Visible = false;
                }
            }
            //this.PerformLayout();
        }

        private void updatePage()
        {
            // todo
            flowLayoutPanel1.AutoScrollPosition = new Point(0, 0);
            button_previousPage.Enabled = pageNb != 0;
            label_pageNb.Text = "Page: " + (pageNb + 1).ToString();
            numericUpDown_pageNb.Value = pageNb + 1;
            getData();
            fillData();
            button_nextPage.Enabled = brief_timeline_dataset.Tables[0].Rows.Count == n;
        }

        private void ViewFullRecipe(RecipeViewBrief sender)
        {
            Form_RecipeViewFull f = new Form_RecipeViewFull(sender.recipe_id, Form_Home.userID);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void EditRecipe(RecipeViewBrief sender)
        {
            Form_AddRecipe f = new Form_AddRecipe(Form_AddRecipe.AddRecipeOptions.EditRecipe, recipe_id: sender.recipe_id);
            this.Hide();
            f.ShowDialog();
            updatePage();
            this.Show();
        }

        private void button_previousPage_Click(object sender, EventArgs e)
        {
            pageNb--;
            options.pageNb = pageNb;
            updatePage();
        }

        private void button_nextPage_Click(object sender, EventArgs e)
        {
            pageNb++;
            options.pageNb = pageNb;
            updatePage();
        }

        private void button_goToPage_Click(object sender, EventArgs e)
        {
            pageNb = (int)numericUpDown_pageNb.Value - 1;
            options.pageNb = pageNb;
            updatePage();

            /*
            int _pageNb = (int)numericUpDown_pageNb.Value - 1;

            DataSet _brief_timeline_dataset = new DataSet();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = null;
                cmd = new SqlCommand(@"exec get_my_recipes @userID = @param1, @starting_row = @param2, @ending_row = @param3", Form_Home.connection);
                cmd.Parameters.Add(new SqlParameter("@param1", userID));
                cmd.Parameters.Add(new SqlParameter("@param2", _pageNb * n + 1));
                cmd.Parameters.Add(new SqlParameter("@param3", (_pageNb + 1) * n));
                adapter.SelectCommand = cmd;
                adapter.Fill(_brief_timeline_dataset);
                if (_brief_timeline_dataset.Tables[0].Rows.Count == 0)
                    MessageBox.Show("No Data.");
                else
                {
                    pageNb = _pageNb;
                    updatePage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SearchRecipe f = new Form_SearchRecipe(
                opt: this.options.opt,
                userID: opt != Form_Home.RecipesBriefViewOptions.Options.SearchRecipes ? this.userID : null,
                userName: opt != Form_Home.RecipesBriefViewOptions.Options.SearchRecipes ? this.userName : null
                );
            this.Hide();
            f.Show();
            this.Close();
            this.Dispose();
        }
    }
}
