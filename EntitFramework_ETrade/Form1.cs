using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
namespace EntitFramework_ETrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ETradeContext eTradeContext=new ETradeContext())
            {
                dgwProducts.DefaultCellStyle.ForeColor = Color.Black;

                dgwProducts.DataSource = eTradeContext.Products.ToList();
                //Entity frameworkta tabloya erişmak kodu bu kadar.

            }

        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
