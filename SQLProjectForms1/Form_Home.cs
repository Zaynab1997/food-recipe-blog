using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;


// todo: 
// -- add option to sign in via email...

namespace SQLProjectForms1
{
    public partial class Form_Home : Form
    {
        Stack<Panel> visibilityStack = new Stack<Panel>();
        bool is_company;
        //private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ @"C:\Users\AbdelRahman\Desktop\SQL Project final t2addam\SQLProjectProjectTest2.mdf" + ";Integrated Security = True; Connect Timeout = 30";
        private static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=SQLProjectProjectTest2;Integrated Security=True;Pooling=False";
        private static string picsDirectory = @"..\..\Pics\";
        //SqlConnection scon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=SQLProjectTest1;Integrated Security=True;Pooling=False");
        FormTesting ftesting;

        public static SqlConnection connection = new SqlConnection(connectionString);
        public static int userID;

        public class RecipesBriefViewOptions
        {
            public enum Options
            {
                // search recipes is same as my recipes...
                MyRecipes = 0, SearchRecipes = 4, TimeLine = 1, RatedRecipes = 2, SavedRecipes = 3
            };


            public Options opt;
            public int pageNb;
            public int? userID;
            public string userName;
            public string recipeName;
            public int? dishTypeID;
            public int? dishOriginID;
            public int? prepTime_min;
            public int? prepTime_max;
            public int? serves_min;
            public int? serves_max;
            public int? calories_min;
            public int? calories_max;
            public int? difficulty_min;
            public int? difficulty_max;
            public int? rating_min;
            public int? rating_max;
            public int? nbRatings_min;
            public int? nbRatings_max;
            public int orderBy;
            public int order;
            public int? productID_1;
            public int? productID_2;
            public int? productID_3;
            public int? productID_4;
            public int? productID_5;
            public int? productID_6;

            public RecipesBriefViewOptions(
                Options opt,
                int pageNb = 0,
                string userName = null,
                int? userID = null,
                string recipeName = null,
                int? dishTypeID = null,
                int? dishOriginID = null,
                int? prepTime_min = null,
                int? prepTime_max = null,
                int? serves_min = null,
                int? serves_max = null,
                int? calories_min = null,
                int? calories_max = null,
                int? difficulty_min = null,
                int? difficulty_max = null,
                int? rating_min = null,
                int? rating_max = null,
                int? nbRatings_min = null,
                int? nbRatings_max = null,
                int orderBy = 0,
                int order = 0,
                int? productID_1 = null,
                int? productID_2 = null,
                int? productID_3 = null,
                int? productID_4 = null,
                int? productID_5 = null,
                int? productID_6 = null
                )
            {
                this.opt = opt;
                this.pageNb = pageNb;
                this.userID = userID;
                this.userName = userName;
                this.recipeName = recipeName;
                this.dishTypeID = dishTypeID;
                this.dishOriginID = dishOriginID;
                this.prepTime_min = prepTime_min;
                this.prepTime_max = prepTime_max;
                this.serves_min = serves_min;
                this.serves_max = serves_max;
                this.calories_min = calories_min;
                this.calories_max = calories_max;
                this.difficulty_min = difficulty_min;
                this.difficulty_max = difficulty_max;
                this.rating_min = rating_min;
                this.rating_max = rating_max;
                this.nbRatings_min = nbRatings_min;
                this.nbRatings_max = nbRatings_max;
                this.orderBy = orderBy;
                this.order = order;
                this.productID_1 = productID_1;
                this.productID_2 = productID_2;
                this.productID_3 = productID_3;
                this.productID_4 = productID_4;
                this.productID_5 = productID_5;
                this.productID_6 = productID_6;
            }
        }

        public enum PicFolders
        {
            Categories, Companies, Products, Recipes, Subcategories, Users
        };

        private static string PicFoldersString(PicFolders x)
        {
            string y = null;
            switch (x)
            {
                case PicFolders.Categories:
                    y = "Categories";
                    break;
                case PicFolders.Companies:
                    y = "Companies";
                    break;
                case PicFolders.Products:
                    y = "Products";
                    break;
                case PicFolders.Recipes:
                    y = "Recipes";
                    break;
                case PicFolders.Subcategories:
                    y = "Subcategories";
                    break;
                case PicFolders.Users:
                    y = "Users";
                    break;
                default:
                    y = null;
                    break;
            }
            return y;
        }

        public static string GetPicPath(int picName, PicFolders folder)
        {
            string[] s = Directory.GetFiles(Form_Home.picsDirectory + PicFoldersString(folder) + "\\", picName + ".*", SearchOption.TopDirectoryOnly);
            if (s.Length == 0)
            {
                return null;
            }
            else
            {
                return s[0];
            }
        }

        public static string CreatePicPath(int picName, PicFolders folder, string picOldPath)
        {
            string s;
            return s = Form_Home.picsDirectory + PicFoldersString(folder) + "\\" + picName.ToString() + Path.GetExtension(picOldPath);
        }

        public Form_Home()
        {
            // MessageBox.Show(Directory.Exists(@"..\..\Pics").ToString() + "\n" + Directory.GetCurrentDirectory());
            InitializeComponent();
            ftesting = new FormTesting();
            visibilityStack.Push(panel_home);
            Form_Home.connection.Open();
        }


        private void ShowHide(Panel toShow, Panel toHide)
        {
            toShow.Visible = true;
            toHide.Visible = false;
            visibilityStack.Push(toShow);
        }

        private void button_login_u_Click(object sender, EventArgs e)
        {
            this.label1.Text = "User Name";

            ShowHide(this.panel_signin, this.panel_home);

            this.is_company = false;
        }

        private void button_login_c_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Company Name";

            ShowHide(this.panel_signin, this.panel_home);

            this.is_company = true;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();

                //adapter.TableMappings.Add("Table", "Countries");

                SqlParameter param1 = new SqlParameter("@param1", SqlDbType.VarChar);
                param1.Value = textBox_userName.Text;
                SqlCommand cmd = new SqlCommand("select * from users where users.userName = @param1", Form_Home.connection);
                cmd.Parameters.Add(param1);
                adapter.SelectCommand = cmd;
                adapter.Fill(dataset);

                if (dataset.Tables[0].Rows.Count != 0 && (bool)dataset.Tables[0].Rows[0]["is_company"] == is_company)
                {
                    if ((string)dataset.Tables[0].Rows[0]["userPassword"] == textBox_password.Text)
                    {
                        // todo: ....
                        MessageBox.Show("login successfully");
                        Form_Home.userID = (int)dataset.Tables[0].Rows[0]["userID"];
                        if (is_company)
                        {
                            using (Form_Company1 f = new Form_Company1(Form_Home.userID, (string)dataset.Tables[0].Rows[0]["userName"]))
                            {
                                this.Hide();
                                f.ShowDialog();
                                this.textBox_userName.Text = "";
                                this.textBox_password.Text = "";
                                this.Show();
                            }
                        }
                        else
                        {
                            using (Form_User1 f = new Form_User1(Form_Home.userID, (string)dataset.Tables[0].Rows[0]["userName"]))
                            {
                                this.Hide();
                                f.ShowDialog();
                                this.textBox_userName.Text = "";
                                this.textBox_password.Text = "";
                                this.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("wrong password");
                    }
                }
                else
                {
                    MessageBox.Show((is_company ? "company" : "user") + " name not found");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
            }
        }

        private void testingFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // todo: we can also modify visibilityStack to contain forms too...
            ftesting.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (visibilityStack.Count > 1)
            {
                Panel panel = visibilityStack.Peek();
                visibilityStack.Pop().Visible = false;
                visibilityStack.Peek().Visible = true;
                for (int i = 0; i < panel.Controls.Count; i++)
                {
                    if (panel.Controls[i].GetType() == typeof(TextBox)) ((TextBox)(panel.Controls[i])).Text = "";
                }
            }
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            ShowHide(this.panel_signup_home, this.panel_home);
        }

        private void button_signup_u_Click(object sender, EventArgs e)
        {
            ShowHide(this.panel_signup_u, this.panel_signup_home);
        }

        private void button_signup_c_Click(object sender, EventArgs e)
        {
            // todo
            try
            {
                DataSet dataset;
                dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("select * from countries order by countries.country_name;", Form_Home.connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(dataset);

                DataRow row = dataset.Tables[0].NewRow();
                row["country_id"] = DBNull.Value;
                row["country_name"] = "--optional--";
                dataset.Tables[0].Rows.InsertAt(row, 0);

                comboBox_countries.DataSource = dataset.Tables[0];
                comboBox_countries.DisplayMember = "country_name"; // dataset.Tables[0].Columns[1].ColumnName
                comboBox_countries.ValueMember = "country_id";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
            }
            checkBox_delivery.Checked = false;
            checkBox_onlineShopping.Checked = false;
            pictureBox_logo_signup_c.ImageLocation = null;
            ShowHide(panel_signup_c, panel_signup_home);
        }

        private void button_signup_u_done_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_userName_signup_u.Text) || string.IsNullOrWhiteSpace(textBox_password_signup_u.Text))
            {
                MessageBox.Show("User Name and Password can't be empty.");
                return;
            }
            string userName1 = textBox_userName_signup_u.Text.Trim();
            string userPassword1 = textBox_password_signup_u.Text.Trim();
            string email1 = textBox_email_signup_u.Text.Trim(); // it cannot be null here, it would be empty if nothing is inserted, so no error on function trim()
            try
            {
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter param1 = new SqlParameter("@param1", SqlDbType.VarChar);
                param1.Value = userName1;
                SqlCommand cmd = new SqlCommand("select * from users where users.userName = @param1", Form_Home.connection);
                cmd.Parameters.Add(param1);
                adapter.SelectCommand = cmd;
                adapter.Fill(dataset);

                bool ok = true;

                if (dataset.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("User Name is already taken. Choose another User Name.");
                    ok = false;
                }

                if (email1.Length != 0)
                {
                    param1.Value = email1;
                    cmd.CommandText = "select * from users where users.email = @param1";
                    dataset = new DataSet();
                    adapter.Fill(dataset);
                    if (dataset.Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("This Email already has an account.");
                        ok = false;
                    }
                }

                if (ok)
                {
                    cmd.CommandText = "insert into users(userName, userPassword, " + (email1.Length == 0 ? "" : "email, ") + "joining_time, is_company) values (@userName, @userPassword, " + (email1.Length == 0 ? "" : "@email, ") + "@jointime, 0);";
                    cmd.Parameters.Add(new SqlParameter("@userName", userName1));
                    cmd.Parameters.Add(new SqlParameter("@userPassword", userPassword1));
                    if (email1.Length != 0) cmd.Parameters.Add(new SqlParameter("@email", email1));
                    cmd.Parameters.Add(new SqlParameter("@jointime", DateTime.UtcNow));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Signed Up successfully.");
                    // todo : ...
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
            }
        }

        private void button_signup_c_done_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_userName_signup_c.Text) || string.IsNullOrWhiteSpace(textBox_password_signup_c.Text))
            {
                MessageBox.Show("User Name and Password can't be empty.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_homepage_signup_c.Text) && string.IsNullOrWhiteSpace(textBox_phone_signup_c.Text))
            {
                MessageBox.Show("A Phone number or a Home Page should be provided.");
                return;
            }

            string userName1 = textBox_userName_signup_c.Text.Trim();
            string userPassword1 = textBox_password_signup_c.Text.Trim();
            string email1 = textBox_email_signup_c.Text.Trim(); // it cannot be null here, it would be empty if nothing is inserted, so no error on function trim()

            // todo...
            try
            {
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter param1 = new SqlParameter("@param1", SqlDbType.VarChar);
                param1.Value = userName1;
                SqlCommand cmd = new SqlCommand("select * from users where users.userName = @param1", Form_Home.connection);
                cmd.Parameters.Add(param1);
                adapter.SelectCommand = cmd;
                adapter.Fill(dataset);

                bool ok = true;

                if (dataset.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("User Name is already taken. Choose another User Name.");
                    ok = false;
                }

                if (email1.Length != 0)
                {
                    param1.Value = email1;
                    cmd.CommandText = "select * from users where users.email = @param1";
                    dataset = new DataSet();
                    adapter.Fill(dataset);
                    if (dataset.Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("This Email already has an account.");
                        ok = false;
                    }
                }
                if (!ok) return;

                string company_address1 = textBox_address_signup_c.Text.Trim();
                string fax1 = textBox_fax_signup_c.Text.Trim();
                string phone1 = textBox_phone_signup_c.Text.Trim();
                string homepage1 = textBox_homepage_signup_c.Text.Trim();
                int? city_id1 = (int?)comboBox_cities.SelectedValue;
                bool delivery1 = checkBox_delivery.Checked;
                bool online_shopping1 = checkBox_onlineShopping.Checked;

                // todo: replace this with a procedure called insertCompany... (into both tables: users and companies)
                cmd.CommandText = "insert into users(userName, userPassword, joining_time, "

                    + (email1.Length == 0 ? "" : "email, ")

                    + "is_company) values (@userName, @userPassword, @jointime, "

                    + (email1.Length == 0 ? "" : "@email, ")

                    + "1);";

                cmd.Parameters.Add(new SqlParameter("@userName", userName1));
                cmd.Parameters.Add(new SqlParameter("@userPassword", userPassword1));
                cmd.Parameters.Add(new SqlParameter("@jointime", DateTime.UtcNow));

                if (email1.Length != 0) cmd.Parameters.Add(new SqlParameter("@email", email1));

                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("select userID from users where users.userName = @userName", Form_Home.connection);
                cmd.Parameters.Add(new SqlParameter("@userName", userName1));
                adapter.SelectCommand = cmd;
                adapter.Fill(dataset);
                int userid1 = (int)dataset.Tables[0].Rows[0][0];

                cmd = new SqlCommand();
                cmd.Connection = Form_Home.connection;
                cmd.CommandText = "insert into companies(userID, online_shopping, delivery"

                    + (city_id1 == null ? "" : ", city_id")
                    + (company_address1.Length == 0 ? "" : ", company_address")
                    + (fax1.Length == 0 ? "" : ", fax")
                    + (phone1.Length == 0 ? "" : ", phone")
                    + (homepage1.Length == 0 ? "" : ", homepage")

                    + ") values (@userID, @online_shopping, @delivery"

                    + (city_id1 == null ? "" : ", @city_id")
                    + (company_address1.Length == 0 ? "" : ", @company_address")
                    + (fax1.Length == 0 ? "" : ", @fax")
                    + (phone1.Length == 0 ? "" : ", @phone")
                    + (homepage1.Length == 0 ? "" : ", @homepage")

                    + ");";

                cmd.Parameters.Add(new SqlParameter("@userID", userid1));
                cmd.Parameters.Add(new SqlParameter("@online_shopping", online_shopping1));
                cmd.Parameters.Add(new SqlParameter("@delivery", delivery1));

                if (city_id1 != null) cmd.Parameters.Add(new SqlParameter("@city_id", city_id1));
                if (company_address1.Length != 0) cmd.Parameters.Add(new SqlParameter("@company_address", company_address1));
                if (fax1.Length != 0) cmd.Parameters.Add(new SqlParameter("@fax", fax1));
                if (phone1.Length != 0) cmd.Parameters.Add(new SqlParameter("@phone", phone1));
                if (homepage1.Length != 0) cmd.Parameters.Add(new SqlParameter("@homepage", homepage1));

                cmd.ExecuteNonQuery();

                if (pictureBox_logo_signup_c.Image != null)
                {
                    string newpath = Form_Home.CreatePicPath(userid1, PicFolders.Companies, pictureBox_logo_signup_c.ImageLocation);
                    File.Copy(pictureBox_logo_signup_c.ImageLocation, newpath, true);
                }


                MessageBox.Show("Signed Up successfully.");
                // todo : ...
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
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
                    dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("select * from provinces where provinces.country_id = " + comboBox_countries.SelectedValue + " order by provinces.province_name asc;", Form_Home.connection);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dataset);

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
        }

        private void comboBox_provinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_provinces.Enabled == false) return;
            try
            {
                DataSet dataset;
                dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("select * from cities where cities.province_id = " + comboBox_provinces.SelectedValue + "order by cities.city_name asc;", Form_Home.connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(dataset);

                comboBox_cities.DataSource = dataset.Tables[0];
                comboBox_cities.DisplayMember = "city_name";
                comboBox_cities.ValueMember = "city_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
            }
        }

        private void button_logo_Click(object sender, EventArgs e)
        {
            if (button_logo.Text == "Remove Logo")
            {
                pictureBox_logo_signup_c.ImageLocation = null;
                button_logo.Text = "Choose Logo (optional)";
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
                        /*
                        MemoryStream myStream = null;
                        if ((myStream = (MemoryStream)openFileDialog1.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                // Insert code to read the stream here.
                            }
                        }
                        */
                        pictureBox_logo_signup_c.ImageLocation = openFileDialog1.FileName;
                        //pictureBox_logo_signup_c.Image = new Bitmap(openFileDialog1.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                    button_logo.Text = "Remove Logo";
                }
            }
        }

        private void dowloadImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\AbdelRahman\Desktop\pics\log.txt", true))
                {
                    for (int i = 1; i <= 924; i++)
                    {
                        if (File.Exists(@"C:\Users\AbdelRahman\Desktop\pics\image" + i + ".png")) continue;
                        try
                        {
                            client.DownloadFile(new Uri(@"http://foodb.ca/system/foods/pictures/" + i + @"/full/" + i + ".png"), @"C:\Users\AbdelRahman\Desktop\pics\image" + i + ".png");
                        }
                        catch (Exception ex)
                        {
                            writer.WriteLine(i.ToString() + "\t" + ex.Message);
                        }
                        //if (i % 100 == 0) MessageBox.Show(i.ToString());
                    }
                    MessageBox.Show("done!");
                    //OR 

                    //client.DownloadFileAsync(new Uri(url), @"c:\temp\image35.png");
                }
            }
        }

        private void putImagesInDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("select id from foods", Form_Home.connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(dataset);

                SqlParameter param1 = new SqlParameter("@param1", SqlDbType.Int), param2 = new SqlParameter("@param2", SqlDbType.Image);
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.CommandText = "update foods set picture = @param2 where id = @param1";
                MemoryStream stream = new MemoryStream();
                string s = "";
                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    this.Name = i.ToString();
                    if (File.Exists(@"C:\Users\AbdelRahman\Desktop\pics\image" + ((int)dataset.Tables[0].Rows[i]["id"]).ToString() + ".png"))
                    {
                        param1.Value = (int)dataset.Tables[0].Rows[i]["id"];
                        (new Bitmap(@"C:\Users\AbdelRahman\Desktop\pics\image" + ((int)dataset.Tables[0].Rows[i]["id"]).ToString() + ".png")).Save(stream, ImageFormat.Png);
                        param2.Value = stream.ToArray();
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        s += i.ToString() + "\n";
                    }
                }
                MessageBox.Show(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
            for (int i = 1; i <= 924; i++)
            {
                if (File.Exists(@"C:\Users\AbdelRahman\Desktop\pics\image" + i + ".png"))
                    System.IO.File.Move(@"C:\Users\AbdelRahman\Desktop\pics\image" + i + ".png", @"C:\Users\AbdelRahman\Desktop\pics\" + i + ".png");
            }
            MessageBox.Show("done");
        }

        private void recipeViewformtestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecipeView_from_test tt = new RecipeView_from_test();
            tt.Show();
        }

        private void Form_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
    }
}
