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

namespace BakkalProjesi
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bakkal;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        void gridData()
        {
            conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bakkal;Integrated Security=True");
            adapter = new SqlDataAdapter("select ProductCode,ProductName,ProductImage from Products", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }
        private void imageBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation= openFileDialog1.FileName;
            imageTextBox.Text = openFileDialog1.FileName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("insert into Products (ProductName,ProductImage) values (@name, @image)", conn);
            command.Parameters.AddWithValue("@name", nameBox.Text);
            command.Parameters.AddWithValue("@image", imageTextBox.Text);
            command.ExecuteNonQuery();
            conn.Close();
            gridData();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            gridData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosed = dataGridView1.SelectedCells[0].RowIndex;
            CodeBox.Text = dataGridView1.Rows[choosed].Cells[0].Value.ToString();
            nameBox.Text = dataGridView1.Rows[choosed].Cells[1].Value.ToString();
            imageTextBox.Text = dataGridView1.Rows[choosed].Cells[2].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[choosed].Cells[2].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
