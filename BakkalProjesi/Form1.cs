using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BakkalProjesi
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        //SQL Tanımlamarım

        SqlConnection connection;
        SqlDataReader dr;
        SqlCommand command;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void loginform_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
            panel1.Height, 30, 30));
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //SQL
                string username = UsernameTextBox.Text;
                string password = PasswordTextBox.Text;

                connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Bakkal;Integrated Security=True");
                connection.Open();

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from KullaniciBilgileri where Username='" + UsernameTextBox.Text + "'And Password='" + PasswordTextBox.Text + "'";

                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    Form2 go= new Form2();
                    go.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, your username or password was incorrect. Please double-check your username and password.");
            }
        }
    }
}
