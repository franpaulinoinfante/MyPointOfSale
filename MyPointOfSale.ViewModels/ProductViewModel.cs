using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPointOfSale.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal ITBIS { get; set; }
        public string Category { get; set; } // Assuming Category is a string, adjust as necessary
    }
}
