using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsManagementSystem
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        int stratpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            stratpoint += 1;
            progress.Value = stratpoint;
            if(progress.Value == 100)
            {
                progress.Value = 0;
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
