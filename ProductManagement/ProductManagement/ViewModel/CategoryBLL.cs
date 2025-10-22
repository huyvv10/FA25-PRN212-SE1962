using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.DAL;
using ProductManagement.Models;

namespace ProductManagement.ViewModel
{
    public class CategoryBLL
    {
        private CategoryDAL _categoryDAL=new();

        public List<Category> GetAllCategory()
        {
            return _categoryDAL.GetAllCategories();
        }
    }
}
