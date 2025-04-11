using MyPointOfSale.Controllers;
using MyPointOfSale.ViewModels.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyPointOfSale.WinForm
{
    public partial class frmFindClients : Form
    {
        private IReadOnlyList<ClientViewModel> clients;

        public frmFindClients(InvoiceController invoiceController)
        {
            InitializeComponent();

            InvoiceController = invoiceController;

            clients = new List<ClientViewModel>();
        }

        public InvoiceController InvoiceController { get; }

        public ClientViewModel ClientViewModel { get; private set; }

        private void frmFindClients_Load(object sender, EventArgs e)
        {
            try
            {
                clients = InvoiceController.GetClients();
                FillDataGridView(clients);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillDataGridView(IReadOnlyList<ClientViewModel> clients)
        {
            dataGridView1.Rows.Clear();
            foreach (ClientViewModel client in clients)
            {
                dataGridView1.Rows.Add(client.ClientId, client.FirstName, client.LastName, client.DocumentName, client.DocumentNumber);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocument.Text))
            {
                MessageBox.Show("El campo de búsqueda no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IReadOnlyList<ClientViewModel> results = clients.Where(d => d.DocumentNumber.StartsWith(txtDocument.Text)).ToList();
            FillDataGridView(results);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int.TryParse(dataGridView1.SelectedRows[0].Cells["clmClientId"]?.Value?.ToString(), out int id);
                ClientViewModel = clients.FirstOrDefault(c => c.ClientId == id);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
