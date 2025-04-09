using System;
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

        public IReadOnlyList<CategoriesViewModel> GetCategories()
        {
            var categories = productDao.Category();
            if (categories == null)
            {
                throw new InvalidOperationException("Categorias no encontradas");
            }

            List<CategoriesViewModel> categoriesViews = new List<CategoriesViewModel>();
            foreach(Category category in categories)
            {
                categoriesViews.Add(new CategoriesViewModel()
                {
                    CategoryId = category.Id,
                    CategoryName = category.CategoryName
                });
            }

            return categoriesViews;

        }

        public IReadOnlyList<ProductViewModel> GetProducts()
        {

            List<ProductViewModel> productViewModels = new List<ProductViewModel>();
            foreach (Product product in productDao.GetProducts())
            {
                productViewModels.Add(new ProductViewModel()
                {
                    Id = product.ProductId,
                    Description = product.Description,
                    Price = product.Price,
                    ITBIS = product.ITBIS,
                    Category = product.Category.CategoryName
                });
            }

            return productViewModels;
        }
    }
}
