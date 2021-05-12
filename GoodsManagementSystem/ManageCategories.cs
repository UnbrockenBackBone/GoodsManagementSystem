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
    public partial class ManageCategories : Form
    {
        SqlConnection connection = new SqlConnection();
        public ManageCategories()
        {
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            InitializeComponent();
        }
        void Populate()
        {
            try
            {
                connection.Open();
                string MyQuery = "select * from CategoryTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(MyQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                CategoriesGV.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch
            {

            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (CategoriesId.Text == "")
            {
                MessageBox.Show("Введіть Id категорії");
            }
            else
            {
                connection.Open();
                string myquery = "delete from CategoryTbl where CatId='" + CategoriesId.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Категорію успішно видалено");
                connection.Close();
                Populate();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("update CategoryTbl set CatName='" + CategoriesName.Text + "' where CatId='" + CategoriesId.Text + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Категорію оновлено успішно");
                connection.Close();
                Populate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into CategoryTbl values('" + CategoriesId.Text + "','" + CategoriesName.Text + "')", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Категорію додано успішно");
                connection.Close();
                Populate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void CategoriesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoriesId.Text = CategoriesGV.SelectedRows[0].Cells[0].Value.ToString();
            CategoriesName.Text = CategoriesGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
