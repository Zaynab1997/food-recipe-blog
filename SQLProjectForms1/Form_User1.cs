using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLProjectForms1
{
    public partial class Form_User1 : Form
    {
        private bool isProfilePanShowed = false;
        private string userName;
        private int userID;


        public Form_User1(int userID, string userName)
        {
            this.userID = userID;
            this.userName = userName;
            InitializeComponent();
            this.Text = "Logged in : \"" + userName + "\"";
            this.pictureBox1.ImageLocation = Form_Home.GetPicPath(userID, Form_Home.PicFolders.Users);
            label_username.Text = "UserName: " + userName;
        }

        private void Form_User1_Load(object sender, EventArgs e)
        {
            FormRatingsProductsFollow main_caller = new FormRatingsProductsFollow();
            main_caller.main_caller = userID;
            main_caller.main_caller_string = userName;
        }


        private void openRecipeBriefView(Form_Home.RecipesBriefViewOptions options)
        {
            using (Form_RecipesBriefView f = new Form_RecipesBriefView(options))
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
        private void button_myRecipes_Click(object sender, EventArgs e)
        {
            openRecipeBriefView(new Form_Home.RecipesBriefViewOptions(Form_Home.RecipesBriefViewOptions.Options.MyRecipes, userName: this.userName, userID: this.userID));
        }
        private void button_searchRecipes_Click(object sender, EventArgs e)
        {
            using (Form_SearchRecipe f = new Form_SearchRecipe(Form_Home.RecipesBriefViewOptions.Options.SearchRecipes))
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
        private void button_timeline_Click(object sender, EventArgs e)
        {
            openRecipeBriefView(new Form_Home.RecipesBriefViewOptions(Form_Home.RecipesBriefViewOptions.Options.TimeLine, userName: this.userName, userID: this.userID));
        }
        private void button_ratedRecipes_Click(object sender, EventArgs e)
        {
            openRecipeBriefView(new Form_Home.RecipesBriefViewOptions(Form_Home.RecipesBriefViewOptions.Options.RatedRecipes, userName: this.userName, userID: this.userID));
        }
        private void button_savedRecipes_Click(object sender, EventArgs e)
        {
            openRecipeBriefView(new Form_Home.RecipesBriefViewOptions(Form_Home.RecipesBriefViewOptions.Options.SavedRecipes, userName: this.userName, userID: this.userID));
        }


        private void button_addRecipe_Click(object sender, EventArgs e)
        {
            // todo
            using (Form_AddRecipe f = new Form_AddRecipe(option: Form_AddRecipe.AddRecipeOptions.AddNewRecipe, userID: this.userID))
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }


        private void label_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            ((Label)sender).ForeColor = Color.Blue;
        }
        private void label_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            ((Label)sender).ForeColor = Color.Black;
        }


        private void button_profile_Click(object sender, EventArgs e)
        {
            if (isProfilePanShowed)
            {
                this.Width -= 171;
            }
            else
            {
                this.Width += 171;
            }
            isProfilePanShowed = !isProfilePanShowed;
        }





        private void label_profile_Click(object sender, EventArgs e)
        {
            FormUserProfile pro = new FormUserProfile();
            pro.editing = true;
            pro.is_company = false;
            pro.userID = userID;
            pro.userName = userName;
            this.Hide();
            pro.ShowDialog();
            userName = pro.userName;
            this.Refresh();
            label_username.Text = "UserName: " + userName;
            this.Show();
        }


        private void label_log_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_followers_Click(object sender, EventArgs e)
        {
            FormRatingsProductsFollow products = new FormRatingsProductsFollow();
            products.type = FormRatingsProductsFollow.View_Type.Followers;
            products.id_given = userID;
            products.is_company = false;
            products.main_caller = userID;
            //editing of viewing it is the same because the user is given at start
            this.Hide();
            products.ShowDialog();
            this.Show();
        }

        private void label_ratings_Click(object sender, EventArgs e)
        {
            FormRatingsProductsFollow ratings = new FormRatingsProductsFollow();
            ratings.type = FormRatingsProductsFollow.View_Type.Rating;
            ratings.id_given = userID;
            ratings.is_company = false;
            // editing of viewing it is the same because the user is given at start
            this.Hide();
            ratings.ShowDialog();
            this.Show();
        }

        private void label_followed_Click(object sender, EventArgs e)
        {
            FormRatingsProductsFollow followed = new FormRatingsProductsFollow();
            followed.type = FormRatingsProductsFollow.View_Type.Followed;
            followed.id_given = userID;
            followed.is_company = false;
            followed.main_caller = userID;
            // editing of viewing it is the same because the user is given at start
            this.Hide();
            followed.ShowDialog();
            this.Show();
        }


    }
}
