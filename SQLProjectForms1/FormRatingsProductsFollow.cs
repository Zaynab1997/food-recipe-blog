using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace SQLProjectForms1
{
    public partial class FormRatingsProductsFollow : Form
    {
        public enum View_Type { Products, Followers, Followed, Rating, Providers, Recipes };
        public View_Type type;
        public int id_given;
        public bool is_company = false;
        public int main_caller;
        public string main_caller_string;


        //public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"D:\Downloads\DatabASE v3\SQLProjectProjectTest2.mdf" + @";Integrated Security=True;Connect Timeout=30";
        public string connectionString = Form_Home.connection.ConnectionString;
        public FormRatingsProductsFollow()
        {
            InitializeComponent();
        }

        private void FormRatingsProductsFollow_Load(object sender, EventArgs e)
        {
            dataGridView_all.AllowUserToAddRows = false;

            try
            {
                using (SqlConnection connection1 = new SqlConnection(connectionString))
                {
                    DataSet dataset1 = new DataSet();
                    SqlDataAdapter adapter1 = new SqlDataAdapter();


                    switch (type)
                    {
                        case View_Type.Products:
                            label_view.Text += " Products";
                            SqlCommand cmd1 = new SqlCommand("SELECT products.product_id,products.product_name, dbo.products_companies.unit_price, dbo.products_companies.units_instock,dbo.products_companies.quantity_perunit FROM products INNER JOIN dbo.products_companies ON products.product_id=dbo.products_companies.product_id WHERE dbo.products_companies.company_id=" + id_given, connection1);

                            adapter1.SelectCommand = cmd1;
                            adapter1.Fill(dataset1);
                            dataGridView_all.DataSource = dataset1.Tables[0];
                            break;


                        case View_Type.Followers:
                            label_view.Text += " Followers";
                            SqlCommand cmd2 = new SqlCommand("SELECT users.userID,users.userName, users.joining_time, users.email FROM users INNER JOIN dbo.follow ON users.userID=dbo.follow.follower_id WHERE follow.followed_id=" + id_given, connection1);

                            adapter1.SelectCommand = cmd2;
                            adapter1.Fill(dataset1);
                            dataGridView_all.DataSource = dataset1.Tables[0];
                            break;


                        case View_Type.Followed:
                            label_view.Text += " Followed";
                            SqlCommand cmd3 = new SqlCommand("SELECT users.userID,users.userName, users.joining_time, users.email FROM users INNER JOIN dbo.follow ON users.userID=dbo.follow.followed_id WHERE follow.follower_id=" + id_given, connection1);

                            adapter1.SelectCommand = cmd3;
                            adapter1.Fill(dataset1);
                            dataGridView_all.DataSource = dataset1.Tables[0];
                            break;

                        case View_Type.Rating:
                            label_view.Text += " Rating";
                            SqlCommand cmd4 = new SqlCommand("SELECT users.userID,users.userName, ratings.rating,ratings.rating_time FROM users INNER JOIN dbo.ratings ON users.userID=dbo.ratings.userID WHERE ratings.recipe_id=" + id_given, connection1);

                            adapter1.SelectCommand = cmd4;
                            adapter1.Fill(dataset1);
                            dataGridView_all.DataSource = dataset1.Tables[0];
                            break;
                        case View_Type.Providers:
                            label_view.Text += " Providers";
                            SqlCommand cmd5 = new SqlCommand("SELECT users.userID,users.userName, dbo.companies.company_address FROM users INNER JOIN dbo.companies ON users.userID=dbo.companies.userID inner join products_companies on products_companies.company_id=companies.userID WHERE products_companies.product_id=" + id_given, connection1);

                            adapter1.SelectCommand = cmd5;
                            adapter1.Fill(dataset1);
                            dataGridView_all.DataSource = dataset1.Tables[0];
                            break;

                        case View_Type.Recipes:
                            label_view.Text += " Providers";
                            SqlCommand cmd6 = new SqlCommand("SELECT users.userName, dbo.companies.company_address, countries.country_name, dbo.provinces.province_name FROM users INNER JOIN dbo.companies ON users.userID=dbo.companies.userID INNER JOIN cities ON cities.city_id=dbo.companies.city_id INNER JOIN dbo.countries ON dbo.countries.country_id=dbo.provinces.country_id WHERE dbo.companies.userID=" + id_given, connection1);

                            adapter1.SelectCommand = cmd6;
                            adapter1.Fill(dataset1);
                            dataGridView_all.DataSource = dataset1.Tables[0];
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_all_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            switch (type)
            {
                case View_Type.Products:
                    FormAddProduct add_product = new FormAddProduct();
                    add_product.product_id = int.Parse(dataGridView_all.CurrentRow.Cells["product_id"].Value.ToString());
                    add_product.editing = false;
                    add_product.user_id = id_given;
                    this.Hide();
                    add_product.ShowDialog();
                    this.Show();
                    break;


                case View_Type.Followers:
                    FormUserProfile pro = new FormUserProfile();
                    pro.userID = int.Parse(dataGridView_all.CurrentRow.Cells["userID"].Value.ToString());
                    pro.is_company = false;
                    pro.editing = false;

                    pro.ana_follower = main_caller;
                    this.Hide();
                    pro.ShowDialog();
                    this.Show();

                    break;


                case View_Type.Followed:
                    FormUserProfile prof = new FormUserProfile();
                    prof.userID = int.Parse(dataGridView_all.CurrentRow.Cells["userID"].Value.ToString());
                    prof.editing = false;
                    prof.ana_follower = main_caller;
                    prof.userName = dataGridView_all.CurrentRow.Cells["userName"].Value.ToString();
                    using (SqlConnection connection1 = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd1 = new SqlCommand("SELECT companies.userID FROM companies WHERE companies.userID=" + int.Parse(dataGridView_all.CurrentRow.Cells["userID"].Value.ToString()), connection1);
                        DataSet dataset1 = new DataSet();
                        SqlDataAdapter adapter1 = new SqlDataAdapter();
                        adapter1.SelectCommand = cmd1;
                        adapter1.Fill(dataset1);
                        if (dataset1.Tables[0].Rows.Count == 0)
                            prof.is_company = false;

                        else prof.is_company = true;
                    }
                    prof.following = true;
                    this.Hide();
                    prof.ShowDialog();
                    this.Show();
                    break;

                case View_Type.Rating:

                    FormUserProfile profile = new FormUserProfile();
                    profile.userID = int.Parse(dataGridView_all.CurrentRow.Cells["userID"].Value.ToString());
                    profile.editing = false;
                    profile.ana_follower = main_caller;
                    profile.userName = dataGridView_all.CurrentRow.Cells["userName"].Value.ToString();
                    using (SqlConnection connection1 = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd1 = new SqlCommand("SELECT companies.userID FROM companies WHERE companies.userID=" + int.Parse(dataGridView_all.CurrentRow.Cells["userID"].Value.ToString()), connection1);
                        DataSet dataset1 = new DataSet();
                        SqlDataAdapter adapter1 = new SqlDataAdapter();
                        adapter1.SelectCommand = cmd1;
                        adapter1.Fill(dataset1);
                        if (dataset1.Tables[0].Rows.Count == 0)
                            profile.is_company = false;

                        else profile.is_company = true;
                    }
                    profile.following = true;
                    this.Hide();
                    profile.ShowDialog();
                    this.Show();
                    break;

                case View_Type.Providers:
                    if (!is_company)
                    {
                        FormUserProfile profile1 = new FormUserProfile();
                        profile1.userID = int.Parse(dataGridView_all.CurrentRow.Cells["userID"].Value.ToString());
                        profile1.editing = false;
                        profile1.ana_follower = main_caller;
                        profile1.userName = dataGridView_all.CurrentRow.Cells["userName"].Value.ToString();
                        using (SqlConnection connection1 = new SqlConnection(connectionString))
                        {
                            SqlCommand cmd1 = new SqlCommand("SELECT companies.userID FROM companies WHERE companies.userID=" + int.Parse(dataGridView_all.CurrentRow.Cells["userID"].Value.ToString()), connection1);
                            DataSet dataset1 = new DataSet();
                            SqlDataAdapter adapter1 = new SqlDataAdapter();
                            adapter1.SelectCommand = cmd1;
                            adapter1.Fill(dataset1);
                            if (dataset1.Tables[0].Rows.Count == 0)
                                profile1.is_company = false;

                            else profile1.is_company = true;
                        }
                        profile1.following = true;
                        this.Hide();
                        profile1.ShowDialog();
                        this.Show();
                    }
                    break;

                case View_Type.Recipes:
                    dataGridView_all.CurrentRow.Cells["userName"].Value.ToString();
                    break;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection1 = new SqlConnection(connectionString))
                {
                    DataSet dataset1 = new DataSet();
                    SqlDataAdapter adapter1 = new SqlDataAdapter();


                    switch (type)
                    { 
                        case View_Type.Products:
                            if (is_company) { 
                                DialogResult dr = MessageBox.Show("Are you sure?",
                       "Deleting a product", MessageBoxButtons.YesNo);
                                switch (dr)
                                {
                                    case DialogResult.Yes:
                                        SqlCommand cmd0 = new SqlCommand("EXEC dbo.delete_a_product_for_company @id_prod =" + int.Parse(dataGridView_all.CurrentRow.Cells["product_id"].Value.ToString()) + " ,@id_company=" + main_caller, connection1);
                                        DataGridView x = (DataGridView)contextMenuStrip1.SourceControl;
                                        foreach (DataGridViewRow item in x.SelectedRows)
                                        {
                                            x.Rows.Remove(item);

                                        }
                                        foreach (DataGridViewCell item in x.SelectedCells)
                                        {
                                            x.Rows.Remove(item.OwningRow);

                                        }

                                        break;
                                    case DialogResult.No:
                                   

                                        break;
                                }
                            }
                            
                            
                           
                            break;


                        case View_Type.Followers:
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = Form_Home.connection;
                            DialogResult dr1 = MessageBox.Show("Are you sure?",
                      "Deleting Follow", MessageBoxButtons.YesNo);
                            switch (dr1)
                            {
                                case DialogResult.Yes:cmd.CommandText = "DELETE FROM follow WHERE followed_id=" + main_caller;
                                     cmd.ExecuteNonQuery();
                                    DataGridView x1 = (DataGridView)contextMenuStrip1.SourceControl;
                                    foreach (DataGridViewRow item in x1.SelectedRows)
                                    {
                                        x1.Rows.Remove(item);

                                    }
                                    foreach (DataGridViewCell item in x1.SelectedCells)
                                    {
                                        x1.Rows.Remove(item.OwningRow);

                                    }

                                    break;
                                case DialogResult.No:

                                    break;
                            }
                           
                            break;


                        case View_Type.Followed:
                            MessageBox.Show("Cannot delete a followed member");
                            break;

                        case View_Type.Rating:
                            SqlCommand cmd1 = new SqlCommand();
                            cmd1.Connection = Form_Home.connection;
                            DialogResult dr2 = MessageBox.Show("Are you sure?",
                      "Deleting a rating", MessageBoxButtons.YesNo);
                            switch (dr2)
                            {
                                case DialogResult.Yes:
                                    cmd1.CommandText = "DELETE FROM dbo.ratings WHERE userID=" + main_caller;
                                    cmd1.ExecuteNonQuery();
                                    DataGridView x2 = (DataGridView)contextMenuStrip1.SourceControl;
                                    foreach (DataGridViewRow item in x2.SelectedRows)
                                    {
                                        x2.Rows.Remove(item);

                                    }
                                    foreach (DataGridViewCell item in x2.SelectedCells)
                                    {
                                        x2.Rows.Remove(item.OwningRow);

                                    }
                                    break;
                                case DialogResult.No:
                                    
                                    break;
                            }
                           

                            break;
                            
                        case View_Type.Providers:
                            MessageBox.Show("Cannot delete a company");
                            break;

                        case View_Type.Recipes:
                            
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    

