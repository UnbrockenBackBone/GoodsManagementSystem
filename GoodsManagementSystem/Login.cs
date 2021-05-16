using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsManagementSystem
{
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection();
        public Login()
        {
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserTbl where Uname ='" + UnameTb.Text + "' and Upassword = '" + PasswordTb.Text + "'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                Main cust = new Main();
                cust.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильне ім'я або пароль");
            }
            connection.Close();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == false)
                PasswordTb.UseSystemPasswordChar = true;
            else
                PasswordTb.UseSystemPasswordChar = false;
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
