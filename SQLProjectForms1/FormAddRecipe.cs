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
  
    public partial class FormAddRecipe : Form
    {
        public bool editing = false;
        bool rated=false;
        private int nbProducts = 0;
        public string username;
        public int userID;
        public int recipe_id;
       
        public int main_caller;
        public FormAddRecipe()
        {
            InitializeComponent();
        }
       
         private void button_image_Click(object sender, EventArgs e)
            {
                if (button_image.Text == "Remove Logo")
                {
                    pictureBox_recipe.ImageLocation = null;
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

                        pictureBox_recipe.ImageLocation = openFileDialog1.FileName;
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

       
        private void FormAddRecipe_Load(object sender, EventArgs e)
        {
            DataSet dataset3;
            dataset3 = new DataSet();
            SqlDataAdapter adapter3 = new SqlDataAdapter();
            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = Form_Home.connection;
            cmd3.CommandText = "select * from saved_recipes where userID="+main_caller+" ;";
            //SqlCommand cmd3 = new SqlCommand("SELECT users.userName FROM users INNER JOIN dbo.follow ON users.userID=dbo.follow.followed_id WHERE follow.follower_id=" + ana_follower + " ;", connection);
            adapter3.SelectCommand = cmd3;
            adapter3.Fill(dataset3);

            if (dataset3.Tables[0].Rows.Count != 0)
            {
                button_save_recipe.Text = "Saved";
                button_save_recipe.Enabled = false;


            }

            numericUpDown_rating.Value = 1;
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                DataTable dt = new DataTable();
                adapter.SelectCommand = new SqlCommand("select * from food_type order by name asc", Form_Home.connection);
                adapter.Fill(dt);
                comboBox_type.DataSource = dt;
                comboBox_type.DisplayMember = "name";
                comboBox_type.ValueMember = "food_type_id";
                adapter.SelectCommand = new SqlCommand("select * from food_origin order by name asc", Form_Home.connection);
                dt = new DataTable();
                adapter.Fill(dt);
                comboBox_origin.DataSource = dt;
                comboBox_origin.DisplayMember = "name";
                comboBox_origin.ValueMember = "food_origin_id";
                adapter.SelectCommand = new SqlCommand("select * from categories order by category_name asc", Form_Home.connection);
                dt = new DataTable();
                adapter.Fill(dt);
                comboBox_category.DisplayMember = "category_name";
                comboBox_category.ValueMember = "category_id";
                comboBox_category.DataSource = dt;
                foreach (DataColumn item in ((DataTable)(comboBox_productName.DataSource)).Columns)
                {
                    dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);

                }
                dataGridView1.Columns["product_id"].Visible = false;
                dataGridView1.Columns["subcategory_id"].Visible = false;
                dataGridView1.Columns["is_generic"].Visible = false;
            }
            if (!editing)
            {//load the first rating
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Form_Home.connection;
                cmd.CommandText = "SELECT rating FROM dbo.ratings WHERE userID =" + main_caller;
                adapter.SelectCommand = cmd;
                adapter.Fill(dataset);
                if (dataset.Tables[0].Rows.Count == 0)
                {
                    radioButton1.Checked = false;
                    rated = false;
                }
                else
                {
                    rated = true;
                    radioButton1.Checked = true;
                    numericUpDown_rating.Value = int.Parse(dataset.Tables[0].Rows[0]["rating"].ToString());
                    numericUpDown_rating.Enabled = false;
                }


                DataSet dataset2 = new DataSet();
                SqlDataAdapter adapter2 = new SqlDataAdapter();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = Form_Home.connection;
                cmd2.CommandText = "SELECT dbo.products_recipes.product_amount, dbo.products_recipes.product_quantity, dbo.products.product_name,products.product_description FROM products INNER JOIN dbo.products_recipes ON products.product_id=dbo.products_recipes.product_id WHERE dbo.products_recipes=" + recipe_id;
                dataGridView1.DataSource = dataset2.Tables[0];
                

                label_author.Visible = true;
                textBox_author.Visible = true;
                // label_rating.Visible = true;
                //numericUpDown_rating.Visible = true;
                radioButton1.Visible = true;
                textBox_recipe_name.Enabled = false;
                textBox_description.Enabled = false;
                textBox_difficulty.Enabled = false;
                comboBox_origin.Enabled = false;
                comboBox_type.Enabled = false;
                panel1.Visible = false;
                button_addProduct.Visible = false;
                label_title.Text = "Recipe";
                label_Ingredients.Text = "Ingredients";
                label_instructions.Text = "Instructions";
                textBox_instructions.Enabled = false;

                
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
            timer1_Tick(timer1, new EventArgs());
        }

        private void comboBox_productName_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.ImageLocation = Form_Home.GetPicPath((int)comboBox_productName.SelectedValue, Form_Home.PicFolders.Products);
            textBox_productDescription.Text = (string)((DataTable)comboBox_productName.DataSource).Rows[comboBox_productName.SelectedIndex]["product_description"];

        }

        private void button_addProduct_Click(object sender, EventArgs e)
        {
            
            if (nbProducts == 10) { MessageBox.Show("Can't add more than 10 products."); return; }
            //MessageBox.Show(comboBox_productName.SelectedItem.ToString());
            
            
            if ((textBox_amount.Text == string.Empty) || (textBox_quantity.Text == string.Empty))
            {
                MessageBox.Show("Enter Amount and Quantity");
                return;
            }
            else
            {
                MessageBox.Show("datatable ma 3am tezbot");
             

                DataRow drow = ((DataRowView)comboBox_productName.SelectedItem).Row;
                drow["product_amount"] = int.Parse(textBox_amount.Text);
                drow["product_quantity"] = int.Parse(textBox_quantity.Text);
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    
                    if (item.IsNewRow) continue;
                    
                    
                    if ((int)item.Cells["product_id"].Value == (int)drow["product_id"])
                    {
                        MessageBox.Show("This product is already listed.");
                        return;
                    }

                    MessageBox.Show("hon");
                }
                dataGridView1.Rows.Add(drow.ItemArray);

                nbProducts++;
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
                tb.Columns.Add("product_amount", typeof(int));
                tb.Columns.Add("product_quantity", typeof(int));


                adapter.SelectCommand = cmd;
                adapter.Fill(tb);
                comboBox_productName.DisplayMember = "product_name";
                comboBox_productName.ValueMember = "product_id";
                comboBox_productName.DataSource = tb;
             
            }
        }

        private void removeFromListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView x = (DataGridView)contextMenuStrip1.SourceControl;
            foreach (DataGridViewRow item in x.SelectedRows)
            {
                x.Rows.Remove(item);
                nbProducts--;
            }
            foreach (DataGridViewCell item in x.SelectedCells)
            {
                x.Rows.Remove(item.OwningRow);
                nbProducts--;
            }
        }

        private void numericUpDown_rating_ValueChanged(object sender, EventArgs e)
        {
            if ((numericUpDown_rating.Value > 10) || (numericUpDown_rating.Value < 1))
            { MessageBox.Show("Rating cannot be greater than 10 nor less than 1");
                if (numericUpDown_rating.Value > 10) numericUpDown_rating.Value = 10;
                if (numericUpDown_rating.Value < 1) numericUpDown_rating.Value = 1;
            }
        }
        private void button_save_recipe_Click(object sender, EventArgs e)
        {
            int trying;
            if ((textBox_recipe_name.Text == string.Empty) || (textBox_difficulty.Text == string.Empty) || (textBox_prep_time.Text == string.Empty) || (textBox_calories.Text == string.Empty) || (textBox_serves.Text == string.Empty))
            { MessageBox.Show("you must fill all the fields");
                return;
            }
            if (!int.TryParse(textBox_difficulty.Text, out trying))
            {
                MessageBox.Show("Wrong format near difficulty");
                textBox_difficulty.Text = string.Empty;
                return;
            }
            if (!int.TryParse(textBox_prep_time.Text, out trying))
            {
                MessageBox.Show("Wrong format near preperation time");
                textBox_prep_time.Text = string.Empty;
                return;
            }
            if (!int.TryParse(textBox_calories.Text, out trying))
            {
                MessageBox.Show("Wrong format near calories");
                textBox_calories.Text = string.Empty;
                return;
            }
            if (!int.TryParse(textBox_serves.Text, out trying))
            {
                MessageBox.Show("Wrong format near serves");
                textBox_serves.Text = string.Empty;
                return;
            }
            if (editing)
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Form_Home.connection;
                    
                    cmd.CommandText = "INSERT INTO dbo.recipes VALUES('"+textBox_recipe_name.Text.Trim()+"', "+userID+",GETDATE(),'"+textBox_description.Text+"', '"+textBox_instructions.Text+"',"+comboBox_origin.SelectedValue+","+comboBox_type.SelectedValue+", "+int.Parse(textBox_prep_time.Text)+","+int.Parse(textBox_serves.Text)+","+int.Parse(textBox_difficulty.Text.Trim())+","+ float.Parse(textBox_calories.Text)+");";
                  
                    
                    int n = cmd.ExecuteNonQuery();
                
                    SqlCommand cmd0 = new SqlCommand();
                    cmd0.Connection = Form_Home.connection;
                    cmd0.Parameters.Add(new SqlParameter("@param1", textBox_recipe_name.Text.Trim()));
                    cmd0.CommandText = "select * from recipes where recipe_name like @param1 ;";
                    DataSet dataset1 = new DataSet();
                    adapter.SelectCommand = cmd0;
                    adapter.Fill(dataset1);
                    recipe_id=int.Parse(dataset1.Tables[0].Rows[0]["recipe_id"].ToString());
                    

                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = Form_Home.connection;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        cmd1.CommandText = @"INSERT INTO products_recipes VALUES ("+recipe_id+","+ (int)dataGridView1.Rows[i].Cells["product_id"].Value + ", "+ (int)dataGridView1.Rows[i].Cells["product_amount"].Value + "," + (int)dataGridView1.Rows[i].Cells["product_quantity"].Value+ ", null);";

                        cmd1.ExecuteNonQuery();
                    }
                    


                    
                }
            }
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label_rating.Visible = radioButton1.Checked;
            numericUpDown_rating.Visible = radioButton1.Checked;
        }

        private void button_follow_Click(object sender, EventArgs e)//profile
        {
            FormUserProfile prof = new FormUserProfile();
            prof.userName = textBox_author.Text;
            prof.editing = false;
            prof.ana_follower = main_caller;


            SqlCommand cmd0 = new SqlCommand();
            cmd0.Connection = Form_Home.connection;
            cmd0.CommandText= "SELECT companies.userID FROM companies WHERE companies.userID="+userID;
            //SqlCommand cmd1 = new SqlCommand("SELECT companies.userID FROM companies WHERE companies.userID=" + int.Parse(dataGridView_all.CurrentRow.Cells["userID"].Value.ToString()), connection1);
                DataSet dataset1 = new DataSet();
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                adapter1.SelectCommand = cmd0;
                adapter1.Fill(dataset1);
                if (dataset1.Tables[0].Rows.Count == 0)
                    prof.is_company = false;

                else prof.is_company = true;
            this.Hide();
            prof.ShowDialog();
            this.Show();

            }

        private void numericUpDown_rating_Leave(object sender, EventArgs e)
        {
            SqlCommand cmd0 = new SqlCommand();
            cmd0.Connection = Form_Home.connection;
            cmd0.CommandText = "INSERT INTO dbo.ratings values("+main_caller+"," + recipe_id + "," + numericUpDown_rating.Value + ",GETDATE());";
            rated = true;
            radioButton1.Visible = false;
            numericUpDown_rating.Enabled = false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dataset;
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{

                dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                if (button_save_recipe.Text == "Add to Saved")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Form_Home.connection;
                    cmd.CommandText = "insert into saved_recipes values (" + userID + "," + recipe_id + ", GETDATE());";
                    //SqlCommand cmd = new SqlCommand("insert into follow values ("+ana_follower+","+userID+", GETDATE());", connection);
                    /// connection.Open();
                    //prob: ma 3am ye5od ana_follower
                    cmd.ExecuteNonQuery();
                    /// connection.Close(); 
                    button_save_recipe.Text = "Saved";
                    button_save_recipe.Enabled = false;

                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + ex.Source.ToString());
            }
        }
    }
    
    }

