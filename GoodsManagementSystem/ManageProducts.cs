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
    public partial class ManageProducts : Form
    {
        SqlConnection connection = new SqlConnection();
        public ManageProducts()
        {
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            InitializeComponent();
        }
        void Populate()
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
            SqlCommand cmd = new SqlCommand(query,connection);
            SqlDataReader rdr;
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource = dt;
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
        void fillsearchcombo()
        {
            string query = "select * from CategoryTbl where CatName='" + SearchCombo.SelectedValue.ToString()+"'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader rdr;
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource = dt;
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        void filterbycategory()
        {
            try
            {
                connection.Open();
                string MyQuery = "select * from ProductTbl where ProdCat='"+ SearchCombo.SelectedValue.ToString()+"'";
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
        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillcategory();
            Populate();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values('" + ProdIdTb.Text + "','" + ProdNameTb.Text + "','" + ProdQtTb.Text + "','" + ProPriceTb.Text + "','" + ProdDescTb.Text + "','" + CatCombo.SelectedValue.ToString() + "')", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Продукт додано успішно");
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
            if (ProdIdTb.Text == "")
            {
                MessageBox.Show("Введіть номер продукту");
            }
            else
            {
                connection.Open();
                string myquery = "delete from ProductTbl where Uphone='" + ProdIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Продукт успішно видалено");
                connection.Close();
                Populate();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("update ProductTbl set ProdName='" + ProdNameTb.Text + "',ProdQty='" + ProdQtTb.Text + "',ProdPrice='" + ProPriceTb.Text + "',ProdDesc='" + ProdDescTb.Text + "',ProdCat='" + CatCombo.SelectedValue.ToString() + "' where ProdId='" + ProdIdTb.Text + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Товар оновлено успішно");
                connection.Close();
                Populate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIdTb.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdNameTb.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQtTb.Text = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
            ProPriceTb.Text = ProductsGV.SelectedRows[0].Cells[3].Value.ToString();
            ProdDescTb.Text = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();
            CatCombo.SelectedValue = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void Search_Click(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
