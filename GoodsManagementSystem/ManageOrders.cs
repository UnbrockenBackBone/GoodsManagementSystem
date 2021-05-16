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
using System.Windows.Forms.VisualStyles;

namespace GoodsManagementSystem
{
    public partial class ManageOrders : Form
    {
        SqlConnection connection = new SqlConnection();
        public ManageOrders()
        {
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private int num = 0;
        int sum = 0;
        private int uprice, totprice, qty;
        private string product;
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
        void Populateproducts()
        {
            try
            {
                connection.Open();
                string MyQuery = "select * from ProductTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(MyQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch
            {

            }
        }
        void fillcategory()
        {
            string query = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader rdr;
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        void updateproduct()
        {
            
            int id = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            if(newQty < 0)
                MessageBox.Show("Помилка операції");
            else
            {
                connection.Open();
                string query = "update ProductTbl set ProdQty = " + newQty + " where ProdId=" + id + "";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                Populateproducts();
            }
        }
        private void ManageOrders_Load(object sender, EventArgs e)
        {
            Populate();
            Populateproducts();
            fillcategory();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("UPrice", typeof(int));
            table.Columns.Add("TotPrice", typeof(int));

            OrderGv.DataSource = table;
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdTb.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerName.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        int flag = 0;
        int stock;
        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            //qty = Convert.ToInt32(QtyTb.Text);
            stock = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
            //totprice = qty * uprice;
            flag = 1;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
                MessageBox.Show("Введіть к-сть");
            else if (flag == 0)
                MessageBox.Show("Виберіть продукт");
            else if (Convert.ToInt32(QtyTb.Text) > stock)
                MessageBox.Show("Немає в наявності");
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                totprice = qty * uprice;
                table.Rows.Add(num, product, qty, uprice, totprice);
                OrderGv.DataSource = table;
                flag = 0;
            }
            sum = sum + totprice;
            TotAmount.Text = sum.ToString();
            updateproduct();
        }

        private void InsertOrder_Click(object sender, EventArgs e)
        {
            if(OrderIdTb.Text =="" || CustomerIdTb.Text == "" || CustomerName.Text == "" || TotAmount.Text == "")
            {
                MessageBox.Show("Заповніть правильно поля");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into OrderTbl values(" + OrderIdTb.Text + "," + CustomerIdTb.Text + ",'" + CustomerName.Text + "','" + OrderDate.Text + "'," + TotAmount.Text + ")", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Замовлення додано успішно");
                    connection.Close();
                    //Populate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void SearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string MyQuery = "select * from ProductTbl where ProdCat='" + SearchCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(MyQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch
            {

            }
        }
    }
}
