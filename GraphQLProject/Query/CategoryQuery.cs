using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Query
{
    public class CategoryQuery : ObjectGraphType
    {
        public CategoryQuery(ICategoryRepository categoryRepository)
        {
            Field<ListGraphType<CategoryType>>("Categories").Resolve(context =>
            {
                return categoryRepository.GetCategories();
            });
        }
    }
}
