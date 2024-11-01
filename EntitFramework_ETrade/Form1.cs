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

            GetAllProduct();
      
        
                //Entity frameworkta tabloya erişmak kodu bu kadar.

        }

        public void GetAllProduct()
        {
          
            ProductDal productDal = new ProductDal();
            dgwProducts.DefaultCellStyle.ForeColor = Color.Black;
            dgwProducts.DataSource = productDal.GetAll();
            dgwProducts.Columns[0].Visible = false;
        }
        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ProductDal productDal=new ProductDal();
            productDal.Add(new Product() { Name = txtName.Text,
            UnitPrice=Convert.ToDecimal(txtFiyat.Text),
            StockAmount=Convert.ToInt32(txtAdet.Text)});
            GetAllProduct();
            MessageBox.Show("ADDED PRODUCT");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ProductDal productDal = new ProductDal();
            productDal.Delete(new Product()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
          
            MessageBox.Show("DELETED PRODUCT");
            GetAllProduct();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductDal productDal = new ProductDal();
            productDal.Update(new Product()
            {   Id=Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
       
            tbxNameUpdate.Text = "";
            tbxStockAmountUpdate.Text = "";
            tbxUnitPriceUpdate.Text = "";
            MessageBox.Show("updated PRODUCT");
            GetAllProduct();
        }
    
        }

}


