using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manav_Otomasyonu
{
    using Repository;
    using Entities;
    public partial class Form1 : Form
    {
        CustomerRepo cr;
        ProductRepo pr;
        CategoryRepo catr;
        public Form1()
        {
            InitializeComponent();
            cr = new CustomerRepo();
            pr = new ProductRepo();
            catr = new CategoryRepo();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (tcManav.SelectedTab.Name=="tpCustomer")
            {
                CustomerForm cf = new CustomerForm();
                cf.ShowDialog();
                FillCustomerGrid();
            }
            else if(tcManav.SelectedTab.Name == "tpProduct")
            {
                ProductForm pf = new ProductForm();
                pf.ShowDialog();
                FillProductGrid();
            }else if (tcManav.SelectedTab.Name == "tpCategories")
            {
                CategoryForm catf = new CategoryForm();
                catf.ShowDialog();
                FillCategoryGrid();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrids();
        }

        private void FillGrids()
        {
            FillCustomerGrid();
            FillProductGrid();
            FillCategoryGrid();
        }

        private void FillCategoryGrid()
        {
            grdCategories.DataSource = catr.Get();
            grdCategories.Columns[0].Visible = false;
            grdCategories.Columns[1].HeaderText = "Kategori Adı";
        }

        private void FillProductGrid()
        {
            grdProducts.DataSource = pr.Get();
            grdProducts.Columns[0].Visible = false;
            grdProducts.Columns[2].Visible = false;
            grdProducts.Columns[1].HeaderText = "Ürün Adı";
            grdProducts.Columns[3].HeaderText = "Ürün Fiyatı";
            grdProducts.Columns[4].HeaderText = "Ürün Stok Miktarı";

        }

        private void FillCustomerGrid()
        {
            grdCustomers.DataSource = cr.Get();
            grdCustomers.Columns[0].Visible = false;
            grdCustomers.Columns[1].HeaderText = "Ad";
            grdCustomers.Columns[2].HeaderText = "Soyad";
            grdCustomers.Columns[3].HeaderText = "Ülke";
            grdCustomers.Columns[4].HeaderText = "Şehir";
            grdCustomers.Columns[5].HeaderText = "İlçe";
            grdCustomers.Columns[6].HeaderText = "Posta Kodu";
            grdCustomers.Columns[7].HeaderText = "Telefon Numarası";
            grdCustomers.Columns[8].HeaderText = "Adres";


        }

        private void grdCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            Customer customer = (grdCustomers.DataSource as List<Customer>)[e.RowIndex];
            CustomerForm cf = new CustomerForm();
            cf.Tag = customer.MusteriID;
            cf.ShowDialog();
            FillCustomerGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tcManav.SelectedTab.Name == "tpCustomer")
            {
                if (grdCustomers.SelectedRows[0].Index>-1)
                {
                    DialogResult dr=MessageBox.Show("Silmek istediğinize emin misiniz?","Uyarı!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    if (dr==DialogResult.Cancel)
                    {
                        return;
                    }
                    CustomerDelete();
                    FillCustomerGrid();
                }
            }
            else if (tcManav.SelectedTab.Name == "tpProduct")
            {
                if (grdProducts.SelectedRows[0].Index > -1)
                {
                    DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    ProductDelete();
                    FillProductGrid();
                }
            }
            else if (tcManav.SelectedTab.Name == "tpCategories")
            {
                if (grdCategories.SelectedRows[0].Index > -1)
                {
                    DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    CategoryDelete();
                    FillCategoryGrid();
                }
            }


        }

        private void CategoryDelete()
        {
            Category category = (grdCategories.DataSource as List<Category>)[grdCategories.SelectedRows[0].Index];
            catr.Delete(category.CategoryID);
        }

        private void ProductDelete()
        {
            Product product = (grdProducts.DataSource as List<Product>)[grdProducts.SelectedRows[0].Index];
            pr.Delete(product.ProductID);
        }

        private void CustomerDelete()
        {
            Customer customer = (grdCustomers.DataSource as List<Customer>)[grdCustomers.SelectedRows[0].Index];
            cr.Delete(customer.MusteriID);
        }

        private void grdProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            ProductForm pf = new ProductForm();
            Product product = (grdProducts.DataSource as List<Product>)[e.RowIndex];
            pf.Tag = product.ProductID;
            pf.ShowDialog();
            FillProductGrid();
        }

        private void grdCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            CategoryForm catf = new CategoryForm();
            Category category = (grdCategories.DataSource as List<Category>)[e.RowIndex];
            catf.Tag = category.CategoryID;
            catf.ShowDialog();
            FillCategoryGrid();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm();
            cf.ShowDialog();
            FillCustomerGrid();
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (grdCustomers.SelectedRows[0].Index > -1)
            {
                DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                CustomerDelete();
                FillCustomerGrid();
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            pf.ShowDialog();
            FillProductGrid();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if (grdProducts.SelectedRows[0].Index > -1)
            {
                DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                ProductDelete();
                FillProductGrid();
            }
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            CategoryForm catf = new CategoryForm();
            catf.ShowDialog();
            FillCategoryGrid();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            if (grdCategories.SelectedRows[0].Index > -1)
            {
                DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                CategoryDelete();
                FillCategoryGrid();
            }
        }
    }
}
