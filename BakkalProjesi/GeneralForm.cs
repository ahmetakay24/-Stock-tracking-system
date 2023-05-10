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
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bakkal;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        void FillChart()
        {
            DataTable dataTable = new DataTable();
            conn.Open();
            SqlDataAdapter chartAdapter = new SqlDataAdapter("select Date,TotalQuantity,TotalSalePrice,TotalPurchasePrice from GeneralView", conn);
            chartAdapter.Fill(dataTable);
            chart1.DataSource = dataTable;
            conn.Close();

            chart1.Series["Total Quantity"].XValueMember = "Date";
            chart1.Series["Total Sale Price"].XValueMember = "Date";
            chart1.Series["Total Purchase Price"].XValueMember = "Date";
            chart1.Series["Total Quantity"].YValueMembers = "TotalQuantity";
            chart1.Series["Total Sale Price"].YValueMembers = "TotalSalePrice";
            chart1.Series["Total Purchase Price"].YValueMembers = "TotalPurchasePrice";
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            gridData();
            FillChart();
        }
        void gridData()
        {
            conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bakkal;Integrated Security=True");
            adapter = new SqlDataAdapter("select * from GeneralView", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            noBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void dateBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO GeneralView (Date,TotalQuantity,TotalPurchasePrice,TotalSalePrice) SELECT @date,SUM(NumberOfProducts),SUM(PurchasePrice),SUM(SalePrice) FROM Products";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@date", dateBox.Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            gridData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string query = "delete from GeneralView where @NumberOfOperations=NumberOfOperations";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@NumberOfOperations", Convert.ToInt32(noBox.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            gridData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string query = "update GeneralView set Date=@Date where NumberOfOperations=@NumberOfOperations";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Date", dateBox.Value);
            cmd.Parameters.AddWithValue("@NumberOfOperations", Convert.ToInt32(noBox.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            gridData();
        }
    }
}
