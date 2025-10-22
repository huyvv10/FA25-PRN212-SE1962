using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.Models;

namespace ProductManagement.DAL
{
    public class CategoryDAL
    {
        private Se1962dbContext _dbContext;

        public List<Category> GetAllCategories()
        {
            _dbContext = new();
            return _dbContext.Categories.ToList();
        }

    }
}
