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

namespace SemesterProject
{
    public partial class ProductList : Form
    {
        public ProductList(String userNameInput)
        {
            InitializeComponent();
            fillTable();
            label1.Text = userNameInput;

        }

        private void fillTable()
        {
            string sql = @"server=LAPTOP-2V3ATLNJ\SQLEXPRESS; database= avigailsp; trusted_connection = true";
            using (var connection = new SqlConnection(sql))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT name,price FROM ITEMS", connection))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        using (DataTable table = new DataTable())
                        {
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;
                        }
                    }

                }
            }
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu form2 = new MainMenu(label1.Text);
            this.Hide();
            form2.ShowDialog();
        }
    }
}

