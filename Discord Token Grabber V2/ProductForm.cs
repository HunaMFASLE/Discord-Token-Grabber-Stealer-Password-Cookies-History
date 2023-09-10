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
    public partial class ProductForm : Form
    {
        Product selectedProduct = null;
        ProductRepo pr;
        CategoryRepo catr;
        public ProductForm()
        {
            InitializeComponent();
            pr = new ProductRepo();
            catr = new CategoryRepo();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillControl();
            FillData();
        }

        private void FillData()
        {
            int id = Convert.ToInt32(this.Tag);
            if (id>0)
            {
                Product product = pr.GetById(id);

                if (product!=null)
                {
                    selectedProduct = product;
                    txtProductName.Text = product.ProductName;
                    cmbCategories.SelectedValue = product.CategoryID;
                    nuUnitPrice.Value = Convert.ToDecimal(product.UnitPrice);
                    nuUnitsInStock.Value = Convert.ToDecimal(product.UnitsInStock); 
                }
            }
        }

        private void FillControl()
        {
            cmbCategories.DataSource = catr.Get();
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSave();
            Close();
        }

        private void FormSave()
        {
            if (selectedProduct==null)
            {
                selectedProduct = new Product();
            }
            selectedProduct.ProductName = txtProductName.Text;
            selectedProduct.CategoryID =Convert.ToInt32(cmbCategories.SelectedValue);
            selectedProduct.UnitPrice = Convert.ToInt32(nuUnitPrice.Value);
            selectedProduct.UnitsInStock= Convert.ToInt32(nuUnitsInStock.Value);
            if (Convert.ToInt32(this.Tag)==0)
            {
                pr.Create(selectedProduct);
                this.Tag = selectedProduct.ProductID;
            }
            else
            {
                pr.Update(selectedProduct);
            }
        }

       
    }
}
