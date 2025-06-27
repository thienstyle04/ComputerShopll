﻿using ComputerShopll.Data;
using ComputerShopll.Models.Interfaces;

namespace ComputerShopll.Models.Services
{
    public class ProductRepository: IProductRepository
    {
        private ComputershopDbContext dbContext;
        public ProductRepository(ComputershopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return dbContext.Products;
        }

        public Product? GetProductDetail(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return dbContext.Products.Where(p => p.IsTrendingProduct);
        }
    }
}
