using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakkalProjesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Products go = new Products();
            go.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StockForm go1= new StockForm();
            go1.Show(); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GeneralForm go2= new GeneralForm();
            go2.Show();
        }
    }
}
