using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLProjectForms1
{
    public partial class Form_Company1 : Form
    {
        DataSet dataset;
        //string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=SQLProjectTest2;Integrated Security=True";
        string connectionString = Form_Home.connection.ConnectionString;
        private string userName;
        private int userID;
        int counter = 0;
        int width;
        
        public Form_Company1(int userID, string userName)
        {

            this.userID = userID;
            this.userName = userName;

            InitializeComponent();
            this.Text = "Logged in : \"" + this.userName + "\"";
            width = this.Width;
        }

        private void button_MyRecipes_Click(object sender, EventArgs e)
        {
           Form_Home.RecipesBriefViewOptions options = new Form_Home.RecipesBriefViewOptions(Form_Home.RecipesBriefViewOptions.Options.MyRecipes, userID: this.userID, userName: this.userName);
           using (Form_RecipesBriefView f = new Form_RecipesBriefView(options))
            {
                this.Hide();
               f.ShowDialog();
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormAddRecipe add_recipe = new FormAddRecipe();
            //add_recipe.editing = true;
            //add_recipe.userID = userID;
            //this.Hide();
            //add_recipe.ShowDialog();
            ////add_recipe.Show();
            //this.Show();

            using (Form_AddRecipe f = new Form_AddRecipe(option: Form_AddRecipe.AddRecipeOptions.AddNewRecipe, userID: this.userID))
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
            }

        }



        private void Form_Company1_Load(object sender, EventArgs e)
        {
            FormRatingsProductsFollow main_caller = new FormRatingsProductsFollow();
            main_caller.main_caller = userID;
            main_caller.main_caller_string = userName;
            label_username.Text += userName;
            // todo
            /*
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                     dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    //adapter.TableMappings.Add("Table", "Countries");

                    SqlParameter param1 = new SqlParameter("@param1", SqlDbType.VarChar);
                    param1.Value = userName;
                    SqlCommand cmd = new SqlCommand("SELECT companies.logo FROM users INNER JOIN companies ON users.userID=dbo.companies.userID WHERE users.userName=@param1", connection);
                    cmd.Parameters.Add(param1);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dataset);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
            }
            */
        }

        private void button_add_product_Click(object sender, EventArgs e)
        {
            FormAddProduct add_product = new FormAddProduct();
            add_product.user_id = userID;
            add_product.product_id = 2;//sending the true one
            add_product.editing =true;//must be true here
            this.Hide();
            add_product.ShowDialog();
            this.Show();
        }

        private void button_profile_MouseEnter(object sender, EventArgs e)
        {
            counter++;
            if (counter % 2 == 0)
                this.Width -= 171;
            else
            {
                this.Width += 171;
                
            }
        }

     

        private void button_profile_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter % 2 == 0)
                this.Width -= 171;
            else
            {
                this.Width += 171;
              //  profile.Left = width;
                //  profile.pictureBox1.Image = (byte[])dataset.Tables[0].Rows[0]["logo"];

              //  this.Controls.Add(profile);
            }

        }

        private void button_view_products_Click(object sender, EventArgs e)
        {
            FormRatingsProductsFollow products = new FormRatingsProductsFollow();
            products.type = FormRatingsProductsFollow.View_Type.Products;
            products.id_given = userID;
            products.is_company = true;
            // editing of viewing it is the same because the user is given at start
            this.Hide();
            products.ShowDialog();
            this.Show();
        }

        private void label_profile_Click(object sender, EventArgs e)
        {
            FormUserProfile pro = new FormUserProfile();
            pro.editing = true;//must be true
            pro.is_company = true;
            pro.userName = userName;
            pro.userID = userID;
            this.Hide();
            pro.ShowDialog();
            userName = pro.userName;
            this.Refresh();
            label_username.Text = "UserName: " + userName;
            this.Show();
        }

        private void label_profile_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label_profile.ForeColor = Color.Blue;
        }

        private void label_profile_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            label_profile.ForeColor = Color.Black;
        }

        private void label_followed_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label_followers.ForeColor = Color.Blue;
        }

        private void label_followed_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            label_followers.ForeColor = Color.Black;

        }

      
        private void label_log_out_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label_log_out.ForeColor = Color.Blue;
        }
        private void label_log_out_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            label_log_out.ForeColor = Color.Black;
        }

        private void label_log_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_followers_Click(object sender, EventArgs e)
        {
            FormRatingsProductsFollow followers = new FormRatingsProductsFollow();
            followers.is_company = true;
            followers.id_given = userID;
            followers.type = FormRatingsProductsFollow.View_Type.Followers;
            this.Hide();
            followers.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (Form_SearchRecipe f = new Form_SearchRecipe(opt: Form_Home.RecipesBriefViewOptions.Options.SearchRecipes))
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}
