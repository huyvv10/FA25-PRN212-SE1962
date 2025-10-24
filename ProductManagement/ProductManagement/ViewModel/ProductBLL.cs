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

        public List<Product> SearchProduct(String kw) { 
            if (kw == null) return _prodDAL.GetAllProducts().ToList();
            var _allProduct = _prodDAL.GetAllProducts()
                            .Where(s => s.Name.ToLower().Contains(kw.Trim().ToLower ())).ToList();
            return _allProduct;                
        }

    }
}