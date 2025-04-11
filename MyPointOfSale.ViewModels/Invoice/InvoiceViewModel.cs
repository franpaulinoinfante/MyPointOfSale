using MyPointOfSale.ViewModels.Invoice;
using System.Collections.Generic;

namespace MyPointOfSale.ViewModels
{
    public class InvoiceViewModel
    {
        public ClientViewModel ClientViewModel { get; set; }
        public string NCF { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ITBIS { get; set; }
        public decimal Total { get; set; }
        public List<LineOfProductViewModel> LineOfProducts { get; set; } = new List<LineOfProductViewModel>();

    }
}
