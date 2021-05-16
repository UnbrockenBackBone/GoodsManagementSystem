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
    public partial class ViewOrders : Form
    {
        SqlConnection connection = new SqlConnection();
        public ViewOrders()
        {
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            InitializeComponent();
        }
        void Populateorders()
        {
            try
            {
                connection.Open();
                string MyQuery = "select * from OrderTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(MyQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                OrdersGV.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch
            {

            }
        }
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            Populateorders();
        }

        private void ViewOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Сума замовлення", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Id замовлення: " + OrdersGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80,100));
            e.Graphics.DrawString("Id покупця: " + OrdersGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 133));
            e.Graphics.DrawString("Ім'я покупця: " + OrdersGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 166));
            e.Graphics.DrawString("Дата замовлення: " + OrdersGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 199));
            e.Graphics.DrawString("Сума замовлення: " + OrdersGV.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 232));
            e.Graphics.DrawString("PoweredByChukhraiStanislav", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230,350));
        }
    }
}
