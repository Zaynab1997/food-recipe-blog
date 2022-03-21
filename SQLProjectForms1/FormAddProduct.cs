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
using System.IO;

namespace SQLProjectForms1
{

    public partial class FormAddProduct : Form
    {
        public int user_id;
        public int product_id=1;
        public bool editing=false;
        bool updating = false;
       // string image;
        int? prod_id_new;
        bool active;
        bool flag = false;
        int second = 0;
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"D:\Downloads\DatabASE v3\SQLProjectProjectTest2.mdf" + @";Integrated Security=True;Connect Timeout=30";
        public FormAddProduct()
        {
            InitializeComponent();

        }

        private void button_image_Click(object sender, EventArgs e)
        {
            if (button_image.Text == "Remove Logo")
            {
                pictureBox_product.ImageLocation = null;
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

                        pictureBox_product.ImageLocation = openFileDialog1.FileName;
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


        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            
            // todo
            if (!checkBox_new_prod.Checked)
            {
                try
                {
                    DataSet dataset, dataset1;
                   // using (SqlConnection connection = new SqlConnection(connectionString))
                 //   {
                        dataset = new DataSet();
                        dataset1 = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlDataAdapter adapter1 = new SqlDataAdapter();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = Form_Home.connection;
                        cmd.CommandText = "SELECT * FROM dbo.categories ORDER BY category_name;";
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Connection = Form_Home.connection;
                        cmd1.CommandText = "SELECT * FROM dbo.quantities ORDER BY quantity_name;";
                        //SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.categories ORDER BY category_name;", connection);
                      //  SqlCommand cmd1 = new SqlCommand("SELECT * FROM dbo.quantities ORDER BY quantity_name;", connection);

                        adapter.SelectCommand = cmd;
                        adapter.Fill(dataset);
                        adapter1.SelectCommand = cmd1;
                        adapter1.Fill(dataset1);
                    //}

                    DataRow row = dataset.Tables[0].NewRow();
                    row["category_id"] = DBNull.Value;
                    row["category_name"] = "--choose one Main category--";
                    dataset.Tables[0].Rows.InsertAt(row, 0);

                    comboBox_main_category.DataSource = dataset.Tables[0];
                    comboBox_main_category.DisplayMember = "category_name"; // dataset.Tables[0].Columns[1].ColumnName
                    comboBox_main_category.ValueMember = "category_id";

                    //////////////// Quantities

                    DataRow row1 = dataset1.Tables[0].NewRow();
                    row1["quantity_id"] = DBNull.Value;
                    row1["quantity_name"] = "--choose quantity--";
                    dataset1.Tables[0].Rows.InsertAt(row1, 0);

                    comboBox_quantity_unit.DataSource = dataset1.Tables[0];
                    comboBox_quantity_unit.DisplayMember = "quantity_name"; // dataset.Tables[0].Columns[1].ColumnName
                                                                            // + " (" + "quantity_abbreviation"+")";
                    comboBox_quantity_unit.ValueMember = "quantity_id";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
                }
            }

            if (!editing){

                label_title.Text = "Product";
                comboBox_category.Enabled = false;
                comboBox_product_name.Enabled = false;
                textBox_description.Enabled = false;
                comboBox_quantity_unit.Enabled = false;
                comboBox_main_category.Enabled = false;
                textBox_unit_price.Enabled = false;
                textBox_units_in_stock.Enabled = false;
                textBox_quantity_per_unit.Enabled = false;
                //try catch selected value and filling
                checkBox_new_prod.Visible = false;
                button_save.Visible = false;
                button_companies.Visible = true;
                button_image.Visible = false;

                try
                {
                    //using (SqlConnection connection1 = new SqlConnection(connectionString))
                    //{
                        DataSet dataset1 = new DataSet();
                        SqlDataAdapter adapter1 = new SqlDataAdapter();
                        
                      //  SqlCommand cmd1 = new SqlCommand("SELECT dbo.products.product_name, products.product_description, dbo.categories.category_name, dbo.products_companies.quantity_perunit, dbo.products_companies.units_instock, dbo.products_companies.unit_price, dbo.subcategories.subcategory_name,quantities.quantity_name FROM products INNER JOIN dbo.subcategories ON products.subcategory_id=dbo.subcategories.subcategory_id INNER JOIN dbo.categories ON dbo.categories.category_id=dbo.subcategories.category_id INNER JOIN dbo.products_companies ON dbo.products_companies.product_id=dbo.products.product_id inner JOIN dbo.quantities ON dbo.products_companies.quantity_id=quantities.quantity_id WHERE products.product_id="+product_id, connection1);
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Connection = Form_Home.connection;
                        cmd1.CommandText = "SELECT dbo.products.product_name, products.product_description, dbo.categories.category_name, dbo.products_companies.quantity_perunit, dbo.products_companies.units_instock, dbo.products_companies.unit_price, dbo.subcategories.subcategory_name,quantities.quantity_name FROM products INNER JOIN dbo.subcategories ON products.subcategory_id=dbo.subcategories.subcategory_id INNER JOIN dbo.categories ON dbo.categories.category_id=dbo.subcategories.category_id INNER JOIN dbo.products_companies ON dbo.products_companies.product_id=dbo.products.product_id inner JOIN dbo.quantities ON dbo.products_companies.quantity_id=quantities.quantity_id WHERE products.product_id=" + product_id;
                        adapter1.SelectCommand = cmd1;
                        
                        adapter1.Fill(dataset1);
                        
                        comboBox_category.SelectedText= dataset1.Tables[0].Rows[0]["subcategory_name"].ToString(); 
                        comboBox_product_name.SelectedText = dataset1.Tables[0].Rows[0]["product_name"].ToString();
                        textBox_description.Text= dataset1.Tables[0].Rows[0]["product_description"].ToString();
                        comboBox_quantity_unit.SelectedText= dataset1.Tables[0].Rows[0]["quantity_name"].ToString();
                        comboBox_main_category.SelectedText = dataset1.Tables[0].Rows[0]["category_name"].ToString();
                        textBox_unit_price.Text= (dataset1.Tables[0].Rows[0]["unit_price"]).ToString();
                        textBox_units_in_stock.Text= dataset1.Tables[0].Rows[0]["units_instock"].ToString();
                        textBox_quantity_per_unit.Text= dataset1.Tables[0].Rows[0]["quantity_perunit"].ToString();
                       // image= dataset1.Tables[0].Rows[0]["product_image"].ToString();
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                int trying;
                if ((textBox_quantity_per_unit.Text == string.Empty) || (textBox_units_in_stock.Text == string.Empty) || (textBox_unit_price.Text == string.Empty) || (comboBox_quantity_unit.Text == string.Empty) || (comboBox_product_name.Text == string.Empty) || (comboBox_category.Text == string.Empty))
                {
                    MessageBox.Show("You should fill all fields");
                    return;
                }
                else
                {
                    if (!int.TryParse(textBox_quantity_per_unit.Text, out trying))
                    {
                        MessageBox.Show("Wrong format near quantity Per Unit");
                        textBox_quantity_per_unit.Text = string.Empty;
                        return;
                    }

                    if (!int.TryParse(textBox_units_in_stock.Text, out trying))
                    {
                        MessageBox.Show("Wrong format near Units in Stock");
                        textBox_units_in_stock.Text = string.Empty;
                        return;
                    }

                    if (!int.TryParse(textBox_unit_price.Text, out trying))
                    {
                        MessageBox.Show("Wrong format near Unit Price");
                        textBox_unit_price.Text = string.Empty;
                        return;
                    }
                }
             ;

                int? category_id = (int?)comboBox_category.SelectedValue;
                int? product_id = (int?)comboBox_product_name.SelectedValue;
                int? quantity_id = (int?)comboBox_quantity_unit.SelectedValue;
                string product_name = comboBox_product_name.Text.Trim();
                string desription = textBox_description.Text.Trim();
                string category = comboBox_category.Text.Trim();
                string quantity_per_unit = textBox_quantity_per_unit.Text.Trim();
                string quantity_unit = comboBox_quantity_unit.Text.Trim();
                string unit_price = textBox_unit_price.Text.Trim();
                string units_in_stock = textBox_units_in_stock.Text.Trim();

                if (checkBox_new_prod.Checked)
                {
                    try
                    {
                        //using (SqlConnection connection1 = new SqlConnection(connectionString))
                        //{
                        DataSet dataset1 = new DataSet();
                        SqlDataAdapter adapter1 = new SqlDataAdapter();

                        // SqlCommand cmd1 = new SqlCommand("insert into products values (@category_id,@product_name,@description," + "0" + ")", connection1);
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Connection = Form_Home.connection;
                        cmd1.CommandText = "insert into products values (@category_id,@product_name,@description," + "0" + ")";
                        cmd1.Parameters.Add(new SqlParameter("@category_id", category_id));
                        cmd1.Parameters.Add(new SqlParameter("@product_name", product_name));
                        // cmd1.Parameters.Add(new SqlParameter("@prod_image", string.Empty));//here image property picture box
                        cmd1.Parameters.Add(new SqlParameter("@description", string.Empty));

                        // cmd.CommandText =("insert into products_companies values (@company_id,@product_id,@quantity_id,@quantity_per_unit,@unit_price,@units_in_stock,@description)",connection);

                        //connection1.Open();
                        cmd1.ExecuteNonQuery();
                        //connection1.Close();

                        //  }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                try
                {
                    //using (SqlConnection connection = new SqlConnection(connectionString))
                    // {
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    //  SqlCommand cmd = new SqlCommand("insert into products_companies values (@company_id,@product_id,@quantity_id,@quantity_per_unit,@unit_price,@units_in_stock,@description)", connection);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Form_Home.connection;
                    cmd.CommandText = "insert into products_companies values (@company_id,@product_id,@quantity_id,@quantity_per_unit,@unit_price,@units_in_stock,@description)";
                    cmd.Parameters.Add(new SqlParameter("@company_id", user_id));
                    cmd.Parameters.Add(new SqlParameter("@product_id", (!checkBox_new_prod.Checked) ? product_id : prod_id_new));
                    cmd.Parameters.Add(new SqlParameter("@quantity_id", quantity_id));
                    cmd.Parameters.Add(new SqlParameter("@quantity_per_unit", quantity_per_unit));
                    cmd.Parameters.Add(new SqlParameter("@unit_price", unit_price));
                    cmd.Parameters.Add(new SqlParameter("@units_in_stock", units_in_stock));
                    cmd.Parameters.Add(new SqlParameter("@description", desription));

                    // cmd.CommandText =("insert into products_companies values (@company_id,@product_id,@quantity_id,@quantity_per_unit,@unit_price,@units_in_stock,@description)",connection);

                    //connection.Open();
                    cmd.ExecuteNonQuery();
                    //  connection.Close();

                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                MessageBox.Show("successfully added a product");
            }
            if ((!editing)&&(updating))
            {
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
               
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Form_Home.connection;
                SqlParameter param1 = new SqlParameter("@param1",SqlDbType.Int);
                SqlParameter param2 = new SqlParameter("@param2", SqlDbType.Money);
                SqlParameter param3 = new SqlParameter("@param3", SqlDbType.Int);
                SqlParameter param4 = new SqlParameter("@param4", SqlDbType.Int);
                SqlParameter param5 = new SqlParameter("@param5", SqlDbType.Int);
                //MessageBox.Show(param1.GetType().ToString());
                param1.Value= int.Parse(textBox_quantity_per_unit.Text.Trim());
                param2.Value= double.Parse(textBox_unit_price.Text.Trim());
                 param3.Value= int.Parse(textBox_units_in_stock.Text.Trim());
                param4.Value = product_id;
                param5.Value =user_id;


                cmd.Parameters.Add(param4);
                cmd.Parameters.Add(param5);
               
               // MessageBox.Show(dt.Rows.Count.ToString());

                cmd.CommandText = "update products_companies set quantity_perunit=@param1,unit_price =@param2, units_instock=@param3 where product_id=@param4 and company_id=@param5" ;
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                //cmd.Parameters.Add(param4);
               // cmd.Parameters.Add(param5);
                //cmd.Parameters.Add(new SqlParameter("@param1", int.Parse(textBox_quantity_per_unit.Text.Trim())));
                //cmd.Parameters.Add(new SqlParameter("@param2", double.Parse(textBox_unit_price.Text.Trim())));
                //cmd.Parameters.Add(new SqlParameter("@param3", (int.Parse(textBox_units_in_stock.Text.Trim()))));

                int n =cmd.ExecuteNonQuery();
                
                MessageBox.Show(n.ToString());
            }



            this.Close();
        }


        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboBox_category.SelectedIndex != 0) && (comboBox_main_category.SelectedIndex != 0))
            {
                comboBox_product_name.Enabled = true;

                try
                {
                    DataSet dataset;
                    
                        
                        dataset = new DataSet();
                    //  using (SqlConnection connection = new SqlConnection(connectionString))
                    //  {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                        //SqlCommand cmd = new SqlCommand("select * from products where products.subcategory_id = " + comboBox_category.SelectedValue + " order by products.product_name asc;", connection);
                        SqlCommand cmd = new SqlCommand();
                       cmd.Connection = Form_Home.connection;
                        cmd.CommandText = "select * from products where products.subcategory_id = " + comboBox_category.SelectedValue + " order by products.product_name asc;";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dataset);
                    

                    comboBox_product_name.DisplayMember = "product_name";
                    comboBox_product_name.ValueMember = "product_id";
                    comboBox_product_name.DataSource = dataset.Tables[0];
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
                }

                try
                {
                    DataSet dataset;
                  //  using (SqlConnection connection = new SqlConnection(connectionString))
                  //  {
                        dataset = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = Form_Home.connection;
                        cmd.CommandText = "select count(product_id) as prod_count,subcategory_id  from products where products.subcategory_id = " + comboBox_category.SelectedValue + " group by subcategory_id";
                       // SqlCommand cmd = new SqlCommand("select count(product_id) as prod_count,subcategory_id  from products where products.subcategory_id = " + comboBox_category.SelectedValue + " group by subcategory_id ;", connection);
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dataset);
                        prod_id_new = (int?)dataset.Tables[0].Rows[0]["prod_count"] + 1;
                   // }

                    // comboBox_product_name.DisplayMember = "prod_count";
                    //   comboBox_product_name.ValueMember = "product_id";
                    // comboBox_product_name.DataSource = dataset.Tables[0];
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
                }
            }
            else
            {
                comboBox_product_name.Enabled = false;

                comboBox_product_name.DataSource = null;

            }
        }

        private void comboBox_product_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label_means.Text = "Do you mean: '"+comboBox_product_name.SelectedText+"' ?";
        }

        private void label_means_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_product_name_Leave(object sender, EventArgs e)
        {
            active = false;
            //  MessageBox.Show(comboBox_product_name.SelectedValue.ToString());
            //comboBox_product_name.MouseClick;

            // label_means.Text = "Do you mean: '" + comboBox_product_name.Text + "' ?";
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((flag) && (active) && (!checkBox_new_prod.Checked))
            {

                if (second++ == 1)
                {
                    timer1.Stop();



                    if (comboBox_category.SelectedIndex != 0)
                    {
                        comboBox_product_name.Enabled = true;

                        try
                        {
                            DataSet dataset;
                           // using (SqlConnection connection = new SqlConnection(connectionString))
                           // {
                                dataset = new DataSet();
                                SqlDataAdapter adapter = new SqlDataAdapter();
                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = Form_Home.connection;
                                cmd.CommandText = "select * from products where products.subcategory_id = " + comboBox_category.SelectedValue + " and product_name like '%" + comboBox_product_name.Text + "%' order by products.product_name asc;";
                               // SqlCommand cmd = new SqlCommand("select * from products where products.subcategory_id = " + comboBox_category.SelectedValue + " and product_name like '%" + comboBox_product_name.Text + "%' order by products.product_name asc;", connection);
                                adapter.SelectCommand = cmd;
                                adapter.Fill(dataset);
                           // }

                            comboBox_product_name.DisplayMember = "product_name";
                            comboBox_product_name.ValueMember = "product_id";
                            comboBox_product_name.DataSource = dataset.Tables[0];
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
                        }

                    }
                    else
                    {
                        comboBox_product_name.Enabled = false;

                        comboBox_product_name.DataSource = null;

                    }
                    if (comboBox_product_name.Text == string.Empty)

                    {
                        comboBox_category_SelectedIndexChanged(sender, e);
                        comboBox_product_name.DroppedDown = false;
                    }
                    else
                        comboBox_product_name.DroppedDown = true;
                    flag = false;
                    second = 0;
                }
            }
        }

        private void comboBox_product_name_TextUpdate(object sender, EventArgs e)
        {
            flag = true;
            timer1.Stop();
            timer1.Enabled = true;
            timer1.Start();
            //menuStrip_product_name.Top += comboBox_product_name.Height;
            //comboBox_product_name.Controls.Add(menuStrip_product_name);
        }

        private void comboBox_product_name_Enter(object sender, EventArgs e)
        {
            active = true;
        }

        private void comboBox_main_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_main_category.SelectedIndex != 0)
            {
                comboBox_category.Enabled = true;
                try
                {
                    DataSet dataset;
                   // using (SqlConnection connection = new SqlConnection(connectionString))
                   // {
                        dataset = new DataSet();

                        SqlDataAdapter adapter = new SqlDataAdapter();

                       // SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.subcategories where subcategories.category_id = " + comboBox_main_category.SelectedValue + " ORDER BY subcategory_name;", connection);
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = Form_Home.connection;
                        cmd.CommandText = "SELECT * FROM dbo.subcategories where subcategories.category_id = " + comboBox_main_category.SelectedValue + " ORDER BY subcategory_name;";

                        adapter.SelectCommand = cmd;
                        adapter.Fill(dataset);

                    //}

                    DataRow row = dataset.Tables[0].NewRow();
                    row["subcategory_id"] = DBNull.Value;
                    row["subcategory_name"] = "--choose one category--";
                    dataset.Tables[0].Rows.InsertAt(row, 0);

                    comboBox_category.DataSource = dataset.Tables[0];
                    comboBox_category.DisplayMember = "subcategory_name"; // dataset.Tables[0].Columns[1].ColumnName
                    comboBox_category.ValueMember = "subcategory_id";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
                }

            }
            else
            {
                comboBox_category.Enabled = false;

                comboBox_category.DataSource = null;
                comboBox_product_name.Enabled = false;

                comboBox_product_name.DataSource = null;
            }
        }

        private void button_companies_Click(object sender, EventArgs e)
        {
            FormRatingsProductsFollow providers = new FormRatingsProductsFollow();
            providers.type = FormRatingsProductsFollow.View_Type.Providers;
            providers.id_given = product_id;
            providers.is_company = false;////needs checking
            this.Hide();
            providers.ShowDialog();
            this.Show();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if(!editing)
            {

                textBox_unit_price.Enabled = true;

                textBox_units_in_stock.Enabled = true;
                textBox_quantity_per_unit.Enabled = true;
                button_save.Visible = true;
                updating = true;
            }
        }
    }
}

