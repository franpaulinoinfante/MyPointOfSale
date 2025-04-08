using MyPointOfSale.DataAccessSQLServer;
using MyPointOfSale.Models;
using MyPointOfSale.ViewModels;
using System.Collections.Generic;

namespace MyPointOfSale.Controllers
{
    public class ProductController
    {
        public IReadOnlyList<ProductViewModel> GetProducts()
        {
            ProductDao productDao = new ProductDao();

            List<ProductViewModel> productViewModels = new List<ProductViewModel>();
            foreach (var product in productDao.GetProducts())
            {
                productViewModels.Add(new ProductViewModel()
                {
                    Id = product.Id,
                    Description = product.Description,
                    Price = product.Price,
                    ITBIS = product.ITBIS,
                    Category = product.Category.Category
                });
            }

            return productViewModels;
        }
    }
}
