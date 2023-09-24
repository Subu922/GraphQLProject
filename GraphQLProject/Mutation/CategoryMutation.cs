using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation
{
    public class CategoryMutation : ObjectGraphType
    {
        public CategoryMutation(ICategoryRepository categoryRepository)
        {
            Field<CategoryType>("CreateCategory").Arguments(new QueryArguments(new QueryArgument<CategoryInputType> { Name = "category" })).Resolve(context =>
            {
                return categoryRepository.AddCategory(context.GetArgument<Category>("category"));
            });

            Field<CategoryType>("UpdateCategory").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "categoryId" }, new QueryArgument<CategoryInputType> { Name = "category" })).Resolve(context =>
               {
                   return categoryRepository.UpdateCategory(context.GetArgument<int>("menuId"), context.GetArgument<Category>("menu"));
               });

            Field<StringGraphType>("DeleteCategory").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "categoryId" })).Resolve(context =>
            {
                categoryRepository.DeleteCategory(context.GetArgument<int>("menuId"));
                return "The category is deleted";
            });
        }
    }
}
