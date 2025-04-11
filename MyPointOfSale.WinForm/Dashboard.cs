using MyPointOfSale.Common.Cache;
using MyPointOfSale.Controllers;
using System;
using System.Windows.Forms;

namespace MyPointOfSale.WinForm
{
    public partial class Dashboard : Form
    {
        private readonly ProductController _productController;
        private readonly UserController _userController;
        private readonly InvoiceController _invoiceController;

        public Dashboard()
        {
            InitializeComponent();

            _productController = new ProductController();
            _userController = new UserController();
            _invoiceController = new InvoiceController();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea cerrar sección?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void usuarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios(_userController);
            usuarios.Show();
        }

        private void productos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmProductos productos = new frmProductos(_productController);
            productos.Show();
        }

        private void lklInvoice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInvoice frmInvoice = new frmInvoice(_invoiceController);
            frmInvoice.Show();
            LoadTableLayoutPanel();
        }

        private void ctrlDateTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd MMM yyy");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadUserData();
            LoadProducts();
            LoadTableLayoutPanel();

        }

        private void LoadTableLayoutPanel()
        {
            LoadClientsTotals();
            LoadSalesTotales();
            LoadTotalProducts();
            LoadTotalNCFUtilizados();

        }

        private void LoadClientsTotals()
        {
            int total = _invoiceController.CountClients();
            if (total > 0)
            {
                lblClientsQuantities.Text = $"{total.ToString()} Clientes actuales";
            }
            else
            {
                lblClientsQuantities.Text = "Clientes Totales";
            }
        }

        private void LoadSalesTotales()
        {
            decimal totalSales = _invoiceController.CalculateSalesTotal();
            if (totalSales > 0)
            {
                lblSalesTotals.Text = totalSales.ToString("C2");
            }
            else
            {
                lblSalesTotals.Text = "Ventas Totales";
            }
        }

        private void LoadTotalProducts()
        {
            int productsTotals = _invoiceController.CountProducts();
            if (productsTotals > 0)
            {
                lblTotalProducts.Text = $"{productsTotals} productos Registrados";
            }
            else
            {
                lblTotalProducts.Text = "Productos Totales";
            }
        }

        private void LoadTotalNCFUtilizados()
        {
            int totalNcfUsed = _invoiceController.CountNcfUsed();
            if (totalNcfUsed > 0)
            {
                lblNCFTotales.Text = $"{totalNcfUsed} NCFs utilizados";
            }
            else
            {
                lblNCFTotales.Text = "NCFs utilizados";
            }
        }

        private void LoadProducts()
        {
            var products = _productController.GetProducts();
            if (products.Count > 0)
            {
                foreach (var product in products)
                {
                    dataGridView1.Rows.Add(product.ProductId.ToString(), product.Description, product.Price.ToString("C2"), product.ITBIS.ToString("C2"), product.Category);
                }
            }
        }

        private void LoadUserData()
        {
            lblUserName.Text = $"{UserLoginCache.FirstName} {UserLoginCache.LastName}";
            lblPosition.Text = UserLoginCache.Position;
            lblUserEmail.Text = UserLoginCache.Email;
        }
    }

}

