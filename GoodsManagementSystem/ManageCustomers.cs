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

namespace GoodsManagementSystem
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\UnbrockenBackBone\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            Populate();
        }

        void Populate()
        {
            try
            {
                connection.Open();
                string MyQuery = "select * from CustomerTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(MyQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
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
                SqlCommand cmd = new SqlCommand("insert into CustomerTbl values('" + CustomerId.Text + "','" + CustomerName.Text + "','" + CustomerPhone.Text + "')", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Покупця додано успішно");
                connection.Close();
                Populate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (CustomerId.Text == "")
            {
                MessageBox.Show("Введіть Id користувача");
            }
            else
            {
                connection.Open();
                string myquery = "delete from CustomerTbl where CustId='" + CustomerId.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Покупця успішно видалено");
                connection.Close();
                Populate();
            }
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerId.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerName.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
            CustomerPhone.Text = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTbl set CustName='" + CustomerName.Text + "',CustPhone='" + CustomerPhone.Text + "' where CustId='" + CustomerId.Text + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Покупця оновлено успішно");
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
