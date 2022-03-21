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


    public partial class FormUserProfile : Form
    {
        public string userName;
        string email;
        string homepage;
        string phone;
       
        int selected_value;
        public int userID;
        public int ana_follower;
        
        public bool following = false;
        public bool editing = false;
        public bool is_company = false;
        public DataSet dataset_recipes;
        public DataSet dataset_products;
        //public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"C:\Users\Asus ROG\Desktop\Database\SQLProjectProjectTest2.mdf" + ";Integrated Security = True; Connect Timeout = 30";
        public string connectionString = Form_Home.connection.ConnectionString;
        SqlCommand cmd;
        public FormUserProfile()
        {
            InitializeComponent();
           
            cmd = new SqlCommand();
        }

        private void button_image_Click(object sender, EventArgs e)
        {
            if (button_image.Text == "Remove Logo")
            {
                pictureBox_profile.ImageLocation = null;
                button_image.Text = "Choose Logo (optional)";
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
                    try
                    {

                        pictureBox_profile.ImageLocation = openFileDialog1.FileName;
                        //pictureBox_logo_signup_c.Image = new Bitmap(openFileDialog1.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                    button_image.Text = "Remove Logo";
                }
            }
        }

        private void FormUserProfile_Load(object sender, EventArgs e)
        {
            if (!is_company)
            {
                //button_saved_rec.Visible = true;
                //button_saved_rec.Visible = true;
                panel_company_details.Visible = false;
                button_view_products.Visible = false;
                label_fav_origin.Visible = true;
                comboBox_fav_origin.Visible = true;
                this.Height = 200;
                try
                {
                    DataSet dataset,dataset1,dataset2;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        dataset = new DataSet();
                        dataset1 = new DataSet();
                        dataset2 = new DataSet();
                        
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlDataAdapter adapter1 = new SqlDataAdapter();
                        SqlDataAdapter adapter2 = new SqlDataAdapter();
                       
                        SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.food_origin ORDER BY name asc;", connection);
                        SqlCommand cmd1 = new SqlCommand("SELECT email,joining_time FROM dbo.users where userID='" + userID + "' ;", connection);
                        SqlCommand cmd2 = new SqlCommand("SELECT * FROM dbo.preferred_food_origins where userID='" + userID + "' ;", connection);
                        
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dataset);


                        adapter1.SelectCommand = cmd1;
                        adapter1.Fill(dataset1);

                        adapter2.SelectCommand = cmd2;
                        adapter2.Fill(dataset2);

                      
                        

                        DataRow row = dataset.Tables[0].NewRow();
                        row["food_origin_id"] = DBNull.Value;
                        row["name"] = "--choose Origin--";
                        dataset.Tables[0].Rows.InsertAt(row, 0);

                        comboBox_fav_origin.DataSource = dataset.Tables[0];
                        comboBox_fav_origin.DisplayMember = "name"; // dataset.Tables[0].Columns[1].ColumnName
                        comboBox_fav_origin.ValueMember = "food_origin_id";
                        if (dataset2.Tables[0].Rows.Count != 0)
                        {
                            comboBox_fav_origin.SelectedValue = (int?)dataset2.Tables[0].Rows[0]["food_origin_id"];
                            selected_value = (int)comboBox_fav_origin.SelectedValue;
                            
                        }
                       email= textBox_email.Text = dataset1.Tables[0].Rows[0]["email"].ToString();
                        textBox_username.Text = this.userName;
                        textBox_joining_time.Text = dataset1.Tables[0].Rows[0]["joining_time"].ToString();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
                }
             
            }
            if(!editing)
            {
                button_saved_rec.Visible = false;
                comboBox_cities.Enabled = false;
                comboBox_countries.Enabled = false;
                comboBox_provinces.Enabled = false;
                button_follow.Visible = true;
                
               // using (SqlConnection connection = new SqlConnection(connectionString))
               // {
                    DataSet dataset3;
                    dataset3 = new DataSet();
                    SqlDataAdapter adapter3 = new SqlDataAdapter();
                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = Form_Home.connection;
                cmd3.CommandText = "SELECT users.userName FROM users INNER JOIN dbo.follow ON users.userID=dbo.follow.followed_id WHERE follow.follower_id=" + ana_follower + " ;";
                    //SqlCommand cmd3 = new SqlCommand("SELECT users.userName FROM users INNER JOIN dbo.follow ON users.userID=dbo.follow.followed_id WHERE follow.follower_id=" + ana_follower + " ;", connection);
                    adapter3.SelectCommand = cmd3;
                    adapter3.Fill(dataset3);

                    if (dataset3.Tables[0].Rows.Count != 0)
                    {
                        button_follow.Text = "Unfollow";
                        
                       
                    }
                    if (following)
                    { button_follow.Text = "Unfollow"; }
                        
                  //  MessageBox.Show("hon");
               // }
            }
            if (editing)
            {
                

                
                comboBox_online_shopping.Enabled = true;
                comboBox_delivery.Enabled = true;
                textBox_email.Enabled = true;
                textBox_fax.Enabled = true;
                textBox_homepage.Enabled = true;
                
                textBox_username.Enabled = true;
                textBox_address.Enabled = true;
                button_image.Enabled = true;
                button_save.Visible = true;
                comboBox_cities.Enabled = true;
                comboBox_provinces.Enabled = true;
                comboBox_countries.Enabled = true;


                textBox_email.BorderStyle = BorderStyle.FixedSingle;
                textBox_fax.BorderStyle = BorderStyle.FixedSingle;
                textBox_homepage.BorderStyle = BorderStyle.FixedSingle;
                textBox_joining_time.BorderStyle = BorderStyle.FixedSingle;
                textBox_username.BorderStyle = BorderStyle.FixedSingle;
                textBox_address.BorderStyle = BorderStyle.FixedSingle;
                button_follow.Visible = false;
            }
            if (is_company && editing)
            {
                button_image.Visible = true;
                pictureBox_profile.Visible = true;
               
            }
         
            if (is_company)
            {
                label_fav_origin.Visible = false;
                comboBox_fav_origin.Visible = false;
                
                try
                {
                    DataSet dataset3;
                   // using (SqlConnection connection = new SqlConnection(connectionString))
                    //{
                        dataset3 = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = Form_Home.connection;
                        cmd.CommandText = "select * from countries order by countries.country_name;";
                      //  SqlCommand cmd = new SqlCommand("select * from countries order by countries.country_name;", connection);
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dataset3);
                   // }
                    
                    DataRow row = dataset3.Tables[0].NewRow();
                    row["country_id"] = DBNull.Value;
                    row["country_name"] = "--choose country--";
                    dataset3.Tables[0].Rows.InsertAt(row, 0);

                    comboBox_countries.DataSource = dataset3.Tables[0];
                    comboBox_countries.DisplayMember = "country_name"; // dataset.Tables[0].Columns[1].ColumnName
                    comboBox_countries.ValueMember = "country_id";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
                }


                try
                {
                    DataSet dataset, dataset1,dataset2;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        dataset = new DataSet();
                        dataset1 = new DataSet();
                        dataset2 = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlDataAdapter adapter1 = new SqlDataAdapter();
                        SqlDataAdapter adapter2 = new SqlDataAdapter();
                        SqlCommand cmd = new SqlCommand("SELECT email,joining_time FROM dbo.users where userName='" + userName + "' ;", connection);
                        SqlCommand cmd1 = new SqlCommand("SELECT company_address,city_id,fax,phone,homepage,online_shopping,delivery FROM dbo.companies where userID=" + userID + ";", connection);
                        
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dataset);

                        adapter1.SelectCommand = cmd1;
                        adapter1.Fill(dataset1);

                        SqlCommand cmd2 = new SqlCommand("SELECT cities.city_name, dbo.provinces.province_name, dbo.countries.country_name FROM cities INNER JOIN dbo.provinces ON cities.province_id=dbo.provinces.province_id INNER JOIN dbo.countries ON dbo.provinces.country_id=dbo.countries.country_id WHERE dbo.cities.city_id='" + (int)dataset1.Tables[0].Rows[0]["city_id"] + "';", connection);
                        adapter2.SelectCommand = cmd2;
                       adapter2.Fill(dataset2);

                        textBox_username.Text = userName;
                       email= textBox_email.Text = dataset.Tables[0].Rows[0]["email"].ToString();
                        textBox_joining_time.Text = dataset.Tables[0].Rows[0]["joining_time"].ToString();
                        textBox_fax.Text= dataset1.Tables[0].Rows[0]["fax"].ToString();
                        phone=textBox_phone.Text = dataset1.Tables[0].Rows[0]["phone"].ToString();
                       homepage= textBox_homepage.Text= dataset1.Tables[0].Rows[0]["homepage"].ToString();
                        comboBox_delivery.SelectedText=(((bool)dataset1.Tables[0].Rows[0]["delivery"]) ? "Yes":"No");
                        comboBox_online_shopping.SelectedText= (((bool)dataset1.Tables[0].Rows[0]["online_shopping"]) ? "Yes" : "No");
                       textBox_address.Text =dataset1.Tables[0].Rows[0]["company_address"].ToString();
                        comboBox_countries.Text = dataset2.Tables[0].Rows[0]["country_name"].ToString();
                        comboBox_provinces.SelectedText=dataset2.Tables[0].Rows[0]["province_name"].ToString();
                        comboBox_cities.SelectedText = dataset2.Tables[0].Rows[0]["city_name"].ToString();
                    }


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

               
            }
            else
            {

            }
        }

        private void comboBox_countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_countries.SelectedIndex != 0)
            {
                comboBox_provinces.Enabled = true;
                comboBox_cities.Enabled = true;
                try
                {
                    DataSet dataset;
                    //using (SqlConnection connection = new SqlConnection(connectionString))
                   // {
                        dataset = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = Form_Home.connection;
                        cmd.CommandText = "select * from provinces where provinces.country_id = " + comboBox_countries.SelectedValue + " order by provinces.province_name asc;";
                        //SqlCommand cmd = new SqlCommand("select * from provinces where provinces.country_id = " + comboBox_countries.SelectedValue + " order by provinces.province_name asc;", connection);
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dataset);
                   // }

                    comboBox_provinces.DisplayMember = "province_name";
                    comboBox_provinces.ValueMember = "province_id";
                    comboBox_provinces.DataSource = dataset.Tables[0];
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
                }
            }
            else
            {
                comboBox_provinces.Enabled = false;
                comboBox_cities.Enabled = false;
                comboBox_provinces.DataSource = null;
                comboBox_cities.DataSource = null;
            }
            if (comboBox_countries.Enabled == false)
                comboBox_provinces.Enabled = false;
        }

        private void comboBox_provinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_provinces.Enabled == false) return;
            try
            {
                DataSet dataset;
               // using (SqlConnection connection = new SqlConnection(connectionString))
               // {
                    dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Form_Home.connection;
                    cmd.CommandText = "select * from cities where cities.province_id = " + comboBox_provinces.SelectedValue + "order by cities.city_name asc;";
                   // SqlCommand cmd = new SqlCommand("select * from cities where cities.province_id = " + comboBox_provinces.SelectedValue + "order by cities.city_name asc;", connection);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dataset);
              //  }

                comboBox_cities.DataSource = dataset.Tables[0];
                comboBox_cities.DisplayMember = "city_name";
                comboBox_cities.ValueMember = "city_id";
                if (comboBox_provinces.Enabled == false)
                    comboBox_cities.Enabled = false;
            }
             
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
            }

        }

        private void comboBox_countries_TextUpdate(object sender, EventArgs e)
        {
           
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd1 = new SqlCommand("UPDATE dbo.users SET userName=@userName, email=@email where userID='"+userID+"'", connection);

                  //  cmd1.Parameters.Add(new SqlParameter("@category_id", category_id));
                  // cmd1.Parameters.Add(new SqlParameter("@product_name", product_name));
                    cmd1.Parameters.Add(new SqlParameter("@userName", (textBox_username.Text == string.Empty) ? userName : userName=textBox_username.Text));//here image property picture box
                    cmd1.Parameters.Add(new SqlParameter("@email",(textBox_email.Text==string.Empty)? email: textBox_email.Text));

                    // cmd.CommandText =("insert into products_companies values (@company_id,@product_id,@quantity_id,@quantity_per_unit,@unit_price,@units_in_stock,@description)",connection);

                    connection.Open();
                    cmd1.ExecuteNonQuery();
                    connection.Close();


                    if ((is_company) && (textBox_homepage.Text != string.Empty) && (textBox_phone.Text != string.Empty))
                    {
                        DataSet dataset1 = new DataSet();
                        SqlDataAdapter adapter1 = new SqlDataAdapter();
                        SqlCommand cmd2 = new SqlCommand("UPDATE dbo.companies SET fax=@fax,phone=@phone,company_address=@address,homepage=@homepage,city_id=@city,delivery=@delivery,online_shopping=@online_shopping WHERE userID='" + userID + "'", connection);

                        cmd2.Parameters.Add(new SqlParameter("@fax", textBox_fax.Text));
                        cmd2.Parameters.Add(new SqlParameter("@city", comboBox_cities.SelectedValue));
                        cmd2.Parameters.Add(new SqlParameter("@phone", textBox_phone.Text));
                        cmd2.Parameters.Add(new SqlParameter("@address", textBox_address.Text));
                        cmd2.Parameters.Add(new SqlParameter("@homepage", textBox_homepage.Text));
                        cmd2.Parameters.Add(new SqlParameter("@delivery", (comboBox_delivery.Text == "Yes") ? true :false));//here image property picture box
                        cmd2.Parameters.Add(new SqlParameter("@online_shopping", (comboBox_online_shopping.Text == "Yes") ? true : false));

                        // cmd.CommandText =("insert into products_companies values (@company_id,@product_id,@quantity_id,@quantity_per_unit,@unit_price,@units_in_stock,@description)",connection);

                        connection.Open();
                        cmd2.ExecuteNonQuery();
                        connection.Close();


                    }
                    else if ((textBox_homepage.Text != string.Empty) && (textBox_phone.Text != string.Empty))
                    {
                        MessageBox.Show("homepage or phone must be provided!");
                        textBox_homepage.Text = homepage;
                        textBox_phone.Text = phone;
                    }
                    if (!is_company)
                    {

                        if (((int)comboBox_fav_origin.SelectedValue != 0)&&(selected_value == 0))
                            {

                            DataSet dataset4 = new DataSet();
                            
                                SqlCommand cmd4 = new SqlCommand("INSERT INTO dbo.preferred_food_origins(userID,food_origin_id)VALUES(" + userID + ","+comboBox_fav_origin.SelectedValue+");", connection);
                                
                             
                                
                                connection.Open();
                                cmd4.ExecuteNonQuery();
                                connection.Close();
                            }
                            else
                            if (((int)comboBox_fav_origin.SelectedValue != selected_value)&& (selected_value != 0))
                            {
                                DataSet dataset5 = new DataSet();
                           
                            SqlCommand cmd5 = new SqlCommand("update preferred_food_origins set food_origin_id=" + comboBox_fav_origin.SelectedValue + " where userID=" + userID, connection);

                                connection.Open();
                                cmd5.ExecuteNonQuery();
                                connection.Close();
                            
                            }
                        
                    }
                    
                }
                this.Close();
            }
            catch (Exception ex)
            {
                if (selected_value == 0)
                    this.Close();
                else

                MessageBox.Show(ex.Message);
               
            }
            
        }

        private void button_view_recipes_Click(object sender, EventArgs e)
        {
            Form_Home.RecipesBriefViewOptions options = new Form_Home.RecipesBriefViewOptions(Form_Home.RecipesBriefViewOptions.Options.MyRecipes, userID: this.userID, userName: this.userName);
            using (Form_RecipesBriefView f = new Form_RecipesBriefView(options))
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
            }

        }

        private void button_view_products_Click(object sender, EventArgs e)
        {
            FormRatingsProductsFollow products = new FormRatingsProductsFollow();
           products.type = FormRatingsProductsFollow.View_Type.Products;
            products.id_given = userID;
            products.is_company = is_company;
            // editing of viewing it is the same because the user is given at start
            this.Hide();
            products.ShowDialog();
            this.Show();
        }

        private void button_follow_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dataset;
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                    
                        dataset = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                    if (button_follow.Text == "Follow")
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = Form_Home.connection;
                        cmd.CommandText = "insert into follow values (" + ana_follower + "," + userID + ", GETDATE());";
                        //SqlCommand cmd = new SqlCommand("insert into follow values ("+ana_follower+","+userID+", GETDATE());", connection);
                       /// connection.Open();
                        //prob: ma 3am ye5od ana_follower
                        cmd.ExecuteNonQuery(); 
                       /// connection.Close(); 
                        button_follow.Text = "Unfollow";

                      }
                    else if(button_follow.Text == "Unfollow")
                    {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Form_Home.connection;
                    cmd.CommandText = "DELETE FROM follow WHERE followed_id=" + userID;
                       // SqlCommand cmd = new SqlCommand("DELETE FROM follow WHERE followed_id="+ userID, connection);
                        
                       // connection.Open();
                        cmd.ExecuteNonQuery();
                       // connection.Close();
                        
                        button_follow.Text = "Follow";
                    }
              //  }

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
            }


            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Home.RecipesBriefViewOptions options = new Form_Home.RecipesBriefViewOptions(Form_Home.RecipesBriefViewOptions.Options.MyRecipes, userID: this.userID, userName: this.userName);
          //  using (Form_RecipesBriefView f = new Form_RecipesBriefView(options))
            {
                this.Hide();
              //  f.ShowDialog();
                this.Show();
            }
        }
    }
}
