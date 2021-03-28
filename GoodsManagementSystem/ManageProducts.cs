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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\UnbrockenBackBone\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

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
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
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
    }
}
