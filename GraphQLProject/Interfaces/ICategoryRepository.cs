using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
        Category AddCategory(Category category);
        Category UpdateCategory(int id, Category category);
        void DeleteCategory(int id);
    }
}
