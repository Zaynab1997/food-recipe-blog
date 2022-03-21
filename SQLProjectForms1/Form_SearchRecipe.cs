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
    public partial class Form_SearchRecipe : Form
    {
        private int nbProducts = 0;
        private Form_Home.RecipesBriefViewOptions.Options opt;
        private int? userID;
        private string userName;

        public Form_SearchRecipe(Form_Home.RecipesBriefViewOptions.Options opt, int? userID = null, string userName = null)
        {
            this.opt = opt;
            this.userID = userID;
            this.userName = userName;


            InitializeComponent();

            switch (this.opt)
            {
                case Form_Home.RecipesBriefViewOptions.Options.TimeLine:
                    goto default;
                case Form_Home.RecipesBriefViewOptions.Options.MyRecipes:
                    goto default;
                case Form_Home.RecipesBriefViewOptions.Options.SearchRecipes:
                    tableLayoutPanel1.GetControlFromPosition(0, 1).Visible = true;
                    tableLayoutPanel1.GetControlFromPosition(1, 1).Visible = true;
                    break;
                case Form_Home.RecipesBriefViewOptions.Options.RatedRecipes:
                    radioButton_ratingsaving_time.Text = "Rating time";
                    radioButton_ratingsaving_time.Visible = true;
                    goto default;
                case Form_Home.RecipesBriefViewOptions.Options.SavedRecipes:
                    radioButton_ratingsaving_time.Text = "Save time";
                    radioButton_ratingsaving_time.Visible = true;
                    goto default;
                default:
                    tableLayoutPanel1.GetControlFromPosition(0, 1).Visible = false;
                    tableLayoutPanel1.GetControlFromPosition(1, 1).Visible = false;
                    break;
            }
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                DataTable dt = new DataTable();
                adapter.SelectCommand = new SqlCommand("select * from food_type order by name asc", Form_Home.connection);
                adapter.Fill(dt);
                comboBox_dishType.DataSource = dt;
                comboBox_dishType.DisplayMember = "name";
                adapter.SelectCommand = new SqlCommand("select * from food_origin order by name asc", Form_Home.connection);
                dt = new DataTable();
                adapter.Fill(dt);
                comboBox_dishOrigin.DataSource = dt;
                comboBox_dishOrigin.DisplayMember = "name";
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
        }

        private void checkBox_gen_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            int row = tableLayoutPanel1.GetRow(cb);
            switch (row)
            {
                case 0:
                    tableLayoutPanel1.GetControlFromPosition(1, row).Text = "";
                    goto case 2;
                case 1:
                    tableLayoutPanel1.GetControlFromPosition(1, row).Enabled = cb.Checked;
                    tableLayoutPanel1.GetControlFromPosition(1, row).Text = "";
                    if (cb.Checked) timer2_Tick(null, null);
                    break;
                case 2:
                case 3:
                    tableLayoutPanel1.GetControlFromPosition(1, row).Enabled = cb.Checked;
                    break;
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    tableLayoutPanel1.GetControlFromPosition(1, row).Enabled = cb.Checked;
                    ((NumericUpDown)tableLayoutPanel1.GetControlFromPosition(1, row)).Value = -1;
                    tableLayoutPanel1.GetControlFromPosition(3, row).Enabled = cb.Checked;
                    ((NumericUpDown)tableLayoutPanel1.GetControlFromPosition(3, row)).Value = -1;
                    break;
                default:
                    break;
            }
        }

        private void numericUpDown_gen_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDown x = (NumericUpDown)sender;
            TableLayoutPanelCellPosition pos = tableLayoutPanel1.GetPositionFromControl(x);
            NumericUpDown y = (NumericUpDown)tableLayoutPanel1.GetControlFromPosition((pos.Column + 2) % 4, pos.Row);
            if (x.Value == -1 || y.Value == -1)
            {
                return;
            }
            else
            {
                if ((pos.Column == 1 && x.Value > y.Value) || (pos.Column == 3 && x.Value < y.Value))
                {
                    e.Cancel = true;
                    MessageBox.Show("Min can't be greater than Max!");
                }
            }
        }

        private void checkBox_products_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Enabled = checkBox_products.Checked;
            dataGridView1.Enabled = checkBox_products.Checked;
            button_addProduct.Enabled = checkBox_products.Checked;
            pictureBox1.Enabled = checkBox_products.Checked;
            textBox_productDescription.Enabled = checkBox_products.Checked;
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

        private void comboBox_productName_TextChanged(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
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

        private void comboBox_productName_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.ImageLocation = Form_Home.GetPicPath((int)comboBox_productName.SelectedValue, Form_Home.PicFolders.Products);
            textBox_productDescription.Text = (string)((DataTable)comboBox_productName.DataSource).Rows[comboBox_productName.SelectedIndex]["product_description"];
        }

        private void button_addProduct_Click(object sender, EventArgs e)
        {
            if (nbProducts == 6) { MessageBox.Show("Can't add more than 6 products."); return; }
            //MessageBox.Show(comboBox_productName.SelectedItem.ToString());
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
            dataGridView1.Rows.Add(drow.ItemArray);
            nbProducts++;
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

        private void comboBox_subcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_productName.Text = "";
            timer1_Tick(null, null);
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


        private void comboBox_author_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void comboBox_author_TextChanged(object sender, EventArgs e)
        {
            if (!timer2.Enabled)
            {
                timer2.Enabled = true;
            }
        }

        private void comboBox_author_Validating(object sender, CancelEventArgs e)
        {
            foreach (DataRowView item in comboBox_author.Items)
            {
                if (item["userName"].ToString() == comboBox_author.Text) return;
            }
            e.Cancel = true;
            MessageBox.Show("Please select an author from the list.");
            comboBox_author.Text = "";
            timer2_Tick(null, null);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            if (!checkBox_authorName.Checked)
            {
                return;
            }
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Form_Home.connection;
                cmd.Parameters.Add(new SqlParameter("@param2", comboBox_author.Text.Trim()));
                cmd.CommandText = "select top 20 userID, userName from users where userName like @param2 + '%' order by userName asc;";
                DataTable tb = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(tb);
                comboBox_author.DisplayMember = "userName";
                comboBox_author.ValueMember = "userID";
                comboBox_author.DataSource = tb;
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            // todo : for adding "back" feature...
            Form_Home.RecipesBriefViewOptions o = new Form_Home.RecipesBriefViewOptions(
                this.opt,
                pageNb: 0,
                userID: opt != Form_Home.RecipesBriefViewOptions.Options.SearchRecipes ? this.userID : (!checkBox_authorName.Checked ? null : (int?)comboBox_author.SelectedValue),
                userName: opt != Form_Home.RecipesBriefViewOptions.Options.SearchRecipes ? this.userName : null,
                recipeName: !checkBox_recipeName.Checked ? null : textBox_recipeName.Text.Trim(),
                dishTypeID: !checkBox_dishType.Checked ? null : (int?)comboBox_dishType.SelectedValue,
                dishOriginID: !checkBox_dishOrigin.Checked ? null : (int?)comboBox_dishOrigin.SelectedValue,
                prepTime_min: !checkBox_prepTime.Checked ? null : numericUpDown_prepTime_min.Value == -1 ? null : (int?)numericUpDown_prepTime_min.Value,
                prepTime_max: !checkBox_prepTime.Checked ? null : numericUpDown_prepTime_max.Value == -1 ? null : (int?)numericUpDown_prepTime_max.Value,
                serves_min: !checkBox_serves.Checked ? null : numericUpDown_serves_min.Value == -1 ? null : (int?)numericUpDown_serves_min.Value,
                serves_max: !checkBox_serves.Checked ? null : numericUpDown_serves_max.Value == -1 ? null : (int?)numericUpDown_serves_max.Value,
                calories_min: !checkBox_calories.Checked ? null : numericUpDown_calories_min.Value == -1 ? null : (int?)numericUpDown_calories_min.Value,
                calories_max: !checkBox_calories.Checked ? null : numericUpDown_calories_max.Value == -1 ? null : (int?)numericUpDown_calories_max.Value,
                difficulty_min: !checkBox_difficulty.Checked ? null : numericUpDown_difficulty_min.Value == -1 ? null : (int?)numericUpDown_difficulty_min.Value,
                difficulty_max: !checkBox_difficulty.Checked ? null : numericUpDown_difficulty_max.Value == -1 ? null : (int?)numericUpDown_difficulty_max.Value,
                rating_min: !checkBox_rating.Checked ? null : numericUpDown_rating_min.Value == -1 ? null : (int?)numericUpDown_rating_min.Value,
                rating_max: !checkBox_rating.Checked ? null : numericUpDown_rating_max.Value == -1 ? null : (int?)numericUpDown_rating_max.Value,
                nbRatings_min: !checkBox_nbRatings.Checked ? null : numericUpDown_nbRatings_min.Value == -1 ? null : (int?)numericUpDown_nbRatings_min.Value,
                nbRatings_max: !checkBox_nbRatings.Checked ? null : numericUpDown_nbRatings_max.Value == -1 ? null : (int?)numericUpDown_nbRatings_max.Value,
                orderBy: radioButton_date.Checked ? 0 : radioButton_rating.Checked ? 1 : radioButton_nbRatings.Checked ? 2 : this.opt == Form_Home.RecipesBriefViewOptions.Options.RatedRecipes ? 3 : 4,
                order: radioButton_desc.Checked ? 0 : 1,
                productID_1: checkBox_products.Checked && dataGridView1.RowCount > 0 ? (int?)dataGridView1.Rows[(1 + dataGridView1.NewRowIndex) % (dataGridView1.RowCount + 1)].Cells["product_id"].Value : null,
                productID_2: checkBox_products.Checked && dataGridView1.RowCount > 1 ? (int?)dataGridView1.Rows[(2 + dataGridView1.NewRowIndex) % (dataGridView1.RowCount + 1)].Cells["product_id"].Value : null,
                productID_3: checkBox_products.Checked && dataGridView1.RowCount > 2 ? (int?)dataGridView1.Rows[(3 + dataGridView1.NewRowIndex) % (dataGridView1.RowCount + 1)].Cells["product_id"].Value : null,
                productID_4: checkBox_products.Checked && dataGridView1.RowCount > 3 ? (int?)dataGridView1.Rows[(4 + dataGridView1.NewRowIndex) % (dataGridView1.RowCount + 1)].Cells["product_id"].Value : null,
                productID_5: checkBox_products.Checked && dataGridView1.RowCount > 4 ? (int?)dataGridView1.Rows[(5 + dataGridView1.NewRowIndex) % (dataGridView1.RowCount + 1)].Cells["product_id"].Value : null,
                productID_6: checkBox_products.Checked && dataGridView1.RowCount > 5 ? (int?)dataGridView1.Rows[(6 + dataGridView1.NewRowIndex) % (dataGridView1.RowCount + 1)].Cells["product_id"].Value : null
                );
            Form_RecipesBriefView f = new Form_RecipesBriefView(o);
            this.Hide();
            f.Show();
            this.Close();
            this.Dispose();
        }

    }
}
