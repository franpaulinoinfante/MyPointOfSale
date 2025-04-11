using MyPointOfSale.Controllers;
using System;
using System.Windows.Forms;

namespace MyPointOfSale.WinForm
{
    public partial class frmProductos : Form
    {
        private readonly ProductController _productController;

        public frmProductos(ProductController productController)
        {
            InitializeComponent();

            _productController = productController;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
        {
            try
            {
                cbbCategory.DataSource = _productController.GetCategories();
                cbbCategory.DisplayMember = "CategoryName";
                cbbCategory.ValueMember = "CategoryId";
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts()
        {
            try
            {
                System.Collections.Generic.IReadOnlyList<ViewModels.ProductViewModel> products = _productController.GetProducts();
                dataGridView1.DataSource = products;
                dataGridView1.Columns["Category"].Visible = false; // Hide the Category column
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
