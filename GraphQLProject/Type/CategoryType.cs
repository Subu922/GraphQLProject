using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{
    public class CategoryType:ObjectGraphType<Category>
    {
        public CategoryType(IMenuRepository menuRepository)
        {
            Field(x=>x.Id);
            Field(x => x.ImageUrl);
            Field(x => x.Name);

            //Added getAllMenu query here so we can use nested query from GraphiQL UI
            Field<ListGraphType<MenuType>>("Menus").Resolve(context =>
            {
                return menuRepository.GetAllMenu();
            });
        }
    }
}
