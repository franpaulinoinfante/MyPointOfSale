using MyPointOfSale.DataAccessSQLServer;
using MyPointOfSale.Models;
using MyPointOfSale.ViewModels;
using System.Collections.Generic;

namespace MyPointOfSale.Controllers
{
    public class ProductController
    {
        readonly ProductDao productDao;

        public ProductController()
        {
            productDao = new ProductDao();
        }

        public IReadOnlyList<ProductViewModel> GetProducts()
        {

            List<ProductViewModel> productViewModels = new List<ProductViewModel>();
            foreach (Product product in productDao.GetProducts())
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
