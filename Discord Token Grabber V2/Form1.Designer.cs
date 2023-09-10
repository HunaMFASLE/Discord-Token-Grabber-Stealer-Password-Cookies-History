namespace Manav_Otomasyonu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcManav = new System.Windows.Forms.TabControl();
            this.tpCustomer = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.tpProduct = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.tpCategories = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.grdCategories = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tcManav.SuspendLayout();
            this.tpCustomer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.tpProduct.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.tpCategories.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // tcManav
            // 
            this.tcManav.Controls.Add(this.tpCustomer);
            this.tcManav.Controls.Add(this.tpProduct);
            this.tcManav.Controls.Add(this.tpCategories);
            this.tcManav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcManav.Location = new System.Drawing.Point(0, 69);
            this.tcManav.Name = "tcManav";
            this.tcManav.SelectedIndex = 0;
            this.tcManav.Size = new System.Drawing.Size(784, 392);
            this.tcManav.TabIndex = 0;
            // 
            // tpCustomer
            // 
            this.tpCustomer.Controls.Add(this.panel2);
            this.tpCustomer.Controls.Add(this.grdCustomers);
            this.tpCustomer.Location = new System.Drawing.Point(4, 25);
            this.tpCustomer.Name = "tpCustomer";
            this.tpCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomer.Size = new System.Drawing.Size(776, 363);
            this.tpCustomer.TabIndex = 0;
            this.tpCustomer.Text = "Müşteriler";
            this.tpCustomer.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.btnCustomerDelete);
            this.panel2.Controls.Add(this.btnCustomerAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 80);
            this.panel2.TabIndex = 1;
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnCustomerDelete.Location = new System.Drawing.Point(385, 15);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(180, 50);
            this.btnCustomerDelete.TabIndex = 4;
            this.btnCustomerDelete.Text = "Sil";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnCustomerAdd.Location = new System.Drawing.Point(199, 15);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(180, 50);
            this.btnCustomerAdd.TabIndex = 3;
            this.btnCustomerAdd.Text = "Ekle";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // grdCustomers
            // 
            this.grdCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCustomers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCustomers.Location = new System.Drawing.Point(3, 3);
            this.grdCustomers.MultiSelect = false;
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomers.Size = new System.Drawing.Size(770, 357);
            this.grdCustomers.TabIndex = 0;
            this.grdCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomers_CellDoubleClick);
            // 
            // tpProduct
            // 
            this.tpProduct.Controls.Add(this.panel3);
            this.tpProduct.Controls.Add(this.grdProducts);
            this.tpProduct.Location = new System.Drawing.Point(4, 25);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpProduct.Size = new System.Drawing.Size(776, 363);
            this.tpProduct.TabIndex = 1;
            this.tpProduct.Text = "Ürünler";
            this.tpProduct.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Controls.Add(this.btnProductDelete);
            this.panel3.Controls.Add(this.btnProductAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 80);
            this.panel3.TabIndex = 2;
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnProductDelete.Location = new System.Drawing.Point(385, 15);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(180, 50);
            this.btnProductDelete.TabIndex = 4;
            this.btnProductDelete.Text = "Sil";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnProductAdd.Location = new System.Drawing.Point(199, 15);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(180, 50);
            this.btnProductAdd.TabIndex = 3;
            this.btnProductAdd.Text = "Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // grdProducts
            // 
            this.grdProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdProducts.Location = new System.Drawing.Point(3, 3);
            this.grdProducts.MultiSelect = false;
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProducts.Size = new System.Drawing.Size(786, 418);
            this.grdProducts.TabIndex = 1;
            this.grdProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducts_CellDoubleClick);
            // 
            // tpCategories
            // 
            this.tpCategories.Controls.Add(this.panel4);
            this.tpCategories.Controls.Add(this.grdCategories);
            this.tpCategories.Location = new System.Drawing.Point(4, 25);
            this.tpCategories.Name = "tpCategories";
            this.tpCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategories.Size = new System.Drawing.Size(776, 363);
            this.tpCategories.TabIndex = 2;
            this.tpCategories.Text = "Kategoriler";
            this.tpCategories.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkRed;
            this.panel4.Controls.Add(this.btnCategoryDelete);
            this.panel4.Controls.Add(this.btnCategoryAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 280);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(770, 80);
            this.panel4.TabIndex = 2;
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnCategoryDelete.Location = new System.Drawing.Point(385, 15);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(180, 50);
            this.btnCategoryDelete.TabIndex = 2;
            this.btnCategoryDelete.Text = "Sil";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryAdd.Location = new System.Drawing.Point(199, 15);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(180, 50);
            this.btnCategoryAdd.TabIndex = 1;
            this.btnCategoryAdd.Text = "Ekle";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // grdCategories
            // 
            this.grdCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCategories.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCategories.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCategories.Location = new System.Drawing.Point(3, 3);
            this.grdCategories.MultiSelect = false;
            this.grdCategories.Name = "grdCategories";
            this.grdCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCategories.Size = new System.Drawing.Size(770, 357);
            this.grdCategories.TabIndex = 1;
            this.grdCategories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategories_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "HIZLI MANAV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcManav);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manav Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcManav.ResumeLayout(false);
            this.tpCustomer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.tpProduct.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.tpCategories.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcManav;
        private System.Windows.Forms.TabPage tpCustomer;
        private System.Windows.Forms.TabPage tpProduct;
        private System.Windows.Forms.TabPage tpCategories;
        private System.Windows.Forms.DataGridView grdCustomers;
        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.DataGridView grdCategories;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.Label label1;
    }
}

