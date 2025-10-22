using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.DAL;
using ProductManagement.Models;

namespace ProductManagement.ViewModel
{
    public class ProductBLL
    {
        private ProductDAL _prodDAL = new();

        public List<Product> GetAllProduct()
        {
            return _prodDAL.GetAllProducts();
        }

        public void AddNewProduct(Product x)
        {
            _prodDAL.AddNewProduct(x);
        }

        public void UpdateProduct(Product x)
        {
            _prodDAL.UpdateProduct(x);
        }
        public void RemoveProduct(Product x)
        {
            _prodDAL.DeleteProduct(x);
        }
    }
}