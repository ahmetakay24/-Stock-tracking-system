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

namespace BakkalProjesi
{
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bakkal;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        void gridData()
        {
            conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bakkal;Integrated Security=True");
            adapter = new SqlDataAdapter("select * from Products", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gridData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pcBOX.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();    
            pnBOX.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            nofBOX.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ppBOX.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            spBOX.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Products(ProductName,NumberOfProducts,PurchasePrice,SalePrice) values (@ProductName,@NumberOfProducts,@PurchasePrice,@SalePrice)";
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@ProductName", pnBOX.Text);
            cmd.Parameters.AddWithValue("@NumberOfProducts",nofBOX.Text);
            cmd.Parameters.AddWithValue("@PurchasePrice", ppBOX.Text);
            cmd.Parameters.AddWithValue("@SalePrice", spBOX.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            gridData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from Products where @ProductCode=ProductCode";
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@ProductCode",Convert.ToInt32(pcBOX.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            gridData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string sorgu = "update Products set ProductName=@ProductName,NumberOfProducts=@NumberOfProducts,PurchasePrice=@PurchasePrice,SalePrice=@SalePrice where ProductCode=@ProductCode";
            cmd= new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@ProductCode",Convert.ToInt32(pcBOX.Text));
            cmd.Parameters.AddWithValue("@ProductName", pnBOX.Text);
            cmd.Parameters.AddWithValue("@NumberOfProducts", nofBOX.Text);
            cmd.Parameters.AddWithValue("@PurchasePrice", ppBOX.Text);
            cmd.Parameters.AddWithValue("@SalePrice", spBOX.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            gridData();
        }
    }
}
