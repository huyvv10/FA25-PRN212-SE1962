using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManagement.Models;

namespace ProductManagement.DAL
{
    public class ProductDAL
    {
        private Se1962dbContext _dbContext;

        public List<Product> GetAllProducts()
        {
            _dbContext = new Se1962dbContext();
            var prodList = _dbContext.Products
                           .Include(s => s.Cat)
                           .ToList();
            return prodList;
        }

        public void AddNewProduct(Product x)
        {
            _dbContext = new();
            _dbContext.Products.Add(x);
            _dbContext.SaveChanges();
        }
        public void UpdateProduct(Product x)
        {
            _dbContext = new();
            _dbContext.Products.Update(x);
            _dbContext.SaveChanges();
        }

        public void DeleteProduct(Product x)
        {
            _dbContext = new();
            _dbContext.Products.Remove(x);
            _dbContext.SaveChanges();
        }


    }
}
