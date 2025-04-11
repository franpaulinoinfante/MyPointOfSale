using MyPointOfSale.Controllers;
using MyPointOfSale.ViewModels;
using MyPointOfSale.ViewModels.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyPointOfSale.WinForm
{
    public partial class frmInvoice : Form
    {
        private readonly InvoiceController _invoiceController;

        private InvoiceViewModel _invoiceViewModel;

        public frmInvoice()
        {
            InitializeComponent();

            _invoiceController = new InvoiceController();
        }

        public frmInvoice(InvoiceController invoiceController)
        {
            InitializeComponent();

            _invoiceController = invoiceController;

        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            LoadProductToComboBox();
        }

        private void LoadProductToComboBox()
        {
            cbbProducts.Items.Clear();

            IReadOnlyList<ProductViewModel> products = _invoiceController.GetProducts();

            foreach (ProductViewModel product in products)
            {
                cbbProducts.Items.Add(product);
                cbbProducts.DisplayMember = "Description";
                cbbProducts.ValueMember = "Id";
            }

        }

        private void btnStartNewSale_Click(object sender, EventArgs e)
        {
            ClearFields();

            txtQuantity.Enabled = true;

            btnFindClient.Enabled = true;
            btnFindProduct.Enabled = true;
            btnAdd.Enabled = true;
            btnProcessInvoice.Enabled = true;
            btnCancel.Enabled = true;
            btnGenerateNCF.Enabled = true;

            cbbProducts.Enabled = true;

            btnNewSale.Enabled = false;

            _invoiceViewModel = new InvoiceViewModel();
            _invoiceController.StartNewSale();
        }

        private void ClearFields()
        {
            txtClientId.Clear();
            txtClient.Clear();
            txtDocumentType.Clear();
            txtNoDcoumento.Clear();
            txtProductId.Clear();
            cbbProducts.SelectedIndex = -1;
            txtQuantity.Clear();
            txtNCF.Clear();
            txtSubTotal.Clear();
            txtITBIS.Clear();
            txtTotal.Clear();

            dataGridView1.Rows.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();

            EndSale();
        }

        private void EndSale()
        {
            txtQuantity.Enabled = false;

            btnFindClient.Enabled = false;
            btnFindProduct.Enabled = false;
            btnAdd.Enabled = false;
            btnProcessInvoice.Enabled = false;
            btnCancel.Enabled = false;
            btnGenerateNCF.Enabled = false;

            cbbProducts.Enabled = false;

            btnNewSale.Enabled = true;

            _invoiceViewModel = null;

            btnNewSale.Focus();
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            frmFindClients findClients = new frmFindClients(_invoiceController);
            if (findClients.ShowDialog() == DialogResult.OK)
            {
                _invoiceViewModel.ClientViewModel = findClients.ClientViewModel;
                _invoiceController.AddClient(_invoiceViewModel.ClientViewModel.DocumentNumber);
                FillFields();
            }
        }

        private void FillFields()
        {
            txtClientId.Text = _invoiceViewModel.ClientViewModel.ClientId.ToString();
            txtClient.Text = $"{_invoiceViewModel.ClientViewModel.FirstName} {_invoiceViewModel.ClientViewModel.LastName}";
            txtDocumentType.Text = _invoiceViewModel.ClientViewModel.DocumentName;
            txtNoDcoumento.Text = _invoiceViewModel.ClientViewModel.DocumentName;

        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            frmFindProduct findProduct = new frmFindProduct(_invoiceController);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Debe indicar una cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantity.Focus();
                return;
            }

            ProductViewModel product = _invoiceController.GetProducts().FirstOrDefault(p => p.Description.ToLower() == cbbProducts.Text.ToLower());
            _invoiceController.AddLineOFProduct(new LineOfProductViewModel()
            {
                ProductId = product.ProductId,
                Description = product.Description,
                Price = product.Price,
                Quantity = int.Parse(txtQuantity.Text)
            });

            cbbProducts.DroppedDown = false;

            txtQuantity.Clear();
            cbbProducts.Focus();

            LoadDatas();

        }

        private void LoadDatas()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            foreach (ProductLineViewModel item in _invoiceController.GetProductLineViewModel())
            {
                dataGridView1.Rows.Add($"{item.Quantity:N0}", item.Description, $"{item.Price:C2}", $"{item.ITBIS:C2}", $"{item.SubToal:C2}");
            }

            txtSubTotal.Text = _invoiceController.GetSubTotal().ToString("C2");
            txtITBIS.Text = _invoiceController.GetITBIS().ToString("C2");
            txtTotal.Text = _invoiceController.GetTotal().ToString("C2");
        }

        private void cbbProducts_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbProducts.Text))
            {

                cbbProducts.AutoCompleteMode = AutoCompleteMode.None;

                string textProduct = cbbProducts.Text.ToLower();

                List<ProductViewModel> products = _invoiceController.GetProducts().Where(p => p.Description.ToLower().StartsWith(cbbProducts.Text.ToLower())).ToList();

                cbbProducts.Items.Clear();
                foreach (ProductViewModel product in products)
                {
                    cbbProducts.Items.Add(product);
                    cbbProducts.DisplayMember = "Description";
                    cbbProducts.ValueMember = "Id";
                }

                cbbProducts.DroppedDown = true;
                cbbProducts.SelectionStart = cbbProducts.Text.Length;
                cbbProducts.SelectionLength = 0;
            }
        }

        private void btnGenerateNCF_Click(object sender, EventArgs e)
        {
            _invoiceController.GenerateNCF();

            txtNCF.Text = _invoiceController.GetNCF();
        }

        private void btnProcessInvoice_Click(object sender, EventArgs e)
        {
            _invoiceController.ProccessInvoice();

            ClearFields();

            EndSale();
        }
    }
}
