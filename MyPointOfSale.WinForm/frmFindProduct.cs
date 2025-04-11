using MyPointOfSale.Controllers;
using System.Windows.Forms;

namespace MyPointOfSale.WinForm
{
    public partial class frmFindProduct : Form
    {
        private readonly InvoiceController _invoiceController;

        public frmFindProduct()
        {
            InitializeComponent();
        }

        public frmFindProduct(InvoiceController invoiceController)
        {
            _invoiceController = invoiceController;
        }
    }
}
