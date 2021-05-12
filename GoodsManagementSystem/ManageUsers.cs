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
    public partial class ManageUsers : Form
    {
        SqlConnection connection = new SqlConnection();
        public ManageUsers()
        {
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            InitializeComponent();
        }

        void Populate()
        {
            try
            {
                connection.Open();
                string MyQuery = "select * from UserTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(MyQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch 
            {

            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {            
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('"+unameTb.Text+"','"+FnameTb.Text+"','"+PasswordTb.Text+"','"+PhoneTb.Text+"')",connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Користувача додано успішно");
                connection.Close();
                Populate();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (PhoneTb.Text == "")
            {
                MessageBox.Show("Введіть номер користувача");
            }
            else
            {
                connection.Open();
                string myquery = "delete from UserTbl where Uphone='" + PhoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Користувача успішно видалено");
                connection.Close();
                Populate();
            }
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            unameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            FnameTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            PasswordTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("update UserTbl set Uname='" + unameTb.Text + "',Ufullname='" + FnameTb.Text + "',Upassword='" + PasswordTb.Text + "' where Uphone='" + PhoneTb.Text + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Користувача оновлено успішно");
                connection.Close();
                Populate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
