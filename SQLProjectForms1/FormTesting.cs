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
    public partial class FormTesting : Form
    {
        public FormTesting()
        {
            InitializeComponent();
        }

        private void SqlQuery(string query)
        {
            try
            {
                #region datareader + loop
                /*
                scon.Open();
                SqlCommand scmd = new SqlCommand("", scon);
                scmd.CommandType = CommandType.Text;
                scmd.CommandText = query;
                SqlDataReader reader = null;
                reader = scmd.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        textBox2.AppendText(reader[i].ToString() + "\t");
                    }
                    textBox2.AppendText("\n");
                }
                scon.Close();
                */
                #endregion

                #region dataset adapter + loop
                /*
                //scon.Open();
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();

                //adapter.TableMappings.Add("Table", "Countries");

                adapter.SelectCommand = new SqlCommand(query, scon);
                adapter.Fill(dataset);
                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < dataset.Tables[0].Columns.Count; j++)
                    {
                        textBox2.AppendText(dataset.Tables[0].Rows[i][j].ToString() + "\t");
                    }
                    textBox2.AppendText("\n");
                }
                //textBox2.Text = dataset.Tables[0].ToString();
                */
                #endregion

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Form_Home.connection;
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "Table";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlQuery(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Form_Home.connection;
                cmd.CommandText = textBox1.Text;

                // insert into users(userName, userPassword, email, joining_time, is_company) values ('usertest1', 'pass', 'NULL', '2018-06-04 08:40:00', 0)
                /*
                SqlParameter param1 = new SqlParameter("@param1", SqlDbType.VarChar);
                param1.Value = "mail1";
                cmd.CommandText = "insert into users(userName, userPassword, email, joining_time, is_company) values ('usertest2', 'pass', @param1, '2018-06-04 08:40:00', 0)";
                cmd.Parameters.Add(param1);
                */

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormTesting_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
